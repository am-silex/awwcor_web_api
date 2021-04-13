using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace awwcor_web_api.Models
{
    public class Ad
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        
        [ForeignKey(nameof(Photo))]
        public int MainPhotoID { get; set; }
        
        
    }
}
