using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             AddTeacher t = new AddTeacher();
             t.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DG.Rows.RemoveAt(DG.SelectedCells[0].RowIndex);
        }

        private void DG_SelectionChanged(object sender, EventArgs e)
        {
            button2.Enabled = ((DG.SelectedRows.Count > 0) && (DG.SelectedCells[0].RowIndex != DG.Rows.Count - 1));
        }

        private void DG_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            LibOfTimetableOfClasses.CTeacher CTeacher1 = CreateCTeacherEx();

            CTeacher1.GetData(DG.Columns[e.ColumnIndex].Name, true);
        }

        private LibOfTimetableOfClasses.CTeacher CreateCTeacherEx()
        {
            LibOfTimetableOfClasses.CTeacher CTeacher1 = new LibOfTimetableOfClasses.CTeacher();

            for (int i = 0; i < DG.RowCount; i++)
            {
                CTeacher1.AddTeacher(DG.Rows[i].Cells[0].Value.ToString(),
                                     DG.Rows[i].Cells[1].Value.ToString(),
                                     DG.Rows[i].Cells[2].Value.ToString(),
                                     DG.Rows[i].Cells[3].Value.ToString(),
                                     DG.Rows[i].Cells[4].Value.ToString(),
                                     (byte)DG.Rows[i].Cells[5].Value);
            }
            return CTeacher1;
        }
    }
}
