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
        public TekkeMenu[] TekkeMenus;


        public Process()
        {
            Products = new Product[0];
            Episodes = new Episode[0];
            Costumers = new Costumer[0];
            TekkeMenus = new TekkeMenu[0];


            #region Product Added



            Add(new Product() { Name = "Elma", unit = "KG", price = 12.99, stock = 100, episode = "Manav" });
            Add(new Product() { Name = "Armut", unit = "KG", price = 15.25, stock = 150, episode = "Manav" });
            Add(new Product() { Name = "Marul", unit = "Adet", price = 5.50, stock = 85, episode = "Manav" });
            Add(new Product() { Name = "Kola", unit = "LT", price = 21.50, stock = 135, episode = "İçecekler" });
            Add(new Product() { Name = "Fanta", unit = "LT", price = 20.50, stock = 126, episode = "İçecekler" });
            Add(new Product() { Name = "Sprite", unit = "LT", price = 21.00, stock = 92, episode = "İçecekler" });
            Add(new Product() { Name = "Ekmek", unit = "Adet", price = 4, stock = 110, episode = "Unlu Mamuller" });
            Add(new Product() { Name = "Lavaş", unit = "Paket", price = 15.99, stock = 57, episode = "Unlu Mamuller" });
            Add(new Product() { Name = "Simit", unit = "Adet", price = 5, stock = 75, episode = "Unlu Mamuller" });
            Add(new Product() { Name = "Vernel", unit = "KG", price = 36.99, stock = 60, episode = "Temizlik Ürünleri" });
            Add(new Product() { Name = "Tualet Kağıdı", unit = "Adet", price = 85.00, stock = 50, episode = "Temizlik Ürünleri" });
            Add(new Product() { Name = "Islak Mendil", unit = "Adet", price = 15.50, stock = 125, episode = "Temizlik Ürünleri" });
            Add(new Product() { Name = "Fasulye", unit = "KG", price = 17.00, stock = 100, episode = "Bakliyat" });
            Add(new Product() { Name = "Nohut", unit = "KG", price = 12.50, stock = 78, episode = "Bakliyat" });
            Add(new Product() { Name = "Mercimek", unit = "KG", price = 9.99, stock = 65, episode = "Bakliyat" });

            #endregion
            #region Episode Added


            Add(new Episode() { Name = "Manav" });
            Add(new Episode() { Name = "İçecekler" });
            Add(new Episode() { Name = "Unlu Mamuller" });
            Add(new Episode() { Name = "Temizlik Ürünleri" });
            Add(new Episode() { Name = "Bakliyat" });


            #endregion
            #region Costumer Added

            Add(new Costumer() { Name = "Oktay", Surname = "Çalışkan", PhoneNumber = "5425450437", IdNumber = "123456", Gender = "Bey" });
            Add(new Costumer() { Name = "Hacı", Surname = "Sarıkatipoğlu", PhoneNumber = "5066144813", IdNumber = "654321", Gender = "Bey" });
            Add(new Costumer() { Name = "Fatma", Surname = "Çelik", PhoneNumber = "5558886664", IdNumber = "963258", Gender = "Hanım" });
            Add(new Costumer() { Name = "Alp", Surname = "Sarıkışla", PhoneNumber = "5325325252", IdNumber = "741258", Gender = "Bey" });
            Add(new Costumer() { Name = "Ahmet", Surname = "Seri", PhoneNumber = "5426356354", IdNumber = "852147", Gender = "Bey" });
            Add(new Costumer() { Name = "Yeşim", Surname = "Özgür", PhoneNumber = "5554562525", IdNumber = "147896", Gender = "Hanım" });
            #endregion
            #region TekkeMenu Added
            Add(new TekkeMenu() { Name = "Fiyat Güncelle" });
            Add(new TekkeMenu() { Name = "Stok Güncelle" });
            Add(new TekkeMenu() { Name = "Müşteri Güncelle" });
            Add(new TekkeMenu() { Name = "Yeni Müşteri Ekle" });




            #endregion
        }
        public Episode[] GetAllEpisodes()
        {
            return Episodes;
        }
        public Costumer[] GetAllCostumers()
        {
            return Costumers;
        }
        public Product[] GetAllProducts()
        {
            return Products;
        }
        public TekkeMenu[] GetAllTekkeMenus()
        {
            return TekkeMenus;
        }


        public void Add(Product e)
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

        public void Add(Episode n)
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


        public void Add(Costumer c)
        {

            Costumer[] temporary = new Costumer[Costumers.Length + 1];
            Array.Copy(Costumers, temporary, Costumers.Length);
            temporary[temporary.Length - 1] = c;
            Costumers = temporary;


        }
        public void Add(TekkeMenu t)
        {

            TekkeMenu[] temporary = new TekkeMenu[TekkeMenus.Length + 1];
            Array.Copy(TekkeMenus, temporary, TekkeMenus.Length);
            temporary[temporary.Length - 1] = t;
            TekkeMenus = temporary;


        }
        public void AllProducts()
        {
            for (int k = 0; k < Products.Length; k++)
            {
                {
                    Console.WriteLine($"{k + 1}) {Products[k].Name} {Products[k].price} {Products[k].stock} {Products[k].unit}");

                }
            }
        }
        public void AllCostumers()
        {
            for (int k = 0; k < Costumers.Length; k++)
            {
                {
                    Console.WriteLine($"{k + 1}) {Costumers[k].Name} {Costumers[k].Surname} {Costumers[k].IdNumber}");

                }
            }
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
        public void TekkeMenuWrite()
        {
            for (int i = 0; i < TekkeMenus.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {TekkeMenus[i].Name}");
            }
        }
        public void TekkeMenuIndex(int selected)
        {
            while (selected != 1 && selected != 2 && selected != 3 && selected != 4)
            {

                Console.WriteLine("Lütfen Doğru İşlem Numarası Gir");
                selected = Convert.ToInt32(Console.ReadLine());

            }
            Console.Clear();
            if (selected == 1)
            {
                string startAgain = "e";
                while (startAgain.ToUpper() == "E")
                {
                    for (int i = 0; i < TekkeMenus.Length; i++)
                    {
                        if (selected == i + 1)
                        {
                            Console.WriteLine($"-*-*-*-{TekkeMenus[i].Name}-*-*-*-");


                            AllProducts();
                            Console.WriteLine($"Lütfen {TekkeMenus[i].Name} İşlemi Yapmak İstediğiniz Ürün Numarasını Giriniz");
                            int productChange = Convert.ToInt32(Console.ReadLine());
                            if (productChange <= Products.Length)
                            {
                                Console.Clear();
                                Console.WriteLine($"-*-*-*-{Products[productChange - 1].Name} {TekkeMenus[i].Name}-*-*-*-");
                                Console.WriteLine("Şu Anki Fiyatı = " + Products[productChange - 1].price);
                                Console.WriteLine("Lütfen Güncel Fiyatı Giriniz");
                                double newPrice = Convert.ToDouble(Console.ReadLine());
                                Products[productChange - 1].price = newPrice;
                                Console.WriteLine($"{Products[productChange - 1].Name} Ürününün Fiyat Güncelleme İşlemi Tamamlandı");
                                Console.WriteLine("Güncel Fiyat = " + Products[productChange - 1].price);

                            }
                            Console.WriteLine($"{TekkeMenus[i].Name} İşlemine Devam Etmek İster Misiniz?");
                            startAgain = Console.ReadLine();

                            Console.Clear();
                        }

                    }

                }
                Console.WriteLine("Güncelleme İşlemi Tamamlandı Güncel Ürün Listesi Aşağıdaki Gibidir");
                AllProducts();
            }
            else if (selected == 2)
            {
                string startAgain = "e";
                while (startAgain.ToUpper() == "E")
                {
                    for (int i = 0; i < TekkeMenus.Length; i++)
                    {
                        if (selected == i + 1)
                        {
                            Console.WriteLine($"-*-*-*-{TekkeMenus[i].Name}-*-*-*-");


                            AllProducts();
                            Console.WriteLine($"Lütfen {TekkeMenus[i].Name} İşlemi Yapmak İstediğiniz Ürün Numarasını Giriniz");
                            int productChange = Convert.ToInt32(Console.ReadLine());
                            if (productChange <= Products.Length)
                            {
                                Console.Clear();
                                Console.WriteLine($"-*-*-*-{Products[productChange - 1].Name} {TekkeMenus[i].Name}-*-*-*-");
                                Console.WriteLine("Şu Anki Stok Miktarı = " + Products[productChange - 1].stock);
                                Console.WriteLine("Lütfen Güncel Stok Miktarını Giriniz");
                                double newStok = Convert.ToDouble(Console.ReadLine());
                                Products[productChange - 1].stock = newStok;
                                Console.WriteLine($"{Products[productChange - 1].Name} Ürününün Stok Güncelleme İşlemi Tamamlandı");
                                Console.WriteLine("Güncel Stok = " + Products[productChange - 1].stock);

                            }
                            Console.WriteLine($"{TekkeMenus[i].Name} İşlemine Devam Etmek İster Misiniz?");
                            startAgain = Console.ReadLine();

                            Console.Clear();
                        }

                    }

                }
                Console.WriteLine("Güncelleme İşlemi Tamamlandı Güncel Ürün Listesi Aşağıdaki Gibidir");
                AllProducts();
            }
            else if (selected == 3)
            {
                string startAgain = "e";
                while (startAgain.ToUpper() == "E")
                {
                    for (int i = 0; i < TekkeMenus.Length; i++)
                    {
                        if (selected == i + 1)
                        {
                            Console.WriteLine($"-*-*-*-{TekkeMenus[i].Name}-*-*-*-");


                            AllCostumers();
                            Console.WriteLine($"Lütfen {TekkeMenus[i].Name} İşlemi Yapmak İstediğiniz Müşteri Numarasını Giriniz");
                            int costumerChange = Convert.ToInt32(Console.ReadLine());
                            if (costumerChange <= Costumers.Length)
                            {
                                Console.Clear();
                                Console.WriteLine($"-*-*-*- {Costumers[costumerChange - 1].Name} {Costumers[costumerChange - 1].Surname} -*-*-*-");
                                string continiuChangeCostumer = "e";
                                while (continiuChangeCostumer.ToUpper() == "E")
                                {
                                    Console.WriteLine("Lütfen Değiştirmek istediğiniz Bölümü Seçiniz");
                                    Console.WriteLine("1) İsim");
                                    Console.WriteLine("2) Soyisim");
                                    Console.WriteLine("3) Kart Numarası");
                                    Console.WriteLine("4) Telefon Numarası");
                                    Console.WriteLine("5) Cinsiyet");
                                    int changeIndex = Convert.ToInt32(Console.ReadLine());
                                    while (changeIndex != 1 && changeIndex != 2 && changeIndex != 3 && changeIndex != 4 && changeIndex != 5)
                                    {
                                        Console.WriteLine("Lütfen Doğru Bölüm Numarası Giriniz");
                                        changeIndex = Convert.ToInt32(Console.ReadLine());
                                    }
                                    if (changeIndex == 1)
                                    {
                                        Console.WriteLine("Lütfen Yeni İsim Giriniz");
                                        string newName = Console.ReadLine();
                                        Costumers[costumerChange - 1].Name = newName;
                                    }
                                    else if (changeIndex == 2)
                                    {
                                        Console.WriteLine("Lütfen Yeni Soyisim Giriniz");
                                        string newSurname = Console.ReadLine();
                                        Costumers[costumerChange - 1].Surname = newSurname;
                                    }
                                    else if (changeIndex == 3)
                                    {
                                        Console.WriteLine("Lütfen Yeni Kart Numarası Giriniz");
                                        string newkartID = Console.ReadLine();
                                        Costumers[costumerChange - 1].IdNumber = newkartID;
                                    }
                                    else if (changeIndex == 4)
                                    {
                                        Console.WriteLine("Lütfen Yeni Telefon Numarası Giriniz");
                                        string newphoneNumber = Console.ReadLine();
                                        Costumers[costumerChange - 1].PhoneNumber = newphoneNumber;
                                    }
                                    else if (changeIndex == 5)
                                    {
                                        Console.WriteLine("Lütfen Yeni Cinsiyet Giriniz");
                                        string newGender = Console.ReadLine();
                                        Costumers[costumerChange - 1].Gender = newGender;
                                    }
                                    Console.Clear();
                                    Console.WriteLine("Değişim İşlemi Tamamlandı Değişen Müşteri Bilgisi Aşağıdaki Gibidir");
                                    Console.WriteLine($"{Costumers[costumerChange - 1].Name} {Costumers[costumerChange - 1].Surname} {Costumers[costumerChange - 1].IdNumber} {Costumers[costumerChange - 1].PhoneNumber} {Costumers[costumerChange - 1].Gender}");
                                    Console.WriteLine("Bu Müşteride Başka Değişiklik Yapmak İster Misiniz? E/H");
                                    continiuChangeCostumer = Console.ReadLine();



                                }


                                Console.WriteLine("Değişim İşlemine Devam Etmek İster Misiniz? E/H");
                                startAgain = Console.ReadLine();
                                Console.Clear();

                            }
                            else
                            {
                                Console.WriteLine("Lütfen Doğru Müşteri Numarasını Giriniz");
                                costumerChange = Convert.ToInt32(Console.ReadLine());
                            }




                        }
                    }

                }
                Console.Clear();
                Console.WriteLine("Değişim İşlemi Bitmiştir Güncel Müşteri Listesi Aşağıdaki Gibidir");
                AllCostumers();

            }
            else if (selected == 4)
            {
                string startAgain = "e";
                if (startAgain.ToUpper() == "E")
                {
                    Console.WriteLine("Lütfen Eklemek İstediğiniz Müşteri Bilgilerini Giriniz");
                    Console.WriteLine("Lütfen İsim Giriniz");
                    string aName = Console.ReadLine();
                    Console.WriteLine("Lütfen Soysim Giriniz");
                    string aSurname = Console.ReadLine();
                    Console.WriteLine("Lütfen Telefon Numarası Giriniz");
                    string aPhoneNumber = Console.ReadLine();
                    Console.WriteLine("Lütfen Kart Numarası Giriniz");
                    string aIdNumber = Console.ReadLine();
                    Console.WriteLine("Lütfen Cinsiyet Giriniz");
                    string aGender = Console.ReadLine();

                    Add(new Costumer
                    {
                        Name = aName,
                        Surname = aSurname,
                        PhoneNumber = aPhoneNumber,
                        IdNumber = aIdNumber,
                        Gender = aGender
                    });

                    Console.Clear();
                    Console.WriteLine("Ekleme İşlemi Tamamlandı");
                    Console.WriteLine("Başka Müşteri Eklemek İster Misiniz?E/H");
                    startAgain = Console.ReadLine();
                }

                Console.Clear();
                Console.WriteLine("Ekleme İşlemi Bitmiştir Güncel Müşteri Listesi Aşağıdaki Gibidir");
                AllCostumers();


            }
        }
    }






}

