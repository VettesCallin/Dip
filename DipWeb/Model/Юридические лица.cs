using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("Юридические лица")]
    public class ЮридическиеЛица
    {
        [Key]
        [Column("Идентификатор юридического лица")]
        [DisplayName("Идентификатор юридического лица")]
        public Guid ИдентификаторЮридическогоЛица { get; set; }

        [Column("Тип юридического лица")]
        [DisplayName("Тип юридического лица")]
        [Required]
        public string ТипЮридическогоЛица { get; set; }

        [Column("Наименование организации")]
        [DisplayName("Наименование организации")]
        [Required]
        public string НаименованиеОрганизации { get; set; }

        [Column("Руководитель организации")]
        [DisplayName("Руководитель организации")]
        [Required]
        public string РуководительОрганизации { get; set; }

        [Column("УНП")]
        [DisplayName("УНП")]
        [Required]
        public int УНП { get; set; }

        [Column("Р/счет")]
        [DisplayName("Р/счет")]
        [Required]
        public string РСчет { get; set; }

        [Column("Идентификатор юридического адреса")]
        [ForeignKey("Идентификатор адреса")]
        [DisplayName("Идентификатор юридического адреса")]
        [Required]
        public Guid ИдентификаторЮридическогоАдреса { get; set; }

        [Column("Идентификатор телефона")]
        [ForeignKey("Идентификатор телефона")]
        [DisplayName("Идентификатор телефона")]
        [Required]
        public Guid ИдентификаторТелефона { get; set; }

        [Column("Вид деятельности")]
        [DisplayName("Вид деятельности")]
        [Required]
        public string ВидДеятельности { get; set; }

        [Column("E-mail")]
        [DisplayName("E-mail")]
        public string? Email { get; set; }
    }
}
