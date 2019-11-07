using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWithExcel
{
    public partial class MainUtilForm : Form
    {
        public MainUtilForm()
        {
            InitializeComponent();
            dataGridView1.RowCount = 3;
            dataGridView2.RowCount = 3;
        }

        private void MainUtilForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            CreateExcelFile.createFile("result");
        }
    }
}
