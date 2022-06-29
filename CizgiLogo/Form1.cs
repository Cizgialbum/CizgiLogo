using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using CizgiLogo.logoKargo;

namespace CizgiLogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FileCleaner();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Lütfen Xml Dosyası Seçin";
            ofd.Filter = "Xml Dosyaları|*.xml";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo f = new FileInfo(ofd.FileName);

                if (f.Extension == ".xml")
                {
                    lblDosyaAdi.Text = ofd.FileName;
                    lblDosyaAdi.Refresh();

                    string source = ofd.FileName;
                    string dest = @"C:\CizgiLogo\temp\" +
                    Path.GetFileName(source);
                    File.Copy(source, dest);

                    string tamYol = @"C:\CizgiLogo\temp\" + source;
                    
                    try
                    {
                        string veri = "";

                        kayitListesi.Items.Clear();
                        kayitListesi.Refresh();

                        double arasTutar = 0;

                        XmlReader xmlReader2 = XmlReader.Create(dest);
                        while (xmlReader2.Read())
                        {
                            if ((xmlReader2.NodeType == XmlNodeType.Element) && (xmlReader2.Name == "table1"))
                            {
                                if (xmlReader2.HasAttributes)
                                    veri = xmlReader2.GetAttribute("textbox29") + ": " + xmlReader2.GetAttribute("textbox28");

                                arasTutar = Convert.ToDouble(xmlReader2.GetAttribute("textbox53").Replace(".", ","));

                                arasTutarVeri.Text = arasTutar.ToString("C");
                                arasTutarVeri.Refresh();
                            }
                        }

                        xmlReader2.Dispose();

                        int say = 0;

                        XmlReader xmlReader3 = XmlReader.Create(dest);
                        while (xmlReader3.Read())
                        {
                            if ((xmlReader3.NodeType == XmlNodeType.Element) && (xmlReader3.Name == "Detail"))
                            {
                                if (xmlReader3.HasAttributes)
                                {
                                    say = say + 1;
                                }
                            }
                        }

                        toplamSayi.Text = say.ToString();
                        toplamSayi.Refresh();

                        progressBar1.Maximum = say;


                        double toplamTutar = 0;

                        xmlReader3.Dispose();

                        logoKargo.logoKargoSoapClient webservice = new logoKargoSoapClient();

                        var donus = webservice.anaKayit("41F2550CA5FE4E6F374CEA25362FO48B5CA7EDF5",
                            arasTutar.ToString());

                        XmlDocument anaKayitDonus = new XmlDocument();
                        anaKayitDonus.LoadXml(donus.ToString());

                        XmlNode anaKayitID = anaKayitDonus.SelectSingleNode("sonuc/kayitid");

                        int ilkKayitID = Convert.ToInt32(anaKayitID.InnerText);

                        int guncelKayitSayi = 0;

                        int basariliKayit = 0;
                        int hataliKayit = 0;

                        basariliSayi.Text = "0";
                        basariliSayi.Refresh();
                        hataliSayi.Text = "0";
                        hataliSayi.Refresh();

                        string hataliKayitMok = "";

                        if (ilkKayitID != 0)
                        {

                            // Çalışıyor Dokunma
                            XmlReader xmlReader = XmlReader.Create(dest);
                            while (xmlReader.Read())
                            {
                                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Detail"))
                                {
                                    if (xmlReader.HasAttributes)
                                        veri = xmlReader.GetAttribute("FATNO") + ": " +
                                               xmlReader.GetAttribute("REFNO");

                                    string altKayitSonuc = webservice.altKayit("41F2550CA5FE4E6F374CEA25362FO48B5CA7EDF5",
                                        xmlReader.GetAttribute("SERI") + xmlReader.GetAttribute("FATNO"), xmlReader.GetAttribute("MÖK"),
                                        xmlReader.GetAttribute("ALICI_ADI"), xmlReader.GetAttribute("textbox70"),
                                        xmlReader.GetAttribute("ODEME_TUTARI"), xmlReader.GetAttribute("TESLIM_TARIHI"),
                                        xmlReader.GetAttribute("textbox56"), ilkKayitID.ToString(), xmlReader.GetAttribute("textbox59"), xmlReader.GetAttribute("TAHSILATLI_KARGO_TUTARI"));


                           string renklendir = "red";

                           if (altKayitSonuc =="Başarılı")
                           {
                               basariliKayit = basariliKayit + 1;
                               renklendir = "green";
                               basariliSayi.Text = basariliKayit.ToString();
                               basariliSayi.Refresh();
                           }

                           //else if (altKayitSonuc == false)
                           //{

                           //}

                           else
                           {
                               hataliKayit = hataliKayit + 1;
                               hataliSayi.Text = hataliKayit.ToString();
                               hataliSayi.Refresh();

                               renklendir = "red";
                          }


                                    listBoxGuncelle(xmlReader.GetAttribute("FATNO"), xmlReader.GetAttribute("MÖK"),
                                        xmlReader.GetAttribute("ALICI_ADI"), xmlReader.GetAttribute("textbox70"),
                                        xmlReader.GetAttribute("TESLIM_TARIHI"), xmlReader.GetAttribute("textbox56"), altKayitSonuc,
                                        renklendir);


                                    string aFiyat = xmlReader.GetAttribute("textbox70").Replace(".", ",");

                                    toplamTutar += Convert.ToDouble(aFiyat);

                                    progressBar1.Increment(1);

                                    guncelKayitSayi = guncelKayitSayi + 1;

                                    guncelislem.Text = "Kayıtlar İşleniyor...";
                                    guncelislem.Refresh();

                                    progresKayit.BackColor = Color.Transparent;
                                    progresKayit.Text = guncelKayitSayi.ToString() + "/"+  say.ToString();
                                    progresKayit.Refresh();

                                    toplamTutarVeri.Text = toplamTutar.ToString("C");
                                    toplamTutarVeri.Refresh();

                                    Thread.Sleep(10);

                                }
                            }

                            xmlReader.Dispose();

                        }

                        if (say != 0 )
                        {
                            if (hataliKayit == say)
                            {
                                guncelislem.Text = "Bu Xml Okutulmuş, Ana Kayıt Siliniyor";
                                guncelislem.Refresh();
                                webservice.anaKayitSil("41F2550CA5FE4E6F374CEA25362FO48B5CA7EDF5", ilkKayitID.ToString());

                                Thread.Sleep(1000);
                            }

                            else
                            {
                                webservice.anaKayitGuncelle("41F2550CA5FE4E6F374CEA25362FO48B5CA7EDF5", ilkKayitID, say.ToString(), toplamTutar);

                                guncelislem.Text = "Ana Kayıt Güncelleniyor";
                                guncelislem.Refresh();
                                Thread.Sleep(2000);

                                guncelislem.Text = "Cari Kodları Atanıyor";
                                guncelislem.Refresh();
                                Thread.Sleep(2000);

                                var donus2 = webservice.logoIdAra("41F2550CA5FE4E6F374CEA25362FO48B5CA7EDF5", ilkKayitID);

                                XmlDocument d2 = new XmlDocument();
                                d2.LoadXml(donus2.ToString());


                                XmlNode logoIDdonus = d2.SelectSingleNode("sonuc/donus");
                                XmlNode logoIDbasarili = d2.SelectSingleNode("sonuc/basarili");
                                XmlNode logoIhatali = d2.SelectSingleNode("sonuc/hatali");


                                guncelislem.Text = logoIDdonus.InnerText + " Başarılı:" + logoIDbasarili.InnerText + " Hatalı:" + logoIhatali.InnerText;
                                guncelislem.Refresh();

                                label4.Text = logoIDdonus.InnerText;

                                Thread.Sleep(4000);

                                guncelislem.Text = webservice.logoXmlAktar("41F2550CA5FE4E6F374CEA25362FO48B5CA7EDF5", ilkKayitID);
                                guncelislem.Refresh();

                            }
                        }


                        else
                        {
                            MessageBox.Show("Veri Girilirken Bir Sorun Oluştu, İnternet Bağlantısını Kontrol Edin");
                        }

                        

                        if (arasTutar != toplamTutar)
                        {
                            lblTutarKarsilastir.Text = "Aras Kargodan Gelen Ana Para Verisi ile Xml Toplamı Uyuşmuyor";
                            lblTutarKarsilastir.ForeColor = Color.Red;
                        }

                        else
                        {
                            lblTutarKarsilastir.Text = "Tutarlar uyuşuyor";
                            lblTutarKarsilastir.ForeColor = Color.Green;
                        }


                    }
                    catch (Exception exception)
                    {
                        label4.Text = exception.ToString();
                    }


                    guncelislem.Text = "İşlemler Tamamlandı!";
                    guncelislem.Refresh();


                }

                else
                {
                    lblDosyaAdi.Text = ofd.FileName;
                    lblDosyaAdi.Refresh();
                    MessageBox.Show("Lütfen XML uzantılı dosya yükleyiniz.");
                }
            }
        }


        public async Task listBoxGuncelle(string fatno, string mok, string alici, string tutar, string teslim, string takipno, string durum, string renk)
        {


                kayitListesi.Items.Add(fatno + " | " + mok + " | " + alici + " | " + tutar + " | " + teslim + " | " + takipno + " | " + durum);

                if (renk == "red")
                {
                kayitListesi.ForeColor = Color.Red;
                }
                else if (renk == "green")
                {
                    kayitListesi.ForeColor = Color.Green;
                }

                else
                {
                    kayitListesi.ForeColor = Color.Black;
                }


                kayitListesi.Refresh();

        }

        public static void FileCleaner()
        {
            DirectoryInfo dic = new DirectoryInfo(@"C:\CizgiLogo\ArasXml"); // açılan klasörün adını al
            FileInfo[] Files = dic.GetFiles(); // dosya listesini al

            foreach (FileInfo file in Files)
            {
                    //file.Delete();
                    System.Threading.Thread.Sleep(500);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = dateTimePicker1.Value.ToShortDateString();
        }
    }
}
