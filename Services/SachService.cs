using Project_Template_SM22_Csharp.DomainClass;
using Project_Template_SM22_Csharp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Template_SM22_Csharp.Services
{
    public class SachService
    {
        private SachRepository sachRepository;
        public SachService()
        {
            sachRepository = new SachRepository();
        }
        public List<Sach> GetAll()
        {
            return sachRepository.GetAll();
        }
        public string Add(Sach s)
        {
            if (sachRepository.Add(s)) return "Thêm thành công";
            return "Không thành công";
        }
        public string Update(Sach s)
        {
            if (sachRepository.Update(s)) return "Sửa thành công";
            return "Không thành công";
        }
        
        public string Delete(Sach s)
        {
            var a = sachRepository.GetAll().FirstOrDefault(C=>C.Ma==s.Ma);
            if (sachRepository.Delete(a)) return "Xóa thành công";
            return "Không thành công";
        }
    }
}
