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
        private SachService sachService;
        public Form1()
        {
            InitializeComponent();
            sachService = new SachService();
            LoadSoTrang();
            LoadData();
            LoadLoc();
        }
        public void LoadSoTrang()
        {
            for (int i = 0; i < 201; i++)
            {
                cmb_SoTrang.Items.Add(i);
            }
            cmb_SoTrang.SelectedIndex = 0;
        }
        public void LoadLoc()
        {
            List<string> lst= new List<string>()
            {
                "Lọc số trang 90","Lọc số trang 190"
            };
            foreach (var x in lst)
            {
                cmb_Loc.Items.Add(x);
            }
        }
        public void LoadData()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Mã";
            dataGridView1.Columns[1].Name = "Tên";
            dataGridView1.Columns[2].Name = "Số Trang";
            dataGridView1.Columns[3].Name = "Trạng Thái";
            dataGridView1.Rows.Clear();
            foreach (var x in sachService.GetAll())
            {
                dataGridView1.Rows.Add(x.Ma, x.Ten, x.SoTrang, x.TrangThai == 1 ? "Hoạt Động" : "Không hoạt động");
            }
        }
        public Sach GetDataFromGui()
        {
            return new Sach()
            {
                Ma= txt_Ma.Text,
                Ten = txt_Ten.Text,
                SoTrang= Int32.Parse(cmb_SoTrang.Text),
                TrangThai = 1
            };
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txt_Ma.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txt_Ten.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            cmb_SoTrang.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sachService.Add(GetDataFromGui()));
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sachService.Update(GetDataFromGui()));
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sachService.Delete(GetDataFromGui()));
            LoadData();
        }
        public void LoadLoc90()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Mã";
            dataGridView1.Columns[1].Name = "Tên";
            dataGridView1.Columns[2].Name = "Số Trang";
            dataGridView1.Columns[3].Name = "Trạng Thái";
            dataGridView1.Rows.Clear();
            foreach (var x in sachService.GetAll().Where(c=>c.SoTrang<90))
            {
                dataGridView1.Rows.Add(x.Ma, x.Ten, x.SoTrang, x.TrangThai == 1 ? "Hoạt Động" : "Không hoạt động");
            }
        }
        public void LoadLoc190()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Mã";
            dataGridView1.Columns[1].Name = "Tên";
            dataGridView1.Columns[2].Name = "Số Trang";
            dataGridView1.Columns[3].Name = "Trạng Thái";
            dataGridView1.Rows.Clear();
            foreach (var x in sachService.GetAll().Where(c=>c.SoTrang<190))
            {
                dataGridView1.Rows.Add(x.Ma, x.Ten, x.SoTrang, x.TrangThai == 1 ? "Hoạt Động" : "Không hoạt động");
            }
        }

        private void cmb_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Loc.Text == "Lọc số trang 90")
            {
                LoadLoc90();
            }
            if (cmb_Loc.Text == "Lọc số trang 190")
            {
                LoadLoc190();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn Clear?", "Thông báo", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                txt_Ma.Text = "";
                txt_Ten.Text = "";
                cmb_SoTrang.Text = "";
            }
            if (dialogResult == DialogResult.No) return;
        }
    }
}
