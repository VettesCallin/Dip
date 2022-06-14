using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("Счета БПК")]
    public class СчетаБПК
    {
        [Key]
        [Column("Идентификатор счета БПК")]
        [DisplayName("Идентификатор счета БПК")]
        public Guid ИдентификаторСчетаБПК { get; set; }

        [Column("Идентификатор юридического лица")]
        [ForeignKey("Идентификатор юридического лица")]
        [DisplayName("Идентификатор юридического лица")]
        public Guid? ИдентификаторЮридическогоЛица { get; set; }

        [Column("Идентификатор физического лица")]
        [ForeignKey("Идентификатор физического лица")]
        [DisplayName("Идентификатор физического лица")]
        public Guid? ИдентификаторФизическогоЛица { get; set; }

        [Column("Идентификатор кода валюты")]
        [ForeignKey("Идентификатор кода валюты")]
        [DisplayName("Идентификатор кода валюты")]
        [Required]
        public Guid ИдентификаторКодаВалюты { get; set; }

        [Column("Процентная ставка")]
        [DisplayName("Процентная ставка")]
        [Required]
        public double ПроцентнаяСтавка { get; set; }

        [Column("Сумма")]
        [DisplayName("Сумма")]
        [Required]
        public Decimal Сумма { get; set; }

        [Column("Капитализация процентов")]
        [DisplayName("Капитализация процентов")]
        [Required]
        public Decimal КапитализацияПроцентов { get; set; }

        [Column("Дата открытия")]
        [DisplayName("Дата открытия")]
        [Required]
        public DateTime ДатаОткрытия { get; set; }

        [Column("Дата закрытия")]
        [DisplayName("Дата закрытия")]
        public DateTime? ДатаЗакрытия { get; set; }
    }
}
