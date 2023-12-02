using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Analizz.Menu;
using Analizz.Option;
using Analizz.FinancialAnalysis;

namespace Analizz.Option
{
    internal class TransactionOption
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
