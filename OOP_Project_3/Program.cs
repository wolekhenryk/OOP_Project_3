using System;
using System.Windows.Forms;

namespace OOP_Project_3;

internal static class Program {
  /// <summary>
  /// The main entry point for the application.
  /// </summary>
  [STAThread]
  static void Main() {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

    var startingFormManager = new Core.VisualFormManager(new Visual.Start());

    Application.Run(startingFormManager.mainForm);
  }
}
