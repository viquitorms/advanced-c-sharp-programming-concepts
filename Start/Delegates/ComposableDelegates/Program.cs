// LinkedIn Learning Course exercise file for Advanced C# Programming by Joe Marini
// Example file for composable delegates


namespace Composable
{
    // declare the delegate type
    public delegate void MyDelegate(int arg1, ref int arg2);

    class Program
    {
        static void func1(int arg1, ref int arg2)
        {
            arg1 += 20;
            string result = (arg1 + arg2).ToString();
            Console.WriteLine("The number from func1 is: " + result);
        }

        static void func2(int arg1, ref int arg2)
        {
            string result = (arg1 * arg2).ToString();
            Console.WriteLine("The number from func2 is: " + result);
        }
        
        static void Main(string[] args)
        {
            MyDelegate f1 = func1;
            MyDelegate f2 = func2;
            // Create a composed delegate from f1 and f2

            MyDelegate all = f1 + f2;

            int a=10;
            int b=20;

            // call each delegate and then the chain
            Console.WriteLine("\nCalling the first delegate");
            f1(a, ref b);
            Console.WriteLine("\nCalling the second delegate");
            f2(a, ref b);
            // TODO: Call the composed delegate
            Console.WriteLine("\nCalling the chained delegates");
            all(a, ref b);

            // TODO: subtract off one of the delegates
            Console.WriteLine("\nCalling the unchained delegates");
            all-=f1;
            all(a, ref b);

        }
    }
}
