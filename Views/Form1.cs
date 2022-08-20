using Project_Template_SM22_Csharp.DomainClass;
using Project_Template_SM22_Csharp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Template_SM22_Csharp.Views
{
    public partial class Form1 : Form
    {
        private XeMayService _xeMayService;
        public Form1()
        {
            InitializeComponent();
            _xeMayService = new XeMayService();
            LoadSoLuong();
            Loaddata();
            Loc();
        }
        public void LoadSoLuong()
        {
            for (int i = 0; i < 50; i++)
            {
                cmb_SoLuong.Items.Add(i);
            }
            cmb_SoLuong.SelectedIndex = 0;
        }
        public void Loc()
        {
            List<string> _lst = new List<string>() { "Lọc số lượng" };
            foreach (var x in _lst)
            {
                cmb_Loc.Items.Add(x);
            }
            
        }
        public void Loaddata()
        {
            dgrid_Load.ColumnCount = 4;
            dgrid_Load.Columns[0].Name = "Mã";
            dgrid_Load.Columns[1].Name = "Tên";
            dgrid_Load.Columns[2].Name = "Số Lượng";
            dgrid_Load.Columns[3].Name = "Trạng Thái";
            dgrid_Load.Rows.Clear();
            foreach (var x in _xeMayService.GetAll())
            {
                dgrid_Load.Rows.Add(x.Ma, x.Ten, x.SoLuong, x.TrangThai == 1 ? "Hoạt Động" : "Không hoạt động");
            }
        }
        private XeMay GetDataFromGui()
        {
            return new XeMay()
            {
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
                SoLuong = Convert.ToInt32(cmb_SoLuong.Text),
                TrangThai = 1
            };
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_xeMayService.Add(GetDataFromGui()));
            Loaddata();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_xeMayService.Update(GetDataFromGui()));
           Loaddata();
        }

        private void dgrid_Load_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgrid_Load_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            txt_Ma.Text = dgrid_Load.Rows[a].Cells[0].Value.ToString();
            txt_Ten.Text = dgrid_Load.Rows[a].Cells[1].Value.ToString();
            cmb_SoLuong.Text = dgrid_Load.Rows[a].Cells[2].Value.ToString();
        }
        public void Loadloc()
        {
            dgrid_Load.ColumnCount = 4;
            dgrid_Load.Columns[0].Name = "Mã";
            dgrid_Load.Columns[1].Name = "Tên";
            dgrid_Load.Columns[2].Name = "Số Lượng";
            dgrid_Load.Columns[3].Name = "Trạng Thái";
            dgrid_Load.Rows.Clear();
            foreach (var x in _xeMayService.GetAll().Where(c=>c.SoLuong<100))
            {
                dgrid_Load.Rows.Add(x.Ma, x.Ten, x.SoLuong, x.TrangThai == 1 ? "Hoạt Động" : "Không hoạt động");
            }
        }

        private void cmb_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Loc.Text== "Lọc số lượng")
            {
                Loadloc();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_xeMayService.Delete(GetDataFromGui()));
            Loaddata();
        }
    }
}
