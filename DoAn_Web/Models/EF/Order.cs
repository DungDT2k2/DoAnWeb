using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoAn_Web.Models.EF
{
    [Table("tb_Order")]
    public class Order : CommontAbstract
    {
        public Order()
        {
            this.orderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required(ErrorMessage ="Tên khách hàng không được để trống")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "SDT khách hàng không được để trống")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Địa chỉ khách hàng không được để trống")]
        public string Address { get; set; }
        public string Email { get; set; }

        public decimal TotalAmount { get; set; }

        public int Quantity { get; set; }
        public int TypePayment { get; set; }

        public ICollection<OrderDetail> orderDetails { get; set; }
    }
}