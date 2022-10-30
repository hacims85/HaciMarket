using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaciMarket
{
    public class Process
    {

        public Product[] Products;
        public Episode[] Episodes;
        public Costumer[] Costumers;


        public Process()
        {
            Products = new Product[0];
            Episodes = new Episode[0];
            Costumers = new Costumer[0];


            #region Product Added



            ProductAdd(new Product() { Name = "Elma", unit = "KG", price = 12.99, stock = 100, episode = "Manav" });
            ProductAdd(new Product() { Name = "Armut", unit = "KG", price = 15.25, stock = 150, episode = "Manav" });
            ProductAdd(new Product() { Name = "Marul", unit = "Adet", price = 5.50, stock = 85, episode = "Manav" });
            ProductAdd(new Product() { Name = "Kola", unit = "LT", price = 21.50, stock = 135, episode = "İçecekler" });
            ProductAdd(new Product() { Name = "Fanta", unit = "LT", price = 20.50, stock = 126, episode = "İçecekler" });
            ProductAdd(new Product() { Name = "Sprite", unit = "LT", price = 21.00, stock = 92, episode = "İçecekler" });
            ProductAdd(new Product() { Name = "Ekmek", unit = "Adet", price = 4, stock = 110, episode = "Unlu Mamuller" });
            ProductAdd(new Product() { Name = "Lavaş", unit = "Paket", price = 15.99, stock = 57, episode = "Unlu Mamuller" });
            ProductAdd(new Product() { Name = "Simit", unit = "Adet", price = 5, stock = 75, episode = "Unlu Mamuller" });
            ProductAdd(new Product() { Name = "Vernel", unit = "KG", price = 36.99, stock = 60, episode = "Temizlik Ürünleri" });
            ProductAdd(new Product() { Name = "Tualet Kağıdı", unit = "Adet", price = 85.00, stock = 50, episode = "Temizlik Ürünleri" });
            ProductAdd(new Product() { Name = "Islak Mendil", unit = "Adet", price = 15.50, stock = 125, episode = "Temizlik Ürünleri" });
            ProductAdd(new Product() { Name = "Fasulye", unit = "KG", price = 17.00, stock = 100, episode = "Bakliyat" });
            ProductAdd(new Product() { Name = "Nohut", unit = "KG", price = 12.50, stock = 78, episode = "Bakliyat" });
            ProductAdd(new Product() { Name = "Mercimek", unit = "KG", price = 9.99, stock = 65, episode = "Bakliyat" });

            #endregion
            #region Episode Added


            EpisodeAdd(new Episode() { Name = "Manav" });
            EpisodeAdd(new Episode() { Name = "İçecekler" });
            EpisodeAdd(new Episode() { Name = "Unlu Mamuller" });
            EpisodeAdd(new Episode() { Name = "Temizlik Ürünleri" });
            EpisodeAdd(new Episode() { Name = "Bakliyat" });


            #endregion
            #region Costumer Added

            CostumerAdd(new Costumer() { Name = "Oktay", Surname = "Çalışkan", PhoneNumber = "5425450437", IdNumber = "123456", Gender = "Bey" });
            CostumerAdd(new Costumer() { Name = "Hacı", Surname = "Sarıkatipoğlu", PhoneNumber = "5066144813", IdNumber = "654321", Gender = "Bey" });
            CostumerAdd(new Costumer() { Name = "Fatma", Surname = "Çelik", PhoneNumber = "5558886664", IdNumber = "963258", Gender = "Hanım" });
            CostumerAdd(new Costumer() { Name = "Alp", Surname = "Sarıkışla", PhoneNumber = "5325325252", IdNumber = "741258", Gender = "Bey" });
            CostumerAdd(new Costumer() { Name = "Ahmet", Surname = "Seri", PhoneNumber = "5426356354", IdNumber = "852147", Gender = "Bey" });
            CostumerAdd(new Costumer() { Name = "Yeşim", Surname = "Özgür", PhoneNumber = "5554562525", IdNumber = "147896", Gender = "Hanım" });
            #endregion
        }
        public Episode[] GetAllEpisodes()
        {
            return Episodes;
        }
        public Costumer[] GetAllCustomers()
        {
            return Costumers;
        }
        public Product[] GetAllProducts()
        {
            return Products;
        }


        public void ProductAdd(Product e)
        {
            Product[] temporary = new Product[Products.Length + 1];
            Array.Copy(Products, temporary, Products.Length);
            temporary[temporary.Length - 1] = e;
            Products = temporary;
        }

        public void Home()
        {
            Console.WriteLine("\t \t \t -*-*-*-*-*-Hacı Baba Tekkesine Hoş Geldiniz-*-*-*-*-*-*-");
            Console.WriteLine("");
            Console.WriteLine(" Hacı Baba Kartınız Var İse Lütfen 1'e Basınız ");
            Console.WriteLine("");
            Console.WriteLine(" Hacı Baba Kartınız İle Her Alışverişinizde Anında %10 İndirim Kazanın...");
            Console.WriteLine("");
            Console.WriteLine(" Kartsız Devam Etmek İçin Herhangi Bir Tuşa Basınız");

        }

        public void EpisodeAdd(Episode n)
        {

            Episode[] temporary = new Episode[Episodes.Length + 1];
            Array.Copy(Episodes, temporary, Episodes.Length);
            temporary[temporary.Length - 1] = n;
            Episodes = temporary;

        }


        public void Index()
        {
            Console.WriteLine("Lütfen Alışveriş Yapmak İstediğiniz Kategoriyi belirtiniz...");
        }

        public void EpisodeWrite()
        {
            for (int i = 0; i < Episodes.Length; i++)
            {
                Console.WriteLine($"{i + 1} {Episodes[i].Name}");
            }
        }


        public void CostumerAdd(Costumer c)
        {

            Costumer[] temporary = new Costumer[Costumers.Length + 1];
            Array.Copy(Costumers, temporary, Costumers.Length);
            temporary[temporary.Length - 1] = c;
            Costumers = temporary;


        }

        double totalPrice = 0;
        string totalOrder = "";
        public void OrderMenu(int selected)
        {

            for (int j = 0; j < Episodes.Length; j++)
            {

                if (selected == j + 1)
                {
                    Console.Clear();
                    Console.WriteLine($"-*-*-*-*{Episodes[j].Name} Reyonu-*-*-*-*-");
                    for (int k = 0; k < Products.Length; k++)
                    {
                        if (Episodes[j].Name == Products[k].episode)
                        {
                            Console.WriteLine($"{k + 1}) {Products[k].Name} {Products[k].price} {Products[k].stock} {Products[k].unit}");
                        }
                    }
                    Console.WriteLine("Lütfen Almak İstediğiniz Ürünün Numarasını Giriniz");
                    int order = Convert.ToInt32(Console.ReadLine());
                    for (int k = 0; k < Products.Length; k++)
                    {
                        if (order == k + 1)
                        {
                            Console.WriteLine($"Kaç {Products[k].unit} {Products[k].Name} Sipariş Etmek İstersiniz?");
                            int piece = Convert.ToInt32(Console.ReadLine());
                            if (piece <= Products[k].stock)
                            {

                                Console.WriteLine($"{piece} {Products[k].unit} {Products[k].Name} = {(piece * Products[k].price)} TL");
                                totalOrder = ($"{piece} {Products[k].unit} {Products[k].Name} = {(piece * Products[k].price)} TL\n") + totalOrder;
                                totalPrice = (piece * Products[k].price) + totalPrice;

                                Console.WriteLine($"Kalan Stok = {(Products[k].stock - piece)}\n");


                                Console.WriteLine($"Toplam Alışveriş = {totalPrice} TL");
                                Products[k].stock = (Products[k].stock - piece);
                            }
                            else
                            {
                                Console.WriteLine("Stok Yetersiz");
                            }


                        }

                    }

                }

            }

        }
        public double GetTotalPrice()
        {
            return totalPrice;
        }
        public string GetTotalOrder()
        {
            return totalOrder;
        }






    }
}
