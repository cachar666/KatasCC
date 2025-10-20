using FluentAssertions;
namespace Cachar;

public class StackTest
{
    
    private static object[] Pila = new object[1]; // Inicia con 1 slot
    
    // Prueba 1: Crear arreglo Pila con un slot
    [Fact]
    public void Si_HacePush_Debe_RetornarUnSlot()
    {
        // Arrange
        string entrada = "Push";
            
        // Act
        string result = Stack(entrada);
            
        // Assert
        result.Should().Be("1");
    }
    
    public String Stack(string entrada)
    {
        if (entrada == "Push")
        {
            Array.Resize(ref Pila, Pila.Length + 1);
        }
        
        return Pila.Length.ToString();
    }

}