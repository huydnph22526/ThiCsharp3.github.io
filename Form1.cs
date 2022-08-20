using Project_Template_SM22_Csharp.DomainClass;
using Project_Template_SM22_Csharp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Template_SM22_Csharp.Views
{
    public partial class Form1 : Form
    {
        private SanPhamService sanPhamService;
        public Form1()
        {
            InitializeComponent();
            sanPhamService = new SanPhamService();
            LoadGia();
            LoadWeb();
            LoadData();
        }
        public void LoadGia()
        {
            foreach (var x in sanPhamService.GetAll())
            {
                cmb_Gia.Items.Add(x.GiaBan);
            }
            cmb_Gia.SelectedIndex = 0;
        }
        public void LoadWeb()
        {
            foreach (var x in sanPhamService.GetAll())
            {
                cmb_Website.Items.Add(x.Website);
            }
            
        }
        public void LoadData()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name ="Mã";
            dataGridView1.Columns[1].Name ="Tên";
            dataGridView1.Columns[2].Name ="Giá";
            dataGridView1.Columns[3].Name ="Trạng Thái";
            dataGridView1.Columns[4].Name ="Website";
            dataGridView1.Rows.Clear();
            foreach (var x in sanPhamService.GetAll())
            {
                dataGridView1.Rows.Add(x.Ma, x.Ten, x.GiaBan, x.TrangThai == 1 ? "Hoạt Động" : "Không hoạt động", x.Website);
            }
        }
        public SanPham GetDataFromGui()
        {
            return new SanPham()
            {
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
                GiaBan = Int32.Parse(cmb_Gia.Text),
                TrangThai = 1,
                Website = cmb_Website.Text
            };
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txt_Ma.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txt_Ten.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            cmb_Gia.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            rbtn_HoatDong.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            rbtn_KoHoatDong.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            cmb_Website.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sanPhamService.Add(GetDataFromGui()));
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sanPhamService.Update(GetDataFromGui()));
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sanPhamService.Delete(GetDataFromGui()));
            LoadData();
        }
    }
}
