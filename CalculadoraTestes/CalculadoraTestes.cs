using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact] //Fact significa que o método abaixo é um cenário de teste e deve ser validado de acordo.
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange - Serve para montar meu cenário. (ENTRADA DE DADOS)
        int num1 = 5;
        int num2 = 10;

        //Act - Chamar o método para executar
        int resultado = _calc.Somar(num1, num2);

        //Assert - Valida se tudo tem o resultado esperado.
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //Arrange - Serve para montar meu cenário. (ENTRADA DE DADOS)
        int num1 = 10;
        int num2 = 10;

        //Act - Chamar o método para executar
        int resultado = _calc.Somar(num1, num2);

        //Assert - Valida se tudo tem o resultado esperado.
        Assert.Equal(20, resultado);
    }
    
    [Fact]
    public void DeveVerificarSe4EhParERetornarTrue()
    {
        //Arrange
        int num = 4;

        //Act
        bool resultado = _calc.EhPar(num);

        //Assert
        Assert.True(resultado);
    }
}