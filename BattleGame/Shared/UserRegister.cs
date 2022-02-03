using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Shared
{
    public class UserRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [StringLength(16, ErrorMessage ="Your username is too long(16 characters max)!")]
        public string Username { get; set; }

        [StringLength(25, MinimumLength =6)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage ="Your Password do not match. Please try again!")]
        public string ConfirmPassword { get; set; }
        public int StartUnitId { get; set; } = 1;

        [Range(0, 1000, ErrorMessage ="You need to select No of Bananas(between 0 and 1000)!")]
        public int Bananas { get; set; } = 100;
        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        [Range(typeof(bool), "true", "true", ErrorMessage ="Only confirmed users can play")]
        public bool IsConfirmed { get; set; } = true;
    }
}
