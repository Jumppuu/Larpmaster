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
            copyRightLbl = new Label();
            titleLbl = new Label();
            newCharBtn = new Button();
            charInfoBtn = new Button();
            loadCharBtn = new Button();
            saveCharBtn = new Button();
            gameMasterBtn = new Button();
            LoadCharFileDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // copyRightLbl
            // 
            copyRightLbl.AutoSize = true;
            copyRightLbl.BackColor = Color.Transparent;
            copyRightLbl.Font = new Font("Old English Text MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            copyRightLbl.ForeColor = Color.Sienna;
            copyRightLbl.Location = new Point(692, 544);
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
            titleLbl.Location = new Point(130, 47);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(735, 165);
            titleLbl.TabIndex = 1;
            titleLbl.Text = "Larpmaster";
            titleLbl.Click += titleLbl_Click;
            // 
            // newCharBtn
            // 
            newCharBtn.AutoSize = true;
            newCharBtn.BackColor = Color.Transparent;
            newCharBtn.FlatAppearance.BorderColor = Color.SaddleBrown;
            newCharBtn.FlatStyle = FlatStyle.Popup;
            newCharBtn.Font = new Font("Engravers MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newCharBtn.Location = new Point(130, 316);
            newCharBtn.Name = "newCharBtn";
            newCharBtn.Size = new Size(129, 48);
            newCharBtn.TabIndex = 2;
            newCharBtn.Text = "Uusi Hahmo";
            newCharBtn.UseVisualStyleBackColor = true;
            newCharBtn.Click += newCharBtn_Click;
            // 
            // charInfoBtn
            // 
            charInfoBtn.AutoSize = true;
            charInfoBtn.BackColor = Color.Transparent;
            charInfoBtn.FlatStyle = FlatStyle.Popup;
            charInfoBtn.Font = new Font("Engravers MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            charInfoBtn.Location = new Point(130, 398);
            charInfoBtn.Name = "charInfoBtn";
            charInfoBtn.Size = new Size(166, 48);
            charInfoBtn.TabIndex = 3;
            charInfoBtn.Text = "Hahmon Tiedot";
            charInfoBtn.UseVisualStyleBackColor = false;
            // 
            // loadCharBtn
            // 
            loadCharBtn.BackColor = Color.Transparent;
            loadCharBtn.FlatStyle = FlatStyle.Popup;
            loadCharBtn.Font = new Font("Engravers MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadCharBtn.Location = new Point(291, 316);
            loadCharBtn.Name = "loadCharBtn";
            loadCharBtn.Size = new Size(121, 48);
            loadCharBtn.TabIndex = 4;
            loadCharBtn.Text = "Lataa Hahmo";
            loadCharBtn.UseVisualStyleBackColor = false;
            loadCharBtn.Click += loadCharBtn_Click;
            // 
            // saveCharBtn
            // 
            saveCharBtn.AutoSize = true;
            saveCharBtn.BackColor = Color.Transparent;
            saveCharBtn.FlatStyle = FlatStyle.Popup;
            saveCharBtn.Font = new Font("Engravers MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveCharBtn.Location = new Point(318, 398);
            saveCharBtn.Name = "saveCharBtn";
            saveCharBtn.Size = new Size(181, 48);
            saveCharBtn.TabIndex = 5;
            saveCharBtn.Text = "Tallenna Hahmo";
            saveCharBtn.UseVisualStyleBackColor = false;
            // 
            // gameMasterBtn
            // 
            gameMasterBtn.AutoSize = true;
            gameMasterBtn.BackColor = Color.Transparent;
            gameMasterBtn.FlatStyle = FlatStyle.Popup;
            gameMasterBtn.Font = new Font("Engravers MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameMasterBtn.Location = new Point(825, 486);
            gameMasterBtn.Name = "gameMasterBtn";
            gameMasterBtn.Size = new Size(133, 46);
            gameMasterBtn.TabIndex = 6;
            gameMasterBtn.Text = "Pelinjohto";
            gameMasterBtn.UseVisualStyleBackColor = false;
            gameMasterBtn.Click += gameMasterBtn_Click;
            // 
            // LoadCharFileDialog
            // 
            LoadCharFileDialog.FileName = "openFileDialog1";
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(970, 590);
            Controls.Add(gameMasterBtn);
            Controls.Add(saveCharBtn);
            Controls.Add(loadCharBtn);
            Controls.Add(charInfoBtn);
            Controls.Add(newCharBtn);
            Controls.Add(titleLbl);
            Controls.Add(copyRightLbl);
            MaximizeBox = false;
            Name = "mainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Larpmaster v 0.1";
            Load += mainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label copyRightLbl;
        private Label titleLbl;
        private Button newCharBtn;
        private Button charInfoBtn;
        private Button loadCharBtn;
        private Button saveCharBtn;
        private Button gameMasterBtn;
        private OpenFileDialog LoadCharFileDialog;
    }
}
