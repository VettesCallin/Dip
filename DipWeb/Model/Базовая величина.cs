using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("Базовая величина")]
    public class БазоваяВеличина
    {
        [Key]
        [Column("Идентификатор базовой величины")]
        [DisplayName("Идентификатор базовой величины")]
        public Guid ИдентификаторБазовойВеличины { get; set; }

        [Column("Значение б.в.")]
        [DisplayName("Значение базовой величины")]
        [Required]
        public Decimal ЗначениеБВ { get; set; }

        [Column("Дата принятия")]
        [DisplayName("Дата принятия")]
        [Required]
        public DateTime ДатаПринятия { get; set; }
    }
}
