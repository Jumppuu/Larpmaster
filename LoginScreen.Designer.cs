namespace Larpmaster
{
    partial class LoginScreen
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
            playerBtn = new Button();
            gameMasterBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // playerBtn
            // 
            playerBtn.BackColor = Color.Transparent;
            playerBtn.BackgroundImage = Properties.Resources.Larpmasterbackground;
            playerBtn.FlatStyle = FlatStyle.Popup;
            playerBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            playerBtn.Location = new Point(238, 248);
            playerBtn.Margin = new Padding(4);
            playerBtn.Name = "playerBtn";
            playerBtn.Size = new Size(178, 70);
            playerBtn.TabIndex = 0;
            playerBtn.Text = "Player";
            playerBtn.UseVisualStyleBackColor = false;
            playerBtn.Click += playerBtn_Click;
            // 
            // gameMasterBtn
            // 
            gameMasterBtn.BackColor = Color.Transparent;
            gameMasterBtn.BackgroundImage = Properties.Resources.Larpmasterbackground;
            gameMasterBtn.FlatStyle = FlatStyle.Popup;
            gameMasterBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            gameMasterBtn.ForeColor = SystemColors.ControlText;
            gameMasterBtn.Location = new Point(560, 248);
            gameMasterBtn.Margin = new Padding(4);
            gameMasterBtn.Name = "gameMasterBtn";
            gameMasterBtn.Size = new Size(188, 70);
            gameMasterBtn.TabIndex = 1;
            gameMasterBtn.Text = "Gamemaster";
            gameMasterBtn.UseVisualStyleBackColor = false;
            gameMasterBtn.Click += gameMasterBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 489);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(743, 56);
            label1.TabIndex = 2;
            label1.Text = "Tämä on prototyyppi hahmonluonnista joten kaikkea ei tästä versiosta löydy.\r\nHahmonluonti toimii mutta rajoitettu Hahmon tasoon 0. ";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            ClientSize = new Size(1034, 568);
            Controls.Add(label1);
            Controls.Add(gameMasterBtn);
            Controls.Add(playerBtn);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kirjautuminen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button playerBtn;
        private Button gameMasterBtn;
        private Label label1;
    }
}