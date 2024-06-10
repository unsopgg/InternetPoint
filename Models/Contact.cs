using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InternetPoint.Models
{
    [Table("contactinfos")]
    public class Contact
    {
        [Key]
        [Column("id")]
            public int Id { get; set; }

            // Внешний ключ для связи с таблицей Users
            public int UserId { get; set; }

            [ForeignKey("UserId")]
            public User User { get; set; }
                 [Column("firstname")]
                   public string Name { get; set; }
        [Column("lastname")]
        public string LName{ get; set; }

        

        [Column("address")]
        public string address { get; set; }
        [Column("email")]
        public string Email { get; set; }
        public User Users { get; set; }
    }
    }


