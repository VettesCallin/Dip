using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("Депозиты")]
    public class Депозиты
    {
        [Key]
        [Column("Идентификатор депозита")]
        [DisplayName("Идентификатор депозита")]
        public Guid ИдентификаторДепозита { get; set; }

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

        [Column("Идентификатор текущего счета")]
        [NotMapped]
        [ForeignKey("Идентификатор текущего счета")]
        [DisplayName("Идентификатор текущего счета")]
        public Guid? ИдентификаторТекущегоСчета { get; set; }

        [Column("Идентификатор счета БПК")]
        [NotMapped]
        [ForeignKey("Идентификатор счета БПК")]
        [DisplayName("Идентификатор счета БПК")]
        public Guid? ИдентификаторСчетаБПК { get; set; }

        [Column("Сумма")]
        [DisplayName("Сумма")]
        [Required]
        public Decimal Сумма { get; set; }

        [Column("Процентная ставка")]
        [DisplayName("Процентная ставка")]
        [Required]
        public double ПроцентнаяСтавка { get; set; }

        [Column("Капитализация процентов")]
        [DisplayName("Капитализация процентов")]
        [Required]
        public string КапитализацияПроцентов { get; set; }

        [Column("Дата отрытия")]
        [DisplayName("Дата отрытия")]
        [Required]
        public DateTime ДатаОтрытия { get; set; }

        [Column("Срок действия договора")]
        [DisplayName("Срок действия договора")]
        [Required]
        public Int16 СрокДействияДоговора { get; set; }

        [Column("Дата окончания")]
        [DisplayName("Дата окончания")]
        [Required]
        public DateTime ДатаОкончания { get; set; }

        [Column("Срок пополнения")]
        [DisplayName("Срок пополнения")]
        [Required]
        public Int16 СрокПополнения { get; set; }

        [Column("Пролонгация")]
        [DisplayName("Пролонгация")]
        [Required]
        public bool Пролонгация { get; set; }

        [Column("Возможность досрочного закрытия")]
        [DisplayName("Возможность досрочного закрытия")]
        [Required]
        public bool ВозможностьДосрочногоЗакрытия { get; set; }

        [Column("Отзывной")]
        [DisplayName("Отзывной")]
        [Required]
        public bool Отзывной { get; set; }
    }
}
