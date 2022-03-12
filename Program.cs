namespace Fac_pro
{
    class Program
    {
        public void Calulation()
        {
            int user_enter;
            int factorial = 1;
            Console.WriteLine("the value : ");
            user_enter = int.Parse(Console.ReadLine());
            for (int i = user_enter; i > 1; i--)
            {
                factorial = i * factorial;
            }
            Console.WriteLine("factorial value : " + factorial);
        }
    }
    class Result
    {
        public static void Main(string[] args)
        {
            Program pro = new Program();
            pro.Calulation();
        }
    }
}