using System;
using System.Collections.Generic;
using System.Text;

namespace VxTel_Refactoring.Domain.Plano
{
    public interface ICalcula
    {
        double ValorSemPlano(int origem, int destino, int tempo);
        double ValorComPlano(int origem, int destino, int tempo, int plano);
        double DefineTaxa(int origem, int destino);
    }
}
