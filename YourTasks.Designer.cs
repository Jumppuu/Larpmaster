namespace Larpmaster
{
    partial class YourTasks
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
            missionLbl = new Label();
            tehtävätTextBox = new TextBox();
            muutaLbl = new Label();
            muutaTextBox = new TextBox();
            okBtn1 = new Button();
            okBtn2 = new Button();
            SuspendLayout();
            // 
            // missionLbl
            // 
            missionLbl.AutoSize = true;
            missionLbl.BackColor = Color.Transparent;
            missionLbl.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            missionLbl.Location = new Point(163, 169);
            missionLbl.Name = "missionLbl";
            missionLbl.Size = new Size(130, 19);
            missionLbl.TabIndex = 0;
            missionLbl.Text = "Tehtävät";
            // 
            // tehtävätTextBox
            // 
            tehtävätTextBox.BackColor = Color.Moccasin;
            tehtävätTextBox.BorderStyle = BorderStyle.FixedSingle;
            tehtävätTextBox.Location = new Point(479, 207);
            tehtävätTextBox.Name = "tehtävätTextBox";
            tehtävätTextBox.Size = new Size(207, 23);
            tehtävätTextBox.TabIndex = 1;
            // 
            // muutaLbl
            // 
            muutaLbl.AutoSize = true;
            muutaLbl.BackColor = Color.Transparent;
            muutaLbl.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            muutaLbl.Location = new Point(531, 169);
            muutaLbl.Name = "muutaLbl";
            muutaLbl.Size = new Size(92, 19);
            muutaLbl.TabIndex = 2;
            muutaLbl.Text = "Muuta";
            muutaLbl.Visible = false;
            // 
            // muutaTextBox
            // 
            muutaTextBox.BackColor = Color.Moccasin;
            muutaTextBox.BorderStyle = BorderStyle.FixedSingle;
            muutaTextBox.Location = new Point(119, 205);
            muutaTextBox.Name = "muutaTextBox";
            muutaTextBox.Size = new Size(207, 23);
            muutaTextBox.TabIndex = 3;
            muutaTextBox.Visible = false;
            // 
            // okBtn1
            // 
            okBtn1.BackColor = Color.Transparent;
            okBtn1.BackgroundImage = Properties.Resources.Larpmasterbackground;
            okBtn1.FlatStyle = FlatStyle.Popup;
            okBtn1.Location = new Point(180, 236);
            okBtn1.Name = "okBtn1";
            okBtn1.Size = new Size(75, 23);
            okBtn1.TabIndex = 4;
            okBtn1.Text = "Ok";
            okBtn1.UseVisualStyleBackColor = false;
            okBtn1.Click += okBtn1_Click;
            // 
            // okBtn2
            // 
            okBtn2.BackColor = Color.Transparent;
            okBtn2.BackgroundImage = Properties.Resources.Larpmasterbackground;
            okBtn2.FlatStyle = FlatStyle.Popup;
            okBtn2.Location = new Point(545, 236);
            okBtn2.Name = "okBtn2";
            okBtn2.Size = new Size(78, 23);
            okBtn2.TabIndex = 5;
            okBtn2.Text = "Ok";
            okBtn2.UseVisualStyleBackColor = false;
            okBtn2.Visible = false;
            okBtn2.Click += okBtn2_Click;
            // 
            // YourTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            ClientSize = new Size(800, 450);
            Controls.Add(okBtn2);
            Controls.Add(okBtn1);
            Controls.Add(muutaTextBox);
            Controls.Add(muutaLbl);
            Controls.Add(tehtävätTextBox);
            Controls.Add(missionLbl);
            Name = "YourTasks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YourTasks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label missionLbl;
        private TextBox tehtävätTextBox;
        private Label muutaLbl;
        private TextBox muutaTextBox;
        private Button okBtn1;
        private Button okBtn2;
    }
}