using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("Учетные записи")]
    public class УчетныеЗаписи
    {
        [Key]
        [Column("Идентификатор учетной записи")]
        [DisplayName("Идентификатор учетной записи")]
        public Guid ИдентификаторУчетнойЗаписи { get; set; }

        [Column("Идентификатор юридического лица")]
        [ForeignKey("Идентификатор юридического лица")]
        [DisplayName("Идентификатор юридического лица")]
        public Guid? ИдентификаторЮридическогоЛица { get; set; }

        [Column("Идентификатор физического лица")]
        [ForeignKey("Идентификатор физического лица")]
        [DisplayName("Идентификатор физического лица")]
        public Guid? ИдентификаторФизическогоЛица { get; set; }

        [Column("Логин")]
        [DisplayName("Логин")]
        [Required]
        public string Логин { get; set; }

        [Column("Пароль")]
        [DisplayName("Пароль")]
        [Required]
        public string Пароль { get; set; }

        [Column("Дата создания учетной записи")]
        [DisplayName("Дата создания")]
        [Required]
        public DateTime ДатаСозданияУчетнойЗаписи { get; set; }
    }
}
