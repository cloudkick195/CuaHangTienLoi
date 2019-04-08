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
    public partial class UC_Em : UserControl
    {
        private static UC_Em _instance;
        public static UC_Em Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Em();
                return _instance;
            }
        }
        public UC_Em()
        {
                InitializeComponent();
        }
    }
}
