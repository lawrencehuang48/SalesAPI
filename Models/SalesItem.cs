using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesAPI.Models
{
    public class SalesItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Tags { get; set; }
        public string PublishDate { get; set; }
        public int UpvoteCount { get; set; }
        public string Links { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
    }
}
