using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace ConvenientStore_Pro
{
    public partial class frm_Product : Form
    {
        private string queryProductType = "";
        public frm_Product()
        {
            InitializeComponent();
            LoadProductType();
        }
        private void LoadProductType()
        {
            ProductTypeBUS productTypeTable = new ProductTypeBUS();
            dgvProductType.DataSource = productTypeTable.GetData();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void ControlButton(int type)
        {
            btAdd.Visible = type == 1 ? true : false;
            btSua.Visible = type == 1 ? true : false;
            btXoa.Visible = type == 1 ? true : false;

            btLuu.Visible = type == 2 ? true : false;
            btHuy.Visible = type == 2 ? true : false;

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            queryProductType = "edit";
            ControlButton(2);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            queryProductType = "delete";
            ExcuteProductType(queryProductType);
            ProductTypeField();

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            queryProductType = "add";
            ControlButton(2);
            ProductTypeField();
        }
        private void ProductTypeField()
        {
            txtMaCategory.Text = "";
            txtTenCategory.Text = "";
            txtMoTaCategory.Text = "";
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            ControlButton(1);
            ExcuteProductType(queryProductType);
            
        }
        private void ExcuteProductType(string query)
        {
            string txtTenCategory = this.txtTenCategory.Text.Trim();
            string txtMoTaCategory = this.txtMoTaCategory.Text.Trim();
            string maCategory = this.txtMaCategory.Text.Trim();
            ProductTypeBUS productTypeBUS = new ProductTypeBUS();

            if (queryProductType == "add")
            {

                if (txtTenCategory == "")
                {
                    DialogResult result = MessageBox.Show("Nhap Ten!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                bool check = productTypeBUS.checkName(txtTenCategory);

                if (check == false)
                {
                    DialogResult result = MessageBox.Show("Ten bi trung!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ProductType objProductType = new ProductType(txtTenCategory, txtMoTaCategory);

                productTypeBUS.Insert(objProductType);
                LoadProductType();
            }
            else if(queryProductType == "edit")
            {
                if (txtTenCategory == "")
                {
                    MessageBox.Show("Nhap Ten!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ProductType objProductType = new ProductType(Int32.Parse(maCategory),txtTenCategory, txtMoTaCategory);

                productTypeBUS.Update(objProductType);
                LoadProductType();
            }
            else if (queryProductType == "delete")
            {
                DialogResult dialogResult = MessageBox.Show("Xóa", "Bạn muốn xóa?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    productTypeBUS.Delete(Int32.Parse(maCategory));
                    LoadProductType();
                }
            }
            else
            {
                if (txtTimType.Text == "")
                {
                    MessageBox.Show("Nhap Ten hoac ma!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgvProductType.DataSource = productTypeBUS.FindItems(txtTimType.Text);

            }

        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            ControlButton(1);
        }

        private void txtTenCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProductType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            queryProductType = "search";
            ExcuteProductType(queryProductType);
        }

        private void dgvProductType_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            txtMaCategory.Text = dgvProductType["MaID", rowindex].Value.ToString();
            txtTenCategory.Text = dgvProductType["ProductTypeName", rowindex].Value.ToString();
            txtMoTaCategory.Text = dgvProductType["Describe", rowindex].Value.ToString();
        }

        private void dgvProductType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btXemProductType_Click(object sender, EventArgs e)
        {
            LoadProductType();
        }
    }
}
