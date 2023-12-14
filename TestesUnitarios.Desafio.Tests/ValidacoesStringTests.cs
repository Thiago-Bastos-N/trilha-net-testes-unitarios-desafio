using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void RetornarQuantidadeCaracteres()
    {
        var texto = "Matrix";
        var resultadoEsperado = 6;

        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void ContemCaractere()
    {
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        Assert.True(resultado);
    }


    [Fact]
    public void TextoTerminaCom()
    {
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        Assert.True(resultado);
    }
}
