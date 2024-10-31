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
            SuspendLayout();
            // 
            // playerBtn
            // 
            playerBtn.Location = new Point(214, 236);
            playerBtn.Name = "playerBtn";
            playerBtn.Size = new Size(104, 23);
            playerBtn.TabIndex = 0;
            playerBtn.Text = "Player";
            playerBtn.UseVisualStyleBackColor = true;
            playerBtn.Click += playerBtn_Click;
            // 
            // gameMasterBtn
            // 
            gameMasterBtn.Location = new Point(399, 236);
            gameMasterBtn.Name = "gameMasterBtn";
            gameMasterBtn.Size = new Size(111, 23);
            gameMasterBtn.TabIndex = 1;
            gameMasterBtn.Text = "Gamemaster";
            gameMasterBtn.UseVisualStyleBackColor = true;
            gameMasterBtn.Click += gameMasterBtn_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            ClientSize = new Size(800, 450);
            Controls.Add(gameMasterBtn);
            Controls.Add(playerBtn);
            Name = "LoginScreen";
            Text = "LoginScreen";
            ResumeLayout(false);
        }

        #endregion

        private Button playerBtn;
        private Button gameMasterBtn;
    }
}