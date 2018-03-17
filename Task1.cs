using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
  public  class Task1
    {
        //Введення натурального числа з консолі
        public static uint ParseNaturalFromString(string text)
        {
            
            uint number;
            if (uint.TryParse(text, out number) == true)
            {
                return number;
            }
            else
            {
                throw new ArgumentOutOfRangeException("natural number",text,"You entered wrong number");
            }
        }
        //За заданим натуральним числом n 
        //Перевірити чи дійсно всі його цифри є різні
        static public bool AreDigitsDifferent(uint number)
        {
            if (number < 10)
            {
                return true;
            }
            uint[] digits = new uint[10];
            uint temp = number;
            uint digit;
            while (temp > 0)
            {
                digit = temp % 10;
                if (digits[digit] != 0)
                {
                    return false;
                }
                else
                {
                    digits[digit] = 1;
                }
                temp = temp / 10;
            }
            return true;
        }
    }
}
