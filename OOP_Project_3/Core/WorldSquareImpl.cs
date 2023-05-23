using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using OOP_Project_3.Visual;

namespace OOP_Project_3.Core {
  internal class WorldSquareImpl : World {
    private readonly TableLayoutPanel tableLayoutPanel;

    public WorldSquareImpl((int, int)size, MaterialForm gameForm) : base(size, gameForm) {
      tableLayoutPanel = GameForm.GetGrid();
      SetGridSize(GetHeight(), GetWidth());
      PlaceEmptyButtons();
    }

    private void SetGridSize(int rows, int cols) {
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

    private void PlaceEmptyButtons() {
      for (var i = 0; i < tableLayoutPanel.RowCount; i++) {
        for (var j = 0; j < tableLayoutPanel.ColumnCount; j++) {
          var btn = new Button() {
            Width = Values.CELL_SIZE,
            Height = Values.CELL_SIZE,
            Margin = Padding.Empty,
            FlatStyle = FlatStyle.Flat,
            FlatAppearance = { BorderSize = 0 },
            Padding = Padding.Empty,
            TabStop = false,
          };
          btn.Font = new Font(btn.Font.FontFamily, Values.BTN_FONT_SIZE);
          tableLayoutPanel.Controls.Add(btn);
        }
      }
    }

    private static void ResetBtn(Control button) {
      button.ResetBackColor();
      button.ResetForeColor();
      button.ResetText();
    }

    private void InvokeActionOnUIThread(Action action) => GameForm.Invoke(action);

    private void ResetBoardState() {
      for (var i = 0; i < tableLayoutPanel.RowCount; ++i) {
        for (var j = 0; j < tableLayoutPanel.ColumnCount; ++j) {
          var currentButton = tableLayoutPanel.GetControlFromPosition(j, i);
          ResetBtn(currentButton);
        }
      }
    }
    public override void Display() {
      ResetBoardState();
      foreach (var organism in OrganismsReadOnly) organism.Display();
    }

    public Control ControlAtPosition((int, int)position) {
      var (i, j) = position;
      return tableLayoutPanel.GetControlFromPosition(j, i);
    }

    public override ValueTuple<int, int> FindFreeSpot((int, int)currentPosition) {
      var (i, j) = currentPosition;
      for (var index = 0; index < Values.SQUARE_MOVES; index++) {
        var newPosition = (i + Values.SquareDy[index], j + Values.SquareDx[index]);
        if (ValidCoords(newPosition) && IsSpotVacant(newPosition))
          return newPosition;
      }
      return default;
    }

    public override ValueTuple<int, int> NextMove((int, int)currentPosition) {
      var (i, j) = currentPosition;
      for (var index = 0; index < Values.SQUARE_ATTEMPTS; index++) {
        var moveIndex = randomGenerator.Next(Values.SQUARE_MOVES);
        var newPosition = (i + Values.SquareDy[moveIndex], j + Values.SquareDx[moveIndex]);
        if (ValidCoords(newPosition))
          return newPosition;
      }
      return default;
    }
  }
}
