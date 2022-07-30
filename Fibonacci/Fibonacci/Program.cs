using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] fib = new int[20];
            //fib[0] = 1;
            //fib[1] = 1;

            //for (int i = 2; i < fib.Length; i++)
            //{
            //    fib[i] = fib[i - 1] + fib[i - 2];

            //}

            //int count = 2;
            //foreach (var item in fib)
            //{
            //    fib[count] = fib[count - 1] + fib[count - 2];
            //    var teste = Convert.ToInt32(fib[count].ToString());

            //    if (count < 19)
            //    {
            //        count++;
            //    }
            //}

            //foreach (var item in fib)
            //{

            //    Console.Write(", " + item);
            //}










            Console.WriteLine("A sequência de fibonacci é: ");

            //var valorUltimo = 0;
            //var valorSoma = 1;
            //var valorProx = 1;
            //int[] arrayLista;
            //var count = 0;

            var teste = fibonacci(20);
            //Console.WriteLine(teste);
            foreach (var item in teste)
            {
                Console.WriteLine(item);
            }

            //while (count < 20)
            //{
            //    //Console.WriteLine(arrayLista);




            //    //Console.WriteLine(valorSoma);
            //    ////soma os valores
            //    //valorSoma = valorProx + valorUltimo;

            //    ////passa o valor do Prox para o ultimo
            //    //valorUltimo = valorProx;
            //    ////passa o valor somado para o Prox
            //    //valorProx = valorSoma;
            //    count++;
            //}


            //Console.WriteLine("Hello World!");

        }


        public static int[] fibonacci(int limit)
        {
            int[] series = new int[20];
            //Array.Resize(ref series, limit);

            series[0] = 1;
            series[1] = 1;

            for (int i = 2; i < limit; i++)
                series[i] = series[i - 1] + series[i - 2];

            return series;
        }
    }
}
