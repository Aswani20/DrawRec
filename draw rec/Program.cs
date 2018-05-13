using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace draw_rec
{
    class Draw 
    {
        public void DrawRec() 
        {
            int RowMax, ColMax;
            Console.Write("Enter number of Rows: ");
            string R = Console.ReadLine();
            Int32.TryParse(R, out RowMax);
            Console.Write("Enter number of Coloums: ");
            string C = Console.ReadLine();
            Int32.TryParse(C, out ColMax);
            if (RowMax > 0 && ColMax > 0) 
            {
                for (int i = 1; i <= RowMax; i++) 
                {
                    for (int j = 1; j <= ColMax; j++) 
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Draw d = new Draw();
            d.DrawRec();
            Console.ReadKey();
        }
    }
}
