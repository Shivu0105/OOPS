using System.Threading.Channels;

namespace Practice
{

    class Car
    {
        private string carName;
        private string carModel;

        public Car(string cName, string cModel)
        {
            this.carName = cName;
            this.carModel = cModel;
        }

        public void CarInfo()
        {
            Console.WriteLine("Car Name is "+ this.carName);
            Console.WriteLine("Cae Model is "+ this.carModel);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Honda", "City");
            c.CarInfo();
        }
    }
}