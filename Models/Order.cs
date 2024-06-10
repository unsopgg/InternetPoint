using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetPoint.Models
{
    [Table("orders")]
    public class Order
    {
        [Key]
        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("service_id")]
        public int ServiceId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }
    }

}
