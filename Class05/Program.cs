namespace Class05
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MethodClass test = new MethodClass();

            int x = 3;
            int y = 2;

            int remain = 0;
            

            //test.Add();
            int value = test.Divide(x, y, out remain);

            Console.WriteLine(value);

            Swap swap = new Swap();
            swap.GameStart();

        }
    }
}
