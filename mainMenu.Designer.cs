namespace Larpmaster
{
    partial class mainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            copyRightLbl = new Label();
            titleLbl = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // copyRightLbl
            // 
            copyRightLbl.AutoSize = true;
            copyRightLbl.BackColor = Color.Transparent;
            copyRightLbl.Font = new Font("Old English Text MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            copyRightLbl.ForeColor = Color.Sienna;
            copyRightLbl.Location = new Point(884, 690);
            copyRightLbl.Name = "copyRightLbl";
            copyRightLbl.Size = new Size(266, 28);
            copyRightLbl.TabIndex = 0;
            copyRightLbl.Text = "© Rajakatse Fantasia ry";
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.BackColor = Color.Transparent;
            titleLbl.Font = new Font("Old English Text MT", 104.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.ForeColor = Color.Sienna;
            titleLbl.Location = new Point(226, 46);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(735, 165);
            titleLbl.TabIndex = 1;
            titleLbl.Text = "Larpmaster";
            // 
            // button1
            // 
            button1.Location = new Point(483, 344);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Toimii";
            button1.UseVisualStyleBackColor = true;
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1162, 727);
            Controls.Add(button1);
            Controls.Add(titleLbl);
            Controls.Add(copyRightLbl);
            Name = "mainMenu";
            Text = "Larpmaster v 0.1";
            Load += mainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label copyRightLbl;
        private Label titleLbl;
        private Button button1;
    }
}
