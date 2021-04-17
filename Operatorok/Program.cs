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
        const string FILE_PATH = "src\\kifejezesek.txt";
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
            var existsWhereBothDividableByTen = arithmeticExpressions
                .Select(x => x)
                .Where(x => (x.FirstOperand % 10 == 0) && (x.SecondOperand % 10 == 0))
                .Any();
            string existsWhereBothDividableByTenString = existsWhereBothDividableByTen ? "Van" : "Nincs";

            Console.WriteLine($"4. feladat: {existsWhereBothDividableByTenString} ilyen kifejezés!");
            #endregion

            #region 5. feladat

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
