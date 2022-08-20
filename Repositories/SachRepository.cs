using Project_Template_SM22_Csharp.Context;
using Project_Template_SM22_Csharp.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Template_SM22_Csharp.Repositories
{
    public class SachRepository
    {
        private FpolyDBContext fpolyDBContext;
        public SachRepository()
        {
            fpolyDBContext = new FpolyDBContext();
        }
        public List<Sach> GetAll()
        {
            return fpolyDBContext.Saches.ToList();
        }
        public bool Add(Sach s)
        {
            if (s == null) return false;
            fpolyDBContext.Add(s);
            fpolyDBContext.SaveChanges();
            return true;
        }
        public bool Update(Sach s)
        {
            if(s== null) return false;
            var a = fpolyDBContext.Saches.FirstOrDefault(c=>c.Ma==s.Ma);
            a.Ma = s.Ma;
            a.Ten = s.Ten;
            a.SoTrang = s.SoTrang;
            fpolyDBContext.Update(a);
            fpolyDBContext.SaveChanges();
            return true;
        }
        public bool Delete(Sach s)
        {
            if (s == null) return false;
            fpolyDBContext.Remove(s);
            fpolyDBContext.SaveChanges();
            return true;
        }
    }
}
