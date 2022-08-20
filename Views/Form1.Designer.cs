namespace Project_Template_SM22_Csharp.Views
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.cmb_SoLuong = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.dgrid_Load = new System.Windows.Forms.DataGridView();
            this.cmb_Loc = new System.Windows.Forms.ComboBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Load)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Ma.Location = new System.Drawing.Point(110, 31);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(162, 29);
            this.txt_Ma.TabIndex = 3;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Ten.Location = new System.Drawing.Point(110, 89);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(162, 29);
            this.txt_Ten.TabIndex = 4;
            // 
            // cmb_SoLuong
            // 
            this.cmb_SoLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_SoLuong.FormattingEnabled = true;
            this.cmb_SoLuong.Location = new System.Drawing.Point(110, 140);
            this.cmb_SoLuong.Name = "cmb_SoLuong";
            this.cmb_SoLuong.Size = new System.Drawing.Size(162, 29);
            this.cmb_SoLuong.TabIndex = 5;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.Location = new System.Drawing.Point(400, 35);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(112, 34);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Sua.Location = new System.Drawing.Point(400, 79);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(112, 40);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // dgrid_Load
            // 
            this.dgrid_Load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Load.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_Load.Location = new System.Drawing.Point(0, 175);
            this.dgrid_Load.Name = "dgrid_Load";
            this.dgrid_Load.RowTemplate.Height = 25;
            this.dgrid_Load.Size = new System.Drawing.Size(555, 275);
            this.dgrid_Load.TabIndex = 9;
            this.dgrid_Load.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_Load_CellClick);
            this.dgrid_Load.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_Load_CellContentClick);
            // 
            // cmb_Loc
            // 
            this.cmb_Loc.FormattingEnabled = true;
            this.cmb_Loc.Location = new System.Drawing.Point(396, 133);
            this.cmb_Loc.Name = "cmb_Loc";
            this.cmb_Loc.Size = new System.Drawing.Size(121, 23);
            this.cmb_Loc.TabIndex = 10;
            this.cmb_Loc.SelectedIndexChanged += new System.EventHandler(this.cmb_Loc_SelectedIndexChanged);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Xoa.Location = new System.Drawing.Point(305, 73);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 37);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.cmb_Loc);
            this.Controls.Add(this.dgrid_Load);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cmb_SoLuong);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.txt_Ma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Load)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.ComboBox cmb_SoLuong;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridView dgrid_Load;
        private System.Windows.Forms.ComboBox cmb_Loc;
        private System.Windows.Forms.Button btn_Xoa;
    }
}