using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlbumsLibrary.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [DataType(DataType.Date)]
        public DateTime Released { get; set; } 
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}