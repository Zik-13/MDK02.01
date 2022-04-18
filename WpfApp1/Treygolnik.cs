using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Treygolnik
    {
        public string Info(int num1, int num2, int num3)
        {
            if ((num1 <= 0 || num2 <= 0 || num3 <= 0) || (num1 + num2 < num3 || num1 + num3 < num2 || num2 + num3 < num1) || (num1 != 0 && num2 != 0 && num3 != 0))
            {
                return "ERROR";
            }
            else
            {
                if ((num1 == num2 && num1 == num3 && num2 == num3)) 
                {
                    return "Равносторонний";
                }
                else if (num1 == num2 || num1 == num3 || num2 == num3)
                {
                    return "Равнобедренный";
                }
                else
                {
                    return "Разносторнний";
                }
            }
        }
    }
}
