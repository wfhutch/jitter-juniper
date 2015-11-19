using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jitter.Models
{
    public class Jot
    {
        public object Author { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        [Key] // Sets Id as a key in the table.
        public int JotId { get; set; }
        public string Picture { get; set; }
    }
}