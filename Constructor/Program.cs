using System.Threading.Channels;
using System.Xml.Linq;

namespace Constructor
{
    //Ctor

     class Mobile   // Class naming convention in pascle.
    {
        private string companyName; // Variables always in camelCase.// Properties
        private string model;
        private double price;

        // It's a Ctor
        public Mobile()
        {
            Console.WriteLine("Here I am Ctor..!"); //non- parameterized 
        }

        public Mobile(string cName,string model,double price) // parameterized
        {
            this.companyName = cName;  //this keyword is use for refering current obj
            this.price = price;
            this.model = model;
        }


        public void showDetails()   //Function
        {
            Console.WriteLine("Mbl price is " + this.price);
            Console.WriteLine("Mbl Company Name "+ this.companyName);
            Console.WriteLine("Mbl Model "+ this.model);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Mobile m = new Mobile();   //Non-parameterized

            Mobile m1 = new Mobile("Apple","iPhone19",5000);
            
            m.showDetails();
            m1.showDetails();
        }
    }
}
