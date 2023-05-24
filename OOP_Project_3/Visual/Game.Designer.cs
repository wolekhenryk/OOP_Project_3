namespace OOP_Project_3.Visual
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPlay = new System.Windows.Forms.TabPage();
            this.gridPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.logTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tabHumanStats = new System.Windows.Forms.TabPage();
            this.tabSaveGame = new System.Windows.Forms.TabPage();
            this.tabLoadGame = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl.SuspendLayout();
            this.tabPlay.SuspendLayout();
            this.tabLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPlay);
            this.tabControl.Controls.Add(this.tabLogs);
            this.tabControl.Controls.Add(this.tabHumanStats);
            this.tabControl.Controls.Add(this.tabSaveGame);
            this.tabControl.Controls.Add(this.tabLoadGame);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Location = new System.Drawing.Point(3, 64);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(794, 383);
            this.tabControl.TabIndex = 0;
            // 
            // tabPlay
            // 
            this.tabPlay.Controls.Add(this.gridPanel);
            this.tabPlay.ImageKey = "game-development.png";
            this.tabPlay.Location = new System.Drawing.Point(4, 39);
            this.tabPlay.Margin = new System.Windows.Forms.Padding(0);
            this.tabPlay.Name = "tabPlay";
            this.tabPlay.Size = new System.Drawing.Size(786, 340);
            this.tabPlay.TabIndex = 0;
            this.tabPlay.Text = "Play the game";
            this.tabPlay.UseVisualStyleBackColor = true;
            // 
            // gridPanel
            // 
            this.gridPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.gridPanel.ColumnCount = 2;
            this.gridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(0, 0);
            this.gridPanel.Margin = new System.Windows.Forms.Padding(0);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.RowCount = 2;
            this.gridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gridPanel.Size = new System.Drawing.Size(786, 340);
            this.gridPanel.TabIndex = 0;
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.logTextBox);
            this.tabLogs.ImageKey = "log.png";
            this.tabLogs.Location = new System.Drawing.Point(4, 39);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(786, 340);
            this.tabLogs.TabIndex = 1;
            this.tabLogs.Text = "View game logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logTextBox.Depth = 0;
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Font = new System.Drawing.Font("Fira Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logTextBox.Location = new System.Drawing.Point(3, 3);
            this.logTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(780, 334);
            this.logTextBox.TabIndex = 0;
            this.logTextBox.Text = "";
            // 
            // tabHumanStats
            // 
            this.tabHumanStats.ImageKey = "soccer-player.png";
            this.tabHumanStats.Location = new System.Drawing.Point(4, 39);
            this.tabHumanStats.Name = "tabHumanStats";
            this.tabHumanStats.Size = new System.Drawing.Size(786, 340);
            this.tabHumanStats.TabIndex = 2;
            this.tabHumanStats.Text = "View human stats";
            this.tabHumanStats.UseVisualStyleBackColor = true;
            // 
            // tabSaveGame
            // 
            this.tabSaveGame.ImageKey = "file.png";
            this.tabSaveGame.Location = new System.Drawing.Point(4, 39);
            this.tabSaveGame.Name = "tabSaveGame";
            this.tabSaveGame.Size = new System.Drawing.Size(786, 340);
            this.tabSaveGame.TabIndex = 3;
            this.tabSaveGame.Text = "Save game to file";
            this.tabSaveGame.UseVisualStyleBackColor = true;
            // 
            // tabLoadGame
            // 
            this.tabLoadGame.ImageKey = "next.png";
            this.tabLoadGame.Location = new System.Drawing.Point(4, 39);
            this.tabLoadGame.Name = "tabLoadGame";
            this.tabLoadGame.Size = new System.Drawing.Size(786, 340);
            this.tabLoadGame.TabIndex = 4;
            this.tabLoadGame.Text = "Load game";
            this.tabLoadGame.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "game-development.png");
            this.imageList1.Images.SetKeyName(1, "log.png");
            this.imageList1.Images.SetKeyName(2, "next.png");
            this.imageList1.Images.SetKeyName(3, "file.png");
            this.imageList1.Images.SetKeyName(4, "soccer-player.png");
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControl;
            this.Name = "Game";
            this.Text = "Game";
            this.tabControl.ResumeLayout(false);
            this.tabPlay.ResumeLayout(false);
            this.tabLogs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabPlay;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel gridPanel;
        private System.Windows.Forms.TabPage tabHumanStats;
        private System.Windows.Forms.TabPage tabSaveGame;
        private System.Windows.Forms.TabPage tabLoadGame;
        private MaterialSkin.Controls.MaterialMultiLineTextBox logTextBox;
    }
}