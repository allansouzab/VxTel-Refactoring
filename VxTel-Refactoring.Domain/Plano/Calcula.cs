using System;
using System.Collections.Generic;
using System.Text;

namespace VxTel_Refactoring.Domain.Plano
{
    public class Calcula : ICalcula
    {
        public double DefineTaxa(int origem, int destino)
        {
            if (origem == 11 && destino == 16)
            { return 1.90; }
            else if (origem == 16 && destino == 11)
            { return 2.90; }
            else if (origem == 11 && destino == 17)
            { return 1.70; }
            else if (origem == 17 && destino == 11)
            { return 2.70; }
            else if (origem == 11 && destino == 18)
            { return 0.90; }
            else if (origem == 18 && destino == 11)
            { return 1.90; }

            return 0;
        }

        public double ValorComPlano(int origem, int destino, int tempo, int plano)
        {
            double taxa = DefineTaxa(origem, destino);
            int tempoExcedente = tempo - plano < 0 ? 0 : tempo - plano;
            return (((10.0 / 100.0) * taxa) + taxa) * tempoExcedente;
        }

        public double ValorSemPlano(int origem, int destino, int tempo)
        {
            double taxa = DefineTaxa(origem, destino);
            return taxa * tempo;
        }
    }
}
