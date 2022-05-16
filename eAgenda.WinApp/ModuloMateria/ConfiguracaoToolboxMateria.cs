using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloMateria
{
    public class ConfiguracaoToolboxMateria : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de Materias";

        public override string TooltipInserir => "Inserir uma nova Materia";

        public override string TooltipEditar => "Editar uma Materia existente";

        public override string TooltipExcluir => "Excluir uma Materia existente";
    }
}