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
        private string queryObj = "";

        public frm_Product()
        {
            InitializeComponent();
            LoadProduct();
            LoadProductType();
            LoadSupplier();
            LoadProductTypeCombobox(cbbProductType);
            LoadSupplierCombobox(cbbSupplier);
        }

        private void LoadProduct()
        {
            ProductBUS productTable = new ProductBUS();
            dgvProduct.DataSource = productTable.GetData();
            dgvProduct.AllowUserToAddRows = false;
        }

        private void LoadProductType()
        {
            ProductTypeBUS productTypeTable = new ProductTypeBUS();
            dgvProductType.DataSource = productTypeTable.GetData();
        }

        private void LoadSupplier()
        {
            SupplierBUS supplier = new SupplierBUS();
            dgvSupplier.DataSource = supplier.GetData();
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

        private void ControlButtonProductType(int type)
        {
            btAdd.Visible = type == 1 ? true : false;
            btSua.Visible = type == 1 ? true : false;
            btXoa.Visible = type == 1 ? true : false;

            btLuu.Visible = type == 2 ? true : false;
            btHuy.Visible = type == 2 ? true : false;

        }

        private void ControlButtonProduct(int type)
        {
            btAddProduct.Visible = type == 1 ? true : false;
            btEditProduct.Visible = type == 1 ? true : false;
            btDeleteProduct.Visible = type == 1 ? true : false;

            btSaveProduct.Visible = type == 2 ? true : false;
            btCancelProduct.Visible = type == 2 ? true : false;

        }

        private void ControlButtonSupplier(int type)
        {
            btAddSupplier.Visible = type == 1 ? true : false;
            btEditSupplier.Visible = type == 1 ? true : false;
            btDeleteSupplier.Visible = type == 1 ? true : false;

            btSaveSupplier.Visible = type == 2 ? true : false;
            btCancelSupplier.Visible = type == 2 ? true : false;

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            queryObj = "edit";
            ControlButtonProductType(2);
        }

        private void btEditSupplier_Click(object sender, EventArgs e)
        {
            queryObj = "edit";
            ControlButtonSupplier(2);
        }

        private void btEditProduct_Click(object sender, EventArgs e)
        {
            queryObj = "edit";
            ControlButtonProduct(2);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            queryObj = "delete";
            ExcuteProductType();
            ProductTypeField();

        }

        private void btDeleteSupplier_Click(object sender, EventArgs e)
        {
            queryObj = "delete";
            ExcuteSupplier();
            SupplierField();
        }

        private void btDeleteProduct_Click(object sender, EventArgs e)
        {
            queryObj = "delete";
            ExcuteProduct();
            ProductField();

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            queryObj = "add";
            ControlButtonProductType(2);
            ProductTypeField();
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            queryObj = "add";
            ControlButtonProduct(2);
            ProductField();
        }

        private void btAddSupplier_Click(object sender, EventArgs e)
        {
            queryObj = "add";
            ControlButtonSupplier(2);
            SupplierField();
        }

        private void ProductTypeField()
        {
            txtMaCategory.Text = "";
            txtTenCategory.Text = "";
            txtMoTaCategory.Text = "";
        }

        private void ProductField()
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            cbbProductType.SelectedIndex = -1;
            cbbSupplier.SelectedIndex = -1;
            cbbProductType.SelectedIndex = 0;
            cbbSupplier.SelectedIndex = 0;
            numPrice.Value = 0;
            txtUnit.Text = "";
            numAmount.Value = 0;
            dtpDateManufacture.Value = System.DateTime.Now;
            dtpDateExpiration.Value = System.DateTime.Now.AddDays(1);
        }

        private void SupplierField()
        {
            txtIdSupplier.Text = "";
            txtTenSupplier.Text = "";
            txtEmailSupplier.Text = "";
            txtAddressSupplier.Text = "";
            txtPhoneSupplier.Text = "";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            ControlButtonProductType(1);
            ExcuteProductType();
        }

        private void btSaveSupplier_Click(object sender, EventArgs e)
        {
            ExcuteSupplier();
            ControlButtonSupplier(1);
        }

        private void btSaveProduct_Click(object sender, EventArgs e)
        {
            ControlButtonProduct(1);
            ExcuteProduct();
        }

        private void ExcuteProduct()
        {
            string productID = this.txtProductID.Text.Trim();
            string productName = this.txtProductName.Text.Trim();
            int price = (int)this.numPrice.Value;
            string unit = txtUnit.Text.Trim();
            int amount = (int)this.numAmount.Value;
            int productType = (cbbProductType.SelectedItem as ProductType).productTypeID;
            int supplier = (cbbSupplier.SelectedItem as Supplier).supplierID;
            DateTime dateAdd = DateTime.Now;
            DateTime dateManufacture = dtpDateManufacture.Value;
            DateTime dateExpiration = dtpDateExpiration.Value;
            int sale = (int)this.numAmount.Value;

            ProductBUS productBUS = new ProductBUS();

            if (queryObj == "add")
            {

                if (productName == "")
                {
                    MessageBox.Show("Nhap Ten!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (unit == "")
                {
                    MessageBox.Show("Nhập đơn vi!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int checkdate = DateTime.Compare(dateExpiration, dateManufacture);
                
                if (checkdate <= 0)
                {
                    MessageBox.Show("Ngày hạn sử dụng sau ngày ngày sản xuất!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Product objProduct = new Product(productName, supplier, productType, price, unit, amount, dateAdd, dateManufacture, dateExpiration, sale);

                productBUS.Insert(objProduct);
                LoadProduct();
                MessageBox.Show("Thêm thành công");
            }
            else if (queryObj == "edit")
            {
                if (productName == "")
                {
                    MessageBox.Show("Nhap Ten!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (unit == "")
                {
                    MessageBox.Show("Nhập đơn vi!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Product objProduct = new Product(Int32.Parse(productID), productName, supplier, productType, price, unit, amount, dateAdd, dateManufacture, dateExpiration, sale);

                productBUS.Update(objProduct);
                LoadProduct();
                MessageBox.Show("Sửa thành công");
            }
            else if (queryObj == "delete")
            {
                DialogResult dialogResult = MessageBox.Show("Xóa", "Bạn muốn xóa?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    productBUS.Delete(Int32.Parse(productID));
                    LoadProduct();
                    MessageBox.Show("Xóa thành công");
                }
            }
            else
            {
                if (txtSearchProduct.Text == "")
                {
                    MessageBox.Show("Nhap Ten hoac ma!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgvProduct.DataSource = productBUS.FindItems(txtSearchProduct.Text);

            }

        }

        private void ExcuteProductType()
        {
            string txtTenCategory = this.txtTenCategory.Text.Trim();
            string txtMoTaCategory = this.txtMoTaCategory.Text.Trim();
            string maCategory = this.txtMaCategory.Text.Trim();
            ProductTypeBUS productTypeBUS = new ProductTypeBUS();

            if (queryObj == "add")
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
                MessageBox.Show("Thêm thành công");
            }
            else if(queryObj == "edit")
            {
                if (txtTenCategory == "")
                {
                    MessageBox.Show("Nhap Ten!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ProductType objProductType = new ProductType(Int32.Parse(maCategory),txtTenCategory, txtMoTaCategory);

                productTypeBUS.Update(objProductType);
                LoadProductType();
                MessageBox.Show("Sửa thành công");
            }
            else if (queryObj == "delete")
            {
                DialogResult dialogResult = MessageBox.Show("Xóa", "Bạn muốn xóa?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    productTypeBUS.Delete(Int32.Parse(maCategory));
                    LoadProductType();
                    MessageBox.Show("Xóa thành công");
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
            LoadProductTypeCombobox(cbbProductType);
            

        }

        private void ExcuteSupplier()
        {
            string txtTenSupplier = this.txtTenSupplier.Text.Trim();
            string txtEmailSupplier = this.txtEmailSupplier.Text.Trim();
            string txtAddressSupplier = this.txtAddressSupplier.Text.Trim();
            string txtPhoneSupplier = this.txtPhoneSupplier.Text.Trim();
            string txtIdSupplier = this.txtIdSupplier.Text.Trim();

            SupplierBUS supplierBUS = new SupplierBUS();

            if (queryObj == "add")
            {

                if (txtTenSupplier == "")
                {
                    DialogResult result = MessageBox.Show("Nhap Ten!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                bool check = supplierBUS.checkName(txtTenSupplier);

                if (check == false)
                {
                    DialogResult result = MessageBox.Show("Ten bi trung!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Supplier obj = new Supplier(txtTenSupplier, txtEmailSupplier, txtAddressSupplier, txtPhoneSupplier);

                supplierBUS.Insert(obj);
                LoadSupplier();
                MessageBox.Show("Thêm thành công");
            }
            else if (queryObj == "edit")
            {
                if (txtTenSupplier == "")
                {
                    MessageBox.Show("Nhap Ten!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Supplier obj = new Supplier(Int32.Parse(txtIdSupplier), txtTenSupplier, txtEmailSupplier, txtAddressSupplier, txtPhoneSupplier);

                supplierBUS.Update(obj);
                LoadSupplier();
                MessageBox.Show("Sửa thành công");
            }
            else if (queryObj == "delete")
            {
                DialogResult dialogResult = MessageBox.Show("Xóa", "Bạn muốn xóa?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    supplierBUS.Delete(Int32.Parse(txtIdSupplier));
                    LoadSupplier();
                    MessageBox.Show("Xóa thành công");
                }
            }
            else
            {
                if (txtSearchSupplier.Text == "")
                {
                    MessageBox.Show("Nhap Ten hoac ma!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgvSupplier.DataSource = supplierBUS.FindItems(txtSearchSupplier.Text);

            }
            LoadSupplierCombobox(cbbSupplier);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            ControlButtonProductType(1);
            LoadProductType();
        }

        private void btCancelSupplier_Click(object sender, EventArgs e)
        {
            ControlButtonSupplier(1);
            LoadSupplier();
        }

        private void btCancelProduct_Click(object sender, EventArgs e)
        {
            ControlButtonProduct(1);
            LoadProduct();
        }

        private void txtTenCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProductType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            queryObj = "search";
            ExcuteProductType();
        }

        private void btSearchProdcut_Click(object sender, EventArgs e)
        {
            queryObj = "search";
            ExcuteProduct
();
        }

        private void btSearchSupplier_Click(object sender, EventArgs e)
        {
            queryObj = "search";
            ExcuteSupplier();
        }

        private void dgvProductType_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            txtMaCategory.Text = dgvProductType["MaID", rowindex].Value.ToString();
            txtTenCategory.Text = dgvProductType["ProductTypeName", rowindex].Value.ToString();
            txtMoTaCategory.Text = dgvProductType["Describe", rowindex].Value.ToString();
        }

        private void dgvProduct_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            txtProductID.Text = dgvProduct["ProductID", rowindex].Value.ToString();
            txtProductName.Text = dgvProduct["ProductName", rowindex].Value.ToString();
            cbbProductType.DisplayMember = "ProductTypeName";
            cbbProductType.ValueMember = "ProductTypeID";
            cbbProductType.SelectedValue = (int)dgvProduct["ProductTypeID", rowindex].Value;

            cbbSupplier.DisplayMember = "SupplierName";
            cbbSupplier.ValueMember = "SupplierID";
            cbbSupplier.SelectedValue = (int)dgvProduct["ProductSupplierID", rowindex].Value;
            
            numPrice.Value = Convert.ToInt32(dgvProduct["Price", rowindex].Value);
            txtUnit.Text = dgvProduct["unit", rowindex].Value.ToString();
            numAmount.Value = (int)dgvProduct["amount", rowindex].Value;
            

            if (dgvProduct["dateManufacture", rowindex].Value.ToString() != "")
            {
                dtpDateManufacture.Value = Convert.ToDateTime(dgvProduct["dateManufacture", rowindex].Value);
            }
            else
            {
                dtpDateManufacture.Value = System.DateTime.Now;
            }

            if (dgvProduct["dateExpiration", rowindex].Value.ToString() != "")
            {
                dtpDateExpiration.Value = Convert.ToDateTime(dgvProduct["dateExpiration", rowindex].Value);
            }
            else
            {
                dtpDateExpiration.Value = System.DateTime.Now;
            }
            
        }

        private void dgvSupplier_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            txtIdSupplier.Text = dgvSupplier["SupplierID", rowindex].Value.ToString();
            txtTenSupplier.Text = dgvSupplier["SupplierName", rowindex].Value.ToString();
            txtEmailSupplier.Text = dgvSupplier["Email", rowindex].Value.ToString();
            txtAddressSupplier.Text = dgvSupplier["Address", rowindex].Value.ToString();
            txtPhoneSupplier.Text = dgvSupplier["PhoneNumber", rowindex].Value.ToString();
        }

        private void dgvProductType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btXemProduct_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void btXemProductType_Click(object sender, EventArgs e)
        {
            LoadProductType();
        }
        private void btXemSupplier_Click(object sender, EventArgs e)
        {
            LoadSupplier();
        }

        void LoadProductTypeCombobox(ComboBox cb)
        {
            ProductTypeBUS ptb = new ProductTypeBUS();
            cb.DataSource = ptb.GetListProductType();
            cb.DisplayMember = "ProductTypeName";
        }

        void LoadSupplierCombobox(ComboBox cb)
        {
            SupplierBUS ptb = new SupplierBUS();
            cb.DataSource = ptb.GetListSupplier();
            cb.DisplayMember = "SupplierName";
        }

        private void frm_Product_Load(object sender, EventArgs e)
        {

        }
    }
}
