using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BUS;
using DTO;

namespace ConvenientStore_Pro
{
    public partial class frm_Customer : Form
    {
        private string Query = "";
        public frm_Customer()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ControlButton(1);
        }

        private void frm_Customer_Load(object sender, EventArgs e)
        {
            LoadData();
            ControlButton(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Query = "add";
            ControlButton(2);
            txMa.Text = "";
            txTen.Text = "";
            txDiaChi.Text = "";
            txSDT.Text = "";
        }

        private bool checkCus(string makh, string tenKh, string Sdt)
        {
            if (makh == "")
            {
                DialogResult result = MessageBox.Show("Nhap ma KH!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (tenKh == "")
            {
                DialogResult result = MessageBox.Show("Nhap ten KH!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Sdt == "")
            {
                DialogResult result = MessageBox.Show("Nhap SDT KH!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Excute(string query)
        {
            if(query == "add")
            {
                try
                {
                    string makh = txMa.Text.Trim();
                    string tenKh = txTen.Text.Trim();
                    string diaChikh = txDiaChi.Text.Trim();
                    string Sdt = txSDT.Text.Trim();

                    
                    bool _checkCuss = checkCus(makh, tenKh, Sdt);
                    if (_checkCuss == false) return;

                    CustomerBUS customerBUS = new CustomerBUS();
                    bool check = customerBUS.checkCode(txMa.Text);

                    if (check == false)
                    {
                        DialogResult result = MessageBox.Show("Ma KH bi trung!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Customer objCustomer = new Customer();
                    objCustomer.cusCode = makh;
                    objCustomer.cusName = tenKh;
                    objCustomer.Address = diaChikh;
                    objCustomer.SDT = Sdt;

                    customerBUS.Insert(objCustomer);
                    LoadData();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            if (query == "edit")
            {
                try
                {
                    ControlButton(2);
                    string makh = txMa.Text.Trim();
                    string tenKh = txTen.Text.Trim();
                    string diaChikh = txDiaChi.Text.Trim();
                    string Sdt = txSDT.Text.Trim();

                    CustomerBUS customerBUS = new CustomerBUS();
                    bool _checkCuss = checkCus(makh, tenKh, Sdt);
                    if (_checkCuss == false) return;

                    Customer objCustomer = new Customer();
                    objCustomer.cusCode = makh;
                    objCustomer.cusName = tenKh;
                    objCustomer.Address = diaChikh;
                    objCustomer.SDT = Sdt;

                    customerBUS.Update(objCustomer);

                    LoadData();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            if (query == "delete")
            {
                try
                {
                    ControlButton(2);
                    string _MaKH = txMa.Text.Trim();
                    CustomerBUS customerTable = new CustomerBUS();
                    customerTable.Delete(_MaKH);
                    LoadData();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void LoadData()
        {
            CustomerBUS customerTable = new CustomerBUS();
            dataGridView1.DataSource = customerTable.GetData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Query = "delete";
            ControlButton(2);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Query = "edit";
            ControlButton(2);
            txMa.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txMa.Text = dataGridView1["Makh", index].Value.ToString();
            txTen.Text = dataGridView1["Tenkh", index].Value.ToString();
            txDiaChi.Text = dataGridView1["Diachi", index].Value.ToString();
            txSDT.Text = dataGridView1["Sdt", index].Value.ToString();
        }
        private void ControlButton(int type)
        {
            btAdd.Visible = type == 1 ? true : false;
            btSua.Visible = type == 1 ? true : false;
            btXoa.Visible = type == 1 ? true : false;

            btLuu.Visible = type == 2 ? true : false;
            btHuy.Visible = type == 2 ? true : false;

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            Excute(Query);
            ControlButton(1);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string _item = txTim.Text.Trim();
            CustomerBUS customerBUS = new CustomerBUS();
            dataGridView1.DataSource = customerBUS.FindItems(_item);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
