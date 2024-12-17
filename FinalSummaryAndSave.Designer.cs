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
            saveButton = new Button();
            summaryTextBox = new TextBox();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new Point(703, 415);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // summaryTextBox
            // 
            summaryTextBox.Location = new Point(12, 11);
            summaryTextBox.Multiline = true;
            summaryTextBox.Name = "summaryTextBox";
            summaryTextBox.Size = new Size(559, 427);
            summaryTextBox.TabIndex = 1;
            // 
            // FinalSummaryAndSave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            ClientSize = new Size(800, 450);
            Controls.Add(summaryTextBox);
            Controls.Add(saveButton);
            Name = "FinalSummaryAndSave";
            Text = "Summary and Save";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private TextBox summaryTextBox;
    }
}