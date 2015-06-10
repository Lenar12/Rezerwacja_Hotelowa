using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezerwacja_w_hotelu
{
    public class grid_operation
    {
        public static string[] row = new string[100];
        public static int size_row=0;
        public string[] value_return(DataGridView grid)
        {
            size_row = grid.RowCount+1;
            int i = 0;
            for(i=0;i<=size_row;i++)
            {
                row[i] = grid.CurrentRow.Cells[i].Value.ToString();
            }    
            return row;
        }
        public string[] row_value()
        {
            return row;
        }
        public int row_count()
        {
            return size_row;
        }

    }
}
