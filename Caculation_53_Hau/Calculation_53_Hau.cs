using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculation_53_Hau
{
    public class Calculation_53_Hau
    {
        private int a_53_Hau, b_53_Hau;
        public Calculation_53_Hau(int a_53_Hau, int b_53_Hau)
        {
            this.a_53_Hau = a_53_Hau;
            this.b_53_Hau = b_53_Hau;
        }
        public int Execute_53_Hau(string CalSymbol_53_Hau)
        {
            int result_53_Hau = 0;
            switch (CalSymbol_53_Hau)
            {
                case "+":
                    result_53_Hau = this.a_53_Hau + this.b_53_Hau;
                    break;
                case "-":
                    result_53_Hau = this.a_53_Hau - this.b_53_Hau;
                    break;
                case "*":
                    result_53_Hau = this.a_53_Hau * this.b_53_Hau;
                    break;
                case "/":
                    result_53_Hau = this.a_53_Hau / this.b_53_Hau;
                    break;
            }
            return result_53_Hau;
        }
    }
}
