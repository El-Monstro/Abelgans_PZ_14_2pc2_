namespace Abelgans_PZ_14_2pc2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            int a1 = 2;
            Console.WriteLine(Arith(a1, n));             
        }
        static int Arith(int a1, int n)
        {
            int d = 6;
            if (n == 1)
            {
                return a1;
            }
            else
            {
                int result = Arith(a1 + d, --n);
                return result;
            }


            static double Arith(double b1, int n)
            {
                double q = 0.5;
                if (n == 1)
                {
                    return b1;
                }
                else
                {
                    double result = Arith(b1 * q, --n);
                    return result;
                }
            }
        }
    }
}