using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWithExcel
{
    public static class DGVUtils
    {

       

        public static void Initialize(DataGridView dgv)
        {
            dgv.ColumnCount = 100;
            dgv.RowCount = 300;
           
            setNumbers(dgv);
        }

        private static void setNumbers(DataGridView dgv)
        {
            int start = 65;
            for(int i = 0; i < dgv.ColumnCount; i++)
            {
                if (i > 25)
                {
                    string s1 = ((char)(start + i / 26 - 1)).ToString();
                    string s2 = ((char)(start + i % 26)).ToString();
                    dgv.Columns[i].HeaderText = String.Concat(s1,s2);
                }
                else
                    dgv.Columns[i].HeaderText = ((char)(start + i)).ToString();
            }
            for(int i =1; i < dgv.RowCount; i++)
            {
                dgv.Rows[i-1].HeaderCell.Value = i.ToString();
                dgv.Rows[i-1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            //MainDGV[0, 0].Value = "Утверждаю";
        }
    }
}
