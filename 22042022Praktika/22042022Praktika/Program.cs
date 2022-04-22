using _22042022Praktika.Data.DAL;
using _22042022Praktika.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _22042022Praktika
{
    class Program
    {
        static void Main(string[] args)
        {
            StadionDbContext stadionDbContext = new StadionDbContext();
            bool check = true;
            string ans;
            do
            {
                Console.WriteLine("1. Stadion elave et");
                Console.WriteLine("2. Stadionlara goster");
                Console.WriteLine("3.  Verilmiş id-li stadionu göstər");
                Console.WriteLine("4. Verilmiş id-li stadionu sil");
                Console.WriteLine("0. Quit");

                ans = Console.ReadLine();


                switch (ans)
                {
                    case "1":
                        Console.WriteLine("insert");
                        Console.WriteLine("Name daxil edin:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Price daxil et:");
                        int price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Capacity daxil et:");
                        int cap = Convert.ToInt32(Console.ReadLine());

                        Stadion stadion = new Stadion
                        {
                            Capacity = cap,
                            Name = name,
                            HourlyPrice = price
                        };

                        stadionDbContext.Stadions.Add(stadion);
                        stadionDbContext.SaveChanges();
                        break;
                    case "2":

                        List<Stadion> stadions = stadionDbContext.Stadions.ToList();

                        foreach (var item in stadions)
                        {
                            Console.WriteLine($"{item.Id} - {item.Name} - {item.HourlyPrice}");
                        }

                        break;
                    case "3":
                        Console.WriteLine("Id daxil et:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var data = stadionDbContext.Stadions.Where(x => x.Id == id).FirstOrDefault();
                        Console.WriteLine(data.Name);
                        break;
                    case "4":
                        Console.WriteLine("Id daxil et:");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        var data2 = stadionDbContext.Stadions.Where(x => x.Id == id2).FirstOrDefault();
                        stadionDbContext.Remove(data2);
                        stadionDbContext.SaveChanges();
                        break;
                    case "0":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Dogru secim edin:");
                        break;
                }

            } while (check);
        }
    }
}
