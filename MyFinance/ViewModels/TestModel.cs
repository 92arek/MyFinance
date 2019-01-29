using System;
using System.ComponentModel.DataAnnotations;

namespace MyFinance.ViewModels
{
    public class TestModel
    {
        [Display(Name = "User name")]
        public string Name { get; set; }
        [Display(Name = "Last login date")]
        public DateTime NowDate { get; set; }

        [Required]
        [Display(Name = "First number")]
        public int? Xval { get; set; }
        
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        [Display(Name = "Second number")]
        public int? Yval { get; set; }
        
    }
}