using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = MinCoins(new int[] { 1, 5, 10 }, 25);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
       static int MinCoins(int[] coins, int value)
        {
            int[] tableOfValues = new int[value +1];

            tableOfValues[0] = 0;

            for (int i = 1; i <= value; i++)
                tableOfValues[i] = int.MaxValue;


            for (int i = 1; i <= value; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] <= i )
                    {
                        int sub_result = tableOfValues[i - coins[j]];
                        if (sub_result != int.MaxValue && sub_result +1 < tableOfValues[i])
                        {
                            tableOfValues[i] = sub_result + 1;
                        }
                    }
                }
            }
            return tableOfValues[value];
        }
    }
}



