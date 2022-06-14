using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("Ценные бумаги")]
    public class ЦенныеБумаги
    {
        [Key]
        [Column("Идентификатор ценной бумаги")]
        [DisplayName("Идентификатор ценной бумаги")]
        public Guid ИдентификаторЦеннойБумаги { get; set; }

        [Column("Вид ценной бумаги")]
        [DisplayName("Вид ценной бумаги")]
        [Required]
        public string ВидЦеннойБумаги { get; set; }

        [Column("Идентификатор юридического лица")]
        [ForeignKey("Идентификатор юридического лица")]
        [DisplayName("Идентификатор юридического лица")]
        public Guid? ИдентификаторЮридическогоЛица { get; set; }

        [Column("Идентификатор физического лица")]
        [ForeignKey("Идентификатор физического лица")]
        [DisplayName("Идентификатор физического лица")]
        public Guid? ИдентификаторФизическогоЛица { get; set; }

        [Column("Серия")]
        [DisplayName("Серия")]
        [Required]
        public string Серия { get; set; }

        [Column("Номер")]
        [DisplayName("Номер")]
        [Required]
        public long Номер { get; set; }

        [Column("Идентификатор кода валюты")]
        [ForeignKey("Идентификатор кода валюты")]
        [DisplayName("Идентификатор кода валюты")]
        [Required]
        public Guid ИдентификаторКодаВалюты { get; set; }

        [Column("Номинал")]
        [DisplayName("Номинал")]
        [Required]
        public Decimal Номинал { get; set; }

        [Column("Процентная ставка")]
        [DisplayName("Процентная ставка")]
        [Required]
        public double ПроцентнаяСтавка { get; set; }

        [Column("Дата заключения")]
        [DisplayName("Дата заключения")]
        [Required]
        public DateTime ДатаЗаключения { get; set; }

        [Column("Период размещения")]
        [DisplayName("Период размещения")]
        [Required]
        public Int16 ПериодРазмещения { get; set; }

        [Column("Период погашения")]
        [DisplayName("Период погашения")]
        [Required]
        public DateTime ПериодПогашения { get; set; }

        [Column("Конечная дата реализации")]
        [DisplayName("Конечная дата реализации")]
        [Required]
        public DateTime КонечнаяДатаРеализации { get; set; }

        [Column("Гарант погашения")]
        [DisplayName("Гарант погашения")]
        [Required]
        public string ГарантПогашения { get; set; }
    }
}
