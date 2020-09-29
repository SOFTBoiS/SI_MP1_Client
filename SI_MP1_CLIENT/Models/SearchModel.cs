using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ServiceReference1;

namespace SoftSearchImages.Models
{
    public class SearchModel
    {
        [Required]
        public string SearchValue { get; set; }
        
        [Required]
        public string Name { get; set; }

        public static string SavedName { get; set; }

        public static PictureDTO image { get; set; }
    }
}
