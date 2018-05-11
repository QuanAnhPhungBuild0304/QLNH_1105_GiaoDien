namespace NHAHANG_RIENG
{
    partial class DoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btThongke = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_out = new System.Windows.Forms.DateTimePicker();
            this.dtp_in = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThongke = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbTrangHientai = new System.Windows.Forms.TextBox();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btQuaylai = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTongthuThucte = new System.Windows.Forms.TextBox();
            this.txbLuotkhach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTongthuHoadon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN_HOADON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN_THANHTOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECHECKIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECHECKOUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThongke
            // 
            this.btThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongke.Location = new System.Drawing.Point(721, 18);
            this.btThongke.Margin = new System.Windows.Forms.Padding(4);
            this.btThongke.Name = "btThongke";
            this.btThongke.Size = new System.Drawing.Size(135, 47);
            this.btThongke.TabIndex = 4;
            this.btThongke.Text = "Thống kê";
            this.btThongke.UseVisualStyleBackColor = true;
            this.btThongke.Click += new System.EventHandler(this.btThongke_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(537, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ:";
            // 
            // dtp_out
            // 
            this.dtp_out.CustomFormat = "dd/MM/yyyy";
            this.dtp_out.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_out.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_out.Location = new System.Drawing.Point(596, 28);
            this.dtp_out.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_out.Name = "dtp_out";
            this.dtp_out.Size = new System.Drawing.Size(117, 27);
            this.dtp_out.TabIndex = 1;
            // 
            // dtp_in
            // 
            this.dtp_in.CustomFormat = "dd/MM/yyyy ";
            this.dtp_in.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_in.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_in.Location = new System.Drawing.Point(367, 29);
            this.dtp_in.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_in.Name = "dtp_in";
            this.dtp_in.Size = new System.Drawing.Size(117, 27);
            this.dtp_in.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thống kê doanh thu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btThongke);
            this.groupBox1.Controls.Add(this.dtp_out);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_in);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1067, 81);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn khoảng thời gian";
            // 
            // dgvThongke
            // 
            this.dgvThongke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME,
            this.TONGTIEN_HOADON,
            this.TONGTIEN_THANHTOAN,
            this.GIAMGIA,
            this.DATECHECKIN,
            this.DATECHECKOUT});
            this.dgvThongke.Location = new System.Drawing.Point(10, 23);
            this.dgvThongke.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongke.Name = "dgvThongke";
            this.dgvThongke.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvThongke.Size = new System.Drawing.Size(1055, 206);
            this.dgvThongke.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbTrangHientai);
            this.groupBox2.Controls.Add(this.btnSau);
            this.groupBox2.Controls.Add(this.btnTruoc);
            this.groupBox2.Controls.Add(this.btnCuoi);
            this.groupBox2.Controls.Add(this.btnDau);
            this.groupBox2.Controls.Add(this.dgvThongke);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 200);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1067, 293);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng dữ liệu";
            // 
            // txbTrangHientai
            // 
            this.txbTrangHientai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTrangHientai.Location = new System.Drawing.Point(503, 256);
            this.txbTrangHientai.Margin = new System.Windows.Forms.Padding(4);
            this.txbTrangHientai.Name = "txbTrangHientai";
            this.txbTrangHientai.ReadOnly = true;
            this.txbTrangHientai.Size = new System.Drawing.Size(48, 26);
            this.txbTrangHientai.TabIndex = 8;
            this.txbTrangHientai.Text = "1";
            this.txbTrangHientai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbTrangHientai.TextChanged += new System.EventHandler(this.txbTrangHientai_TextChanged);
            // 
            // btnSau
            // 
            this.btnSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSau.Location = new System.Drawing.Point(960, 253);
            this.btnSau.Margin = new System.Windows.Forms.Padding(4);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(45, 32);
            this.btnSau.TabIndex = 9;
            this.btnSau.Text = ">>";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc.Location = new System.Drawing.Point(907, 253);
            this.btnTruoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(45, 32);
            this.btnTruoc.TabIndex = 12;
            this.btnTruoc.Text = "<<";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoi.Location = new System.Drawing.Point(1014, 253);
            this.btnCuoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(40, 32);
            this.btnCuoi.TabIndex = 11;
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnDau
            // 
            this.btnDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau.Location = new System.Drawing.Point(856, 253);
            this.btnDau.Margin = new System.Windows.Forms.Padding(4);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(43, 32);
            this.btnDau.TabIndex = 10;
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btQuaylai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 100);
            this.panel1.TabIndex = 10;
            // 
            // btQuaylai
            // 
            this.btQuaylai.BackgroundImage = global::NHAHANG_RIENG.Properties.Resources.back;
            this.btQuaylai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btQuaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuaylai.Location = new System.Drawing.Point(13, 11);
            this.btQuaylai.Margin = new System.Windows.Forms.Padding(4);
            this.btQuaylai.Name = "btQuaylai";
            this.btQuaylai.Size = new System.Drawing.Size(99, 52);
            this.btQuaylai.TabIndex = 5;
            this.btQuaylai.UseVisualStyleBackColor = true;
            this.btQuaylai.Click += new System.EventHandler(this.btQuaylai_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txbTongthuThucte);
            this.groupBox3.Controls.Add(this.txbLuotkhach);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txbTongthuHoadon);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 517);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1067, 86);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(657, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tổng thu thực tế";
            // 
            // txbTongthuThucte
            // 
            this.txbTongthuThucte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongthuThucte.Location = new System.Drawing.Point(664, 47);
            this.txbTongthuThucte.Margin = new System.Windows.Forms.Padding(4);
            this.txbTongthuThucte.Name = "txbTongthuThucte";
            this.txbTongthuThucte.ReadOnly = true;
            this.txbTongthuThucte.Size = new System.Drawing.Size(180, 30);
            this.txbTongthuThucte.TabIndex = 10;
            this.txbTongthuThucte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbLuotkhach
            // 
            this.txbLuotkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLuotkhach.Location = new System.Drawing.Point(195, 47);
            this.txbLuotkhach.Margin = new System.Windows.Forms.Padding(4);
            this.txbLuotkhach.Name = "txbLuotkhach";
            this.txbLuotkhach.ReadOnly = true;
            this.txbLuotkhach.Size = new System.Drawing.Size(111, 30);
            this.txbLuotkhach.TabIndex = 8;
            this.txbLuotkhach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lượt khách";
            // 
            // txbTongthuHoadon
            // 
            this.txbTongthuHoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongthuHoadon.Location = new System.Drawing.Point(375, 47);
            this.txbTongthuHoadon.Margin = new System.Windows.Forms.Padding(4);
            this.txbTongthuHoadon.Name = "txbTongthuHoadon";
            this.txbTongthuHoadon.ReadOnly = true;
            this.txbTongthuHoadon.Size = new System.Drawing.Size(199, 30);
            this.txbTongthuHoadon.TabIndex = 9;
            this.txbTongthuHoadon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng tiền hóa đơn";
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.DefaultCellStyle = dataGridViewCellStyle7;
            this.NAME.HeaderText = "TÊN BÀN";
            this.NAME.Name = "NAME";
            // 
            // TONGTIEN_HOADON
            // 
            this.TONGTIEN_HOADON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TONGTIEN_HOADON.DataPropertyName = "TONGTIEN_HOADON";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TONGTIEN_HOADON.DefaultCellStyle = dataGridViewCellStyle8;
            this.TONGTIEN_HOADON.HeaderText = "TỔNG TIỀN HÓA ĐƠN";
            this.TONGTIEN_HOADON.Name = "TONGTIEN_HOADON";
            // 
            // TONGTIEN_THANHTOAN
            // 
            this.TONGTIEN_THANHTOAN.DataPropertyName = "TONGTIEN_THANHTOAN";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TONGTIEN_THANHTOAN.DefaultCellStyle = dataGridViewCellStyle9;
            this.TONGTIEN_THANHTOAN.HeaderText = "TỔNG TIỀN THANH TOÁN";
            this.TONGTIEN_THANHTOAN.Name = "TONGTIEN_THANHTOAN";
            this.TONGTIEN_THANHTOAN.Width = 180;
            // 
            // GIAMGIA
            // 
            this.GIAMGIA.DataPropertyName = "GIAMGIA";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIAMGIA.DefaultCellStyle = dataGridViewCellStyle10;
            this.GIAMGIA.HeaderText = "GIẢM GIÁ (%)";
            this.GIAMGIA.Name = "GIAMGIA";
            this.GIAMGIA.Width = 120;
            // 
            // DATECHECKIN
            // 
            this.DATECHECKIN.DataPropertyName = "DATECHECKIN";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATECHECKIN.DefaultCellStyle = dataGridViewCellStyle11;
            this.DATECHECKIN.HeaderText = "BẮT ĐẦU";
            this.DATECHECKIN.Name = "DATECHECKIN";
            this.DATECHECKIN.Width = 120;
            // 
            // DATECHECKOUT
            // 
            this.DATECHECKOUT.DataPropertyName = "DATECHECKOUT";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATECHECKOUT.DefaultCellStyle = dataGridViewCellStyle12;
            this.DATECHECKOUT.HeaderText = "KẾT THÚC";
            this.DATECHECKOUT.Name = "DATECHECKOUT";
            this.DATECHECKOUT.Width = 120;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 603);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_in;
        private System.Windows.Forms.Button btThongke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_out;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btQuaylai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThongke;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbTrangHientai;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbTongthuThucte;
        private System.Windows.Forms.TextBox txbLuotkhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTongthuHoadon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN_HOADON;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN_THANHTOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECHECKIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECHECKOUT;
    }
}