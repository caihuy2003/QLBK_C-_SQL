using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBangKeo
{
    public class Funtion
    {
        public static void ToExcel(DataGridView dgv, string DuongDan, string TenTapTin, string ql)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            obj.Range[obj.Cells[1, 1], obj.Cells[1, dgv.Columns.Count]].Merge();
            obj.Cells[1, 1].HorizontalAlignment = -4108;
            obj.Cells[1, 1] = string.Format("Danh sách " + "{0}", ql.ToString());
            obj.Cells[1, 1].Font.Bold = true;
            for (int i = 1; i < dgv.Columns.Count; i++)
            {
                obj.Cells[2, i] = dgv.Columns[i - 1].HeaderText;
                obj.Cells[2, i].Interior.Color = Color.Yellow;
                obj.Cells[2, i].HorizontalAlignment = -4108;
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 3, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                        obj.Cells[i + 3, j + 1].HorizontalAlignment = -4108;
                        obj.Cells[i + 3, j + 1].Borders.LineStyle = XlLineStyle.xlContinuous;
                    }
                }
            obj.ActiveWorkbook.SaveCopyAs(DuongDan + TenTapTin + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
    }
}
