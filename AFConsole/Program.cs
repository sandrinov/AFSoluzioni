namespace AFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Drawing.Bitmap bmp;

            int x = 10;
            int y = 20;
            System.String result = "risultato somma: ";
            int z = Somma(x, y);
            result += z;
            System.Console.WriteLine(result);
        }

        private static int Somma(int x, int y)
        {
            return x + y;
        }
    }
}
