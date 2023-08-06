using NCalc;

namespace DotNetExpressionEvaluator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var expr = new Expression("1.5 + 2");
            //Func<double> f = expr.ToLambda<double>();
            //Console.WriteLine(f());



            var expr = new Expression("key1 * 1.0 / key2");
            expr.Parameters = new Dictionary<string, object>
            {
                { "key1", 1},
                { "key2", 2},
            };
            Func<double> f = expr.ToLambda<double>();

            Console.WriteLine(f());

            Console.ReadKey();
        }
    }
}