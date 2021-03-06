﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace ConvenientStore_Pro
{
    public partial class frm_Main : Form
    {
        frm_SignOn SignOn;
        frm_SignOff signOff;
        frm_Customer frm_Customer;
        frm_Product frm_Product;
        frm_Sum Sum;
        frm_Product pro;
        ScannerBUS Scanner;
        SignOnBUS SignBus;
        Tender_CusBUS Tender_CusBUS;
        String barcode="";
        TreeNode treeNode;
        String cusCode="";
        String cusName = "";
        bool Test = false;
        double Funds = 0;
        double Tendered = 0;
        double Cash = 0;
        double Cre = 0;
        int stepLogin = 0;
        int supperTotal = 0;
        public string EmployeeName { get; set; }
        public frm_Main()
        {
            InitializeComponent();
            Scanner = new ScannerBUS();
            SignBus = new SignOnBUS();
            SignOn = new frm_SignOn();
            signOff = new frm_SignOff();
            frm_Customer = new frm_Customer();
            frm_Product = new frm_Product();
            Sum = new frm_Sum();
            Tender_CusBUS = new Tender_CusBUS();
            UC_SignOn.Instance.btn_SignOn.Click += Btn_SignOn_Click;
            UC_Tool.Instance.btn_Off.Click += Btn_Off_Click;
            UC_Tool.Instance.btCustomer.Click += Btn_Cus_Click;
            UC_Tool.Instance.btProduct.Click += btProduct_Click;
        }
        private void Btn_Can_Click(object sender, EventArgs e)
        {
            sC_Tool2.Panel2.Controls.Add(UC_Tool.Instance); 
            lb_Note.Text = "Please scan barcode or input from keyboard";
            Barcode_textBox.Focus();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; //Tao doi tuong button cua chinh no
            Barcode_textBox.Text += btn.Text;
        }

        private void Enter_btn_Click(object sender, EventArgs e)
        {
            if (lb_Note.Text == "Vui lòng nhập barcode")
                Enter_btn_Tool();
            else if (lb_Note.Text == "Vui lòng nhập ID?")
                Enter_btn_ID();
            else if (lb_Note.Text == "Vui lòng nhập mật khẩu")
                Enter_btn_Pass();
            else if (lb_Note.Text == "Enter Customer Code or Click Skip")
                Enter_btn_TenderCus();
            else if (lb_Note.Text == "Enter Customer's Cash")
                Enter_ChangeDue();
        }
        private void Enter_btn_ID()
        {
            barcode = Barcode_textBox.Text;
            try
            {
                EmployeeName = SignBus.getNameID(barcode);
                Test = SignBus.SignOn_ID(barcode);
                SignOn.lb_Employee.Text = "#Nhân viên: " + EmployeeName;
                if (Test == true)
                {

                    Barcode_textBox.Text = null;
                    lb_Note.Text = "Plese input password";
                    Barcode_textBox.PasswordChar = '*';
                    stepLogin = 2;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Your ID is wrong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                        Barcode_textBox.Text = null;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu\n" + ex.Message, "Connection Failed");
            }
        }
        private void Enter_btn_Pass()
        {
            barcode = Barcode_textBox.Text;
            try
            {
                Test = SignBus.SignOn_Pass(barcode);
                if (Test == true)
                {
                    Barcode_textBox.Text = null;
                    this.Enabled = false;
                    SignOn.ShowDialog();
                    if (SignOn.DialogResult == DialogResult.OK)
                    {
                        this.Enabled = true;
                        sC_Tool2.Panel2.Controls.Add(UC_Tool.Instance);
                        sC_Tool2.Panel2.Controls.Remove(UC_SignOn.Instance);
                        UC_Tool.Instance.Dock = DockStyle.Fill;
                        lb_Note.Text = "Please scan barcode or input from keyboard";
                        Barcode_textBox.PasswordChar = '\0';
                        Funds = SignOn.Funds;
                        btSearchProduct.Visible = true;
                    }
                    else if (SignOn.DialogResult == DialogResult.Cancel)
                    {
                        //frm_Sign.Close();
                        this.Enabled = true;
                        lb_Note.Text = "Choose Sign ON button to enter the system or Exit button to exit";
                        sC_Tool2.Panel2.Controls.Add(UC_SignOn.Instance);
                        UC_SignOn.Instance.Dock = DockStyle.Fill;
                        Barcode_textBox.PasswordChar = '\0';
                    }
                }
                else
                {

                    DialogResult result = MessageBox.Show("Your password is wrong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                        Barcode_textBox.Text = null;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu\n" + ex.Message, "Connection Failed");
            }
        }
        private void Enter_btn_Tool()
        {
            try
            {
                barcode = Barcode_textBox.Text;
                Test = Scanner.GetBarcode(barcode);
                if (Test == true)
                {

                }
                else //if(Test==false || Barcode_textBox.Text=="")
                {
                    sC_Tool2.Panel2.Controls.Remove(UC_Tool.Instance);
                    Unknow();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu\n" + ex.Message, "Connection Failed");
            }
            //b = Scanner.GetBarcode(barcode);
        }
        public void Unknow()
        {
            Barcode_textBox.Text = null;
            lb_Note.Text = "Unknow Code\n" +
                "Plese enter different one";
        }
        private void Enter_btn_TenderCus()
        {
            cusCode = Barcode_textBox.Text;
            try
            {
                cusName = Tender_CusBUS.GetCustomer(cusCode).cusName;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu\n" + ex.Message, "Connection Failed");
            }
            if (cusName != "")
            {
                lbTendered.TextAlign = ContentAlignment.TopRight;
                lbTendered.Text = "Tendered: " +Tendered.ToString("###,###") + "\nKhách hàng: " + cusName + "\n MÃ KH: " + cusCode;
                lb_Note.Text = "Please choose one tender-method";
                Barcode_textBox.Text = Tendered.ToString("###,###");
                Barcode_textBox.Focus();
            }
            else
            {
                Unknow();
            }
        }
        private void Btn_OK_Tool_Click(object sender, EventArgs e)
        {
            Barcode_textBox.Text = "";
            sC_Tool2.Panel2.Controls.Add(UC_Tool.Instance);
            UC_Tool.Instance.Dock = DockStyle.Fill;
            lb_Note.Text = "Please scan barcode or input from keyboard";
            Barcode_textBox.Focus();
        }
        private void Enter_ChangeDue()
        {
            double ChangeDue = 0;
            double Cash = double.Parse(Barcode_textBox.Text);
            if (Cash < Tendered)
            {
                MessageBox.Show("Số tiền không được nhỏ hơn giá tiền", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Barcode_textBox.Focus();
            }
            else
            {
                if (Cash == Tendered)
                    Barcode_textBox.Text = "0";
                else
                {
                    ChangeDue = Cash - Tendered;
                    lb_Note.Text = "Change Due";
                    Barcode_textBox.Text = ChangeDue.ToString("###,###");
                }
                treeView1.Nodes.Clear();
                treeNode = null;
                Tendered = 0;
                lbTendered.Text = "Tender:   "; 
            }
        }
        private void Bksp_btn_Click(object sender, EventArgs e)
        {
            if (Barcode_textBox.Text != "")//o barcode khong rong
                Barcode_textBox.Text = Barcode_textBox.Text.Substring(0, Barcode_textBox.Text.Length - 1);
            else//o bracode rong
                return;
        }
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Barcode_textBox.Text = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (SignOn.DialogResult==DialogResult.OK)
                infor_label.Text = dt.ToString("HH:mm:ss -- dd/MM/yyyy\n" + EmployeeName);
            else
                infor_label.Text = dt.ToString("HH:mm:ss -- dd/MM/yyyy"); 
        }

        private void frm_Main_Shown(object sender, EventArgs e)
        {
            Barcode_textBox.Focus();
            timer1.Start();
        }

        private void Btn_Off_Click(object sender, EventArgs e)
        {
            signOff.ShowDialog();
            if(signOff.DialogResult==DialogResult.OK)
            {
                Sum.ShowDialog();
            }
        }

        private void Btn_Cus_Click(object sender, EventArgs e)
        {
            frm_Customer.ShowDialog();
            if (frm_Customer.DialogResult == DialogResult.OK)
            {
                Sum.ShowDialog();
            }
        }
        private void btProduct_Click(object sender, EventArgs e)
        {
            frm_Product.ShowDialog();
            if (frm_Product.DialogResult == DialogResult.OK)
            {
                frm_Product.ShowDialog();
            }
        }
        private void Btn_SignOn_Click(object sender, EventArgs e)
        {

            Barcode_textBox.Focus();
            lb_Note.Text = "What your ID number?";
            if (stepLogin == 0)
            {
                stepLogin = 1;
                UC_SignOn.Instance.btn_SignOn.Text = "Tiếp tục";
            }
            else if(stepLogin == 1)
            {
                Enter_btn_ID();
            }
            else
            {
                Enter_btn_Pass();
            }
        }
        private void frm_Main_Load(object sender, EventArgs e)
        {
            lb_Note.Text = "Choose Sign ON button to enter the system or Exit button to exit";
            sC_Tool2.Panel2.Controls.Add(UC_SignOn.Instance);
            UC_SignOn.Instance.Dock = DockStyle.Fill;
        }

        private void Barcode_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Barcode_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Barcode_textBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btSearchProduct_Click(object sender, EventArgs e)
        {
            grProducts.Visible = true;
            ProductBUS products = new ProductBUS();
            cbbProducts.DataSource = products.GetListProductByValue(Barcode_textBox.Text);
            cbbProducts.DisplayMember = "ProductName";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            
            string productId = (cbbProducts.SelectedItem as Product).ProductID.ToString();
            string productName = (cbbProducts.SelectedItem as Product).ProductName;
            int amount = (int)numSoLuong.Value;
            int price = (cbbProducts.SelectedItem as Product).Price;
            int subTotal = amount * price;
            string subTotalConvert = subTotal.ToString();
            supperTotal += subTotal;
            item.SubItems.Add(productId);
            item.SubItems.Add(productName);
            item.SubItems.Add(amount.ToString());
            item.SubItems.Add(price.ToString());
            item.SubItems.Add(subTotalConvert);
            lvOrder.Items.Add(item);

            numSoLuong.Value = 1;
            lbThanhTien.Text = supperTotal.ToString();
            grProduct1.Visible = true;
            grProduct2.Visible = true;
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}