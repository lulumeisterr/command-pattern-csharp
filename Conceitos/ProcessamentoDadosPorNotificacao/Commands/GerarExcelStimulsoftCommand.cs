using System;
using System.Collections.Generic;
using System.Text;
using Commands.Interfaces;
using Model;

namespace Commands
{
    public class GerarExcelStimulsoftCommand : ICommand
    {
        private readonly List<Dados> _dados;

        public GerarExcelStimulsoftCommand(List<Dados> dados)
        {
            _dados = dados;
        }

        public async Task Execute()
        {
            throw new NotImplementedException();
        }
    }
}
