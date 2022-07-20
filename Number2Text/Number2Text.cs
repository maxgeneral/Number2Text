using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2Text
{
    public class Number2Text
    {
        public string Corvert(int value)
        {

            char[] numstr = value.ToString().ToCharArray();
            /*int[] ints = new int[numstr.Length];
            for(int i=0;i<numstr.Length;i++)
                ints[i] = Convert.ToInt32(numstr[i]);*/

            string result = "";
            if(value >= 0 && value <= 9 )
            {
                return Convert1(numstr[0]);
            }
            if (value <= 19 && value >= 10)
            {
                if (value == 10) return "десять";
                if (value == 11) return "одиннадцать";
                if (value == 12) return "двенадцать";
                if (value == 13) return "тринадцать";
                if (value == 14) return "четырнадцать";
                if (value == 15) return "пятнадцать";
                if (value == 16) return "шестнадцать";
                if (value == 17) return "семнадцать";
                if (value == 18) return "восемнадцать";
                if (value == 19) return "девятнадцать";
            }
            
            if (value == 100)
            {
                return "сто";
            }
            if (value == 1000)
            {
                return "тысяча";
            }
            if (value <= 89 && value >= 20)
            {
                // 21 => "два"+"дцать" + "один"
                if (value >= 20 && value <= 39)
                {
                    if (value == 20) return "двадцать";
                    if(value == 30) return "тридцать";
                    return Convert1(numstr[1]) + "дцать " + Convert1(numstr[0]);
                }
                // 41 => "сорок" + "один"
                if (value >= 40 && value <= 49)
                {
                    if (value == 40) return "сорок";
                    return "сорок " + Convert1(numstr[0]);
                }
                // 51 => "пять"+"десят" + "один"
                if (value >= 50 && value <= 89)
                {
                    if (value%10 == 0) return Convert1(numstr[1]) + "десят";
                    return Convert1(numstr[1]) + "десят " + Convert1(numstr[0]);
                }
            }
            if (value <= 99 && value >= 90)
            {
                if (value % 10 == 0) return "девяносто";
                return "девяносто" + Convert1(numstr[0]);
            }

            return "";
        }


        public string Convert1(char c)
        {
            string result = "";
                switch (c)
                {
                    case '0': result += "ноль"; break;
                    case '1': result += "один"; break;
                    case '2': result += "два"; break;
                    case '3': result += "три"; break;
                    case '4': result += "четыре"; break;
                    case '5': result += "пять"; break;
                    case '6': result += "шесть"; break;
                    case '7': result += "семь"; break;
                    case '8': result += "восемь"; break;
                    case '9': result += "девять"; break;
                }
            return result;
        }

    }
}
