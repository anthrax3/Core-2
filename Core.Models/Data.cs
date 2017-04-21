using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Data
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Key { get; set; }
        public string Value { get; set; }
    }
}