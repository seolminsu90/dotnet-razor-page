using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Release Date"), DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        // Date, int 등의 형식은 기본이 Required. 불필요 시 DateTime? 과 같이 Nullable로 지정하면 된다.

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Genre { get; set; } = string.Empty;

        [Range(1, 100), DataType(DataType.Currency)]// View engine에 대한 힌트 제공 Date, Time, PhoneNumber, Currency, EmailAddress 등..
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5), Required]
        public string Rating { get; set; } = string.Empty;
    }

    /*
     * 
     *  Add-Migration {마이그레이션네임}
        Update-Database
    */
}
