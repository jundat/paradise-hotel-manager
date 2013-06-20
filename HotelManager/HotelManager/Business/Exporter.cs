using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using RKLib.ExportData;
using System.Windows.Forms;
using System.IO;

namespace HotelManager.Business
{
    class Exporter
    {
        public static int counter = 0;

        public static void ToCsV(string title, DataGridView dGV)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName;
            }
            else
            {
                return;
            }

            //////////////////////////////////////////////////////////////////////////
            string stOutput = "";

            //title
            stOutput += title + "\n\n";


            // Export titles:
            string sHeaders = "";
            for (int j = 0; j < dGV.Columns.Count; j++)
            {
                sHeaders += dGV.Columns[j].HeaderText + "\t";
            }

            sHeaders += "\n";

            for (int j = 0; j < dGV.Columns.Count; j++)
            {
                sHeaders += "------------\t";
            }
            
            stOutput += sHeaders + "\r\n";

            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                {
                    stLine += dGV.Rows[i].Cells[j].Value + "\t";
                }

                stOutput += stLine + "\r\n";
            }

            Encoding unicode = Encoding.GetEncoding(12000);// .GetEncoding(1254);
            byte[] output = unicode.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }  

        public static void ExportExcelFull(string filename, DataTable data, Form parentForm)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel 2003(.xls)|*.xls|CSV File(*.csv)|*.csv";
                dialog.FileName = filename + (counter++);

                if (dialog.ShowDialog(parentForm) == DialogResult.OK)
                {
                    string filePath = dialog.FileName;

                    if (filePath.EndsWith("xls"))
                        Exporter.ExportToExcel(filePath, data);
                    else if (filePath.EndsWith("csv"))
                        Exporter.ExportToExcel(filePath, data);

                    System.Diagnostics.Process.Start(filePath);
                }
            }
            catch
            {
                MessageBox.Show("Không thể lưu file.");
            }
        }

        public static bool ExportToExcel(string filepath, DataTable data)
        {
            try
            {
                // Get the datatable to export			
                DataTable dtEmployee = data.Copy();

                // Export all the details to Excel
                RKLib.ExportData.Export objExport = new RKLib.ExportData.Export("Win");
                
                objExport.ExportDetails(dtEmployee, Export.ExportFormat.Excel, filepath);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool ExportToCSV(string filepath, DataTable data)
        {
            try
            {
                // Get the datatable to export			
                DataTable dtEmployee = data.Copy();

                // Export all the details to Excel
                RKLib.ExportData.Export objExport = new RKLib.ExportData.Export("Win");
                objExport.ExportDetails(dtEmployee, Export.ExportFormat.CSV, filepath);
                //public void ExportDetails(DataTable DetailsTable, int[] ColumnList, string[] Headers, Export.ExportFormat FormatType, string FileName);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
