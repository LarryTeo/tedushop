using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Department { set; get; }
        public string Skype { set; get; }
        public string Emai { set; get; }
        public string Yahoo { set; get; }
        public string FaceBook { set; get; }
        public int Status { set; get; }

    }
}
