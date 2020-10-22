using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo_da_Forca_V2
{
    class palavra
    {
        public string receiveWord(string word, int type)
        {
            string palavra;
            if(type == 1)
            {
                Console.Clear();
                Console.WriteLine($"Escreva a {word}");
                palavra = Console.ReadLine();
            }
            else
            {
                ListaPalavrasDicas lista = new ListaPalavrasDicas();
                palavra = lista.PalavraDica(type - 2, word);
            }

            return palavra;
        }

        public string ConvertWord(string answer)
        {
            string word = "";
            for(int x = 0; x < answer.Length; x++)
            {
                if(answer[x] == ' ')
                {
                    word += " ";
                }
                else
                {
                    word += "_";
                }
            }
            return word;
        }

        public bool ValidWord(string cha, string palavra)
        {
            int counter = 0;
            for (int x = 0; x < palavra.Length; x++)
            {
                if(char.ToLower(palavra[x]) == char.ToLower(cha[0]))
                {
                    break;
                }
                else
                {
                    counter++;
                }
            }
            if(counter == palavra.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validaPalavra(string cha, string palavra)
        {
            if(cha.ToLower() == palavra.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string SecretWordReveal(string cha, string secretWord, string palavra)
        {
            char[] word = new char[secretWord.Length];
            for(int x = 0; x < secretWord.Length; x++)
            {
                word[x] = secretWord[x];
            }
            for(int x = 0; x < palavra.Length; x++)
            {
                if(char.ToLower(cha[0]) == char.ToLower(palavra[x]))
                {
                    word[x] = palavra[x];
                }
                else
                {

                }
            }
            secretWord = "";
            for(int x = 0; x < word.Length; x++)
            {
                secretWord += word[x];
            }
            return secretWord;
        }
    }
}
