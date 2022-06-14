using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("Переводы")]
    public class Переводы
    {
        [Key]
        [Column("Идентификатор перевода")]
        [DisplayName("Идентификатор перевода")]
        public Guid ИдентификаторПеревода { get; set; }

        [Column("Контрольный номер")]
        [DisplayName("Контрольный номер")]
        [Required]
        public string КонтрольныйНомер { get; set; }

        [Column("Идентификатор счета БПК отправителя")]
        [ForeignKey("Идентификатор счета БПК")]
        [DisplayName("Идентификатор счета БПК отправителя")]
        public Guid? ИдентификаторСчетаБпкОтправителя { get; set; }

        [Column("Идентификатор счета БПК получателя")]
        [ForeignKey("Идентификатор счета БПК")]
        [DisplayName("Идентификатор счета БПК получателя")]
        public Guid? ИдентификаторСчетаБпкПолучателя { get; set; }

        [Column("Идентификатор текущего счета отправителя")]
        [ForeignKey("Идентификатор текущего счета")]
        [DisplayName("Идентификатор текущего счета отправителя")]
        public Guid? ИдентификаторТекущегоСчетаОтправителя { get; set; }

        [Column("Идентификатор текущего счета получателя")]
        [ForeignKey("Идентификатор текущего счета")]
        [DisplayName("Идентификатор текущего счета получателя")]
        public Guid? ИдентификаторТекущегоСчетаПолучателя { get; set; }

        [Column("Идентификатор юридического лица")]
        [ForeignKey("Идентификатор юридического лица")]
        [DisplayName("Идентификатор юридического лица")]
        public Guid? ИдентификаторЮридическогоЛица { get; set; }

        [Column("Идентификатор физического лица")]
        [ForeignKey("Идентификатор физического лица")]
        [DisplayName("Идентификатор физического лица")]
        public Guid? ИдентификаторФизическогоЛица { get; set; }

        [Column("Вид перевода")]
        [DisplayName("Вид перевода")]
        [Required]
        public string ВидПеревода { get; set; }

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

        [Column("Дата перевода")]
        [DisplayName("Дата перевода")]
        [Required]
        public DateTime ДатаПеревода { get; set; }

        [Column("Статус")]
        [DisplayName("Статус")]
        [Required]
        public string Статус { get; set; }
    }
}
