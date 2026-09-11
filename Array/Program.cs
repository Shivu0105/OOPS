using System.ComponentModel;

class Practice
{
    static void Main()
    {
        //int[] num = new int[5];                               // array declaration; num=4byte 5X4=20byte; num(stack) -> heap 20bytes 
        //Console.WriteLine("Enter an Elements");
        
        ////input
        //for (int i = 0; i < num.Length; i++)
        //{
        //    num[i] = Convert.ToInt32(Console.ReadLine()); 

        //}

        ////output
        //for (int i = 0; i < num.Length; i++)
        //{
        //    Console.WriteLine(num[i]);
        //}

        int[] num2 = { 10,20,30,40,50};
        Console.WriteLine(num2.Length);

        for (int i = 0; i < num2.Length; i++)
        {
            Console.WriteLine($"{i+1} -> {num2[i]}");        //   0 -> 10
        }
    }
}