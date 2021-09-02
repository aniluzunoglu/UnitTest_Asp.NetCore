using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.APP;
using Xunit;

namespace UnitTest.Test {
    public class CalculatorTest {

        [Fact]
        public void SumTest() {
            //Arrange

            //değişkenleri initialize ettiğimiz yer. İlk değer vereceğim veya nesne örneği oluşturacağım yer

            int a = 5;
            int b = 20;
            var calculator = new Calculator();
            //Act

            //initialize ettiğimiz classlara parametreler verip test edeceğimiz methodları çalıştırdığımız yer.

            var total = calculator.sum(a, b);

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

            List<string> test;
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
    }
}