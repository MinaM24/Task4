using System;
using System.Text;

namespace ConsoleApp.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            
            Car1 car1 = new Car1();

            car1.location = "Baki";
            car1.brand = "Audi";
            car1.model = "Q5";
            car1.modelYear = 2021;
            car1.fuelFype = "Benzin";
            car1.engine = 2.0;
            car1.color = "Ag";
            car1.milieage = 0;
            car1.transmission = "Avtomat";
            car1.price = 54000;

            Car1 car2 = new Car1();

            car2.location = "Baki";
            car2.brand = "BMW";
            car2.model = "X5 M";
            car2.modelYear = 2020;
            car2.fuelFype = "Benzin";
            car2.engine = 4.4;
            car2.color = "Qara";
            car2.milieage = 9000;
            car2.transmission = "Avtomat";
            car2.price = 175000;

            Car1 car3 = new Car1();

            car3.location = "Baki";
            car3.brand = "Jac";
            car3.model = "T8";
            car3.modelYear = 2022;
            car3.fuelFype = "Dizel";
            car3.engine = 2.0;
            car3.color = "Goy";
            car3.milieage = 0;
            car3.transmission = "Mexaniki";
            car3.price = 42000;

            Car1 car4 = new Car1();

            car4.location = "Baki";
            car4.brand = "Porsche";
            car4.model = "Cayenne Turbo S E-Hybrid";
            car4.modelYear = 2020;
            car4.fuelFype = "Hibrid";
            car4.engine = 4.0;
            car4.color = "Qara";
            car4.milieage = 8000;
            car4.transmission = "Avtomat";
            car4.price = 151555;

            Car1[] cars =new Car1[4];

            cars[0] = car1;
            cars[1] = car2;
            cars[2] = car3;
            cars[3] = car4;

            foreach (Car1 car in cars)
            {

                /*Console.WriteLine($"{car.location}\n" +
                    $"{car.brand}\n" +
                    $"{car.model}\n" +
                    $"{car.modelYear}\n" +
                    $"{car.fuelFype}\n" +
                    $"{car.engine}\n" +
                    $"{car.color}\n" +
                    $"{car.milieage}\n" +
                    $"{car.transmission}\n" +
                    $"{car.price}$ ");*/

                Console.WriteLine(car.GetInfo());
                Console.WriteLine("------------");
            }

            
            Console.WriteLine("#############"); 
            
            Car1 c1 = cars[0];
            
            Console.WriteLine(c1.GetInfo());


            /*Console.WriteLine($"{c1.location}\n" +
                $"{c1.brand}\n" +
                $"{c1.model}\n" +
                $"{c1.modelYear}\n" +
                $"{c1.fuelFype}\n" +
                $"{c1.engine}\n" +
                $"{c1.color}\n" +
                $"{c1.milieage}\n" +
                $"{c1.transmission}\n" +
                $"{c1.price}$ ");

            Console.WriteLine("------------");*/




        }
    }
}
