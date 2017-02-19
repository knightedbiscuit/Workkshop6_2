using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workkshop6_2
{
    public interface IInvestment
    {
        //Property
        double Cost
        {
            get;
        }

        double EtValue
        {
            get;
        }

        double Profit
        { get; }

        DateTime Date
        {
            get;
        }

        string ToString();

    }

}
