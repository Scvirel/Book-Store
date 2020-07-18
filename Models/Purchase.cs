using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Purchase
    {
        // ID
        public int Id { get; set; }
        // Person NameSurname
        public string Person { get; set; }
        //Address
        public string Address { get; set; }
        // BookId
        public int BookId { get; set; }
        // Date
        public DateTime Date { get; set; }
    }
}