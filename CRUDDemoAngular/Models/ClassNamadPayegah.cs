using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDDemoAngular.Models
{
    public class ClassNamadPayegah:DbContext //نوشتن وراثت
    {
        //نوشتن کانستراکتر - ورودی دی بی کانتکست جنریک -و ارسالش به اون
        public ClassNamadPayegah(DbContextOptions<ClassNamadPayegah>options):base(options)
        {

        }

        //پراپرتی نماد رکوردهای جدید
        public DbSet<Category> Categories { get; set; }
    }
}
