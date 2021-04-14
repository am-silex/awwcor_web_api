using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace awwcor_web_api.Models
{
    public class AdDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MainPhotoLink { get; set; }
        public float Price { get; set; }
    }
    public class AdFullDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MainPhotoLink { get; set; }
        public float Price { get; set; }
        public string[] PhotoLinks { get; set; }
    }
}
