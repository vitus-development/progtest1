using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'likviditetsmodulKreditorer.Kreditorer' table. You can move, or remove it, as needed.
            this.kreditorerTableAdapter.Fill(this.likviditetsmodulKreditorer.Kreditorer);
            // TODO: This line of code loads data into the 'likviditetsmodulKreditorer.Kreditorer' table. You can move, or remove it, as needed.
            this.kreditorerTableAdapter.Fill(this.likviditetsmodulKreditorer.Kreditorer);
            // TODO: This line of code loads data into the 'likviditetsmodulDataSet.Likviditetsmodul_løn' table. You can move, or remove it, as needed.
            this.likviditetsmodul_lønTableAdapter.Fill(this.likviditetsmodulDataSet.Likviditetsmodul_løn);

        }
    }
}
