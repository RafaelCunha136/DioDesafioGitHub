using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class CalculadoraBasicaTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 10;
            var calculadora = new CalculadoraBasica();

            var result = calculadora.Soma(a, b);

            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 0;
            var calculadora = new CalculadoraBasica();

            var result = calculadora.Subtracao(a, b);

            Assert.AreEqual(esperado, result);
            
        }

        [TestMethod()]
        public void MultiplicacaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 25;
            var calculadora = new CalculadoraBasica();

            var result = calculadora.Multiplicacao(a, b);

            Assert.AreEqual(esperado, result);
            
        }

        [TestMethod()]
        public void DivisaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 1;
            var calculadora = new CalculadoraBasica();

            var result = calculadora.Divisao(a, b);

            Assert.AreEqual(esperado, result);
            
        }
    }
}