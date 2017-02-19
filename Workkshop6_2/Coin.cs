﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workkshop6_2
{
    public class Coin : IInvestment
    {
        double cost, etValue, profit;
        DateTime date;

        //Constructor
        public Coin(double cost, double etValue, DateTime date)
        {
            this.cost = cost;
            this.etValue = etValue;
            this.date = date;
            profit = cost-etValue;
        }

        public Coin() :this(0,0,new DateTime(1900,0,0))
        { }

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
        {
            get { return profit; }
        }

        public override string ToString()
        {
            return (String.Format("Coin, Proft: {0}, Date:{1}", profit, date.ToString()));
        }

    }
}
