using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo_da_Forca_V2
{
    class ListaPalavrasDicas
    {
        #region Palavras e Dicas
        #region Palavras
        string[] palavras = { 
            "Arvore",
            "Leao",
            "Viajar",
            "Mitologia",
            "Oftamologista",
            "Araucaria", 
            "Cerrado",
            "Caldo de cana",
            "Fernando de Noronha",
            "Espartilho"
        };
        #endregion
        #region Dicas
        string[] dicas = { 
            "Cresce na natureza", 
            "Rei da Floresta" ,
            "Férias",
            "História",
            "Médico",
            "Arvore",
            "Bioma", 
            "Bebida tipica do Brasil",
            "Praia",
            "Vestuario feminino"
        };
        #endregion
        #endregion

        public int Qtd()
        {
            return palavras.Length;
        }
        public string PalavraDica(int rnd, string word)
        {
            if(word == "palavra")
            {
                return palavras[rnd];
            }
            else
            {
                return dicas[rnd];
            }
        }
    }
}
