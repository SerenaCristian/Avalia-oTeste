using AtividadesAvaliativaTestTechClass.Exercicios;
using System;
using Xunit;


namespace AtividadesAvaliativaTestTechClass.Tests
    {
        public class FatorialTests
        {
            [Fact]
            public void CalcularFatorial_DeveRetornar1_QuandoNumeroForZero()
            {
                // Arrange
                Fatorial fatorial = new Fatorial();
                double numero = 0;
                double resultadoEsperado = 1;

                // Act
                double resultado = fatorial.CalcularFatorial((int)numero);

                // Assert
                Assert.Equal(resultadoEsperado, resultado);
            }

            [Fact]
            public void CalcularFatorial_DeveRetornar120_QuandoNumeroForCinco()
            {
                // Arrange
                Fatorial fatorial = new Fatorial();
                int numero = 5;
                int resultadoEsperado = 120;

                // Act
                int resultado = (int)fatorial.CalcularFatorial(numero);

                // Assert
                Assert.Equal(resultadoEsperado, resultado);
            }



            [Fact]
        
        public void CalcularFatorial_DeveLancarExcecao_QuandoNumeroForNegativo()
        {
            // Arrange
            Fatorial fatorial = new Fatorial();
            int numero = -1;

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => fatorial.CalcularFatorial(numero));
            Assert.Equal("O número não pode ser negativo", ex.Message);
        }

    }
}



