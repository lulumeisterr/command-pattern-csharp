using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Dados
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public string SobreVoce { get; set; }

        public Dados(string nome, int idade, char sexo, string sobreVoce)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
            SobreVoce = sobreVoce;
        }

        public Dados()
        {
        }
    }
}
