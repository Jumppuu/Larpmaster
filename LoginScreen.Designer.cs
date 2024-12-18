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
            playerBtn.FlatStyle = FlatStyle.Popup;
            playerBtn.Font = new Font("Engravers MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerBtn.Location = new Point(190, 198);
            playerBtn.Name = "playerBtn";
            playerBtn.Size = new Size(142, 56);
            playerBtn.TabIndex = 0;
            playerBtn.Text = "Player";
            playerBtn.UseVisualStyleBackColor = false;
            playerBtn.Click += playerBtn_Click;
            // 
            // gameMasterBtn
            // 
            gameMasterBtn.BackColor = Color.Transparent;
            gameMasterBtn.FlatStyle = FlatStyle.Popup;
            gameMasterBtn.Font = new Font("Engravers MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameMasterBtn.ForeColor = SystemColors.ControlText;
            gameMasterBtn.Location = new Point(448, 198);
            gameMasterBtn.Name = "gameMasterBtn";
            gameMasterBtn.Size = new Size(150, 56);
            gameMasterBtn.TabIndex = 1;
            gameMasterBtn.Text = "Gamemaster";
            gameMasterBtn.UseVisualStyleBackColor = false;
            gameMasterBtn.Click += gameMasterBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, 405);
            label1.Name = "label1";
            label1.Size = new Size(410, 30);
            label1.TabIndex = 2;
            label1.Text = "Tämä on prototyyppi hahmonluonnista joten kaikkea ei tästä versiosta löydy.\r\nHahmonluonti toimii mutta rajoitettu Hahmon tasoon 0. ";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            ClientSize = new Size(827, 454);
            Controls.Add(label1);
            Controls.Add(gameMasterBtn);
            Controls.Add(playerBtn);
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button playerBtn;
        private Button gameMasterBtn;
        private Label label1;
    }
}