using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Type { set; get; }
    }
}
