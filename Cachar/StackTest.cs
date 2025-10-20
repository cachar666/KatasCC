using FluentAssertions;
namespace Cachar;

public class StackTest
{
    
    private static object[] Pila = new object[1]; // Inicia con 1 slot
    
    // Prueba 1: Crear arreglo Pila con un slot
    [Fact]
    public void Si_HacePush_Debe_RetornarCantidadDeSlotEntreUno_y_Cinco()
    {
        // Arrange
        string entrada = "Push";
            
        // Act
        string result = Stack(entrada);
            
        // Assert
        result.Should().MatchRegex("^[1-5]$");
    }
    
    [Fact]
    public void Si_HacePop_Debe_RetornarCantidadDeSlotEntreUno_y_Cinco()
    {
        // Arrange
        string entrada = "Pop";
            
        // Act
        string result = Stack(entrada);
            
        // Assert
        result.Should().MatchRegex("^[1-5]$");
    }
    
    public String Stack(string entrada)
    {
        if (entrada == "Push")
        {
            // Expandir el arreglo agregando un slot
            Array.Resize(ref Pila, Pila.Length + 1);
        }

        if (entrada == "Pop")
        {
            // Reducir el arreglo quitando un slot
            Array.Resize(ref Pila, Pila.Length - 1);
        }

        return Pila.Length.ToString();
    }

}