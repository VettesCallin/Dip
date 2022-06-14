using DipWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace DipWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
                
        }
        public DbSet<Адреса> Адреса { get; set; }
        public DbSet<Телефон> Телефоны { get; set; }
        public DbSet<БазоваяВеличина> БазоваяВеличина { get; set; }
        public DbSet<Банк> Банк { get; set; }
        public DbSet<БПК> БПК { get; set; }
        public DbSet<Валюта> Валюта { get; set; }
        public DbSet<ВОО> ВОО { get; set; }
        public DbSet<Депозиты> Депозиты { get; set; }
        public DbSet<Кредитование> Кредитование { get; set; }
        public DbSet<Переводы> Переводы { get; set; }
        public DbSet<Платежи_3м_лицам> Платежи_3м_лицам { get; set; }
        public DbSet<ПогашенияКредитов> ПогашенияКредитов { get; set; }
        public DbSet<Страхование> Страхование { get; set; }
        public DbSet<СчетаБПК> СчетаБПК { get; set; }
        public DbSet<ТекущиеСчета> ТекущиеСчета { get; set; }
        public DbSet<ФизическиеЛица> ФизическиеЛица { get; set; }
        public DbSet<ЦенныеБумаги> ЦенныеБумаги { get; set; }
        public DbSet<ЮридическиеЛица> ЮридическиеЛица { get; set; }
        public DbSet<УчетныеЗаписи> УчетныеЗаписи { get; set; }
    }
}
