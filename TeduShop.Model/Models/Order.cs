using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string CustomerName { set; get; }
        [Required]
        public string CustomerAddress { set; get; }
        [Required]
        public string CustomerEmail { set; get; }
        public string CustomerMessage { set; get; }
        public string PaymentMethod { set; get; }
        public string PaymentStatus { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
       // public virtual IEnumerable<Product> Products { set; get; }

    }
}
