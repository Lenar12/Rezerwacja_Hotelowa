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
        public string[] value_return(DataGridView grid)
        {
            
            int i = 0;
            for(i=0;i<=(int)grid.RowCount;i++)
            {
                row[i] = grid.CurrentRow.Cells[i].Value.ToString();
            }    
            return row;
        }
        public string[] row_value()
        {
            return row;
        }

    }
}
