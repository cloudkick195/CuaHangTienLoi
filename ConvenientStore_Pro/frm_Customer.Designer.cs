namespace ConvenientStore_Pro
{
    partial class frm_Customer
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoaiNV = new System.Windows.Forms.ComboBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txMa = new System.Windows.Forms.TextBox();
            this.txTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txTim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoaiNV);
            this.groupBox1.Controls.Add(this.btLuu);
            this.groupBox1.Controls.Add(this.btHuy);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.txSDT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txDiaChi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txMa);
            this.groupBox1.Controls.Add(this.txTen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "-r";
            // 
            // LoaiNV
            // 
            this.LoaiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiNV.FormattingEnabled = true;
            this.LoaiNV.Location = new System.Drawing.Point(170, 163);
            this.LoaiNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoaiNV.Name = "LoaiNV";
            this.LoaiNV.Size = new System.Drawing.Size(181, 28);
            this.LoaiNV.TabIndex = 3;
            this.LoaiNV.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(148, 359);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(94, 33);
            this.btLuu.TabIndex = 2;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(256, 359);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(94, 33);
            this.btHuy.TabIndex = 2;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.button5_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(254, 309);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(96, 33);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txSDT
            // 
            this.txSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSDT.Location = new System.Drawing.Point(107, 133);
            this.txSDT.Name = "txSDT";
            this.txSDT.Size = new System.Drawing.Size(243, 26);
            this.txSDT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại";
            // 
            // txDiaChi
            // 
            this.txDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDiaChi.Location = new System.Drawing.Point(107, 101);
            this.txDiaChi.Name = "txDiaChi";
            this.txDiaChi.Size = new System.Drawing.Size(243, 26);
            this.txDiaChi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // txMa
            // 
            this.txMa.Enabled = false;
            this.txMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMa.Location = new System.Drawing.Point(106, 37);
            this.txMa.Name = "txMa";
            this.txMa.Size = new System.Drawing.Size(243, 26);
            this.txMa.TabIndex = 1;
            this.txMa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txTen
            // 
            this.txTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTen.Location = new System.Drawing.Point(107, 69);
            this.txTen.Name = "txTen";
            this.txTen.Size = new System.Drawing.Size(243, 26);
            this.txTen.TabIndex = 1;
            this.txTen.TextChanged += new System.EventHandler(this.txTen_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên KH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.txTim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btTim);
            this.groupBox2.Location = new System.Drawing.Point(379, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 410);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lí khách hàng";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(232, 359);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(94, 33);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Makh,
            this.Tenkh,
            this.Diachi,
            this.Sdt});
            this.dataGridView1.Location = new System.Drawing.Point(9, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 262);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // Makh
            // 
            this.Makh.DataPropertyName = "CustomerCode";
            this.Makh.HeaderText = "Ma KH";
            this.Makh.Name = "Makh";
            // 
            // Tenkh
            // 
            this.Tenkh.DataPropertyName = "customerName";
            this.Tenkh.HeaderText = "Ten KH";
            this.Tenkh.Name = "Tenkh";
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Address";
            this.Diachi.HeaderText = "Dia chi";
            this.Diachi.Name = "Diachi";
            // 
            // Sdt
            // 
            this.Sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sdt.DataPropertyName = "SDT";
            this.Sdt.HeaderText = "SDT";
            this.Sdt.Name = "Sdt";
            // 
            // txTim
            // 
            this.txTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTim.Location = new System.Drawing.Point(96, 37);
            this.txTim.Name = "txTim";
            this.txTim.Size = new System.Drawing.Size(243, 26);
            this.txTim.TabIndex = 1;
            this.txTim.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã KH";
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(133, 359);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(94, 33);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(361, 35);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(96, 33);
            this.btTim.TabIndex = 2;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frm_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Customer";
            this.Text = "frm_Customer";
            this.Load += new System.EventHandler(this.frm_Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txTim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.ComboBox LoaiNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txMa;
        private System.Windows.Forms.Label label8;
    }
}