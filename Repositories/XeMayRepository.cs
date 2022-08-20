using Project_Template_SM22_Csharp.Context;
using Project_Template_SM22_Csharp.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Template_SM22_Csharp.Repositories
{
    public class XeMayRepository
    {

        private FpolyDBContext _fpolyDBContext;
        public XeMayRepository()
        {
            _fpolyDBContext = new FpolyDBContext();
        }
        public List<XeMay> GetAll()
        {
            return _fpolyDBContext.XeMays.ToList();
        }
        public bool Add(XeMay x)
        {
            if (x == null) return false;
            _fpolyDBContext.Add(x);
            _fpolyDBContext.SaveChanges();
            return true;
        }
        public bool Update(XeMay x)
        {
            if(x==null) return false;
            var a = _fpolyDBContext.XeMays.FirstOrDefault(c => c.Ma == x.Ma);
            a.Ten= x.Ten;
            a.SoLuong = x.SoLuong;
            _fpolyDBContext.Update(a);
            _fpolyDBContext.SaveChanges();
            return true;
        }
        public bool Delete(XeMay x)
        {
            
            if (x == null) return false;
            _fpolyDBContext.Remove(x);
            _fpolyDBContext.SaveChanges();
            return true;
        }
    }
}
