using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workkshop6_2
{
    public class Investments2 :IInvestment
    {
        protected Antique a;
        protected Gold g;
        protected Coin c;
        protected double cost;
        protected double etValue;
        protected double profit;
        protected DateTime date;

        //property
        public double Cost
        {
            get { return cost; }
        }

        public double EtValue
        {
            get { return etValue; }
        }

        public DateTime Date
        {
            get { return date; }
        }

        public double Profit
        { get { return profit; } }

        //Consturctor
        public Investments2(double cost, double etValue, DateTime date)
        {
            this.cost = cost;
            this.etValue = etValue;
            this.date = date;
            profit = cost - etValue;
        }

        public Investments2() : this(0,0,new DateTime(1900,0,0))
        { }

    }
}
