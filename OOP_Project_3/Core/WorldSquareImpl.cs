using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace OOP_Project_3.Core
{
    internal class WorldSquareImpl : World
    {
        private readonly TableLayoutPanel tableLayoutPanel;
        public WorldSquareImpl((int, int) size, MaterialForm gameForm) : base(size, gameForm)
        {
            tableLayoutPanel = GameForm.GetGrid();
            SetGridSize(GetHeight(), GetWidth());
        }

        private void SetGridSize(int rows, int cols)
        {
            tableLayoutPanel.RowCount = rows;
            tableLayoutPanel.ColumnCount = cols;

            tableLayoutPanel.SuspendLayout();

            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.ColumnStyles.Clear();

            for (var i = 0; i < rows; i++)
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, Values.CELL_SIZE));

            for (var i = 0; i < cols; i++)
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, Values.CELL_SIZE));

            tableLayoutPanel.ResumeLayout();
        }



        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
