using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Code_First_01.Models.Entities
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string PublisherCity { get; set; }
        public string PublisherMail { get; set; }
        public bool IsDeleted { get; set; }
        public List<Book> Books { get; set; }
    }
}