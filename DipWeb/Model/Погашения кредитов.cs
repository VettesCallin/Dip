using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("Погашения кредитов")]
    public class ПогашенияКредитов
    {
        [Key]
        [Column("Идентификатор погашения")]
        [DisplayName("Идентификатор погашения")]
        public Guid ИдентификаторПогашения { get; set; }

        [Column("Идентификатор кредитования")]
        [ForeignKey("Идентификатор кредитования")]
        [DisplayName("Идентификатор кредитования")]
        [Required]
        public Guid ИдентификаторКредитования { get; set; }

        [Column("Номер кредитного договора")]
        [ForeignKey("Номер кредитного договора")]
        [DisplayName("Номер кредитного договора")]
        [Required]
        public long НомерКредитногоДоговора { get; set; }

        [Column("Идентификатор юридического лица")]
        [ForeignKey("Идентификатор юридического лица")]
        [DisplayName("Идентификатор юридического лица")]
        public Guid? ИдентификаторЮридическогоЛица { get; set; }

        [Column("Идентификатор физического лица")]
        [ForeignKey("Идентификатор физического лица")]
        [DisplayName("Идентификатор физического лица")]
        public Guid? ИдентификаторФизическогоЛица { get; set; }

        [Column("Сумма")]
        [DisplayName("Сумма")]
        [Required]
        public Decimal Сумма { get; set; }

        [Column("Дата платежа")]
        [DisplayName("Дата платежа")]
        [Required]
        public DateTime ДатаПлатежа { get; set; }
    }
}
