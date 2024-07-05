using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InStock.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot be over 10 characters")]
        public string Symbol {get; set;} = string.Empty;
        
        public  string CompanyName {get; set;} = string.Empty;
        [Required]
        [Range(1,100000000)]
        public decimal Purchase {get; set;}
        [Required]
        [Range(0.001,100)]
        public decimal LastDiv {get; set;}
        public string Industry {get; set;} = string.Empty;
        public long MarketCap {get; set;}
    }
}