using System.Runtime.CompilerServices;
using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes // arrenge monta o cenario - act é a ação - assert é a validação
{
    private CalculadoraImp _calc;
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //arrange
        int num1 = 5;
        int num2 = 10;

        //act
        int resultado = _calc.Somar(num1,num2);

        //assert
        Assert.Equal(15,resultado);
    }
}