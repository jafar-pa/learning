using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> = new Dictionary<string, int>();
            //1. reverse  sentence  // hey you Bub = Bub! you, Hey
            Reverse("Hello Jafar Hru?");

            var s = MonoalphabeticEncryption("the", 5);
            var ss = ToLong("three");
            Sample sample = new Sample();
            sample.Print();
           

            ISample sample1 = new Sample();
            sample1.Print();

        }

        private static void Reverse(string v)
        {
            string[] a = v.Split(' ');
            string ss = string.Empty;
            Array.Reverse(a);
            Console.WriteLine("Reverse String is:");
            for (int i = 0; i <= a.Length - 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                ss = a[i] + "" + ' ';
            }
        }
    

        private static Dictionary<string, long> numberTable =
    new Dictionary<string, long>
        {{"zero",0},{"one",1},{"two",2},{"three",3},{"four",4},
        {"five",5},{"six",6},{"seven",7},{"eight",8},{"nine",9},
        {"ten",10},{"eleven",11},{"twelve",12},{"thirteen",13},
        {"fourteen",14},{"fifteen",15},{"sixteen",16},
        {"seventeen",17},{"eighteen",18},{"nineteen",19},{"twenty",20},
        {"thirty",30},{"forty",40},{"fifty",50},{"sixty",60},
        {"seventy",70},{"eighty",80},{"ninety",90},{"hundred",100},
        {"thousand",1000},{"million",1000000},{"billion",1000000000},
        {"trillion",1000000000000},{"quadrillion",1000000000000000},
        {"quintillion",1000000000000000000}};
        public static long ToLong(string numberString)
        {
            var numbers = Regex.Matches(numberString, @"\w+").Cast<Match>()
                 .Select(m => m.Value.ToLowerInvariant())
                 .Where(v => numberTable.ContainsKey(v))
                 .Select(v => numberTable[v]);
            long acc = 0, total = 0L;
            foreach (var n in numbers)
            {
                if (n >= 1000)
                {
                    total += (acc * n);
                    acc = 0;
                }
                else if (n >= 100)
                {
                    acc *= n;
                }
                else acc += n;
            }
            return (total + acc) * (numberString.StartsWith("minus",
                  StringComparison.InvariantCultureIgnoreCase) ? -1 : 1);
        }
        private static string MonoalphabeticEncryption(string sPlainText, int key)
        {
            sPlainText = sPlainText.ToUpper();
            string[] cipherTextChars = new string[sPlainText.Length];
            var alphabet = Enumerable.Range('A', 26).Select(x => (char)x).ToList();

            for (int i = 0; i < sPlainText.Length; i++)
            {  
                    char value = sPlainText[i];
                    int index = alphabet.FindIndex(a => a.Equals(value));
                    cipherTextChars[i] = alphabet[index + key].ToString();
            }

            return string.Join("",cipherTextChars).ToString();

        }
    }
    interface ISample
    {
        void Print(string a = "Jafar");
    }
    class Sample : ISample
    {
        public void Print(string a = "Sample")
        {
            Console.WriteLine(a);//throw new NotImplementedException();
        }
    }


}
