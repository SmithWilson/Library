using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.ViewModels
{
    public class AddBookViewModel
    {
        [DisplayName("Название")]
        [Required(ErrorMessage = "Не указано название книги")]
        public string Name { get; set; }

        [DisplayName("Дата выхода")]
        [Required(ErrorMessage = "Не указана дата выхода")]
        [DataType(DataType.DateTime)]
        public DateTimeOffset ReleaseDate { get; set; }

        [DisplayName("Жанр")]
        [Required(ErrorMessage = "Не указан жанр книги")]
        [RegularExpression(@"[a-zA-Zа-яА-Я\s]+", ErrorMessage = "Жанр должен состоять из букв латиницы или кириллицы")]
        public string Genre { get; set; }

        [DisplayName("Автор")]
        [Required(ErrorMessage = "Не указан автор книги")]
        [RegularExpression(@"[a-zA-Zа-яА-Я\s]+", ErrorMessage = "Жанр должен состоять из букв латиницы или кириллицы")]
        public string Author { get; set; }
    }
}