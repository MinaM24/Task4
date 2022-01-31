

namespace ConsoleApp.Task4
{
    class Car1
    { 

        public string location;
        public string brand;
        public string model;
        public int modelYear;
        public string fuelFype;
        public double engine;
        public string color;
        public int milieage;
        public string transmission;
        public int price;

        

        public string GetInfo()
        {
            string output = $"{this.location}\n" +
                $"{this.brand}\n" +
                $"{this.model}\n" +
                $"{this.modelYear}\n" +
                $"{this.fuelFype}\n" +
                $"{this.engine}\n" +
                $"{this.color}\n" +
                $"{this.milieage}\n" +
                $"{this.transmission}\n" +
                $"{this.price}$";

            return output;



        }


    }
}
