using System;
using System.Collections;
using System.Collections.Generic;

namespace DATAPROJE2_2
{

    class Program
    {
        //KUYRUK BÖLÜMÜ
        class Kuyruk
        {
            List<int> müşteriler = new List<int>();
            public Kuyruk() { }
            public  Kuyruk (int[] dizi)
            {
                for (int i = 0; dizi.Length > i; i++)
                {
                    müşteriler.Add((int)dizi[i]);
                }

            }
            public bool BosMu()
            {
                if (müşteriler.Count == 0)
                {
                    return true;
                }
                return false;
            }
            public void ElemanEkle(int Müsteri)
            {
                müşteriler.Add(Müsteri);
            }
            public int ElemanSil()
            {
                int min = müşteriler[0];
                müşteriler.Remove(min);
                return min;
            }

        }
        //PQ BÖLÜMÜ
        class ÖncelikliKuyruk
        {
            List<int> müşteriler = new List<int>();
            public ÖncelikliKuyruk() { }

            public ÖncelikliKuyruk(int [] dizi)
            {
                for (int i = 0; dizi.Length > i; i++)
                {
                    müşteriler.Add((int)dizi[i]);
                }

            }
            public bool BosMu()
            {
                if (müşteriler.Count == 0)
                {
                    return true;
                }
                return false;
            }
            public void ElemanEkle(int Müsteri)
            {
                müşteriler.Add(Müsteri);
            }
            public int ElemanSil()
            {
                int min = müşteriler[0];
                
                for (int i = 0; müşteriler.Count > i; i++)
                {
                    if (müşteriler[i] < min)
                    {                      
                        min = müşteriler[i];
                    }

                }
                müşteriler.Remove(min);
                return min;
            }
        }
        
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Merhaba");

            Console.WriteLine("PQ Bölümünde Gerçekleşen çözüm");
            Console.WriteLine(" ");
            int [] sepetlerim = { 6, 7, 2, 1, 12, 5, 3, 7, 4, 2 }; //SEPETLERİM DİZİSİ
            ÖncelikliKuyruk müşterilistesi = new ÖncelikliKuyruk(sepetlerim);   //ÖNCELİKLİ KUYRUK SINIFINDA MÜŞTERİLİSTESİ TANIMLANIR VE SEPETLERİM DİZİSİ BUNUN İÇİNE EKLENİR  
            int üc = 3;
            int vakitsayar = 0;
            double ortalamBeklemeSüresi = 0;
            for(int i = 0; i< sepetlerim.Length; i++)
            {
                int ürünsayisi = 0;
                ürünsayisi = müşterilistesi.ElemanSil();//DÖNGÜ  DÖNDÜĞÜ SÜRECE KUYRUKTAKİ İLGİLİ ELEMAN ÇIKARILIP BURADA DÖNDÜRÜLÜR
                vakitsayar += üc * ürünsayisi;
                Console.WriteLine("TOPLAM HARCANAN VAKİT : " + vakitsayar);//TOPLAM HARCANAN VAKİT BURADA YAZDIRILIR
                ortalamBeklemeSüresi += vakitsayar; 
                            
            }
            Console.WriteLine("ORTALAMA BEKLEME SURESİ : " + (ortalamBeklemeSüresi/ sepetlerim.Length));//ORTALAMA BEKLEME SÜRESİ BURADA YAZDIRILIR
            Console.ReadLine();
            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            Console.WriteLine(" ");
            Console.WriteLine("Kuyruk Bölümünde gerçekleşen çözüm");
            Kuyruk müşterilistesi2 = new Kuyruk(sepetlerim); // KUYRUK SINIFINDA MÜŞTERİLİSTESİ TANIMLANIR VE SEPETLERİM DİZİSİ BUNUN İÇİNE EKLENİR  
            double ortalamBeklemeSüresi2 = 0;
            int vakitsayar2 = 0;
            for (int i = 0; i < sepetlerim.Length; i++)
            {
                int ürünsayisi = 0;
                ürünsayisi = müşterilistesi2.ElemanSil();// DÖNGÜ  DÖNDÜĞÜ SÜRECE KUYRUKTAKİ İLGİLİ ELEMAN ÇIKARILIP BURADA DÖNDÜRÜLÜR
                vakitsayar2 += üc * ürünsayisi;
                Console.WriteLine("TOPLAM HARCANAN VAKİT : " + vakitsayar2);//TOPLAM HARCANAN VAKİT BURADA YAZDIRILIR
                ortalamBeklemeSüresi2 += vakitsayar2;

            }
            Console.WriteLine("ORTALAMA BEKLEME SURESİ : " + (ortalamBeklemeSüresi2 / sepetlerim.Length));//ORTALAMA BEKLEME SÜRESİ BURADA YAZDIRILIR
            Console.ReadLine();



        }
    }
}
