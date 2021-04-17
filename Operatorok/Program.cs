using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Operatorok
{
    class Program
    {
        private static readonly string FILE_IN = "kifejezesek.txt";
        private static readonly string FILE_OUT = "eredmenyek.txt";

        static List<ArithmeticExpression> arithmeticExpressions;
        static void Main(string[] args)
        {
            #region 1. feladat
            arithmeticExpressions = ReadFile(FILE_IN);
            #endregion

            #region 2. feladat
            var totalNumberOfExpressions = arithmeticExpressions.Count();

            Console.WriteLine($"2. feladat: Kifejezések száma: {totalNumberOfExpressions}");
            #endregion

            #region 3. feladat
            var numberOfExpressionsWithMod = arithmeticExpressions
                .Select(x => x)
                .Where(x => x.Operaator.Equals("mod"))
                .Count();

            Console.WriteLine($"3. feladat: Kifejezések maradékos osztással: {numberOfExpressionsWithMod}");
            #endregion

            #region 4. feladat
            var bothDividableByTenExists = arithmeticExpressions
                .Select(x => x)
                .Where(x => (x.FirstOperand % 10 == 0) && (x.SecondOperand % 10 == 0))
                .Any();
            string bothDividableByTenExistsString = bothDividableByTenExists ? "Van" : "Nincs";

            Console.WriteLine($"4. feladat: {bothDividableByTenExistsString} ilyen kifejezés!");
            #endregion

            #region 5. feladat
            var groupByOperaator = arithmeticExpressions
                .Select(x => x)
                .Where(x => x.OperaatorIsValid())
                .GroupBy(x => x.Operaator)
                .ToList();

            Console.WriteLine("5. feladat: Statisztika");
            foreach (string operaator in groupByOperaator.Select(x => x.Key))
            {
                var counter = arithmeticExpressions
                    .Select(y => y)
                    .Where(y => y.Operaator.Equals(operaator))
                    .Count();

                Console.WriteLine($"\t{operaator} -> {counter} db");
            }
            #endregion

            #region 7. feladat
            string userInput = "";
            while (true)
            {
                Console.Write("7. feladat: Kérek egy kifejezést (pl.: 1 + 1): ");
                userInput = Console.ReadLine();

                if (userInput.Equals("vége"))
                    break;

                if (ArithmeticExpression.StringToArithmeticExpression(userInput) == null)
                    break;

                string expressionResult = ArithmeticExpression.StringToArithmeticExpression(userInput).Result();

                Console.WriteLine($"\t{userInput} = {expressionResult}");
            }
            #endregion

            #region 8. feladat
            Console.WriteLine($"8. feladat: {FILE_OUT}");
            WriteFile(FILE_OUT);
            #endregion

            Console.ReadKey();
        }

        private static List<ArithmeticExpression> ReadFile(string filePath)
        {
            List<ArithmeticExpression> result = new List<ArithmeticExpression>();

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                result.Add(ArithmeticExpression.StringToArithmeticExpression(line));
            }

            return result;
        }

        private static void WriteFile(string fileName)
        {
            StringBuilder contents = new StringBuilder();
            arithmeticExpressions.ForEach(x => contents.Append(x.ToString()).Append("\n"));
            File.WriteAllText(fileName, contents.ToString());
        }
    }
}
