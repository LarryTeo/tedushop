using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        public int ID { set; get; }
        public DateTime VististedDate { set; get; }
        public string IPAddress { set; get; }
    }
}
