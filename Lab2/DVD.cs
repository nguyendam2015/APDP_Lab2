using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class DVD : LibraryItem
    {
        public int Runtime { get; set; } // Runtime in minutes
        public DVD(string title, string author, DateTime publicationDate, int runtime)
            : base(title, author, publicationDate)
        {
            Runtime = runtime;
            
        }

        public override void CheckOut()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"You have checked out '{Title}'.");
            }
            else
            {
                Console.WriteLine($"Sorry, '{Title}' is currently unavailable.");
            }
        }
        public override void ReturnItem()
        {
            if (!Available)
            {
                Available = true;
                Console.WriteLine($"You have returned '{Title}'.");
            }
            else
            {
                Console.WriteLine($"'{Title}' was not checked out.");
            }
        }
    }

}
