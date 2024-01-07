using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public String Title { get; set; }

        public String Description { get; set; }
        [Required]
        public String ISBN { get; set; }

        [Required]
        public String Author { get; set; }

        [Required]
        [Range(0, 1000)]
        [Display(Name ="List Price")]
        public double ListPrice { get; set; }

        [Required]
        [Range(0, 1000)]
        [Display(Name = "Price for 1-50")]
        public double Price { get; set; }

        [Required]
        [Range(0, 1000)]
        [Display(Name = "Price for 50+")]
        public double Price50 { get; set; }

        [Required]
        [Range(0, 1000)]
        [Display(Name = "Price for 100+")]
        public double Price100{ get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]

        [ValidateNever]
        public Category Category { get; set; }
        [ValidateNever]
        public String ImageURL { get; set; }
    }
}
