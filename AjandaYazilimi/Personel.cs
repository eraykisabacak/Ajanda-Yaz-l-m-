using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjandaYazilimi
{
    class Personel
    {
        string ad, soyad, meslek;
        bool cinsiyet, medeni_durum;        
        DateTime dogum_tarihi;
        decimal maas;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Meslek { get => meslek; set => meslek = value; }
//        public bool Cinsiyet { get => cinsiyet; set => cinsiyet = value; }
//        public bool Medeni_durum { get => medeni_durum; set => medeni_durum = value; }
        public DateTime Dogum_tarihi { get => dogum_tarihi; set => dogum_tarihi = value; }
        public decimal Maas { get => maas; set => maas = value; }

        public Personel(string ad,string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;
        }

        public Personel(string ad, string soyad,DateTime dogum_tarihi)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.dogum_tarihi = dogum_tarihi;
        }

        public int Yas
        {
            get
            {
                return (DateTime.Now.Year - dogum_tarihi.Year);
            }
        }

        public enum Cinsiyet
        {
            ERKEK = 0, KADIN = 1
        }

        public enum Medeni_Durumu
        {
            BEKAR = 0, EVLİ = 1
        }

        public void ZamYap(decimal miktar)
        {
            maas = maas + miktar;    

        }

        public string KalanGünSayısı()
        {
            return (57-(DateTime.Now.Year - dogum_tarihi.Year))*365 + "Gün Kalmıştır";
        }

       
        public void DosyayaYaz(string ad,string soyad,string meslek,string cinsiyet,string medeni_durum,string maas,string email,string adres,List<Ajanda> ajanda)
        {
            string dosya_yolu = @"C:\Users\nefre\Desktop\AjandaYazilimi\data.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            
            if(cinsiyet == "ERKEK")
            {
                if (medeni_durum == "BEKAR")
                {
                    sw.WriteLine(ad + "|" +
                        soyad + "|" +
                        dogum_tarihi + "|" +
                        meslek + "|" +
                        Personel.Cinsiyet.ERKEK + "|" +
                        Personel.Medeni_Durumu.BEKAR + "|" +
                        email + "|" + 
                        adres + "|" + 
                        ajanda[0].TelefonNo);
                }
                else
                {
                    sw.WriteLine(ad + "|" + 
                        soyad + "|" +
                        dogum_tarihi + "|" +
                        meslek + "|" + 
                        Personel.Cinsiyet.ERKEK + "|" + 
                        Personel.Medeni_Durumu.EVLİ + "|" + 
                        email + "|" + 
                        adres + "|" +
                        ajanda[0].TelefonNo);
                }
            }
            else if(cinsiyet == "KADIN")
            {
                if (medeni_durum == "EVLİ")
                {
                     sw.WriteLine(ad + "|" + 
                         soyad + "|" +
                         dogum_tarihi + "|" +
                         meslek + "|" + 
                         Personel.Cinsiyet.KADIN + "|" + 
                         Personel.Medeni_Durumu.EVLİ + "|" + 
                         email + "|" + 
                         adres + "|" +
                         ajanda[0].TelefonNo);
                }
                else
                {
                    sw.WriteLine(ad + "|" + 
                        soyad + "|" +
                        dogum_tarihi + "|" +
                        meslek + "|" + 
                        Personel.Cinsiyet.KADIN + "|" + 
                        Personel.Medeni_Durumu.BEKAR + "|" + 
                        email + "|" + 
                        adres + "|" +
                        ajanda[0].TelefonNo);
                }
            }
            sw.Flush();
            sw.Close();
            fs.Close();
        }



        public List<Personel> DosyadanOku()
        {
            List<Personel> personeller = new List<Personel>();
            string dosya_yolu = @"C:\Users\nefre\Desktop\AjandaYazilimi\data.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();

            while (yazi != null)
            {
                char ayrac = '|';
                string[] bilgiler = yazi.Split(ayrac);
                           
                Personel personel = new Personel(bilgiler[0],bilgiler[1]);
                Console.WriteLine(bilgiler[2]);
                personel.Dogum_tarihi = DateTime.Parse(bilgiler[2]);
                Console.WriteLine(personel.Yas);
                personel.meslek = bilgiler[3];
                if(bilgiler[4] == "ERKEK")
                {
                    personel.cinsiyet = false;
                }
                else if (bilgiler[4] == "KADIN")
                {
                    personel.cinsiyet = true;
                }

                if(bilgiler[5] == "BEKAR")
                {
                    personel.medeni_durum = false;
                }
                else if(bilgiler[5] == "EVLİ")
                {
                    personel.medeni_durum = true;
                }
                personeller.Add(personel);
                yazi = sw.ReadLine(); 
                }
            return personeller;
        }

        public List<Ajanda> ajanda(string istel,string gsmtel,string gsm2tel)
        {
            List<Ajanda> ajandalar = new List<Ajanda>();
            Ajanda ajanda2 = new Ajanda("İs Telefonu", istel);
            Ajanda ajanda3 = new Ajanda("Gsm Tel", gsmtel);
            Ajanda ajanda4 = new Ajanda("Gsm Tel2", gsm2tel);
            return ajandalar;

        }

        public List<Ajanda> ajanda(string istel, string gsmtel)
        {
            List<Ajanda> ajandalar = new List<Ajanda>();
            Ajanda ajanda2 = new Ajanda("İs Telefonu", istel);
            Ajanda ajanda3 = new Ajanda("Gsm Tel", gsmtel);
            ajandalar.Add(ajanda2);
            ajandalar.Add(ajanda3);
            return ajandalar;

        }
    }
}
