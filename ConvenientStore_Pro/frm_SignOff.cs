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
    public partial class frm_SignOff : Form
    {
        //private int a=0;
        public frm_SignOff()
        {
            InitializeComponent();
        }

        private void frm_SignOff_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            String s = dt.ToString("HH:mm -- dd/MM/yyyy");
            lbDateTime.Text = s;
        }
        private void TxtChange(TextBox txt, Label lb1, Label lb2)
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
                lb2.Text = (int.Parse(lb1.Text) * int.Parse(txt.Text)).ToString("###,###");
                txtTong.Text = re.ToString("###,###");
            }
        }

        private void txt500_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtChange(txt500,lb500,lbx500);
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
                TxtChange(txt500k,lb500k,lbx500k);
            }
            catch (Exception)
            {

                MessageBox.Show("Plese enter number", "ERROR: TEXTBOX IS EMPTY",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt2k_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtChange(txt2k,lb2k,lbx2000);
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
                TxtChange(txt5k,lb5k,lbx5000);
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
                TxtChange(txt10k,lb10k,lbx10k);
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
                TxtChange(txt20k,lb20k,lbx20k);
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
                TxtChange(txt50k,lb50k,lbx50k);
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
                TxtChange(txt100k,lb100k,lbx100k);
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
                TxtChange(txt200k,lb200k,lbx200k);
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
                TxtChange(txt1k,lb1k,lbx1000);
            }
            catch (Exception)
            {

                MessageBox.Show("Plese enter number", "ERROR: TEXTBOX IS EMPTY",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
