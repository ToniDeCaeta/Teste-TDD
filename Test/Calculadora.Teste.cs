using New.Talents;
using Xunit;

namespace Testes.Integracao;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadofinal = calc.Soma(num1, num2);

        Assert.Equal(resultado, resultadofinal);
        
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadofinal = calc.Multiplicar(num1, num2);

        Assert.Equal(resultado, resultadofinal);
        
    }

     [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 5, 1)]
    public void TesteDividir(int num1, int num2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadofinal = calc.Dividir(num1, num2);

        Assert.Equal(resultado, resultadofinal);
        
    }

     [Theory]
    [InlineData(6, 2, 4)]
    [InlineData(5, 5, 0)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadofinal = calc.Subtrair(num1, num2);

        Assert.Equal(resultado, resultadofinal);
        
    }

    [Fact]
    public void TestarDivisaoPorZero ()
    {
        Calculadora calc = new Calculadora();
        Assert.Throws<DivideByZeroException>(()=> calc.Dividir(3,0));  
    } // trata a execeção ao dividir por zero

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = new Calculadora();

        Assert.NotEmpty(calc.historico());
    }
}