using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloProva
{
    public class ConfiguracaoToolboxProva : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de Provas";

        public override string TooltipInserir { get { return "Inserir uma nova prova"; } }

        public override string TooltipEditar { get { return "Editar uma prova existente"; } }

        public override string TooltipExcluir { get { return "Excluir uma prova existente"; } }

        public override string TooltipFiltrar { get { return "Filtrar Provas por Status"; } }

        public override string TooltipAdicionarItens => "Adicionar itens para uma prova";

        public override string TooltipAtualizarItens => "Atualizar itens da prova";

        public override bool AdicionarItensHabilitado => false;

        public override bool AtualizarItensHabilitado => false;

        public override bool FiltrarHabilitado => false;
    }
}
