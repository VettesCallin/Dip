using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("Валюты")]
    public class Валюта
    {
        [Key]
        [Column("Идентификатор кода валюты")]
        [DisplayName("Идентификатор кода валюты")]
        public Guid ИдентификаторКодаВалюты { get; set; }

        [Column("Код валюты")]
        [DisplayName("Код валюты")]
        [Required]
        public string КодВалюты { get; set; }

        [Column("Наименование")]
        [DisplayName("Наименование")]
        [Required]
        public string Наименование { get; set; }

        [Column("Страна")]
        [DisplayName("Страна")]
        [Required]
        public string Страна { get; set; }

        [Column("Курс НБ")]
        [DisplayName("Курс НБ")]
        [Required]
        public double КурсНБ { get; set; }

        [Column("Курс банка покупки нал.")]
        [DisplayName("Курс банка покупки нал.")]
        [Required]
        public double КурсБанкаПокупкиНал { get; set; }

        [Column("Курс банка покупки безнал.")]
        [DisplayName("Курс банка покупки безнал.")]
        [Required]
        public double КурсБанкаПокупкиБезнал { get; set; }

        [Column("Курс банка продажи нал.")]
        [DisplayName("Курс банка продажи нал.")]
        [Required]
        public double КурсБанкаПродажиНал { get; set; }

        [Column("Курс банка продажи безнал.")]
        [DisplayName("Курс банка продажи безнал.")]
        [Required]
        public double КурсБанкаПродажиБезнал { get; set; }
    }
}
