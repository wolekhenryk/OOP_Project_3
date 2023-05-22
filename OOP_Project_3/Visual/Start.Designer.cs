namespace OOP_Project_3.Visual
{
    partial class Start
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
            this.TextBoxWidth = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxHeight = new MaterialSkin.Controls.MaterialTextBox();
            this.WorldTypeSelection = new MaterialSkin.Controls.MaterialComboBox();
            this.ButtonStartGame = new MaterialSkin.Controls.MaterialButton();
            this.CenteredLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // TextBoxWidth
            // 
            this.TextBoxWidth.AnimateReadOnly = false;
            this.TextBoxWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxWidth.Depth = 0;
            this.TextBoxWidth.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxWidth.LeadingIcon = null;
            this.TextBoxWidth.Location = new System.Drawing.Point(6, 175);
            this.TextBoxWidth.MaxLength = 50;
            this.TextBoxWidth.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxWidth.Multiline = false;
            this.TextBoxWidth.Name = "TextBoxWidth";
            this.TextBoxWidth.Size = new System.Drawing.Size(288, 50);
            this.TextBoxWidth.TabIndex = 0;
            this.TextBoxWidth.Text = "";
            this.TextBoxWidth.TrailingIcon = null;
            // 
            // TextBoxHeight
            // 
            this.TextBoxHeight.AnimateReadOnly = false;
            this.TextBoxHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxHeight.Depth = 0;
            this.TextBoxHeight.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxHeight.LeadingIcon = null;
            this.TextBoxHeight.Location = new System.Drawing.Point(6, 275);
            this.TextBoxHeight.MaxLength = 50;
            this.TextBoxHeight.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxHeight.Multiline = false;
            this.TextBoxHeight.Name = "TextBoxHeight";
            this.TextBoxHeight.Size = new System.Drawing.Size(288, 50);
            this.TextBoxHeight.TabIndex = 1;
            this.TextBoxHeight.Text = "";
            this.TextBoxHeight.TrailingIcon = null;
            // 
            // WorldTypeSelection
            // 
            this.WorldTypeSelection.AutoResize = false;
            this.WorldTypeSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WorldTypeSelection.Depth = 0;
            this.WorldTypeSelection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WorldTypeSelection.DropDownHeight = 174;
            this.WorldTypeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorldTypeSelection.DropDownWidth = 121;
            this.WorldTypeSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WorldTypeSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WorldTypeSelection.FormattingEnabled = true;
            this.WorldTypeSelection.IntegralHeight = false;
            this.WorldTypeSelection.ItemHeight = 43;
            this.WorldTypeSelection.Items.AddRange(new object[] {
            "Square world type",
            "Hex world type"});
            this.WorldTypeSelection.Location = new System.Drawing.Point(6, 375);
            this.WorldTypeSelection.MaxDropDownItems = 4;
            this.WorldTypeSelection.MouseState = MaterialSkin.MouseState.OUT;
            this.WorldTypeSelection.Name = "WorldTypeSelection";
            this.WorldTypeSelection.Size = new System.Drawing.Size(288, 49);
            this.WorldTypeSelection.StartIndex = 0;
            this.WorldTypeSelection.TabIndex = 2;
            // 
            // ButtonStartGame
            // 
            this.ButtonStartGame.AutoSize = false;
            this.ButtonStartGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonStartGame.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonStartGame.Depth = 0;
            this.ButtonStartGame.HighEmphasis = true;
            this.ButtonStartGame.Icon = null;
            this.ButtonStartGame.Location = new System.Drawing.Point(6, 475);
            this.ButtonStartGame.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonStartGame.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonStartGame.Name = "ButtonStartGame";
            this.ButtonStartGame.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonStartGame.Size = new System.Drawing.Size(288, 50);
            this.ButtonStartGame.TabIndex = 3;
            this.ButtonStartGame.Text = "New game";
            this.ButtonStartGame.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonStartGame.UseAccentColor = false;
            this.ButtonStartGame.UseVisualStyleBackColor = true;
            this.ButtonStartGame.Click += new System.EventHandler(this.ButtonStartGame_Click);
            // 
            // CenteredLabel
            // 
            this.CenteredLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CenteredLabel.Depth = 0;
            this.CenteredLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CenteredLabel.Location = new System.Drawing.Point(6, 64);
            this.CenteredLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CenteredLabel.Name = "CenteredLabel";
            this.CenteredLabel.Size = new System.Drawing.Size(288, 66);
            this.CenteredLabel.TabIndex = 4;
            this.CenteredLabel.Text = "Welcome back";
            this.CenteredLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(9, 153);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Width (in rows)";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(9, 253);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(113, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Height (in rows)";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(6, 353);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(76, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "World type";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 550);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.CenteredLabel);
            this.Controls.Add(this.ButtonStartGame);
            this.Controls.Add(this.WorldTypeSelection);
            this.Controls.Add(this.TextBoxHeight);
            this.Controls.Add(this.TextBoxWidth);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox TextBoxWidth;
        private MaterialSkin.Controls.MaterialTextBox TextBoxHeight;
        private MaterialSkin.Controls.MaterialComboBox WorldTypeSelection;
        private MaterialSkin.Controls.MaterialButton ButtonStartGame;
        private MaterialSkin.Controls.MaterialLabel CenteredLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}