using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace InStock.Helpers
{
    public class QueryObject
    {
        public string? Symbol {get; set;} = null;
        public string? CompanyName {get; set;} = null;
        public string? SortBy {get; set;} = null;
        public bool IsDecsending {get; set;} = false;

        public int PageNumber {get; set;} = 1;
        public int PageSize {get; set;} = 12;
    }
}