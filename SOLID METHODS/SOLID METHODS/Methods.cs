namespace SOLID_METHODS
{
    public static class Methods
    {

        public static List<int> BolenleriniBul(int sayi)
        {
            List<int> Bolenler = new List<int>();
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Bolenler.Add(i);
                }

            }
            return Bolenler;
        }

        public static bool AsalMı(int sayi)
        {
            bool sonuç = true;
            if (BolenleriniBul(sayi).Count > 0)
            {
                sonuç = false;
            }

            return sonuç;
        }

        public static bool AsalMıV2(int sayi)
        {
            bool sonuç = true;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sonuç = false;
                    break;
                    // Buradaki break if değeri sağlandımı döngüyü durduruyor.
                }
            }
            return sonuç;
        }


        public static List<int> IkiSayiArasindakiAsallar(int sayi1, int sayi2)
        {
            List<int> asallar = new List<int>();
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (AsalMıV2(i))
                {
                    asallar.Add(i);
                }
            }
            return asallar;
        }

        public static bool CiftMi(int sayi1)
        {
            bool sonuc = false;
            if (sayi1 % 2 == 0)
            {
                sonuc = true;
            }
            return sonuc;

        }
        public static int İkiSayiArasindakiCiftSayilarinToplamı(int sayi1, int sayi2)
        {
            int toplam = 0;

            for (int i = sayi1; i < sayi2; i++)
            {
                if (CiftMi(i) == true)
                {
                    toplam += i;
                }
            }
            return toplam;
        }
        public static string YazınınTersi(string yazı)
        {
            string sonuc = "";
            for (int i = 0; i < yazı.Length; i++)
            {
                sonuc += yazı[i].ToString();
            }
            return sonuc;
        }

        public static string YazınınTersiV2(string yazı)
        {
            string sonuc = "";
            for (int i = 0; i < yazı.Length; i++)
            {
                sonuc += yazı[yazı.Length - 1 - i].ToString();
            }
            return sonuc;
        }

        public static bool PolindromMu(string yazı)
        {
            bool sonuc = false;
            if (YazınınTersi(yazı) == yazı)
            {
                sonuc = true;
            }
            return sonuc;
        }

        public static string RiverseWordLast2(string yazi)
        {
            string sonuc = "";
            for (int i = 0; i < 2; i++)
            {
                sonuc += YazınınTersiV2(yazi)[i].ToString();
            }
            return sonuc;
        }

        public static string RiverseWordLast2V(string yazi)
        {
            string ters = YazınınTersiV2(yazi);
            string ilkiki = ters.Substring(0, 2);
            return ilkiki;
        }

        public static bool SıfırDeğilseBaşındaSıfırOlmamalı(string yazi)
        {
            bool sonuc = true;

            if (yazi != "0" && yazi[0] == '0')
            {
                sonuc = false;
            }
            return sonuc;
        }
        public static bool RakamlardanOlusuyorMu(string yazi)
        {
            bool sonuc = true;
            foreach (char karakter in yazi)
            {
                if (!(karakter >= 48 && karakter <= 57))// 0=char(48) 9=char(57)
                {
                    sonuc = false;
                    break;
                }
            }

            return sonuc;
        }
        public static bool IlkSayiSifirMi(string yazi)
        {
            bool sonuc = true;

            if (yazi[0] == '0')
            {
                sonuc = yazi.Length == 1;
            }

            return sonuc;
        }

        public static bool DoğalSayıMı(string yazı)
        {
            bool sonuç = false;

            if (
                 RakamlardanOlusuyorMu(yazı) && SıfırDeğilseBaşındaSıfırOlmamalı(yazı) && yazı.Length < 10
               )
            {
                sonuç = true;
            }
            return sonuç;
        }
        public static bool IlkHaneSifirOlmamali(string yazi)
        {
            bool sonuc = true;
            if (yazi[0] == '0')
            {
                sonuc = false;
            }
            return sonuc;
        }

        public static bool PozitifTamSayımı(string yazı)
        {
            bool sonuç = false;
            if (yazı.Length > 0)
            {
                if (
                    RakamlardanOlusuyorMu(yazı) &&
                    IlkHaneSifirOlmamali(yazı) &&
                    yazı.Length < 10
                   )
                {
                    sonuç = true;
                }

            }
            return sonuç;
        }
        public static bool EnAzBirKarakterSıfıdDeğilseIlkHaneSifirOlmamali(string yazi)
        {
            bool sonuc = true;

            if (yazi.Length > 0)
            {
                if (yazi != "0")
                {
                    if (yazi[0] == '0')
                    {
                        sonuc = false;
                    }
                }
            }
            return sonuc;

        }
        static int FibonacciSeries(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;

            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   


            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }

            return result;
        }
    }
}