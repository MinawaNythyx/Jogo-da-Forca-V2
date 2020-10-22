using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo_da_Forca_V2
{
    class Menu
    {
        public void Menuu()
        {
            palavra word = new palavra();
            Jogo jogo = new Jogo();

            bool loopGame = true;
            do
            {
                bool loopEscolha = true;
                do
                {
                    Console.Clear(); 
                    Console.WriteLine("Bem- vindo ao\nJogo da Forca");
                    Console.WriteLine("Deseja jogar contra o Jogador ou contra a Maquina?");
                    Console.WriteLine("Digite:\n1 para Jogador\n2 para Maquina\n3 para sair");
                    string resposta = Console.ReadLine();

                    string palavra;
                    string dica;

                    switch (resposta)
                    {
                        case "1":
                            palavra = word.receiveWord("palavra", 1);
                            dica = word.receiveWord("dica", 1);
                            jogo.Iniciar(palavra, dica);
                            loopEscolha = false;
                            break;
                        case "2":
                            ListaPalavrasDicas list = new ListaPalavrasDicas();
                            Random rnd = new Random();
                            int rand = rnd.Next(2, list.Qtd() + 2);
                            palavra = word.receiveWord("palavra", rand);
                            dica = word.receiveWord("dica", rand);
                            jogo.Iniciar(palavra, dica);
                            loopEscolha = false;
                            break;
                        case "3":
                            loopEscolha = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Escolha um valor valido");
                            Console.ReadLine();
                            break;
                    }
                } while (loopEscolha);               
                loopGame = Quit();
            } while (loopGame);
        }
        private bool Quit()
        {
            string quit;
            do
            {
                Console.WriteLine("Deseja sair do jogo?\n1 - Sair\n2 - Ficar no jogo");
                quit = Console.ReadLine();
                switch (quit)
                {
                    case "1":
                        return false;
                    case "2":
                        return true;
                    default:
                        Console.Clear();
                        Console.WriteLine("Escolha uma opção valida");
                        break;
                }
            } while (true);
        }
    }
}
