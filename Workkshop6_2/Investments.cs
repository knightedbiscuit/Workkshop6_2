using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workkshop6_2
{
    class Investments
    {
        static void Main(string[] args)
        {
            List < IInvestment > list = new List<IInvestment>();
            list.Add(new Antique(12000,9000,new DateTime(2016,12,1)));
            list.Add(new Gold(150000, 100000, new DateTime(2017, 1, 2)));
            list.Add(new Coin(3000, 2000, new DateTime(2016, 6, 6)));

            double totalvalue=0, totalprofit=0;
            foreach (IInvestment i in list)
            {
                totalvalue += i.EtValue;
                totalprofit += i.Profit;
            }
            Console.WriteLine("The total value is ${0}.\nThe total profit is ${1}.", totalvalue, totalprofit);

            foreach (IInvestment i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
