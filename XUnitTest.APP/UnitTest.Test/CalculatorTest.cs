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
    }
}