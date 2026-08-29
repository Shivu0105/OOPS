using System.Threading.Channels;
using System.Xml.Linq;

namespace Constructor
{
    //Ctor

     class Mobile   // Class naming convention in pascle.
    {
        private string companyName; // Variables always in camelCase.// Properties
        private string companyModel;
        private double companyPrice;

        // It's a Ctor
        public Mobile()
        {
            Console.WriteLine("Here I am non-param'd Ctor..!"); //non- parameterized 
        }

        public Mobile(string cName,string cModel,double cPrice) // parameterized
        {
            this.companyName = cName;  //this keyword is use for refering current 
            this.companyModel = cModel;
            this.companyPrice = cPrice;

            Console.WriteLine("I'm Param'd Ctor...!");
        }


        public void showDetails()   //Function
        {
            Console.WriteLine("Mbl Company Name "+ this.companyName);
            Console.WriteLine("Mbl Model "+ this.companyModel);
            Console.WriteLine("Mbl price is " + this.companyPrice);
        }

    }

    class Laptop
    {
        private string laptopName;
        private string laptopModel;
        private double laptopPrice;
        private string laptopColor;

        public Laptop()
        {
            Console.WriteLine("Here I'm non-param'd ctor in other class");
        }

        public Laptop(string lName, string lModel, double lPrice, string lColor)
        {
            this.laptopName = lName;
            this.laptopModel = lModel;
            this.laptopPrice = lPrice;
            this.laptopColor = lColor;
        }

        public void LaptopDetails()
        {
            Console.WriteLine("Laptop Name is "+ this.laptopName);
            Console.WriteLine("Laptop Model is "+ this.laptopModel);
            Console.WriteLine("Laptop Price is "+ this.laptopPrice);
            Console.WriteLine("Laptop Color is "+ this.laptopColor);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Mobile m = new Mobile();   //Non-parameterized

            Mobile m1 = new Mobile(":- Apple",":- iPhone19",5000);
            
            m.showDetails();
            m1.showDetails();


            Laptop l = new Laptop();

            Laptop l1 = new Laptop("HP", "Victus",70000,"Blue");

            l.LaptopDetails();
            l1.LaptopDetails();

        }
    }

    


















}

