using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace WorkWithExcel
{
    public class CreateExcelFile
    {
        public static void createFile(string filename)
        {
            Application excel = new Application();
            excel.Visible = false;
            excel.DisplayAlerts = false;
            Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
            // worksheet.Name = "Proekt";
            merge(worksheet);
            string path = (Environment.CurrentDirectory + "\\"+ filename+".xlsx");
            workbook.SaveAs(path); ;
            workbook.Close();
            excel.Quit();
        }

        private static void merge(Worksheet worksheet)
        {
            for(int i=1; i <= 3; i++)
            {
                worksheet.Range[worksheet.Cells[i, 1], worksheet.Cells[i, 10]].Merge();
                if (i == 1)
                {
                    worksheet.Range[worksheet.Cells[i, 20], worksheet.Cells[i, 29]].Merge();
                }
                else
                    worksheet.Range[worksheet.Cells[i, 14], worksheet.Cells[i, 29]].Merge();
            }

        }
    }
}
