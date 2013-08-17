using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteCert.Models
{
    public class Document
    {
        public int DocumentID { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Title { get; set; }
        public DateTime? Published { get; set; }
        public string Author { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Keywords { get; set; }
    }
}