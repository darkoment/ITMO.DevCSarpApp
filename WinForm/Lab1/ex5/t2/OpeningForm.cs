using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLab1Task5._2
{
    public partial class OpeningForm : Form
    {
        public OpeningForm()
        {
            InitializeComponent();
        }

        private void OpeningForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(400, 20), new Point(800, 200), new Point(400, 380), new Point(0, 200) });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
