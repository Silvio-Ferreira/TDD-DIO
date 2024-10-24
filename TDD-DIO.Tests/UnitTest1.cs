using TDD_DIO;
using Xunit;

namespace TDD_DIO.Tests;

public class UnitTest1
{
    public Calculadora construirClasse()
    {
        string data = "23/10/2024";
        Calculadora calc = new Calculadora("23/10/2024");

        return calc;
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.Somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

     [Theory]
    [InlineData (2, 1, 1)]
    [InlineData (5, 5, 0)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.Subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

     [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.Multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

     [Theory]
    [InlineData (10, 2, 5)]
    [InlineData (22, 1, 22)]
    public void TestDividir(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.Dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDividisaoPorZero()
    {
        Calculadora calc = construirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3, 0));
    }


    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = construirClasse();

        calc.Somar(1, 2);
        calc.Subtrair(5, 2);
        calc.Multiplicar(2, 9);
        calc.Dividir(100, 5);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}