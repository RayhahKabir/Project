using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Dot_Net_Developer_Test.Models
{
    public class StockM
    {
        [Display(Name = "Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Your Date"), StringLength(15), Display(Name = "Date")]
        public string? Date { get; set; }
        [Required(ErrorMessage = "Enter Your Trade_code"), StringLength(40), Display(Name = "Trade Code")]
        public string? Trade_code { get; set; }
        [Required(ErrorMessage = "Enter Your High"), Display(Name = "High")]
        public double High { get; set; }
        [Required(ErrorMessage = "Enter Your Low"), Display(Name = "Low")]
        public double Low { get; set; }
        [Required(ErrorMessage = "Enter Your Open"), Display(Name = "Open")]
        public double Open { get; set; }
        [Required(ErrorMessage = "Enter Your Close"), Display(Name = "Close")]
        public double Close { get; set; }
        [Required(ErrorMessage = "Enter Your Valume"), StringLength(60), Display(Name = "Valume")]
        public string? Valume { get; set; }
    }
    public class StockMDbContext : DbContext 
    {
        public StockMDbContext(DbContextOptions<StockMDbContext>options):base (options)
        {
        }
        public DbSet<StockM>StockMs { get; set; }
    }
}
