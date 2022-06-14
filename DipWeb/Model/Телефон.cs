using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("Телефоны")]
    public class Телефон
    {
        [Key]
        [Column("Идентификатор телефона")]
        [DisplayName("Идентификатор телефона")]
        public Guid ИдентификаторТелефона { get; set; }

        [Column("Идентификатор физического лица")]
        [DisplayName("Идентификатор физического лица")]
        public Guid? ИдентификаторФизическогоЛица { get; set; }

        [Column("Оператор")]
        [DisplayName("Оператор")]
        public string? Оператор { get; set; }

        [Column("Код страны")]
        [DisplayName("Код страны")]
        [Required]
        public string КодCтраны { get; set; }

        [Column("Код оператора")]
        [DisplayName("Код оператора")]
        [Required]
        public string КодОператора { get; set; }

        [Column("Номер телефона")]
        [DisplayName("Номер телефона")]
        [Required]
        public string НомерТелефона { get; set; }

        [Column("Детали")]
        [DisplayName("Детали")]
        public string? Детали { get; set; }
    }
}
