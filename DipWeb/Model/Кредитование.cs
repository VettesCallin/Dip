using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("Кредитование")]
    public class Кредитование
    {
        [Key]
        [Column("Идентификатор кредитования")]
        [DisplayName("Идентификатор кредитования")]
        public Guid ИдентификаторКредитования { get; set; }

        [Column("Номер кредитного договора")]
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

        [Column("Вид кредита")]
        [DisplayName("Вид кредита")]
        [Required]
        public string ВидКредита { get; set; }

        [Column("Процентная ставка")]
        [DisplayName("Процентная ставка")]
        [Required]
        public double ПроцентнаяСтавка { get; set; }

        [Column("Срок")]
        [DisplayName("Срок")]
        [Required]
        public Int16 Срок { get; set; }

        [Column("Общая сумма")]
        [DisplayName("Общая сумма")]
        [Required]
        public Decimal ОбщаяСумма { get; set; }

        [Column("Сумма ежемесячных платежей")]
        [DisplayName("Сумма ежемесячных платежей")]
        [Required]
        public Decimal СуммаЕжемесячныхПлатежей { get; set; }

        [Column("Дата оформления")]
        [DisplayName("Дата оформления")]
        [Required]
        public DateTime ДатаОформления { get; set; }

        [Column("Период погашения")]
        [DisplayName("Период погашения")]
        [Required]
        public Int16 ПериодПогашения { get; set; }

        [Column("Конечная дата кредита")]
        [DisplayName("Конечная дата кредита")]
        [Required]
        public DateTime КонечнаяДатаКредита { get; set; }

        [Column("Срок кредитной линии")]
        [DisplayName("Срок кредитной линии")]
        public Int16? СрокКредитнойЛинии { get; set; }

        [Column("Пеня")]
        [DisplayName("Пеня")]
        [Required]
        public double Пеня { get; set; }

        [Column("Штрафные санкции")]
        [DisplayName("Штрафные санкции")]
        public Decimal? ШтрафныеCанкции { get; set; }

        [Column("Обеспечение")]
        [DisplayName("Обеспечение")]
        [Required]
        public string Обеспечение { get; set; }

        [Column("Сумма обеспечения")]
        [DisplayName("Сумма обеспечения")]
        [Required]
        public Decimal СуммаОбеспечения { get; set; }

        [Column("Статус")]
        [DisplayName("Статус")]
        [Required]
        public string Статус { get; set; }
    }
}
