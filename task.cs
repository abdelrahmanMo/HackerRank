using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            int count = 0;
            List<int> boys = new List<int>();
            List<int> girls = new List<int>();

             n = Convert.ToInt32(Console.ReadLine());
            var stringArrayBoys = Console.ReadLine().Split(' ');
           
            for (var i = 0; i < n; i++)
            {
                boys.Add(Convert.ToInt32(stringArrayBoys[i])); // line 17
            }

            m = Convert.ToInt32(Console.ReadLine());
            var stringArrayGirls = Console.ReadLine().Split(' ');
            for (var i = 0; i < m; i++)
            {
                girls.Add(Convert.ToInt32(stringArrayGirls[i])); // line 17
            }
            girls.Sort();
            boys.Sort();
            int x = 0;
            int y = 0;
            while(x <n && y<m)
            {
              
                    if (boys[x] - 1 > girls[y])
                    {
                        y++;
                    }
                    else if (boys[x] < girls[y] - 1)
                    {
                        x++;
                    }
                    else
                    {
                        count++;
                        y++;
                        x++;
                    }
                
            }

            Console.WriteLine(count);



        }
   
    }
}
