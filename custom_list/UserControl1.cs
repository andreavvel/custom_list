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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }


        #region Properties

        private string _name;
        private string _document;
        private string _vehicle;
        private string _cost;

        [Category("Custom props")]
        public string NameUser
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }

        [Category("Custom props")]
        public string Document
        {
            get { return _document; }
            set { _document = value; lblDocument.Text = value; }
        }

        [Category("Custom props")]
        public string Vehicle
        {
            get { return _vehicle; }
            set { _vehicle = value; lblVehicle.Text = value; }
        }

        [Category("Custom props")]
        public string Cost
        {
            get { return _cost; }
            set { _cost = value; lblCost.Text = value; }
        }

        #endregion

        private void UserControl1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(247, 241, 251);
        }

        private void UserControl1_MouseHover(object sender, EventArgs e)
        {
            //this.BackColor = Color.Silver;
        }

        private void UserControl1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
}
