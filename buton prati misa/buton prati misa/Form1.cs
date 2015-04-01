using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buton_prati_misa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrati_MouseDown(object sender, MouseEventArgs e)
        {

            btnPrati.Location = PointToClient(Cursor.Position);

        }

        private void btnPrati_MouseMove(object sender, MouseEventArgs e)
        {
            btnPrati.Location = PointToClient(Cursor.Position);
        }

        private void btnPrati_MouseClick(object sender, MouseEventArgs e)
        {
            Random z = new Random();
            int v = z.Next(-30,50);
            int u = z.Next(-50, 50);

            Size l = new Size(v, u);

            btnPrati.Location = Point.Add(btnPrati.Location, l);

        }
    }
}
