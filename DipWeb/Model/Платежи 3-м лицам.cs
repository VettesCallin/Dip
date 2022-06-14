using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("Платежи 3-м лицам")]
    public class Платежи_3м_лицам
    {
        [Key]
        [Column("Идентификатор платежа 3-м лицам")]
        [DisplayName("Идентификатор платежа 3-м лицам")]
        public Guid ИдентификаторПлатежа3мЛицам { get; set; }

        [Column("Идентификатор БПК")]
        [ForeignKey("Идентификатор БПК")]
        [DisplayName("Идентификатор БПК")]
        public Guid? ИдентификаторБПК { get; set; }

        [Column("Идентификатор юридического лица")]
        [ForeignKey("Идентификатор юридического лица")]
        [DisplayName("Идентификатор юридического лица")]
        public Guid? ИдентификаторЮридическогоЛица { get; set; }

        [Column("Идентификатор физического лица")]
        [ForeignKey("Идентификатор физического лица")]
        [DisplayName("Идентификатор физического лица")]
        public Guid? ИдентификаторФизическогоЛица { get; set; }

        [Column("Номер плательщика ЕРИП")]
        [DisplayName("Номер плательщика ЕРИП")]
        public long? НомерПлательщикаЕРИП { get; set; }

        [Column("Номер услуги ЕРИП")]
        [DisplayName("Номер услуги ЕРИП")]
        public long? НомерУслугиЕРИП { get; set; }

        [Column("Номер операции ЕРИП")]
        [DisplayName("Номер операции ЕРИП")]
        public long? НомерОперацииЕРИП { get; set; }

        [Column("Идентификатор кода валюты")]
        [ForeignKey("Идентификатор кода валюты")]
        [DisplayName("Идентификатор кода валюты")]
        [Required]
        public Guid ИдентификаторКодаВалюты { get; set; }

        [Column("Сумма")]
        [DisplayName("Сумма")]
        [Required]
        public Decimal Сумма { get; set; }

        [Column("Комиссия")]
        [DisplayName("Комиссия")]
        public double? Комиссия { get; set; }

        [Column("Дата платежа")]
        [DisplayName("Дата платежа")]
        [Required]
        public DateTime ДатаПлатежа { get; set; }

        [Column("Назначение")]
        [DisplayName("Назначение")]
        [Required]
        public string Назначение { get; set; }

        [Column("Получатель платежа")]
        [DisplayName("Получатель платежа")]
        public string? ПолучательПлатежа { get; set; }

        [Column("УНП получателя")]
        [DisplayName("УНП получателя")]
        public int? УнпПолучателя { get; set; }

        [Column("Р/счет получателя")]
        [DisplayName("Р/счет получателя")]
        public string? РСчетПолучателя { get; set; }
    }
}
