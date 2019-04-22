using System;
using System.Collections.Generic;

namespace Dealership {

  public class Program
  {
    public static void Main()
    {
      Car porsche = new Car("2003 Porsche 911", 113344, 8883);
      Car ford = new Car("1994 Ford F450", 15000, 100000);
      Car nissan = new Car("1986 720", 69000, 100);
      Car honda = new Car("1990 Civic Hatchback", 11111, 1000);
      Car yota = new Car("Toyota Rav-4", 7000, 150000);
      Car chrys = new Car("Chrysler Lebaron", 4000, 200000);

      //ONE WAY OF CREATING INSTANCES OF THE CAR CLASS
      // Car porsche = new Car();
      // porsche.MakeModel = "2003 Porsche 911";
      // porsche.Price = 113344;
      // porsche.Miles = 8883;
      //
      // Car ford = new Car();
      // ford.MakeModel = "1994 Ford F450";
      // ford.Price = 15000;
      // ford.Miles = 100000;
      //
      // Car nissan = new Car();
      // nissan.MakeModel = "1986 720";
      // nissan.Price = 69000;
      // nissan.Miles = 100;
      //
      // Car honda = new Car();
      // honda.MakeModel = "1990 Civic Hatchback";
      // honda.Price = 111111;
      // honda.Miles = 1000;

      List<Car> Cars = new List<Car>() { porsche, ford, nissan, honda, yota, chrys };

      // porsche.SetPrice(100);

      Console.WriteLine("Enter Maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach(Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("------------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
      }
    }
  }

}

//A DIFFERENT WAY TO LIST CARS UNDER A CERTIAN PRICE
//     foreach(Car automobile in Cars)
//     {
//       Console.WriteLine(automobile.MakeModel);
//     }
//
//     Console.WriteLine("Enter Maximum price: ");
//     string stringMaxPrice = Console.ReadLine();
//     int maxPrice = int.Parse(stringMaxPrice);
//
//     List<Car> CarsMatchingSearch = new List<Car>();
//
//     foreach(Car automobile in Cars)
//     {
//       if (automobile.Price < maxPrice)
//       {
//         CarsMatchingSearch.Add(automobile);
//       }
//     }
//
//     foreach(Car automobile in CarsMatchingSearch)
//     {
//       Console.WriteLine(automobile.MakeModel);
//     }
//   }
// }
