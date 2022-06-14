using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("Банк")]
    public class Банк
    {
        [Key]
        [Column("Идентификатор банка")]
        [DisplayName("Идентификатор банка")]
        public Guid ИдентификаторБанка { get; set; }

        [Column("Наименование")]
        [DisplayName("Наименование")]
        [Required]
        public string Наименование { get; set; }

        [Column("Код банка")]
        [DisplayName("Код банка")]
        [Required]
        public int КодБанка { get; set; }

        [Column("УНП банка")]
        [DisplayName("УНП банка")]
        [Required]
        public int УнпБанка { get; set; }

        [Column("БИК банка")]
        [DisplayName("БИК банка")]
        [Required]
        public string БикБанка { get; set; }

        [Column("Р/счет")]
        [DisplayName("Р/счет")]
        [Required]
        public string РСчет { get; set; }

        [Column("Идентификатор юридического адреса")]
        [DisplayName("Идентификатор юридического адреса")]
        [Required]
        public Guid ИдентификаторЮридическогоАдреса { get; set; }

        [Column("Идентификатор телефона")]
        [DisplayName("Идентификатор телефона")]
        [Required]
        public Guid ИдентификаторТелефона { get; set; }

        [Column("Детали")]
        [DisplayName("Детали")]
        public string? Детали { get; set; }
    }
}
