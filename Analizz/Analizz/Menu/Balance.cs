using Analizz.Option;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Analizz.Menu
{
    internal class Balance : TransactionBills
    {


        public static decimal showCurrentBalance(decimal DefaultValue = 0)
        {
            var currentValue = User.option.Balance;
            foreach (var item in income)
            {
                currentValue += item.Amount;
            }
            foreach (var item in expenses)
            {
                currentValue -= item.Amount;
            }


            return currentValue == 0 ? DefaultValue : currentValue;

        }


    }
}
