﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Model
{
    public class Base
    {
        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
