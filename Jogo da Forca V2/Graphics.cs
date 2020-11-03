using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo_da_Forca_V2
{
    class Graphics
    {
        public void Graphic(string secretWord, string palavra, string dica, int errors)
        {
            string head = Head(errors);
            string shoulder = Shoulder(errors);
            string legs = Legs(errors);

            Console.Clear();
            Console.WriteLine(dica);
            Console.WriteLine("|----------|");
            Console.WriteLine("|          |");
            Console.WriteLine($"|          {head}");
            Console.WriteLine($"|         {shoulder}");
            Console.WriteLine($"|         {legs}");
            Console.WriteLine("|          ");
            Console.WriteLine("|          ");
            Console.WriteLine($"- {secretWord}");
        }

        private string Head(int errors)
        {
            if (errors > 0)
            {
                return "O";
            }
            else
            {
                return "";
            }
        }

        private string Shoulder(int errors)
        {
            if (errors == 2)
            {
                return "/";
            }
            else if (errors == 3)
            {
                return "/|";
            }
            else if (errors > 3)
            {
                return "/|\\";
            }
            else
            {
                return "";
            }
        }

        private string Legs(int errors)
        {
            if (errors == 5)
            {
                return "/";
            }
            else if (errors > 5)
            {
                return "/ \\";
            }
            else
            {
                return "";
            }
        }
    }
}
