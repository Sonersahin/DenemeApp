using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeApp.Web.Models
{
    public class Student
    {
        [Required(ErrorMessage ="İsminizi Girininiz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Girininiz.")]
        [EmailAddress(ErrorMessage ="Lütfen Mail adresinizi düzgün bir biçimde giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon Girininiz.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Kursa Ktılıp Katılmayacağınızı Bilmemiz gerekikor.")]
        public bool? WillAttend { get; set; }

    }
}
