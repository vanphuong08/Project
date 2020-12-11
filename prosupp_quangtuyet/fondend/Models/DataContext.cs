using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace fondend.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("name=connection")
        { }
        public DbSet<DANH_SACH_KHO> DANH_SACH_KHOs { get; set; }
        public DbSet<THEM_MOI_NHAP_KHO> THEM_MOI_NHAP_KHOs { get; set; }
        public DbSet<THEM_MOI_XUAT_KHO> THEM_MOI_XUAT_KHOs { get; set; }
    }
}