using System;
using System.Collections.Generic;
using System.Text;

namespace Commands.Interfaces
{
    //Interface responsavel por encapsular uma solicitação específica chamada pelos invokers
    public interface ICommand
    {
        /// <summary>
        ///  Método Execute, que é chamado pelo CommandInvoker
        /// </summary>
        /// <returns>Task</returns>
        Task Execute();
    }
}
