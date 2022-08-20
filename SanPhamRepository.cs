using Project_Template_SM22_Csharp.Context;
using Project_Template_SM22_Csharp.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Template_SM22_Csharp.Repositories
{
    public class SanPhamRepository
    {
        private FpolyDBContext fpolyDBContext;
        public SanPhamRepository()
        {
            fpolyDBContext = new FpolyDBContext();
        }
        public List<SanPham> GetAll()
        {
            return fpolyDBContext.SanPhams.ToList();
        }
        public bool Add(SanPham sp)
        {
            if (sp == null) return false;
            fpolyDBContext.Add(sp);
            fpolyDBContext.SaveChanges();
            return true;
        }
        public bool Update(SanPham sp)
        {
            
            if(sp==null) return false;
            var a = fpolyDBContext.SanPhams.FirstOrDefault(a => a.Ma == sp.Ma);
            a.Ten = sp.Ten;
            a.GiaBan = sp.GiaBan;
            a.TrangThai = sp.TrangThai;
            a.Website = sp.Website;
            fpolyDBContext.Update(a);
            fpolyDBContext.SaveChanges();
            return true;
        }
        public bool Delete(SanPham sp)
        {
            if (sp == null) return false;
            fpolyDBContext.Remove(sp);
            fpolyDBContext.SaveChanges();
            return true;
        }
    }
}
