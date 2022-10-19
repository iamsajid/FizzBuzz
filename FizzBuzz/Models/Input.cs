namespace FizzBuzz.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Input
    {
        [Required(ErrorMessage = "Number Required")]
        [Range(1, 1000, ErrorMessage = "Number between 1 to 1000 Allowed only.")]
        public int Value { get; set; }
    }
}
