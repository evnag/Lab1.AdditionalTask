namespace Lab1.AdditionalTask
{
    public partial class RhombForm : Form
    {
        public RhombForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RhombForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(this.Width / 2, 0), new Point(this.Width, this.Height / 2), new Point(this.Width / 2, this.Height), new Point(0, this.Height / 2) });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }
    }
}