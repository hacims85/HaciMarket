using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaciMarket
{
    class Program
    {
        static void Main(string[] args)
        {

            Process process = new Process();

            #region Get Results
            process.Products = process.GetAllProducts();
            process.Episodes = process.GetAllEpisodes();
            process.Costumers = process.GetAllCostumers();
            process.TekkeMenus = process.GetAllTekkeMenus();
            #endregion

            #region Home Page
            process.Home();
            string search = Console.ReadLine();
            string continueOrder = "e";
            Console.Clear();
            #endregion
            #region Secret Place
            if (search == "658514")
            {
                Console.WriteLine("-*-*-*-*-*-TEKKE MENU-*-*-*-*-*-");
                Console.WriteLine("Hoş Geldin Hacı Baba");
                process.TekkeMenuWrite();
                Console.WriteLine("Lütfen Yapmak İstediğin İşlemi Belirt");
                int selected = Convert.ToInt32(Console.ReadLine());
                process.TekkeMenuIndex(selected);

            }
            #endregion
            #region Kart Id +

            else if (search == "1")
            {
                Console.WriteLine("Lütfen Kart Numaranızı Giriniz");
                string IdNumber = Console.ReadLine();
                Console.Clear();
                for (int i = 0; i < process.Costumers.Length; i++)
                {
                    if (IdNumber == process.Costumers[i].IdNumber)
                    {
                        Console.WriteLine($"Hoş Geldiniz {process.Costumers[i].Name } {process.Costumers[i].Gender}");
                        while (continueOrder.ToUpper() == "E")
                        {


                            process.Index();
                            process.EpisodeWrite();
                            int selected = Convert.ToInt32(Console.ReadLine());
                            process.OrderMenu(selected);
                            Console.WriteLine($"Alışverişe Devam Etmek İster Misiniz {process.Costumers[i].Name } {process.Costumers[i].Gender}");
                            continueOrder = Console.ReadLine();
                            Console.Clear();
                        }
                        if (continueOrder.ToUpper() == "H")
                        {
                            double totalPrice = process.GetTotalPrice();
                            string totalOrder = process.GetTotalOrder();
                            Console.WriteLine($"Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz {process.Costumers[i].Name } {process.Costumers[i].Gender}");
                            Console.WriteLine("-*-*-Tüm Siparişleriniz-*-*-");
                            Console.WriteLine(totalOrder);
                            Console.WriteLine($"Toplam Alışverişiniz = {totalPrice} TL");
                            Console.WriteLine($"Hacı Baba Kart İndirimi = {totalPrice * 0.1} TL");
                            Console.WriteLine($"Ödenecek Tutar = {totalPrice * 0.9} TL");

                        }
                    }
                }




            }
            #endregion
            #region Kart ID -
            else
            {
                while (continueOrder.ToUpper() == "E")
                {
                    Console.Clear();
                    process.Index();
                    process.EpisodeWrite();
                    int selected = Convert.ToInt32(Console.ReadLine());



                    process.OrderMenu(selected);


                    Console.WriteLine("Alışverişe Devam Etmek İster Misiniz");
                    continueOrder = Console.ReadLine();
                    Console.Clear();
                }
                if (continueOrder.ToUpper() == "H")
                {
                    double totalPrice = process.GetTotalPrice();
                    string totalOrder = process.GetTotalOrder();
                    Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz");
                    Console.WriteLine("-*-*-Tüm Siparişleriniz-*-*-");
                    Console.WriteLine(totalOrder);
                    Console.WriteLine($"Toplam Alışverişiniz = {totalPrice} TL");

                }

            }
            #endregion



        }


    }
}

