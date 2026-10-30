using Calculadora.Services;

namespace CalculadoraTeste;

public class CalculadoraTeste
{

    private Calculadoraimp _calc;

    public CalculadoraTeste()
    {
        this._calc = new Calculadoraimp();
    }


    [Fact]
    public void DeveRetornar5com10ERetornar15()
    {
        //Arrange
        int n1 = 5;
        int n2 = 10;


        //Act
        int resultado = this._calc.Somar(n1,n2);


        //Assert
        Assert.Equal(15, resultado);
    }
}
