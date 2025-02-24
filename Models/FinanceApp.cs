using System;
using System.ComponentModel.DataAnnotations;

namespace Expance.Models
{
    public class FinanceApp
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "Amount is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0.")]
        public double Amount { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; } = null!;

        [Required(ErrorMessage = "Date is required.")]
        public DateTime Date { get; set; }

        // Constructor to set default date
        public FinanceApp()
        {
            Date = DateTime.Now;
        }
    }
}
