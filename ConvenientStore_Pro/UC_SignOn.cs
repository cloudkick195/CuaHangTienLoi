using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConvenientStore_Pro;
namespace ConvenientStore_Pro
{
    public partial class UC_SignOn : UserControl
    {
        private static UC_SignOn _instance;
        public static UC_SignOn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_SignOn();
                return _instance;
            }
        }
        public UC_SignOn()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
