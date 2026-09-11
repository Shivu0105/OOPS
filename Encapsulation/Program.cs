using System.Threading.Channels;

namespace Encapsulation
{

    class Car
    {
        private string carName;
        private string carModel;
        private string carColor;


        ////Getter
        //public string GetCarName()
        //{
        //    return this.carName;
        //}

        ////Setter
        //public void SetCarName(string carName)
        //{
        //    this.carName = carName;
        //}

        public string CarName
        {
            get { return this.carName; }
            set { this.carName = value; }
        }

        // Modern way to write Getter & Setter
        public string CarColor
        {
            get {  return this.carColor; }
            set { this.carColor = value; }   
        }

        public string CarModel
        {
            get { return this.carModel; }
            set { this.carModel = value;}
        }

        public Car(string carNa, string carModel, string  carColor) // Parameter
        {
            carName = carNa;
            this.carModel = carModel;
            this.carColor = carColor;
        }
        public void CarInfo()
        {
            Console.WriteLine("CarName is "+ carName);
            Console.WriteLine("Car Color is "+ carColor);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car c = new Car("Honda","City","Brown");

            //string carName = c.GetCarName();

            //Console.WriteLine(carName);


            //c.SetCarName("BMW");
            //c.CarInfo();

            //c.SetCarName("Audi");
            //Console.WriteLine(c.GetCarName());


            //Console.WriteLine(c.CarColor);

            c.CarName = "Hero";
            Console.WriteLine(c.CarName);

            c.CarColor = "Black";
            Console.WriteLine(c.CarColor);
            
            c.CarModel = "Splender";
            Console.WriteLine(c.CarModel);


            // Server  => 24x7 PC  => 
        }
    }
}
