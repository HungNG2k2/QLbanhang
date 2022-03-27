namespace QL_BanHang
{
    partial class frmMain
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
            this.butKhachHang = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butHangHoa = new System.Windows.Forms.Button();
            this.butHoaDon = new System.Windows.Forms.Button();
            this.butNhanVien = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butKhachHang
            // 
            this.butKhachHang.Location = new System.Drawing.Point(388, 3);
            this.butKhachHang.Name = "butKhachHang";
            this.butKhachHang.Size = new System.Drawing.Size(380, 186);
            this.butKhachHang.TabIndex = 0;
            this.butKhachHang.Text = "Khach hang";
            this.butKhachHang.UseVisualStyleBackColor = true;
            this.butKhachHang.Click += new System.EventHandler(this.butKhachHang_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.butKhachHang, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.butHangHoa, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.butHoaDon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.butNhanVien, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(771, 385);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // butHangHoa
            // 
            this.butHangHoa.Location = new System.Drawing.Point(388, 195);
            this.butHangHoa.Name = "butHangHoa";
            this.butHangHoa.Size = new System.Drawing.Size(380, 186);
            this.butHangHoa.TabIndex = 0;
            this.butHangHoa.Text = "Hang hoa";
            this.butHangHoa.UseVisualStyleBackColor = true;
            this.butHangHoa.Click += new System.EventHandler(this.butHangHoa_Click);
            // 
            // butHoaDon
            // 
            this.butHoaDon.Location = new System.Drawing.Point(3, 195);
            this.butHoaDon.Name = "butHoaDon";
            this.butHoaDon.Size = new System.Drawing.Size(379, 186);
            this.butHoaDon.TabIndex = 0;
            this.butHoaDon.Text = "Hoa don";
            this.butHoaDon.UseVisualStyleBackColor = true;
            this.butHoaDon.Click += new System.EventHandler(this.butHoaDon_Click);
            // 
            // butNhanVien
            // 
            this.butNhanVien.Location = new System.Drawing.Point(3, 3);
            this.butNhanVien.Name = "butNhanVien";
            this.butNhanVien.Size = new System.Drawing.Size(379, 186);
            this.butNhanVien.TabIndex = 0;
            this.butNhanVien.Text = "Nhan vien";
            this.butNhanVien.UseVisualStyleBackColor = true;
            this.butNhanVien.Click += new System.EventHandler(this.butNhanVien_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 385);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butKhachHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button butHangHoa;
        private System.Windows.Forms.Button butHoaDon;
        private System.Windows.Forms.Button butNhanVien;
    }
}

