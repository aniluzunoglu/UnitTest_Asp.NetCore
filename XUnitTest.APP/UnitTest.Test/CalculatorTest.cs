using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.APP;
using Xunit;

namespace UnitTest.Test {
    public class CalculatorTest {

        public Calculator calculator { get; set; }

        public CalculatorTest() {
            this.calculator = new Calculator();
        }

        [Fact]
        public void Sum_SimpleValues_ReturnTotalValue() {
            //Arrange

            //değişkenleri initialize ettiğimiz yer. İlk değer vereceğim veya nesne örneği oluşturacağım yer

            int a = 5;
            int b = 20;
            //Act

            //initialize ettiğimiz classlara parametreler verip test edeceğimiz methodları çalıştırdığımız yer.

            var total = calculator.Sum(a, b);

            //Assert 

            //doğrulama evresidir. Act evresinden çıkan sonuç beklediğim mi değil mi burada test edilir.

            Assert.Equal<int>(25, total);
        }

        [Fact] //method parametre almıyorsa fact attribute kullanılır.
        public void AssertExamples() {
            // Arrange
            List<string> names = new List<string>() { "Anıl", "Burak", "Mustafa" };
            string regex = "^dog";
            string val = null;

            // Act            

            // Assert

            Assert.Contains("Anıl", "Anıl Uzunoğlu");
            Assert.DoesNotContain("Anıl", "Uzunoğlu");
            Assert.Contains(names, x => x == "Anıl");

            Assert.True(5 > 2);
            Assert.False(2 > 5);
            Assert.True("".GetType() == typeof(string));
            Assert.False("".GetType() == typeof(int));

            Assert.Matches(regex, "dog ceki");
            Assert.DoesNotMatch(regex, "ceki dog ");

            Assert.StartsWith("One", "One Story");
            Assert.EndsWith("Story", "One Story");

            Assert.Empty(new List<string>());
            Assert.NotEmpty(names);

            Assert.InRange<int>(10, 2, 20);
            Assert.NotInRange<int>(27, 2, 20);

            Assert.Single(new List<string>() { "Anıl" });
            Assert.Single(new string[] { "Anıl" });
            Assert.Single<int>(new List<int>() { 6 });

            Assert.IsType<string>("Anıl");
            Assert.IsNotType<string>(6);

            Assert.IsAssignableFrom<IEnumerable<string>>(names);
            Assert.IsAssignableFrom<object>("Anıl");

            Assert.Null(val);
            Assert.NotNull(names);

            Assert.Equal<int>(2, 2);
            Assert.NotEqual<int>(2, 6);
        }

        [Theory]
        [InlineData(2, 5, 7)]
        [InlineData(10, 5, 15)]
        public void Sum_SimpleValues_ReturnTotalValue_2(int a, int b, int expectedTotal) {
            // Arrange            

            // Act
            var result = calculator.Sum(a, b);

            // Assert
            Assert.Equal(expectedTotal, result);
        }

        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(10, 5, 50)]
        public void Multiplate_SimpleValues_ReturnMultiplatedValue(int a, int b, int expectedMultiplication) {
            // Arrange

            // Act
            var result = calculator.Multiplate(a,b);

            // Assert

            Assert.Equal(expectedMultiplication, result);
        }

        [Theory]
        [InlineData(0, 5, 0)]
        [InlineData(10, 0, 0)]
        public void Multiplate_ZeroValues_ReturnZeroValue(int a, int b, int expectedMultiplication) {
            // Arrange

            // Act
            var result = calculator.Multiplate(a, b);

            // Assert

            Assert.Equal(expectedMultiplication, result);
        }
    }
}