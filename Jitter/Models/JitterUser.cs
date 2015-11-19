﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jitter.Models
{
    public class JitterUser
    {
        [Key] //Annotation. Must go above the property being annotated. Set Id as key in the table.
        public int JitterUserId { get; set; }

        [MaxLength(161)] 
        public string Description { get; set; }
        public string FirstName { get; set; }

        [Required] // The user must provide a Handle.
        [MaxLength(20)]
        [MinLength(3)]
        [RegularExpression(@"^[a-zA-Z\d]+[-_a-zA-Z]{0,2}[a-zA-Z/d]+")]
        public string Handle { get; set; }

        public string LastName { get; set; }
        public string Picture { get; set; }
    }
}