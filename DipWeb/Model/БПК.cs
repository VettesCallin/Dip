using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("БПК")]
    public class БПК
    {
        [Key]
        [Column("Идентификатор БПК")]
        [DisplayName("Идентификатор БПК")]
        public Guid ИдентификаторБПК { get; set; }

        [Column("Вид платежной системы")]
        [DisplayName("Вид платежной системы")]
        [Required]
        public string ВидПлатежнойСистемы { get; set; }

        [Column("Вид БПК")]
        [DisplayName("Вид БПК")]
        [Required]
        public string ВидБПК { get; set; }

        [Column("Идентификатор счета БПК")]
        [DisplayName("Идентификатор счета БПК")]
        [Required]
        public Guid ИдентификаторСчетаБПК { get; set; }

        [Column("Идентификатор кода валюты")]
        [DisplayName("Идентификатор кода валюты")]
        [Required]
        public Guid ИдентификаторКодаВалюты { get; set; }

        [Column("Срок действия")]
        [DisplayName("Срок действия")]
        [Required]
        public string СрокДействия { get; set; }

        [Column("Номер карты")]
        [DisplayName("Номер карты")]
        [Required]
        public long НомерКарты { get; set; }

        [Column("Наименование организации")]
        [DisplayName("Наименование организации")]
        public string? НаименованиеОрганизации { get; set; }

        [Column("Данные держателя")]
        [DisplayName("Данные держателя")]
        public string? ДанныеДержателя { get; set; }

        [Column("Код CVV")]
        [DisplayName("Код CVV")]
        [Required]
        public string КодCVV { get; set; }

        [Column("PIN")]
        [DisplayName("PIN")]
        public string? PIN { get; set; }

        [Column("Дата выпуска")]
        [DisplayName("Дата выпуска")]
        [Required]
        public DateTime ДатаDыпуска { get; set; }

        [Column("Дата истечения")]
        [DisplayName("Дата истечения")]
        [Required]
        public DateTime ДатаИстечения { get; set; }

        [Column("Бонусная программа")]
        [DisplayName("Бонусная программа")]
        public string? БонуснаяПрограмма { get; set; }

        [Column("Заготовка")]
        [DisplayName("Заготовка")]
        [Required]
        public bool Заготовка { get; set; }

        [Column("Состояние")]
        [DisplayName("Состояние")]
        [Required]
        public string Состояние { get; set; }
    }
}
