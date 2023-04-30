using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Model
{
    public class Operacao
    {
        public int ValorX { get; set; }
        public int ValorY { get; set; }

        /// <summary>
        /// Construtor
        /// </summary>
        public Operacao()
        {
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public Operacao(int valorX, int valorY)
        {
            ValorX = valorX;
            ValorY = valorY;
        }

        /// <summary>
        /// Soma dois valores
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        /// <returns>Soma de dois valores</returns>
        public Task<int> Soma(int x, int y)
        {
            return Task.FromResult(x + y);
        }


    }
}
