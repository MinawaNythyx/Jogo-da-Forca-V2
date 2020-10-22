using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Jogo_da_Forca_V2
{
    class Jogo
    {
        public void Iniciar(string palavra, string dica)
        {
            bool loopGame = true;
            palavra word = new palavra();
            string secretWord = word.ConvertWord(palavra);
            int errors = 0;
            string usedChar = "";
            do
            {
                Graphics(secretWord, palavra, dica, errors);

                Console.WriteLine($"\n{usedChar}\nDigite a letra ou a palavra");
                string cha = Console.ReadLine(); 

                if (cha.Length == 1)
                {
                    usedChar += cha + " - ";
                    if (word.ValidWord(cha, palavra))
                    {
                        errors++;
                    }
                    else
                    {
                        secretWord = word.SecretWordReveal(cha, secretWord, palavra);
                    }
                }
                else
                {
                    if(word.validaPalavra(cha, palavra))
                    {
                        loopGame = WinLose("WIN", palavra, dica, errors);
                        Console.ReadLine();
                    }
                    else
                    {
                        errors++;
                    }
                }
                if(errors > 5)
                {
                    loopGame = WinLose("LOSE", palavra, dica, errors);
                    Console.ReadLine();
                }
                else if(secretWord == palavra && errors < 6)
                {
                    loopGame = WinLose("WIN", palavra, dica, errors);
                    Console.ReadLine();
                }
            } while (loopGame);
        }

        #region Graphics
        private void Graphics(string secretWord, string palavra, string dica, int errors)
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
            if(errors > 0)
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
            if(errors == 2)
            {
                return "/";
            }
            else if(errors == 3)
            {
                return "/|";
            }
            else if(errors > 3)
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
        #endregion

        private bool WinLose(string condition, string palavra, string dica, int errors)
        {
            Graphics(palavra, palavra, dica, errors);
            Console.WriteLine($"YOU {condition}");
            return false;
        }
    }
}
