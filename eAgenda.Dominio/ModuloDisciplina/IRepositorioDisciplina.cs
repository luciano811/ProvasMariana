using eAgenda.Dominio.Compartilhado;
using System;
using System.Collections.Generic;

namespace eAgenda.Dominio.ModuloDisciplina
{
    public interface IRepositorioDisciplina : IRepositorio<Disciplina>
    {
        List<Disciplina> SelecionarDisciplinasFuturos(DateTime dataInicial, DateTime dataFinal);

        List<Disciplina> SelecionarDisciplinasPassados(DateTime hoje);
    }
}
