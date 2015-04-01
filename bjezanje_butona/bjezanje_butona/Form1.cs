using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bjezanje_butona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBjezi_MouseHover(object sender, EventArgs e)
        {
            Random izmjena = new Random();
            int a = izmjena.Next(-30,50);
            int b=izmjena.Next(-50,50);

            Size bjezanje = new Size (a,b);

            btnBjezi.Location = Point.Add(btnBjezi.Location, bjezanje);


        }
    }
}
