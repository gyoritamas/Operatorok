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
        private static readonly string FILE_PATH = "src\\kifejezesek.txt";
        private static readonly string[] VALID_OPERATORS = { "+", "-", "*", "/", "div", "mod" };
        static List<ArithmeticExpression> arithmeticExpressions;
        static void Main(string[] args)
        {
            #region 1. feladat
            arithmeticExpressions = ReadSourceFile(FILE_PATH);
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
                .Where(x => VALID_OPERATORS.Contains(x.Operaator))
                .GroupBy(x => x.Operaator)
                .ToList();

            Console.WriteLine("5. feladat: Statisztika");
            foreach(string operaator in groupByOperaator.Select(x => x.Key))
            {
                var counter = arithmeticExpressions
                    .Select(y => y)
                    .Where(y => y.Operaator.Equals(operaator))
                    .Count();

                Console.WriteLine($"\t{operaator} -> {counter} db");
            }

            #endregion

            Console.ReadKey();

        }

        private static List<ArithmeticExpression> ReadSourceFile(string filePath)
        {
            List<ArithmeticExpression> result = new List<ArithmeticExpression>();

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] arithmethicExpressionString = line.Split(' ');

                Int32.TryParse(arithmethicExpressionString[0], out int firstOperand);
                string operaator = arithmethicExpressionString[1];
                Int32.TryParse(arithmethicExpressionString[0], out int secondOperand);

                result.Add(new ArithmeticExpression(firstOperand, operaator, secondOperand));

            }

            return result;
        }
    }
}
