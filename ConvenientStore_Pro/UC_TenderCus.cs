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
    public partial class UC_TenderCus : UserControl
    {
        private static UC_TenderCus _instance;
        public static UC_TenderCus Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_TenderCus();
                return _instance;
            }
        }
        public UC_TenderCus()
        {
            InitializeComponent();
        }
    }
}
