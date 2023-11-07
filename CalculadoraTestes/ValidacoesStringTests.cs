using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {   
            //Arrange
            string texto = "Olá";

            //Act
            int resultado = _validacoes.ContarCaracteres(texto);

            //Assert
            Assert.Equal(3, resultado);
        }

        [Fact]
        public void DeveContar8CaracteresEmAndressaERetornar8()
        {   
            //Arrange
            string texto = "Andressa";

            //Act
            int resultado = _validacoes.ContarCaracteres(texto);

            //Assert
            Assert.Equal(8, resultado);
        }
    }
}