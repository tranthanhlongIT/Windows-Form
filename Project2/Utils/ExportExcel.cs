using ClosedXML.Excel;
using Project2.Forms.Components;
using System.Data;
using System.Windows.Forms;

namespace Project2.Utils
{
    public static class ExportExcel
    {
        private static void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private static DataTable CreateDataTable(DataGridView dgv)
       {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
                dt.Columns.Add(column.HeaderText);
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dt.Rows.Add();
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    dt.Rows[i][j] = dgv.Rows[i].Cells[j].Value.ToString();
                }
            }
            return dt;
        }

       public static void CreateSheet(string sheetName, DataGridView dgv)
        {
            DataTable dt = CreateDataTable(dgv);
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Workbook|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(dt, sheetName);
                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                        Alert("Export Successful", Form_Alert.enmType.Success);
                    }
                    catch
                    {
                        Alert("Export Failed", Form_Alert.enmType.Warning);
                    }
                }
            }
        }
    }
}
