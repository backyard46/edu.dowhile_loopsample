using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoopSample2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int sum = 0;

            Console.WriteLine("マイナス値を入れるまで数字を足し算します。");

            do
            {
                sum += n;
                Console.Write("整数値を入力＞ ");
                n = int.Parse(Console.ReadLine());
            }
            while (n > 0);

            Console.WriteLine("合計値は{0}です。",sum);
            Console.ReadKey();
        }
    }
}
