using System.ComponentModel.DataAnnotations;

namespace Summernote.Models.Home
{
    public class IndexViewModel
    {
        [Required]
        public string Text { get; set; }
    }
}
