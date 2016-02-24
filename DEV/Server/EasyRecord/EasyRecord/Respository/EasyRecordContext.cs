using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyRecord.Respository.Entitys;

namespace EasyRecord.Respository
{
    public class EasyRecordContext : DbContext
    {
        //构造连接字符串
        public EasyRecordContext() : base("EasyRecordConn")
        {
        }

        //指定实体集
        public DbSet<CategoryEntity> Category { get; set; }

        //重写创建方法指定命名规则为单数
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
