using System.Drawing;
using MaterialSkin;
using MaterialSkin.Controls;

namespace OOP_Project_3.Core;

public class VisualFormManager {
  public MaterialForm mainForm { get; }
  public VisualFormManager(MaterialForm newForm) {
    mainForm = newForm;
    var skinManager = MaterialSkinManager.Instance;
    skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500,
                                              Accent.LightGreen200, TextShade.WHITE);
    skinManager.Theme = MaterialSkinManager.Themes.DARK;
    skinManager.AddFormToManage(mainForm);
  }
  public void SetSize((int, int)sizeTuple) => mainForm.Size = new Size(sizeTuple.Item2,
                                                                       sizeTuple.Item1);
  public void Hide() => mainForm.Hide();
  public void Show() => mainForm.Show();
  public void Refresh() {
    mainForm.Invalidate();
    mainForm.Refresh();
  }
}
