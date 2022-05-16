using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.Moduloquestao
{
    public class ConfiguracaoToolboxQuestao : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de Questões";

        public override string TooltipInserir => "Inserir uma nova Questao";

        public override string TooltipEditar => "Editar uma Questao existente";

        public override string TooltipExcluir => "Excluir uma Questao existente";
    }
}