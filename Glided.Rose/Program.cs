
using Glided.Rose.Domain.Entities;
using Glided.Rose.Infrastructure.Repositories.Implementations;

ItemCreator itemCreator = new ItemCreator();

//StandardItem apple = itemCreator.CreateStandardItem("Apple", 4, 10);
//MatureItem brie = itemCreator.CreateMatureItem("Aged brie", 7, 10);
//LegendaryItem sulfuras = itemCreator.CreateLegendaryItem("Sulfuras");
//BackstagePasses Concert = itemCreator.CreateBackstagePasses("Concert", 20, 25);

//int days = 25;

//for (int day = 1; day <= days; day++)
//{
//    Console.WriteLine("Day " + day);
//    Console.WriteLine("---------------------");

//    Console.WriteLine(apple.Name + " - SellIn: " + apple.SellIn + " - Quality: " + apple.Quality);
//    apple.UpgradeQuality();

//    Console.WriteLine(brie.Name + " - SellIn: " + brie.SellIn + " - Quality: " + brie.Quality);
//    brie.UpgradeQuality();

//    Console.WriteLine(sulfuras.Name + " - Quality: " + sulfuras.Quality);

//    Console.WriteLine(Concert.Name + " - SellIn: " + Concert.SellIn + " - Quality: " + Concert.Quality);
//    Concert.UpgradeQuality();

//    Console.WriteLine();
//    Console.WriteLine();
//}