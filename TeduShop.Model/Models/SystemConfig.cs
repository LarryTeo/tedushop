using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        public int ID { set; get; }
        public string Code { set; get; }
        public string ValueString { set; get; }
        public int ValueInt { set; get; }
    }
}
