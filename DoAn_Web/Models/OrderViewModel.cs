using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAn_Web.Models
{
    public class OrderViewModel
    {
        [Required(ErrorMessage = "Tên khách hàng không được để trống")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "SDT khách hàng không được để trống")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Địa chỉ khách hàng không được để trống")]
        public string Address { get; set; }
        public string Email { get; set; }
        public int TypePayment { get; set; }
    }
}