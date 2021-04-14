using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace awwcor_web_api.Models
{
    public class Photo
    {
        public int Id { get; set; }   
        public string PhotoURL { get; set; }
        public Ad Ad { get; set; }
    }
}
