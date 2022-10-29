using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.AdditionalTask
{
    public partial class ElipseForm : Form
    {
        public ElipseForm()
        {
            InitializeComponent();
        }

        private void ElipseForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, this.Width, this.Height);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void OpenRhombFormButton_Click(object sender, EventArgs e)
        {
            Form rhombform = new RhombForm();
            rhombform.ShowDialog();
        }

        private void CloseElipseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
