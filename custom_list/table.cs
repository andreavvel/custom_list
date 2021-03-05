using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace custom_list
{
    public partial class table : UserControl
    {
        public table()
        {
            InitializeComponent();
        }

        private string _test;

        [Category("Hola")]
        public string Test
        {
            get { return _test; }
            set { _test = value; label1.Text = value; }
        }
    }
}
