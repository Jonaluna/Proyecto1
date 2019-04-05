using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class tablero : Form
    {
        public tablero()
        {
            InitializeComponent();
        }

        private void tablero_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Alfil.Location = new System.Drawing.Point(194, 287);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureBox3.Location = new System.Drawing.Point(188, 283);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Peon.Location = new System.Drawing.Point(192, 248);
            System.Threading.Thread.Sleep(3000);
            this.Peon1.Location = new System.Drawing.Point(224, 248);
        }
    }
}
