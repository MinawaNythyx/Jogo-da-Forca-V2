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
            Graphics graphics = new Graphics();
            do
            {
                graphics.Graphic(secretWord, palavra, dica, errors);

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

        private bool WinLose(string condition, string palavra, string dica, int errors)
        {
            Graphics graphics = new Graphics();
            graphics.Graphic(palavra, palavra, dica, errors);
            Console.WriteLine($"YOU {condition}");
            return false;
        }
    }
}
