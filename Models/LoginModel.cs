﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetPoint.Models
{
    [Table("users")]
    public class LoginModel
    {

        [Required(ErrorMessage = "Поле \"Электронная почта\" обязательно для заполнения")]
        [EmailAddress(ErrorMessage = "Введите действительный адрес электронной почты")]
        [Column("email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле \"Пароль\" обязательно для заполнения")]
        [Column("passwordhash")]
        public string Password { get; set; }

    }

}
