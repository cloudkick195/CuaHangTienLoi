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
    public partial class UC_OK : UserControl
    {
        private static UC_OK _instance;
        public static UC_OK Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_OK();
                return _instance;
            }
        }
        public UC_OK()
        {
            InitializeComponent();
        }
    }
}
