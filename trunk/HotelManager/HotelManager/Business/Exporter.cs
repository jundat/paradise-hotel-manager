using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using RKLib.ExportData;

namespace HotelManager.Business
{
    class Exporter
    {
        public static bool ExportToExcel(string filepath, DataTable data)
        {
            try
            {
                // Get the datatable to export			
                DataTable dtEmployee = data.Copy();

                // Export all the details to Excel
                RKLib.ExportData.Export objExport = new RKLib.ExportData.Export("Win");
                objExport.ExportDetails(dtEmployee, Export.ExportFormat.Excel, filepath);
                //public void ExportDetails(DataTable DetailsTable, int[] ColumnList, string[] Headers, Export.ExportFormat FormatType, string FileName);
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
