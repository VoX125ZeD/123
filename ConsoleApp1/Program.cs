using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();

            
            while (true)
            {
                string str = "";
                for (int i = 0; i < 6; i++)
                {
                    if (ran.Next(0, 2) == 0)
                    {
                        if (ran.Next(0, 2) == 0)
                        {
                            str += (char)ran.Next(65, 90);
                        }
                        else
                        {
                            str += (char)ran.Next(97, 122);
                        }
                    }
                    else
                    {
                        str += (char)ran.Next(49, 57);
                    }
                }
                Console.WriteLine(str);
                Console.Read();
            }
        }
    }
}
