using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BüyükOyun
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int sayi;
                string kisisayisi = "";
                bool döngü = false;
                Console.WriteLine("Kaç kişilik oyun olsun?");
                while (döngü == false)
                {
                    kisisayisi = Console.ReadLine();
                    döngü = int.TryParse(kisisayisi, out sayi);
                        if (döngü == false)
                    {
                        Console.WriteLine("Lütfen kaç kişiyle oynamak istediğiniz nümerik olarak giriniz!:");
                        Console.WriteLine("Kaç kişilik oyun olsun?");
                    }
                    else if (sayi<0)
                    {
                        Console.WriteLine("0'dan küçük sayı girilemez!");
                        Console.WriteLine("Kaç kişilik oyun olsun?");
                        döngü = false;
                    }
                }
                sayi = Convert.ToInt32(kisisayisi);

                double[] puan = new double[sayi];
                string[] isimler = new string[sayi];

                for (int i = 0; i < sayi; i++)
                {
                    Console.WriteLine($"{i + 1}. Oyuncu İsmini giriniz:");
                    isimler[i] = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("1: [KOLAY]\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("2: [ORTA]\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("3: [ZOR]\n");
                    Console.ResetColor();
                    Console.WriteLine("Zorluk Seviyenizi Yazınız: ");
                    string zorluk = Console.ReadLine();
                    while (zorluk.ToLower() != "kolay" && zorluk.ToLower() != "orta" && zorluk.ToLower() != "zor")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Geçersiz seçim yaptınız. Tekrar Seçim yapınız.");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("1: [KOLAY]\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("2: [ORTA]\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("3: [ZOR]\n");
                        Console.ResetColor();
                        Console.WriteLine("Zorluk Seviyenizi Yazınız: ");
                        zorluk = Console.ReadLine();
                    }

                    if (zorluk.ToLower() == "kolay")
                    {
                        double puan1 = 10;
                        int tahminHakki = 3;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Kolay Seviyede oynayacaksınız.");
                        Random random = new Random();
                        int a = random.Next(10);
                        int j;
                        for (j = 1; j <= tahminHakki; j++)
                        {



                            Console.WriteLine("0 ve 10 arasında tahmininizi giriniz:");
                            int tahmin = Convert.ToInt32(Console.ReadLine());
                            if (tahmin == a)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Tebrikler{j}. tahmininizde bildiniz. Puanınız:{puan1 / j}");
                                Console.ResetColor();

                                puan[i] = puan1 / j;
                                break;
                            }
                            else if (tahmin < a)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"Yukarı!{3 - j} Hakkınız kaldı.");
                            }
                            else if (tahmin > a)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"Aşağı!{3 - j} Hakkınız kaldı.");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Hakkınız Kalmadı.");
                                Console.ResetColor();
                            }


                        }

                    }
                    if (zorluk.ToLower() == "orta")
                    {
                        double puan2 = 20;
                        int tahminHakki = 5;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Orta Seviyede Oynuyorsunuz");
                        Random random = new Random();
                        int b = random.Next(20);

                        for (int k = 1; k < tahminHakki; k++)
                        {

                            Console.WriteLine("0 ve 20 arasında tahmininizi giriniz:");
                            int tahmin = Convert.ToInt32(Console.ReadLine());
                            if (tahmin == b)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Tebrikler{k}. tahmininizde bildiniz. Puanınız:{puan2 / k}");
                                Console.ResetColor();
                                puan[i] = puan2 / tahminHakki;
                                break;
                            }
                            else if (tahmin < b)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"Yukarı!{5 - k} Hakkınız kaldı.");
                            }
                            else if (tahmin > b)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"Aşağı!{5 - k} Hakkınız kaldı.");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Hakkınız Kalmadı.");
                                Console.ResetColor();
                            }


                        }
                    }
                    if (zorluk.ToLower() == "zor")
                    {
                        double puan3 = 30;
                        int tahminHakki = 7;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Zor Seviyede Oynuyorsunuz");
                        Random random = new Random();
                        int c = random.Next(30);

                        for (int l = 1; l < tahminHakki; l++)
                        {

                            Console.WriteLine("0 ve 30 arasında tahmininizi giriniz:");
                            int tahmin = Convert.ToInt32(Console.ReadLine());
                            if (tahmin == c)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Tebrikler{l}. tahmininizde bildiniz. Puanınız:{puan3 / l}");
                                Console.ResetColor();
                                puan[i] = puan3 / l;
                                break;
                            }
                            else if (tahmin < c)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"Yukarı!{7 - l} Hakkınız kaldı.");
                            }
                            else if (tahmin > c)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"Aşağı!{7 - l} Hakkınız kaldı.");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Hakkınız Kalmadı.");
                                Console.ResetColor();
                            }

                        }


                    }




                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("****PUAN TABLOSU****");
                Console.ResetColor();
                Array.Sort(puan, isimler);
                Array.Reverse(puan);
                Array.Reverse(isimler);
                for (int j = 0; j < isimler.Length; j++)
                {
                    Console.WriteLine($"{isimler[j]},{puan[j]}");
                }
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Devam Edilsin mi? [Evet] --- [Hayır]");
                string devam = Console.ReadLine();
                while (devam.ToLower() != "evet" && devam.ToLower() != "hayır")
                {
                    Console.WriteLine("Geçersiz seçenek yaptın. Devam Edilsin mi? [Evet] --- [Hayır] ");
                    devam = Console.ReadLine();
                }
                if (devam.ToLower() == "evet")
                {
                    Console.ResetColor();
                    Console.Clear();
                    Console.WriteLine("Yeni oyun başlıyor");

                }
                else if (devam.ToLower() == "hayır")
                {
                    break;
                }

            }
            Console.WriteLine("OYUN BİTTİ ÇIKMAK İÇİN BİR TUŞA BAS...");



            Console.ReadLine();
        }
    }
}
