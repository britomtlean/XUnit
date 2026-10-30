using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTeste
{
    public class ValidarStringTeste
    {
        private ValidarString _test;

        public ValidarStringTeste()
        {
            this._test = new ValidarString();
        }

        [Fact]
        public void ReturnLength()
        {
            //Arrange
            string text = "OLA";

            //Act
            int resultado = _test.ReturnLength(text);

            //Assert
            Assert.Equal(3, resultado);
        }
    }
}
