using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("ВОО")]
    public class ВОО
    {
        [Key]
        [Column("Идентификатор ВОО")]
        [DisplayName("Идентификатор ВОО")]
        public Guid ИдентификаторВОО { get; set; }

        [Column("Тип ВОО")]
        [DisplayName("Тип ВОО")]
        [Required]
        public string ТипВОО { get; set; }

        [Column("Идентификатор юридического лица")]
        [DisplayName("Идентификатор юридического лица")]
        public Guid? ИдентификаторЮридическогоЛица { get; set; }

        [Column("Идентификатор физического лица")]
        [DisplayName("Идентификатор физического лица")]
        public Guid? ИдентификаторФизическогоЛица { get; set; }

        [Column("Идентификатор банка")]
        [DisplayName("Идентификатор банка")]
        [Required]
        public Guid ИдентификаторБанка { get; set; }

        [Column("Идентификатор кода валюты 1")]
        [DisplayName("Идентификатор кода валюты 1")]
        [Required]
        public Guid ИдентификаторКодаВалюты1 { get; set; }

        [Column("Идентификатор кода валюты 2")]
        [DisplayName("Идентификатор кода валюты 2")]
        [Required]
        public Guid ИдентификаторКодаВалюты2 { get; set; }

        [Column("Сумма")]
        [DisplayName("Сумма")]
        [Required]
        public Decimal Сумма { get; set; }

        [Column("Моржа")]
        [DisplayName("Моржа")]
        [Required]
        public Decimal Моржа { get; set; }

        [Column("Дата")]
        [DisplayName("Дата")]
        [Required]
        public DateTime Дата { get; set; }
    }
}
