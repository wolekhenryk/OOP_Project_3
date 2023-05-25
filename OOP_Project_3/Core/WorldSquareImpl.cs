using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace OOP_Project_3.Core;

internal class WorldSquareImpl : World {
  private readonly TableLayoutPanel tableLayoutPanel;

  public WorldSquareImpl((int, int)size, MaterialForm gameForm) : base(size, gameForm) {
    tableLayoutPanel = GameForm.GetGrid();
    SetGridSize(GetHeight(), GetWidth());
    PlaceEmptyButtons();
  }

  private void SetGridSize(int rows, int cols) {
    tableLayoutPanel.RowCount = rows + 1;
    tableLayoutPanel.ColumnCount = cols + 1;

    tableLayoutPanel.SuspendLayout();

    tableLayoutPanel.RowStyles.Clear();
    tableLayoutPanel.ColumnStyles.Clear();

    for (var i = 0; i < rows - 1; i++)
      tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, Values.CELL_SIZE));

    for (var i = 0; i < cols - 1; i++)
      tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, Values.CELL_SIZE));

    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, Values.CELL_SIZE));
    tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, Values.CELL_SIZE));

    tableLayoutPanel.ResumeLayout();
  }

  private void PlaceEmptyButtons() {
    for (var i = 0; i < tableLayoutPanel.RowCount; i++) {
      for (var j = 0; j < tableLayoutPanel.ColumnCount; j++) {
        if (i == GetHeight()) {
          var btn = new Label {
            Width = Values.CELL_SIZE, Height = Values.CELL_SIZE, Margin = Padding.Empty,
            Padding = Padding.Empty,  TabStop = false,
          };
          btn.Font = new Font(btn.Font.FontFamily, Values.BTN_FONT_SIZE);
          tableLayoutPanel.Controls.Add(btn);
        } else if (j == GetWidth()) {
          var btn =
              new Label { Width = Values.CELL_SIZE, Height = Values.CELL_SIZE,
                          Margin = Padding.Empty,   Padding = Padding.Empty,
                          TabStop = false,          TextAlign = ContentAlignment.MiddleCenter };
          btn.Font = new Font(btn.Font.FontFamily, Values.BTN_FONT_SIZE);
          tableLayoutPanel.Controls.Add(btn);
        } else if (i < tableLayoutPanel.RowCount - 1 && j < tableLayoutPanel.ColumnCount - 1) {
          var btn = new Label { Width = Values.CELL_SIZE,
                                Height = Values.CELL_SIZE,
                                Margin = Padding.Empty,
                                Padding = Padding.Empty,
                                BorderStyle = BorderStyle.Fixed3D,
                                TabStop = false,
                                TextAlign = ContentAlignment.MiddleCenter };
          btn.Font = new Font(btn.Font.FontFamily, Values.BTN_FONT_SIZE);
          tableLayoutPanel.Controls.Add(btn);
        }
      }
    }

    var targetBtn = new Button { Width = Values.CELL_SIZE,
                                 Height = Values.CELL_SIZE,
                                 Margin = Padding.Empty,
                                 FlatStyle = FlatStyle.Flat,
                                 FlatAppearance = { BorderSize = 0 },
                                 Padding = Padding.Empty,
                                 TabStop = false,
                                 TextAlign = ContentAlignment.MiddleCenter,
                                 BackColor = Color.Red,
                                 Text = "\u2192" };
    targetBtn.Font = new Font(targetBtn.Font.FontFamily, Values.BTN_FONT_SIZE, FontStyle.Bold);
    tableLayoutPanel.Controls.Add(targetBtn, GetWidth(), GetHeight());
    targetBtn.Click += (_, _) => MakeTurn();
  }

  private static void ResetBtn(Control button) {
    button.ResetBackColor();
    button.ResetForeColor();
    button.ResetText();
  }

  private void InvokeActionOnUIThread(Action action) => GameForm.Invoke(action);

  private void ResetBoardState() {
    for (var i = 0; i < tableLayoutPanel.RowCount - 1; ++i) {
      for (var j = 0; j < tableLayoutPanel.ColumnCount - 1; ++j) {
        var currentButton = tableLayoutPanel.GetControlFromPosition(j, i);
        ResetBtn(currentButton);
      }
    }
  }
  public override void Display() {
    ResetBoardState();
    foreach (var organism in Organisms)
      organism.Display();
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

  public override ValueTuple<int, int> NextMove((int, int)currentPosition, int factor = 1) {
    var (i, j) = currentPosition;
    for (var index = 0; index < Values.SQUARE_ATTEMPTS; index++) {
      var moveIndex = randomGenerator.Next(Values.SQUARE_MOVES);
      var newPosition =
          (i + Values.SquareDy[moveIndex] * factor, j + Values.SquareDx[moveIndex] * factor);
      if (ValidCoords(newPosition))
        return newPosition;
    }
    return default;
  }

  public override void PlaceOrganism(Type classType) {
    var newPos = GetRandomFreeSpot();
    if (newPos == default)
      return;
    AddOrganism(OrganismFactory.Create(classType, newPos, this));
  }
}

public class UpperBorderLabel : Label {
  protected override void OnPaint(PaintEventArgs e) {
    base.OnPaint(e);

    using var borderPen = new Pen(BorderColor, BorderWidth);
    e.Graphics.DrawLine(borderPen, 0, 0, Width, 0);
  }

  public Color BorderColor { get; set; } = Color.DarkGray;
  public float BorderWidth { get; set; } = 1.5F;
}

public class LeftBorderLabel : Label {
  protected override void OnPaint(PaintEventArgs e) {
    base.OnPaint(e);

    using var borderPen = new Pen(BorderColor, BorderWidth);
    e.Graphics.DrawLine(borderPen, 0, Height, 0, 0);
  }

  public Color BorderColor { get; set; } = Color.DarkGray;
  public float BorderWidth { get; set; } = 1.5F;
}
