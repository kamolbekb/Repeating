using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1, maxCounter = 1, prevNum = 0;
            int finderN = 0;
            Console.WriteLine("Raqamlardan iborat matn kiriting, dastur consoledan (0)-raqami kirib kelguncha davom etadi, 0 raqami kiritilgandan song ekranga eng kop qaytalangan sonni va uni necha marta qaytarilganini chiqarib  beradi. ");
            Console.Write("Ihtiyoriy raqamlar to`plamini kiriting: ");
            string str = Console.ReadLine();
            string result = "";
            bool shart = str.Contains('0');
            while (!shart)
            {
                Console.Write("Ihtiyoriy raqamlar to`plamini kiriting:: ");
                result += str;
                str = Console.ReadLine();
                shart = str.Contains('0');
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0')
                {
                    break;
                }
                result += str[i].ToString();
            }
            string res2 = "";
            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsDigit(result[i]))
                    res2 += result[i].ToString();
            }

            for (int i = 0; i < res2.Length - 1; i++)
            {
                if (res2[i + 1] == res2[i])
                {
                    counter++;
                }
                else if (prevNum == 0)
                {
                    prevNum = res2[i + 1] - '0';
                }
                else
                {
                    if (maxCounter <= counter)
                    {
                        maxCounter = counter;
                        finderN = prevNum;
                    }
                    prevNum = res2[i + 1] - '0';
                    counter = 1;
                }
            }
            Console.WriteLine($" {finderN} soni {maxCounter} marta qaytarildi");

        }
    }
}