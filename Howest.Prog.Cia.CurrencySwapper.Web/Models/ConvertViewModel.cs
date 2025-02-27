﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Howest.Prog.Cia.CurrencySwapper.Web.Models
{
    public class ConvertViewModel
    {
        public string SourceCurrency { get; set; }

        public string TargetCurrency { get; set; }

        public double Amount { get; set; }

        public double ConvertedAmount { get; set; }

        public bool ShowResult { get; set; }
    }
}
