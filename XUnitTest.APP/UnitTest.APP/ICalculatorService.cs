using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.APP {
    public interface ICalculatorService {
        int Add(int a, int b);
        int Multiplate(int a, int b);
        decimal Divide(int a, int b);
    }
}
