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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameSelection));
            nameInputTxtBox = new TextBox();
            okBtn = new Button();
            charNameLbl = new Label();
            oikeaNimiLbl = new Label();
            realNameTxtbox = new TextBox();
            okBtn2 = new Button();
            SuspendLayout();
            // 
            // nameInputTxtBox
            // 
            nameInputTxtBox.BackColor = Color.Moccasin;
            nameInputTxtBox.Location = new Point(88, 273);
            nameInputTxtBox.Margin = new Padding(3, 4, 3, 4);
            nameInputTxtBox.Name = "nameInputTxtBox";
            nameInputTxtBox.Size = new Size(300, 27);
            nameInputTxtBox.TabIndex = 0;
            // 
            // okBtn
            // 
            okBtn.BackgroundImage = Properties.Resources.Larpmasterbackground;
            okBtn.FlatStyle = FlatStyle.Popup;
            okBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            okBtn.Location = new Point(194, 308);
            okBtn.Margin = new Padding(3, 4, 3, 4);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(86, 31);
            okBtn.TabIndex = 1;
            okBtn.Text = "Ok";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // charNameLbl
            // 
            charNameLbl.AutoSize = true;
            charNameLbl.BackColor = Color.Transparent;
            charNameLbl.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            charNameLbl.Location = new Point(62, 216);
            charNameLbl.Name = "charNameLbl";
            charNameLbl.Size = new Size(364, 24);
            charNameLbl.TabIndex = 2;
            charNameLbl.Text = "Kirjoita hahmosi nimi";
            // 
            // oikeaNimiLbl
            // 
            oikeaNimiLbl.AutoSize = true;
            oikeaNimiLbl.BackColor = Color.Transparent;
            oikeaNimiLbl.Font = new Font("Engravers MT", 12F, FontStyle.Bold);
            oikeaNimiLbl.Location = new Point(535, 216);
            oikeaNimiLbl.Name = "oikeaNimiLbl";
            oikeaNimiLbl.Size = new Size(354, 24);
            oikeaNimiLbl.TabIndex = 3;
            oikeaNimiLbl.Text = "Kirjoita oikea nimesi";
            oikeaNimiLbl.Visible = false;
            // 
            // realNameTxtbox
            // 
            realNameTxtbox.BackColor = Color.Moccasin;
            realNameTxtbox.Location = new Point(553, 273);
            realNameTxtbox.Margin = new Padding(3, 4, 3, 4);
            realNameTxtbox.Name = "realNameTxtbox";
            realNameTxtbox.Size = new Size(300, 27);
            realNameTxtbox.TabIndex = 4;
            realNameTxtbox.Visible = false;
            // 
            // okBtn2
            // 
            okBtn2.BackgroundImage = Properties.Resources.Larpmasterbackground;
            okBtn2.FlatStyle = FlatStyle.Popup;
            okBtn2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            okBtn2.Location = new Point(666, 308);
            okBtn2.Margin = new Padding(3, 4, 3, 4);
            okBtn2.Name = "okBtn2";
            okBtn2.Size = new Size(86, 31);
            okBtn2.TabIndex = 5;
            okBtn2.Text = "Ok";
            okBtn2.UseVisualStyleBackColor = true;
            okBtn2.Visible = false;
            okBtn2.Click += okBtn2_Click;
            // 
            // NameSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            ClientSize = new Size(914, 600);
            Controls.Add(okBtn2);
            Controls.Add(realNameTxtbox);
            Controls.Add(oikeaNimiLbl);
            Controls.Add(charNameLbl);
            Controls.Add(okBtn);
            Controls.Add(nameInputTxtBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "NameSelection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nimen valinta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameInputTxtBox;
        private Button okBtn;
        private Label charNameLbl;
        private Label oikeaNimiLbl;
        private TextBox realNameTxtbox;
        private Button okBtn2;
    }
}