using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW11._2.Core.Entities
{
    public class Book
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Введіть назву книги")]
        [Display(Name = "Book Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введіть ISBN")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Введіть видавництво")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Введіть автора")]
        public string Author { get; set; }
    }
}
