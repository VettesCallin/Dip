using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DipWeb.Model
{
    [Table("Физические лица")]
    public class ФизическиеЛица
    {
        [Key]
        [Column("Идентификатор физического лица")]
        [DisplayName("Идентификатор физического лица")]
        public Guid ИдентификаторФизическогоЛица { get; set; }

        [Column("Фамилия")]
        [DisplayName("Фамилия")]
        [Required]
        public string Фамилия { get; set; }

        [Column("Имя")]
        [DisplayName("Имя")]
        [Required]
        public string Имя { get; set; }

        [Column("Отчество")]
        [DisplayName("Отчество")]
        public string? Отчество { get; set; }

        [Column("Пол")]
        [DisplayName("Пол")]
        [Required]
        public string Пол { get; set; }
       
        [Column("Гражданство")]
        [DisplayName("Гражданство")]
        [Required]
        public string Гражданство { get; set; }

        [Column("Дата рождения")]
        [DisplayName("Дата рождения")]
        [Required]
        public DateTime ДатаРождения { get; set; }

        [Column("Название документа, удостоверяющего личность")]
        [DisplayName("Название документа")]
        [Required]
        public string НазваниеДокумента { get; set; }

        [Column("Серия документа")]
        [DisplayName("Серия документа")]
        [Required]
        public string СерияДокумента { get; set; }

        [Column("Номер документа")]
        [DisplayName("Номер документа")]
        [Required]
        public int НомерДокумента { get; set; }

        [Column("Дата выдачи документа")]
        [DisplayName("Дата выдачи")]
        [Required]
        public DateTime ДатаВыдачи { get; set; }

        [Column("Дата окончания документа")]
        [DisplayName("Дата окончания")]
        public DateTime? ДатаОкончания { get; set; }

        [Column("Орган, выдавший документ")]
        [DisplayName("Кем выдан")]
        [Required]
        public string ОрганВыдавшийДокумент { get; set; }

        [Column("Идентификационный номер")]
        [DisplayName("ИН")]
        public string? ИдентификационныйНомер { get; set; }

        [Column("Идентификатор адреса регистрации")]
        [ForeignKey("Идентификатор адреса")]
        [DisplayName("Идентификатор адреса регистрации")]
        [Required]
        public Guid ИдентификаторАдресаРегистрации { get; set; }

        [Column("Идентификатор адреса прописки")]
        [ForeignKey("Идентификатор адреса")]
        [DisplayName("Идентификатор адреса прописки")]
        public Guid? ИдентификаторАдресаПрописки { get; set; }

        [Column("E-mail")]
        [DisplayName("E-mail")]
        public string? Email { get; set; }

        [Column("Место  работы")]
        [DisplayName("Место  работы")]
        public string? МестоРаботы { get; set; }

        [Column("Информация о клиенте")]
        [DisplayName("Информация")]
        public string? Информация { get; set; }
    }
}
