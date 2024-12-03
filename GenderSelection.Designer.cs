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
            MaleButton.FlatStyle = FlatStyle.Popup;
            MaleButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaleButton.Location = new Point(45, 34);
            MaleButton.Margin = new Padding(2);
            MaleButton.Name = "MaleButton";
            MaleButton.Size = new Size(78, 20);
            MaleButton.TabIndex = 0;
            MaleButton.Text = "Mies";
            MaleButton.UseVisualStyleBackColor = false;
            MaleButton.Click += MaleButton_Click;
            // 
            // FemaleButton
            // 
            FemaleButton.BackColor = Color.Transparent;
            FemaleButton.FlatStyle = FlatStyle.Popup;
            FemaleButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FemaleButton.Location = new Point(141, 34);
            FemaleButton.Margin = new Padding(2);
            FemaleButton.Name = "FemaleButton";
            FemaleButton.Size = new Size(87, 20);
            FemaleButton.TabIndex = 1;
            FemaleButton.Text = "Nainen";
            FemaleButton.UseVisualStyleBackColor = false;
            FemaleButton.Click += FemaleButton_Click;
            // 
            // BackButton_GenderSelect
            // 
            BackButton_GenderSelect.BackColor = Color.Transparent;
            BackButton_GenderSelect.FlatStyle = FlatStyle.Popup;
            BackButton_GenderSelect.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton_GenderSelect.Location = new Point(432, 31);
            BackButton_GenderSelect.Name = "BackButton_GenderSelect";
            BackButton_GenderSelect.Size = new Size(118, 23);
            BackButton_GenderSelect.TabIndex = 2;
            BackButton_GenderSelect.Text = "Takaisin";
            BackButton_GenderSelect.UseVisualStyleBackColor = false;
            BackButton_GenderSelect.Click += BackButton_GenderSelect_Click;
            // 
            // GenderSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            ClientSize = new Size(562, 278);
            Controls.Add(BackButton_GenderSelect);
            Controls.Add(FemaleButton);
            Controls.Add(MaleButton);
            Margin = new Padding(2);
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