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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            button1.Location = new Point(127, 282);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 2;
            button1.Text = "Uusi Hahmo";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(127, 340);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 3;
            button2.Text = "Hahmon Tiedot";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(327, 282);
            button3.Name = "button3";
            button3.Size = new Size(102, 23);
            button3.TabIndex = 4;
            button3.Text = "Lataa Hahmo";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(327, 340);
            button4.Name = "button4";
            button4.Size = new Size(102, 23);
            button4.TabIndex = 5;
            button4.Text = "Lataa Hahmo";
            button4.UseVisualStyleBackColor = true;
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1162, 727);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
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
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
