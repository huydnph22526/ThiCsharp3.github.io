using Project_Template_SM22_Csharp.DomainClass;
using Project_Template_SM22_Csharp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Template_SM22_Csharp.Services
{
    public class XeMayService
    {
        private XeMayRepository _xeService;
        public XeMayService()
        {
            _xeService = new XeMayRepository();
            GetAll();
        }
        public List<XeMay> GetAll()
        {
            return _xeService.GetAll();
        }
        public string Add(XeMay x)
        {
            if (_xeService.Add(x)) return "Thêm thành công";
            return "Không thành công";
        }
        public string Update(XeMay x)
        {
            if (_xeService.Update(x))
            {
                GetAll();
                return "Sửa thành công";
            }
            return "Không thành công";
        }
        public string Delete(XeMay x)
        {
            var xe = _xeService.GetAll().FirstOrDefault(c => c.Ma == x.Ma);
            if (_xeService.Delete(xe)) return "Xóa thành công";
            return "Không thành công";
        }
    }
}
