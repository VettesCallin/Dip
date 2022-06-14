using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("Адреса")]
    public class Адреса
    {
        [Key]
        [Column("Идентификатор адреса")]
        [DisplayName("Идентификатор адреса")]
        public Guid ИдентификаторАдреса { get; set; }

        [Column("Страна")]
        [DisplayName("Страна")]
        [Required]
        public string Страна { get; set; }

        [Column("Область")]
        [DisplayName("Область")]
        [Required]
        public string Область { get; set; }

        [Column("Город")]
        [DisplayName("Город")]
        [Required]
        public string Город { get; set; }

        [Column("Строка адреса")]
        [DisplayName("Строка адреса")]
        [Required]
        public string СтрокаАдреса { get; set; }

        [Column("Почтовый индекс")]
        [DisplayName("Почтовый индекс")]
        public int? ПочтовыйИндекс { get; set; }

        [Column("Код СОАТО")]
        [DisplayName("Код СОАТО")]
        public string? КодСОАТО { get; set; }

        [Column("Детали")]
        [DisplayName("Детали")]
        public string? Детали { get; set; }
    }
}
