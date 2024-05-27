using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Article:BaseEntity
    {
        public string Title { get; set; }
        public DateTime DateCreate { get; set; } 
        public DateTime? DateUpdate { get; set; }
        public string Text { get; set; }
        public int CountView { get; set; }
        public int CountLike { get; set; }
        public Author Author { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
