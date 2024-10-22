using TDD_DIO;
using Xunit;

namespace TDD_DIO.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.Somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

     [Theory]
    [InlineData (2, 1, 1)]
    [InlineData (5, 5, 0)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.Subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

     [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.Multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

     [Theory]
    [InlineData (10, 2, 5)]
    [InlineData (22, 1, 22)]
    public void TestDividir(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.Dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDividisaoPorZero()
    {
        Calculadora calc = new Calculadora();

        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3, 0));
    }


    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = new Calculadora();

        calc.Somar(1, 2);
        calc.Subtrair(5, 2);
        calc.Multiplicar(2, 9);
        calc.Dividir(100, 5);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}