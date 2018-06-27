using System;
using System.Collections;
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
    public partial class Discipline : Form
    {
        public Discipline()
        {
            InitializeComponent();
        }

        private SortOrder SO = SortOrder.Ascending;

        private void DG_Disc_SelectionChanged(object sender, EventArgs e)
        {
            if ((DG_Disc.SelectedRows.Count > 0)&&(DG_Disc.SelectedCells[0].RowIndex != DG_Disc.Rows.Count - 1))
            {
                Delete.Enabled = true;
            }
            else
            {
                Delete.Enabled = false;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
           DG_Disc.Rows.RemoveAt(DG_Disc.SelectedCells[0].RowIndex);
        }

        private class RowComparer : IComparer
        {
            private static int sortOrderModifier = 1;
            private int indexOfTheColumn = 0;

            public RowComparer(SortOrder sortOrder, int indexOfTheColumn)
            {
                if (sortOrder == SortOrder.Descending)
                {
                    sortOrderModifier = -1;
                }
                else if (sortOrder == SortOrder.Ascending)
                {
                    sortOrderModifier = 1;
                }

                this.indexOfTheColumn = indexOfTheColumn;
            }

            public int Compare(object x, object y)
            {
                int compareRes = 0;
                int ProvDgX, ProvDgY;
                bool check;

                DataGridViewRow dgX = (DataGridViewRow)x;
                DataGridViewRow dgY = (DataGridViewRow)y;
                if (!dgY.Cells[indexOfTheColumn + 1].Equals(null))
                {
                    check = int.TryParse(dgX.Cells[indexOfTheColumn].Value.ToString(), out ProvDgX);

                    if (!check)
                    {
                        compareRes = String.Compare(dgX.Cells[indexOfTheColumn].Value.ToString(),
                                                        dgY.Cells[indexOfTheColumn].Value.ToString());
                    }
                    else
                    {
                        ProvDgY = int.Parse(dgY.Cells[indexOfTheColumn].Value.ToString());
                        if (ProvDgX < ProvDgY)
                        {
                            compareRes = -1;
                        }
                        else
                        {
                            if (ProvDgX == ProvDgY)
                                compareRes = 0;
                            else
                                compareRes = 1;
                        }
                    }
                }

                return compareRes * sortOrderModifier;
            }
        }

        private void DG_Disc_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DG_Disc.Sort(new RowComparer(SO, e.ColumnIndex));
            if (SO == SortOrder.Ascending)
                SO = SortOrder.Descending;
            else
                SO = SortOrder.Ascending;
        }
    }
}

