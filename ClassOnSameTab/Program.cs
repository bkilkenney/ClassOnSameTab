using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOnSameTab
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();                  //myCar ONLY AVAILABLE IN MAIN METHOD(SCOPE)

            Car myThirdCar = new Car("Honda", "Accord", 2015, "Blue");


            Console.WriteLine("The next line is going to print out the color of myThirdCar \nbased on the input parameter in ():");

            Console.WriteLine(myThirdCar.Color);  //Prints Blue

            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2000;
            myCar.Color = "Beige";

            Car myOtherCar = myCar;     //myOtherCar is another handle to the same bucket in computer's memory. NOTICE
                                        //NEW keyword and Car() method missing, b/c were assigning it to one that 
                                        //already exists. 


            Console.ReadLine();
            Console.WriteLine("Here are the specs of my car: {0} {1} {2} {3}", //This will print the same properties as myOtherCar
                myCar.Make,                            //2 HANDLES TO THE SAME BUCKET IN MEMORY
                myCar.Model,
                myCar.Year,
                myCar.Color);

            Console.ReadLine();

            Console.WriteLine("Here are the specs of my other car: {0} {1} {2} {3}", 
                myOtherCar.Make, 
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Color);  //Even though I didn't set these values it's taking on the same properties of myCar

            Console.ReadLine();


            Console.WriteLine("Here are the specs of my third car: {0} {1} {2} {3}",
               myThirdCar.Make,
               myThirdCar.Model,
               myThirdCar.Year,
               myThirdCar.Color);

            Console.ReadLine();



       //Random things I picked up:
            Console.WriteLine("Here's some random things I picked up:");
            Console.ReadLine();

            Console.WriteLine("DateTime.Now method prints out like this:");
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();

            int num = 10;
            string number = num.ToString();
            Console.WriteLine("The following number is actually a STRING:");
            Console.WriteLine(number);
            Console.WriteLine("It's like magic!");

            Console.ReadKey();

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            this.Make = "Nissan";
        }


        public Car(string make, string model, int year, string color)  
        {
            this.Make = make;               //Make is the property; make is the input parameter
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }
    }
}
