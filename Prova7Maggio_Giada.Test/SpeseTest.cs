using Prova7Maggio_Giada.Factory.Entita;
using System;
using Xunit;

namespace Prova7Maggio_Giada.Test
{
    public class SpeseTest
    {
        [Fact]
        public void ScontoViaggioTest()
        {
            //ARRANGE
            Viaggio v = new Viaggio();
            //ACT
            decimal importo = 500;
            decimal rimborso = v.Sconto(importo);
            //ASSERT
            Assert.Equal(550, rimborso);
        }
    }
}
