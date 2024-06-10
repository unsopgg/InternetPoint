using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetPoint.Models
{
    
    [Table("customers")]
    public class Customer
    {
        [Key]
        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("executed")]
        public bool Executed { get; set; }

    }

}
