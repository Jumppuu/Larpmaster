namespace Larpmaster
{
    partial class FinalSummaryAndSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalSummaryAndSave));
            saveButton = new Button();
            summaryTextBox = new TextBox();
            mainMenuBtn = new Button();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.BackgroundImage = Properties.Resources.Larpmasterbackground;
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            saveButton.Location = new Point(439, 317);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(184, 55);
            saveButton.TabIndex = 0;
            saveButton.Text = "Tallenna Hahmo";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // summaryTextBox
            // 
            summaryTextBox.BackColor = Color.Moccasin;
            summaryTextBox.BorderStyle = BorderStyle.FixedSingle;
            summaryTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            summaryTextBox.Location = new Point(12, 11);
            summaryTextBox.Multiline = true;
            summaryTextBox.Name = "summaryTextBox";
            summaryTextBox.ReadOnly = true;
            summaryTextBox.Size = new Size(412, 361);
            summaryTextBox.TabIndex = 1;
            // 
            // mainMenuBtn
            // 
            mainMenuBtn.BackgroundImage = Properties.Resources.Larpmasterbackground;
            mainMenuBtn.FlatStyle = FlatStyle.Flat;
            mainMenuBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            mainMenuBtn.Location = new Point(682, 22);
            mainMenuBtn.Name = "mainMenuBtn";
            mainMenuBtn.Size = new Size(106, 55);
            mainMenuBtn.TabIndex = 2;
            mainMenuBtn.Text = "Päävalikko";
            mainMenuBtn.UseVisualStyleBackColor = true;
            mainMenuBtn.Click += mainMenuBtn_Click;
            // 
            // FinalSummaryAndSave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            ClientSize = new Size(800, 450);
            Controls.Add(mainMenuBtn);
            Controls.Add(summaryTextBox);
            Controls.Add(saveButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FinalSummaryAndSave";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yhteenveto ja tallennus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private TextBox summaryTextBox;
        private Button mainMenuBtn;
    }
}