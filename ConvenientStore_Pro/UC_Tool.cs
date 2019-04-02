using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenientStore_Pro
{
    public partial class UC_Tool : UserControl
    {
        private static UC_Tool _instance;
        public static UC_Tool Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Tool();
                return _instance;
            }
        }
        public UC_Tool()
        {
            InitializeComponent();
        }

        private void btn_Off_Click(object sender, EventArgs e)
        {

        }
    }
}
