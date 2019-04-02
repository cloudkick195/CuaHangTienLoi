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
    public partial class UC_TenderMethod : UserControl
    {
        private static UC_TenderMethod _instance;
        public static UC_TenderMethod Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_TenderMethod();
                return _instance;
            }
        }
        public UC_TenderMethod()
        {
            InitializeComponent();
        }
    }
}
