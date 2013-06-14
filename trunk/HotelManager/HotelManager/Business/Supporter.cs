using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelManager.Business
{
    class Supporter : BusAbstract
    {
        public static DataTable GetDataTable(DataGridView dgvtemp)
        {
            DataTable DTT = new DataTable();
            while (DTT.Rows.Count < dgvtemp.Rows.Count - 1)
            {
                DTT.Rows.Add(); // đếm số Rows để khởi tạo.
            }

            for (int i = 0; i < dgvtemp.Columns.Count; i++)
            {
                DTT.Columns.Add(dgvtemp.Columns[i].Name);

                for (int j = 0; j < dgvtemp.Rows.Count - 1; j++)
                {
                    DTT.Rows[j][i] = dgvtemp[i, j].Value;
                }
            }
            return DTT;
        }
    }
}
