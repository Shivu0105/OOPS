namespace Student
{

    class Pen
    {
        int price;
        string color;
        string type;

        void Writing() 
        {
            Console.WriteLine("Pen is Writting " + Writing);
        }

        void Stopped()
        {
            Console.WriteLine("Pen Stopped " + Stopped);
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");

                Pen p = new Pen();

                p.Writing();
                p.Stopped();

                p.price = 25;
                p.color = "Red";
                p.type = "Ball Pen";

                Console.WriteLine("Pen Price is "+ p.price);
                Console.WriteLine("Pen Color is "+ p.color);
                Console.WriteLine("Pen Type is "+ p.type);

            }
        }
    }
}
