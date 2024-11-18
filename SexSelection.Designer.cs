namespace Larpmaster
{
    partial class SexSelection
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
            SuspendLayout();
            // 
            // MaleButton
            // 
            MaleButton.BackColor = Color.PeachPuff;
            MaleButton.BackgroundImage = Properties.Resources.Larpmasterbackground;
            MaleButton.Location = new Point(64, 57);
            MaleButton.Name = "MaleButton";
            MaleButton.Size = new Size(112, 34);
            MaleButton.TabIndex = 0;
            MaleButton.Text = "Mies";
            MaleButton.UseVisualStyleBackColor = false;
            // 
            // FemaleButton
            // 
            FemaleButton.BackgroundImage = Properties.Resources.Larpmasterbackground;
            FemaleButton.Location = new Point(173, 57);
            FemaleButton.Name = "FemaleButton";
            FemaleButton.Size = new Size(112, 34);
            FemaleButton.TabIndex = 1;
            FemaleButton.Text = "Nainen";
            FemaleButton.UseVisualStyleBackColor = true;
            // 
            // SexSelection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            ClientSize = new Size(800, 450);
            Controls.Add(FemaleButton);
            Controls.Add(MaleButton);
            Name = "SexSelection";
            Text = "Valitse sukupuoli:";
            Load += SexSelection_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button MaleButton;
        private Button FemaleButton;
    }
}