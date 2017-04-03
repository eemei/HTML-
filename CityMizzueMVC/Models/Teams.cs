using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CityMizzueMVC.Models
{
    public class Teams
    {
        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Username")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("age")]
        public int Age { get; set; }
        //public string StudentName { get; set; }
        //public decimal StudentMobileNumber { get; set; }
        //public int Founded { get; set; }
        //public string FullName { get; set; }
    }


}