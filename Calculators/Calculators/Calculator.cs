using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Text.RegularExpressions;


namespace Calculators
{
    public class Calculator
    {
        public string str;
        public int AddTwoNumbers(string str)
        {
            string[] sever = str.Split(',');
            int res = 0;
            if (sever.Count() != 2) throw new ArgumentException("Строка не соответствует требованиям,введено не 2 числа");
            foreach (String s in sever)
            {
                int number;
                if (int.TryParse(s, out number))
                    res += number;
                else
                    throw new ArgumentException("Строка не соответствует требованиям,введены посторонние символы");
            }
            return res;
        }
        public int AddAnyNumbers(string str)
        {
            string[] sever = str.Split(',');
            int res = 0;
            foreach (String s in sever)
            {
                int number;
                if (int.TryParse(s, out number))
                    res += number;
                else
                    throw new ArgumentException("Строка не соответствует требованиям,введены посторонние символы");
            }
            return res;
        }
        public int AddAnyDivide(string str)
        {
            string pattern = @"[ ,.<>?/'!@#№$:;%^&*=\|/{}()]";
            string[] sever = Regex.Split(str, pattern);
            int res = 0;
            foreach (String s in sever)
            {
                int number;
                if (int.TryParse(s, out number))
                    res += number;
                else
                    throw new ArgumentException("Строка не соответствует требованиям,введены посторонние символы");
            }
            return res;
        }
        public int AddNotNegativeNumbers(string str)
        {
            string pattern = @"[ ,.<>?/'!@#№$:;%^&*=\|/{}()]";
            string[] sever = Regex.Split(str, pattern);
            int res = 0;
            foreach (String s in sever)
            {
                int number;
                if (int.TryParse(s, out number) && number > 0)
                    res += number;
                else
                    throw new ArgumentException("Строка не соответствует требованиям,введены посторонние символы или отрицательное число");
            }
            return res;
        }
        public int AddAnyLongDivide(string str)
        {
            string pattern = @"[ ,.<>?/'!@#№$:;%^&*=\|/{}()]+";
            string[] sever = Regex.Split(str, pattern);
            int res = 0;
            foreach (String s in sever)
            {
                int number;
                if (int.TryParse(s, out number) && number >= 0)
                    res += number;
                else
                    throw new ArgumentException("Строка не соответствует требованиям,введены посторонние символы или отрицательное число");
            }
            return res;
        }

    }
}
