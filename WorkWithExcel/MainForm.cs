using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;using Excel = Microsoft.Office.Interop.Excel;

namespace WorkWithExcel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DGVUtils.Initialize(MainDGV);
            this.MainDGV.Paint += new PaintEventHandler(dataGridView1_Paint);
            
        }

        void dataGridView1_Paint(object sender, PaintEventArgs e)

        {

            //merge cell[0,0] and cell[1,0]

            Rectangle r1 = this.MainDGV.GetCellDisplayRectangle(0, 0, true);

            Rectangle r2 = this.MainDGV.GetCellDisplayRectangle(0, 1, true);

            r1.X += 1;

            r1.Width -= 2;

            r1.Height = r1.Height + r2.Height - 1;

            e.Graphics.FillRectangle(Brushes.White, r1);

            e.Graphics.DrawString("some thing here", this.MainDGV.Font, Brushes.Black, r1);



            //merge cell[4,1],[4,2],[4,3]

            Rectangle t1 = this.MainDGV.GetCellDisplayRectangle(1, 4, true);

            Rectangle t2 = this.MainDGV.GetCellDisplayRectangle(2, 4, true);

            Rectangle t3 = this.MainDGV.GetCellDisplayRectangle(3, 4, true);

            t1.Width = t1.Width + t2.Width + t3.Width - 3;

            t1.Height -= 1;

            t1.X += 1;

            e.Graphics.FillRectangle(Brushes.White, t1);

            e.Graphics.DrawString("some thing here", this.MainDGV.Font, Brushes.Black, t1);

        }
    }
}
