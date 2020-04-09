using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Party_Invites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Proszę wprowadzić swoje imię i nazwisko.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podać swój adres e-mail.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podać swój numer telefonu.")]
        [Phone]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Proszę określić, czy weźmiesz udział w wydarzeniu.")]
        public bool? WillAttend { get; set; }
    }
}
