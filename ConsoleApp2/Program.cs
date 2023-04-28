using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        
           
        {
            int bilgisayar_puan = 0;
            int oyuncu_puan = 0;
            Console.WriteLine("============Uygulamamıza hoşgeldiniz============");
            Console.WriteLine("------------ 1-oyunlar , 2-hesaplamalar ------------");
            int seçim = Convert.ToInt32(Console.ReadLine());
            if(seçim==1)
            {
                Console.Clear();
                Console.WriteLine("===========Bir oyun Seçiniz===========");
                Console.WriteLine("                                  ");
                Console.WriteLine("                                  ");
                Console.WriteLine("                                  ");
                Console.WriteLine("1-Sayı tahmin etme , 2-yazı Tura , 3-Şanslı Kişi , 4-Taş , Kağıt , makas ");
                int oyunsecimi = Convert.ToInt32(Console.ReadLine());
                if(oyunsecimi==1)
                {
                    Console.Clear();
                    Console.WriteLine("--------------- 1-Bilgisayara karşı , 2-Arkadaşın ile ---------------");
                    int kaçkişili = Convert.ToInt32(Console.ReadLine());
                    if(kaçkişili==1)
                    {
                        Console.Clear();
                        Console.WriteLine("--------------- Kaç kere oynansın ---------------");
                        int kaç_kere = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i<=kaç_kere; i++)
                        {
                            Console.Clear();
                            Random r = new Random();
                            int rastgelesayı = r.Next(1, 10);
                            int bilgisayar = r.Next(1, 10);
                            Console.WriteLine("****************** 1 ile 10 arasında bir sayı seçiniz ******************");
                            int oyuncusayı = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            if (bilgisayar>rastgelesayı)
                            {
                                bilgisayar_puan = (10-(bilgisayar-rastgelesayı));
                               
                                
                                Console.Clear();
                               
                            }
                            else if (rastgelesayı>bilgisayar)
                            {
                                bilgisayar_puan = (10-(rastgelesayı-bilgisayar));
                          
                                
                              
                                Console.Clear();
                            }
                           else if (oyuncusayı>rastgelesayı)
                            {
                                oyuncu_puan = (10-(oyuncusayı-rastgelesayı));
                      
                                Console.Clear();

                            }
                            else if (rastgelesayı>oyuncusayı)
                            {
                                oyuncu_puan = (10-(rastgelesayı-oyuncusayı));
                                Console.Clear();
                            }

                        }
                     
                        if (bilgisayar_puan>oyuncu_puan)
                        {
                            Console.WriteLine("////// bilgisayar " + bilgisayar_puan + " puan alarak kazandı //////");
                            Console.WriteLine("////// Oyuncu " + oyuncu_puan + " puan alarak kaybetti //////");
                        }
                        if (oyuncu_puan>bilgisayar_puan)
                        {
                            Console.WriteLine("////// Oyuncu " + oyuncu_puan + " puan alarak kazandı ////// ");
                            Console.WriteLine("////// bilgisayar " + bilgisayar_puan + " puan alarak kaybetti //////");
                         
                        }
                        Console.ReadKey();
                    }
                    if(kaçkişili==2)
                    {
                        
                        Console.Clear();
                        Console.WriteLine("--------------- Kaç kere oynansın ---------------");
                        int kaç_kere = Convert.ToInt32(Console.ReadLine());
                        int oyuncu1_puan = 0;
                        int oyuncu2_puan = 0;
                        for (int i = 1; i<=kaç_kere; i++)
                        {
                            Random r = new Random();
                            int rastgelesayı1 = r.Next(1, 10);
                            Console.WriteLine("****************** 1 ile 10 arasında bir sayı seçiniz ******************");
                            int oyuncusayı1 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("****************** 1 ile 10 arasında bir sayı seçiniz ******************");
                            int oyuncusayı2 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            if (oyuncusayı2>rastgelesayı1)
                            {
                                oyuncu2_puan = (10-(oyuncusayı2-rastgelesayı1));


                                Console.Clear();

                            }
                            else if (rastgelesayı1>oyuncusayı2)
                            {
                                oyuncu2_puan = (10-(rastgelesayı1-oyuncusayı2));



                                Console.Clear();
                            }
                            else if (oyuncusayı1>rastgelesayı1)
                            {
                                oyuncu1_puan = (10-(oyuncusayı1-rastgelesayı1));

                                Console.Clear();

                            }
                            else if (rastgelesayı1>oyuncusayı1)
                            {
                                oyuncu1_puan = (10-(rastgelesayı1-oyuncusayı1));
                                Console.Clear();
                            }

                        }

                        if (oyuncu1_puan>oyuncu2_puan)
                        {
                            Console.WriteLine("////// 1. oyuncu " + oyuncu1_puan + " puan alarak kazandı //////");
                            Console.WriteLine("////// 2. Oyuncu " + oyuncu2_puan + " puan alarak kaybetti //////");
                        }
                       else if (oyuncu2_puan>oyuncu1_puan)
                        {
                            Console.WriteLine("////// 2. Oyuncu " + oyuncu2_puan + " puan alarak kazandı ////// ");
                            Console.WriteLine("////// 1. oyuncu " + oyuncu1_puan + " puan alarak kaybetti //////");

                        }
                        Console.ReadKey();
                    }
          
                }
                else if (oyunsecimi==2)
                {
                    Console.Clear();
                    Random r = new Random();
                    int rastgelesayı = r.Next(1, 2);
                    Console.WriteLine("---- 1. oyuncu Seçim Yapınız ----");
                    Console.WriteLine("======== 1- Yazı , 2-Tura ========");
                    int oyuncu1seçim = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("---- 2. oyuncu Seçim Yapınız ----");
                    Console.WriteLine("======== 1- Yazı , 2-Tura ========");
                    int oyuncu2seçim = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (oyuncu1seçim==rastgelesayı)
                    {
                        Console.WriteLine("------- 1. oyuncu kazandı -------");
                    }
                    
                    else if (oyuncu2seçim==rastgelesayı)
                    {
                        Console.WriteLine("------- 2. oyuncu kazandı -------");
                    }
                    else
                    {
                        Console.WriteLine("******* Berabere ******* ");
                    }
                    Console.ReadKey();
                }
                else if(oyunsecimi==3)
                {
                    Console.Clear();
                    
                    Console.WriteLine("Kaç kişilik bir oyun olsun :");
                    int kaçkişi = Convert.ToInt32(Console.ReadLine());
                    string[] kişiler = new string[kaçkişi];
                    for (int i =0;i<=(kaçkişi-1);i++)
                    {
                        Console.Clear();
                        Console.WriteLine((i+1) + ". kişinin ismini giriniz :");
                        kişiler[i]=Console.ReadLine();
                        
                    }
                    Console.Clear();
                    Random r = new Random();
                    int kişiseçimi=r.Next(0,kişiler.Length); ;
                    Console.WriteLine("Şanslı kişi :" + kişiler[kişiseçimi]);
                    Console.ReadKey();
                }
                else if(oyunsecimi==4)
                {
bas:
                    int oyuncu1 = 0;
                    int oyuncu2 = 0;
                    for (int i = 1; i <= 5; i++)
                    {

                        Console.WriteLine("**** 1-Taş **** ");
                        Console.WriteLine("**** 2-Kağıt ****");
                        Console.WriteLine("**** 3-Makas ****");
                        Console.WriteLine("----- 1. Oyuncu Seçiminizi Giriniz ----- ");
                        int secim1 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("**** 1-Tas ****");
                        Console.WriteLine("**** 2-Kağıt ****");
                        Console.WriteLine("**** 3-Makas ****");
                        Console.WriteLine("----- 2. Oyuncu Seçiminizi Giriniz ----- ");
                        int secim2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (secim1 == 1 && secim2 == 2)
                        {
                            Console.WriteLine("====================================");
                            Console.WriteLine(" 2. oyucu kazandı");
                            Console.WriteLine("====================================");
                            oyuncu2 += 5;
                        }


                        else if (secim1 == 1 && secim2 == 3)
                        {
                            Console.WriteLine("====================================");
                            Console.WriteLine("1. oyucu kazandı");
                            Console.WriteLine("====================================");
                            oyuncu1 += 5;
                        }


                        else if (secim1 == 1 && secim2 == 1)
                        {
                            Console.WriteLine("====================================");
                            Console.WriteLine(" Berabere");
                            Console.WriteLine("====================================");
                        }

                        else if (secim1 == 2 && secim2 == 1)
                        {
                            Console.WriteLine("====================================");
                            Console.WriteLine(" 1. oyucu kazandı");
                            Console.WriteLine("====================================");
                            oyuncu1 += 5;
                        }

                        else if (secim1 == 2 && secim2 == 3)
                        {
                            Console.WriteLine("====================================");
                            Console.WriteLine(" 2. oyucu kazandı");
                            Console.WriteLine("====================================");
                            oyuncu2 += 5;
                        }

                        else if (secim1 == 2 && secim2 == 2)
                        {
                            Console.WriteLine("====================================");
                            Console.WriteLine(" Berabere");
                            Console.WriteLine("====================================");
                        }

                        else if (secim1 == 3 && secim2 == 1)
                        {
                            Console.WriteLine("====================================");
                            Console.WriteLine("  2. oyucu kazandı");
                            Console.WriteLine("====================================");
                            oyuncu2 += 5;
                        }

                        else if (secim1 == 3 && secim2 == 2)
                        {
                            Console.WriteLine("====================================");
                            Console.WriteLine(" 1. oyucu kazandı");
                            Console.WriteLine("====================================");
                            oyuncu1 += 5;
                        }

                        else if (secim1 == 3 && secim2 == 3)
                        {
                            Console.WriteLine("====================================");
                            Console.WriteLine(" Berabere");
                            Console.WriteLine("====================================");

                        }
                        else
                        {
                            Console.WriteLine("*****Yanlış sayı girdiniz*****");
                            goto bas;
                        }
                        Console.ReadKey();
                        Console.Clear();
                    }
                    Console.WriteLine("oyuncu 2 `nin puanı : " + oyuncu2);
                    Console.WriteLine("oyuncu 1 `nin puanı : " + oyuncu1);
                    if (oyuncu1 > oyuncu2)
                    {
                        Console.WriteLine("Oyuncu 1 Kazandı");
                    }
                    else if (oyuncu1 > oyuncu2)
                    {
                        Console.WriteLine("Oyuncu 2 Kazandı");
                    }


                    Console.ReadLine();



                }
            }
            if(seçim==2)
            {

            }
            
        }
    }
}
