using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloDisciplina
{
    public class ConfiguracaoToolboxDisciplina : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de Disciplinas";

        public override string TooltipInserir => "Inserir uma nova disciplina";

        public override string TooltipEditar => "Editar uma disciplina existente";

        public override string TooltipExcluir => "Excluir uma disciplina existente";

        public override string TooltipFiltrar { get { return "Filtrar Disciplina por Status"; } }

        public override bool FiltrarHabilitado => false;
    }
}
