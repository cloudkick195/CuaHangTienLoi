using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenientStore_Pro
{
    public partial class frm_SignOn : Form
    {
        public double Funds { get; set; }
        public frm_SignOn()
        {
            InitializeComponent();            
        }
        private void frm_SignOn_Shown(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbDateTime.Text = dt.ToString("HH:mm -- dd/MM/yyyy");
        }
        private void Txt(TextBox txt)
        {
            if (txt.Text != "")
            {
                int a500 = int.Parse(txt500.Text);
                int a1k = int.Parse(txt1k.Text);
                int a2k = int.Parse(txt2k.Text);
                int a5k = int.Parse(txt5k.Text);
                int a10k = int.Parse(txt10k.Text);
                int a20k = int.Parse(txt20k.Text);
                int a50k = int.Parse(txt50k.Text);
                int a100k = int.Parse(txt100k.Text);
                int a200k = int.Parse(txt200k.Text);
                int a500k = int.Parse(txt500k.Text);
                int re = a500 * 500 + a1k * 1000 + a2k * 2000 + a5k * 5000 + a10k * 10000 + a20k * 20000
                    + a50k * 50000 + a100k * 100000 + a200k * 200000 + a500k * 500000;
                txtTong.Text = re.ToString("###,###");
            }
        }
        private void txt500_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Txt(txt500);
            }
            catch (Exception)
            {

                MessageBox.Show("Plese enter number", "ERROR: TEXTBOX IS EMPTY",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt1k_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Txt(txt1k);
            }
            catch (Exception)
            {

                MessageBox.Show("Plese enter number", "ERROR: TEXTBOX IS EMPTY",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txt2k_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Txt(txt2k);
            }
            catch (Exception)
            {

                MessageBox.Show("Plese enter number", "ERROR: TEXTBOX IS EMPTY",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt5k_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Txt(txt5k);
            }
            catch (Exception)
            {

                MessageBox.Show("Plese enter number", "ERROR: TEXTBOX IS EMPTY",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt10k_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Txt(txt10k);
            }
            catch (Exception)
            {

                MessageBox.Show("Plese enter number", "ERROR: TEXTBOX IS EMPTY",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt20k_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Txt(txt20k);
            }
            catch (Exception)
            {

                MessageBox.Show("Plese enter number", "ERROR: TEXTBOX IS EMPTY",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt50k_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Txt(txt50k);
            }
            catch (Exception)
            {

                MessageBox.Show("Plese enter number", "ERROR: TEXTBOX IS EMPTY",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt100k_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Txt(txt100k);
            }
            catch (Exception)
            {

                MessageBox.Show("Plese enter number", "ERROR: TEXTBOX IS EMPTY",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt200k_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Txt(txt200k);
            }
            catch (Exception)
            {

                MessageBox.Show("Plese enter number", "ERROR: TEXTBOX IS EMPTY",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt500k_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Txt(txt500k);
            }
            catch (Exception)
            {

                MessageBox.Show("Plese enter number", "ERROR: TEXTBOX IS EMPTY",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt500_MouseUp(object sender, MouseEventArgs e)
        {
            txt500.SelectAll();
        }

        private void txt1k_MouseUp(object sender, MouseEventArgs e)
        {
            txt1k.SelectAll();
        }

        private void txt2k_MouseUp(object sender, MouseEventArgs e)
        {
            txt2k.SelectAll();
        }

        private void txt5k_MouseUp(object sender, MouseEventArgs e)
        {
            txt5k.SelectAll();
        }

        private void txt10k_MouseUp(object sender, MouseEventArgs e)
        {
            txt10k.SelectAll();
        }

        private void txt20k_MouseUp(object sender, MouseEventArgs e)
        {
            txt20k.SelectAll();
        }

        private void txt50k_MouseUp(object sender, MouseEventArgs e)
        {
            txt50k.SelectAll();
        }

        private void txt100k_MouseUp(object sender, MouseEventArgs e)
        {
            txt100k.SelectAll();
        }

        private void txt200k_MouseUp(object sender, MouseEventArgs e)
        {
            txt200k.SelectAll();
        }

        private void txt500k_MouseUp(object sender, MouseEventArgs e)
        {
            txt500k.SelectAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txt500_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Funds = double.Parse(txtTong.Text);
        }
    }  
}
