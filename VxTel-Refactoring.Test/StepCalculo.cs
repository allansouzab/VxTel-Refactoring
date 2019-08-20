using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using VxTel_Refactoring.Domain;

namespace VxTel_Refactoring.Test
{
    [Binding]
    public sealed class StepCalculo
    {
        private Calcula calcula;
        private int origem;
        private int destino;
        private int tempo;
        private double valorSemPlano;
        private double valorComPlano;

        [Given(@"que estou consumindo o método ValorComPlano")]
        public void DadoQueEstouConsumindoOMetodoValorComPlano()
        {
            calcula = new Calcula();
        }

        [Given(@"preencho o campo '(.*)' com o valor (.*), o campo '(.*)' com o valor (.*) e o campo '(.*)' com valor (.*)")]
        public void DadoPreenchoOCampoComOValorOCampoComOValorEOCampoComValor(string origem0, int p1, string destino2, int p3, string tempo4, int p5)
        {
            origem = p1;
            destino = p3;
            tempo = p5;
        }

        [When(@"executo a aplicação")]
        public void QuandoExecutoAAplicacao()
        {
            valorSemPlano = (Double)calcula.ValorSemPlano(origem, destino, tempo);
            valorComPlano = (Double)calcula.ValorComPlano(origem, destino, tempo, 2);
        }

        [Then(@"vejo '(.*)'")]
        public void EntaoVejo(int p0)
        {
            Assert.AreEqual(p0, valorSemPlano);
        }
    }
}
