using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesAPI.Models
{
    public class SalesImageItem
    {
        public string Title { get; set; }
        public string Tags { get; set; }
        public IFormFile Image { get; set; }
        public string Links { get; set; }
    }
}
