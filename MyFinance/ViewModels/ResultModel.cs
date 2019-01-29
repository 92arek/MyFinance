using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFinance.ViewModels
{
    public class ResultModel
    {
        public int ResultOfCalculation { get; set; }

        public string CalculationType { get; set; } = string.Empty;
    }
}