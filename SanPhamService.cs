using Project_Template_SM22_Csharp.DomainClass;
using Project_Template_SM22_Csharp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Template_SM22_Csharp.Services
{
    public class SanPhamService
    {
        private SanPhamRepository sanPhamRepository;
        public SanPhamService()
        {
            sanPhamRepository = new SanPhamRepository();
        }
        public List<SanPham> GetAll()
        {
            return sanPhamRepository.GetAll();
        }
        public string Add(SanPham sp)
        {
            if (sanPhamRepository.Add(sp)) return "Thêm thành công";
            return "Không thành công";
        }
        public string Update(SanPham sp)
        {
            if (sanPhamRepository.Update(sp)) return "Sửa thành công";
            return "Không thành công";
        }
        public string Delete(SanPham sp)
        {
            var a = sanPhamRepository.GetAll().FirstOrDefault(c => c.Ma == sp.Ma);
            if (sanPhamRepository.Delete(a)) return "Xóa thành công";
            return "Không thành công";
        }
    }
}
