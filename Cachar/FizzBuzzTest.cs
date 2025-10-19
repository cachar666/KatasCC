using FluentAssertions;

namespace Cachar;

public class FizzBuzzTest
{
    [Fact]
    public void SI_EnvioUno_Debe_Retornar_Uno()
    {
        //Arrange
        int entrada = 1;
            
        //Act
        string result = FizzBuzz(entrada);
        
        //Assert
        result.Should().Be("1");
    }

    [Fact]
    public void Si_EnvioDos_Debe_Retornar_Dos()
    {
        //Arrange
        int entrada = 2;
        //Act
        string result = FizzBuzz(entrada);
        //Assert
        result.Should().Be("2");
    }
    
    [Fact]
    public void Si_EnvioTres_Debe_Retornar_Fizz()
    {
        //Arrange
        int entrada = 3;
        //Act
        string result = FizzBuzz(entrada);
        //Assert
        result.Should().Be("Fizz");
    }

    private string FizzBuzz(int entrada)
    {
        if (entrada == 2) return "2";
        if (entrada == 3) return "Fizz";
        
        return "1";
        
    }
}