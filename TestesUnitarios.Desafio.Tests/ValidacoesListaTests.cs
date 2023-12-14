using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void RemoverNumerosNegativos()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void ListaContemDeterminadoNumero()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void MultiplicarNumerosLista()
    {
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };

        var resultado = _validacoes.MultiplicarElementosDaListaPor2(lista);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void RetornarMaiorNumeroLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultado = _validacoes.RetornarMaiorNumeroDaLista(lista);

        Assert.Equal(9, resultado);
    }

    [Fact]
    public void RetornarMenorNumeroLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        Assert.Equal(-8, resultado);
    }
}