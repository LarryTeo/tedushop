﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string URL { set; get; }
        public int? DisplayOrder { set; get; }

        [Required]
        public int GroupId { set; get; }
        // bắt đầu tạo thuộc tính cho khóa ngoại
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }
        public string Target { set; get; }
        [Required]
        public bool Status { set; get; }

    }
}
