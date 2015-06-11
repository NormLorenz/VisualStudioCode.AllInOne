using System.ComponentModel.DataAnnotations;

namespace VisualStudioCode.WebAPI.Models
{
    public class Code
    {
        public int Id { get; set; }
        [Required]
        public string Display { get; set; }
        [Required]
        public string Value { get; set; }
    }
}