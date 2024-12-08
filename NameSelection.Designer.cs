namespace Larpmaster
{
    partial class NameSelection
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
            nameInputTxtBox = new TextBox();
            okBtn = new Button();
            charNameLbl = new Label();
            SuspendLayout();
            // 
            // nameInputTxtBox
            // 
            nameInputTxtBox.BackColor = Color.Moccasin;
            nameInputTxtBox.Location = new Point(27, 77);
            nameInputTxtBox.Name = "nameInputTxtBox";
            nameInputTxtBox.Size = new Size(100, 23);
            nameInputTxtBox.TabIndex = 0;
            // 
            // okBtn
            // 
            okBtn.BackgroundImage = Properties.Resources.Larpmasterbackground;
            okBtn.Location = new Point(27, 106);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 1;
            okBtn.Text = "Ok";
            okBtn.UseVisualStyleBackColor = true;
            // 
            // charNameLbl
            // 
            charNameLbl.AutoSize = true;
            charNameLbl.BackColor = Color.Transparent;
            charNameLbl.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            charNameLbl.Location = new Point(27, 34);
            charNameLbl.Name = "charNameLbl";
            charNameLbl.Size = new Size(291, 19);
            charNameLbl.TabIndex = 2;
            charNameLbl.Text = "Kirjoita hahmosi nimi";
            // 
            // NameSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            ClientSize = new Size(800, 450);
            Controls.Add(charNameLbl);
            Controls.Add(okBtn);
            Controls.Add(nameInputTxtBox);
            Name = "NameSelection";
            Text = "Name Selection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameInputTxtBox;
        private Button okBtn;
        private Label charNameLbl;
    }
}