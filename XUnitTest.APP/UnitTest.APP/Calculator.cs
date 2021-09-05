using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.APP {
    public class Calculator {

        private ICalculatorService _calculatorService { get; set; }

        public Calculator(ICalculatorService calculatorService) {
            this._calculatorService = calculatorService;
        }

        public int Sum(int a, int b) {
            return _calculatorService.Add(a, b);
        }

        public int Multiplate(int a, int b) {
            return _calculatorService.Multiplate(a, b);
        }
    }
}
