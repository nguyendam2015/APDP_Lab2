using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class LibraryItem
    {
        public string Title { get; set; }
        
        public string Author { get; set; }

        public DateTime PublicationDate { get; set; }   

        public Boolean Available { get; set; }  

        public abstract void CheckOut();

        public abstract void ReturnItem();

        public LibraryItem(string title, string author, DateTime publicationDate)
        {
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
            Available = true; // Items are available by default
        }
    }
}
