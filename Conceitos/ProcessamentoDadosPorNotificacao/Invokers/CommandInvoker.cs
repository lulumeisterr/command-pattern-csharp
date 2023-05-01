using System;
using System.Collections.Generic;
using System.Text;
using Commands.Interfaces;

namespace Invokers
{
    /// <summary>
    ///  Responsável por receber um comando e chamar o metodo responsavel que executará esse comando
    ///  ou seja ela é a responsável por invocar a ação que o comando representa.
    /// </summary>
    public class CommandInvoker
    {
        /// <summary>
        /// Interface responsavel por chamar o metodo a ser executado.
        /// </summary>
        private ICommand _command;

        /// <summary>
        /// responsável por receber um objeto de comando e 
        /// armazená-lo em uma variável interna para ser executado posteriormente (Aqui podemos fazer ou desfazer operacoes)
        /// </summary>
        /// <param name="command">Comando</param>
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        /// <summary>
        /// Responsável por chamar o método Execute do objeto de comando armazenado
        /// </summary>
        public void ExecuteCommand()
        {
            _command.Execute();
        }

    }
}
