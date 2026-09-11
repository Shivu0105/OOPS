namespace Basic
{

    class Student
    {
        private string name; // Variable
        private string name1;
        private string name2;
       
        public void SetName(string n) // Setter
        {
            name = n;
        }

        public string GetName() // Getter
        {
            return name;
        }

        public string Name1 // Modern way of Getter Setter
        {
            set {  name1 = value; }
            get { return name1; }
        }

        public string Name2
        {
            set { name2 = value; }
            get { return  name2; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // data types
            // variable to store value that can change
            // const is the constant value that can't change
            // PI value, log1

            Console.WriteLine("Enter any value:");
            int a = Convert.ToInt32(Console.ReadLine());  // user input

            Console.WriteLine(a);

            Student s = new Student();

            s.SetName("Shivam");

            Console.WriteLine(s.GetName());


            s.Name1 = "Rahul";
            Console.WriteLine(s.Name1);

            s.Name2 = "Ram";
            Console.WriteLine(s.Name2);

            Console.ReadLine();

            const double PI = 3.14;
            Console.WriteLine("PI value =>" + PI);
            //PI++;
            Console.WriteLine("PI new value =>" + PI);

            //http:www.Zomato.com/MyProfile
            //http:www.Zomato.com/orders  => ORDER API => DB user:1 
            //               display to user    <= API <= orderList

            // 1. List primitive dataType in C# and who suppots unsigned with example. 
            Console.ReadLine();

            int num = -10;
            byte age = 255;
            float num1 = -1.3f;
            double studentCount = 4000000;
            long electrons = -2560000000000000000;
            bool male = true;

            Console.WriteLine("int dataType =>" + num);
            Console.WriteLine("byte dataType =>" + age);
            Console.WriteLine("Float dataType =>" + num1);
            Console.WriteLine("Double dataType =>" + studentCount);
            Console.WriteLine("Long dataType =>" + electrons);
            Console.WriteLine("Bool dataType =>" + male);

            uint population = 500000000;
            ushort marks = 35000;
            ulong stars = 5000000000000000000;

            Console.WriteLine("uint dataType =>" + population);
            Console.WriteLine("ushort dataType =>" + marks);
            Console.WriteLine("ulong dataType =>" + stars);

            //2. Non Primptive dataType

            //3. loop

            //4. if-else

            // Practice - Practice - Practice  --> Imp 

            // 1-2 




        }
    }
}


