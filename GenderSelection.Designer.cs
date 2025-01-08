namespace Larpmaster
{
    partial class GenderSelection
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
            MaleButton = new Button();
            FemaleButton = new Button();
            BackButton_GenderSelect = new Button();
            SuspendLayout();
            // 
            // MaleButton
            // 
            MaleButton.BackColor = Color.Transparent;
            MaleButton.BackgroundImage = Properties.Resources.Larpmasterbackground;
            MaleButton.FlatStyle = FlatStyle.Flat;
            MaleButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            MaleButton.Location = new Point(261, 248);
            MaleButton.Margin = new Padding(2, 3, 2, 3);
            MaleButton.Name = "MaleButton";
            MaleButton.Size = new Size(131, 77);
            MaleButton.TabIndex = 0;
            MaleButton.Text = "Mies";
            MaleButton.UseVisualStyleBackColor = false;
            MaleButton.Click += MaleButton_Click;
            // 
            // FemaleButton
            // 
            FemaleButton.BackColor = Color.Transparent;
            FemaleButton.BackgroundImage = Properties.Resources.Larpmasterbackground;
            FemaleButton.FlatStyle = FlatStyle.Flat;
            FemaleButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            FemaleButton.Location = new Point(510, 248);
            FemaleButton.Margin = new Padding(2, 3, 2, 3);
            FemaleButton.Name = "FemaleButton";
            FemaleButton.Size = new Size(131, 77);
            FemaleButton.TabIndex = 1;
            FemaleButton.Text = "Nainen";
            FemaleButton.UseVisualStyleBackColor = false;
            FemaleButton.Click += FemaleButton_Click;
            // 
            // BackButton_GenderSelect
            // 
            BackButton_GenderSelect.BackColor = Color.Transparent;
            BackButton_GenderSelect.FlatStyle = FlatStyle.Flat;
            BackButton_GenderSelect.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            BackButton_GenderSelect.Location = new Point(755, 36);
            BackButton_GenderSelect.Margin = new Padding(3, 4, 3, 4);
            BackButton_GenderSelect.Name = "BackButton_GenderSelect";
            BackButton_GenderSelect.Size = new Size(135, 31);
            BackButton_GenderSelect.TabIndex = 2;
            BackButton_GenderSelect.Text = "Takaisin";
            BackButton_GenderSelect.UseVisualStyleBackColor = false;
            BackButton_GenderSelect.Click += BackButton_GenderSelect_Click;
            // 
            // GenderSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            ClientSize = new Size(914, 600);
            Controls.Add(BackButton_GenderSelect);
            Controls.Add(FemaleButton);
            Controls.Add(MaleButton);
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "GenderSelection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Valitse sukupuoli:";
            ResumeLayout(false);
        }

        #endregion

        private Button MaleButton;
        private Button FemaleButton;
        private Button BackButton_GenderSelect;
    }
}