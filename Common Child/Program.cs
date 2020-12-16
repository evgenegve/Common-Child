using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Child
{
    class Program
    {
        static int CommonChild(string s1, string s2)
        {
            int n = s1.Length + 1;
            int m = s2.Length + 1;

            var tableA = new int[m, n];
            for (int i = 0; i < n; i++)
                tableA[0, i] = 0;
            
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                { 
                    if (s2[i - 1] == s1[j - 1])
                    {
                        tableA[i, j] = tableA[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        tableA[i, j] = Math.Max(tableA[i - 1, j], tableA[i, j -1]);
                    }
                }

            }

            return tableA[m-1,n-1];

        }

        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            Console.WriteLine(CommonChild(s1, s2));

        }
    }
}
