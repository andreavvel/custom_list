using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace custom_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Items creation
            items();
        }

        private string randomString()
        {
            //Comentario de andrea
            //Me avisas si sale biennn
            //Este es mi comentario
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[20];
            var random = new Random();
            /* for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            return new String(stringChars); */
        }

        private void items()
        {
            //Hola es es mi otro comentario
            UserControl1[] item = new UserControl1[20];
            for(int i = 0; i < item.Length; i++)
            {
                /* item[i] = new UserControl1();
                item[i].NameUser = randomString().Substring(0, 20) + "...";
                item[i].Document = randomString().Substring(0, 10) + "...";
                item[i].Vehicle = randomString().Substring(0, 10) + "...";
                item[i].Cost = randomString().Substring(0, 10) + "..."; */

                //flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.Add(item[i]);
            }
        }
    }
}
