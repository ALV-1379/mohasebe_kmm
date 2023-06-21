using System;

namespace mohasebe_bmm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adad haye mad nazar ra vared konid");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());


            int a = 1;
            for (int i = 1; i<=x && i<=y; i++)
            {
                if(x % i ==0 && y%i == 0)
                {
                    a = i;
                }
            }

            Console.WriteLine($"bmm do adad barbar {a}");

            Console.ReadKey();


           
        }
    }
}
