using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace InternetPoint.Models
{

    
    [Table("services")]

    public class ServiceInfo
    {
        [Key]
        [Column("service_id")]
        public int ServiceID { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("price")]
        [Required]
        public decimal Price { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("speed")]
        [Required]
        public int Speed { get; set; }
    }
}
