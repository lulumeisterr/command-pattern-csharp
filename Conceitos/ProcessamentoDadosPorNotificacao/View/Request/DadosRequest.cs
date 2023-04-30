using System;
using System.Collections.Generic;
using System.Text;

namespace View.Request
{
    /// <summary>
    /// Dados a ser recebido
    /// </summary>
    public class DadosRequest
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public string SobreVoce { get; set; }

        public DadosRequest(string nome, int idade, char sexo, string sobreVoce)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
            SobreVoce = sobreVoce;
        }

        public DadosRequest()
        {
        }
    }
}
