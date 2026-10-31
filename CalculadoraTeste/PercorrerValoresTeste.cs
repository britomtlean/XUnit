using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraTeste
{
    public class PercorrerValoresTeste
    {

        //EXECUTA UM LAÇO DE REPETIÇÃO CORRESPONDENTE A CADA VALOR CONTIDO DO ATRIBUTO [InlineData()]

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void Percorrer(int numero)
        {
            //VERIFICAÇÃO AQUI
        }



    }
}
