using System;
using System.Collections.Generic;
using System.Text;
using Commands.Interfaces;
using Model;
using ProcessamentoDadosPorNotificacao.Commands.Enum;
using Stimulsoft.Report;

namespace Commands
{
    /// <summary>
    /// Classe responsvel por executar a operação
    /// </summary>
    public class GerarExcelStimulsoftCommand : ICommand
    {
        private readonly List<Dados> _dados;

        public GerarExcelStimulsoftCommand(List<Dados> dados) => _dados = dados;

        public CommandStatus Status { get; private set; }

        /// <summary>
        /// Metodo responsavel por implementar objetos de comando para executar a operação
        /// </summary>
        /// <returns></returns>
        public async Task Execute()
        {
            StiReport report = new StiReport();

            try
            {
                // carrega o relatório criado anteriormente
                report.Load(@"C:\Users\lucas\OneDrive\Área de Trabalho\Desenvolvimento\skills-cshap\Conceitos\ProcessamentoDadosPorNotificacao\Resource\Report.mrt");

                // define a fonte de dados (se houver)
                report.RegData("root", _dados);

                // compila o relatório
                await report.CompileAsync();

                // renderiza o relatório
                await report.RenderAsync();

                // Exporta o relatório para um arquivo excel
                report.ExportDocument(StiExportFormat.Excel, @"C:\Users\lucas\meu_relatorio.xls");

                Status = CommandStatus.Success;
            }
            catch (Exception)
            {
                Status = CommandStatus.Failure;
            }
        }
    }
}
