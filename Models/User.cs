using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace InternetPoint.Models
{

    [Table("users")]
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("username")]
        public string Name { get; set; }


        [Column("email")]
        public string Email { get; set; }

        [Column("passwordhash")]
        public string password { get; set; }

        [Column("firstname")]
        public string firstname { get; set; }



        [Column("lastname")]
        public string lastname { get; set; }

        [Column("phone")]
        public string phone { get; set; }

        [Column("address")]
        public string address { get; set; }

        [NotMapped]
        public bool IsAdmin { get; set; }
        // Свойство для связанных заказов
        public List<Order> Orders { get; set; }
        [NotMapped]
        public bool ShowTariffs { get; set; }

    }

}


