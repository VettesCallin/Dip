using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("Страхование")]
    public class Страхование
    {
        [Key]
        [Column("Идентификатор страхования")]
        [DisplayName("Идентификатор страхования")]
        public Guid ИдентификаторСтрахования { get; set; }

        [Column("Вид страхования")]
        [DisplayName("Вид страхования")]
        [Required]
        public string ВидСтрахования { get; set; }

        [Column("Идентификатор юридического лица")]
        [ForeignKey("Идентификатор юридического лица")]
        [DisplayName("Идентификатор юридического лица")]
        public Guid? ИдентификаторЮридическогоЛица { get; set; }

        [Column("Идентификатор физического лица")]
        [ForeignKey("Идентификатор физического лица")]
        [DisplayName("Идентификатор физического лица")]
        public Guid? ИдентификаторФизическогоЛица { get; set; }

        [Column("Срок страхования")]
        [DisplayName("Срок страхования")]
        [Required]
        public Int16 СрокСтрахования { get; set; }

        [Column("Дата заключения")]
        [DisplayName("Дата заключения")]
        [Required]
        public DateTime ДатаЗаключения { get; set; }

        [Column("Дата окончания")]
        [DisplayName("Дата окончания")]
        [Required]
        public DateTime ДатаОкончания { get; set; }

        [Column("Сумма")]
        [DisplayName("Сумма")]
        [Required]
        public Decimal Сумма { get; set; }

        [Column("Страховой тариф")]
        [DisplayName("Страховой тариф")]
        [Required]
        public double СтраховойТариф { get; set; }

        [Column("Периоды уплаты")]
        [DisplayName("Периоды уплаты")]
        [Required]
        public string ПериодыУплаты { get; set; }

        [Column("Комиссионное вознаграждение")]
        [DisplayName("Комиссионное вознаграждение")]
        [Required]
        public double КомиссионноеВознаграждение { get; set; }

        [Column("Бонусная программа")]
        [DisplayName("Бонусная программа")]
        public double? БонуснаяПрограмма { get; set; }
    }
}
