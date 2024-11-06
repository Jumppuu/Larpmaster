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
            playerBtn.BackColor = Color.Transparent;
            playerBtn.FlatStyle = FlatStyle.Popup;
            playerBtn.Font = new Font("Engravers MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerBtn.Location = new Point(217, 264);
            playerBtn.Margin = new Padding(3, 4, 3, 4);
            playerBtn.Name = "playerBtn";
            playerBtn.Size = new Size(162, 75);
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
            gameMasterBtn.Location = new Point(512, 264);
            gameMasterBtn.Margin = new Padding(3, 4, 3, 4);
            gameMasterBtn.Name = "gameMasterBtn";
            gameMasterBtn.Size = new Size(171, 75);
            gameMasterBtn.TabIndex = 1;
            gameMasterBtn.Text = "Gamemaster";
            gameMasterBtn.UseVisualStyleBackColor = false;
            gameMasterBtn.Click += gameMasterBtn_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            ClientSize = new Size(945, 605);
            Controls.Add(gameMasterBtn);
            Controls.Add(playerBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginScreen";
            Text = "LoginScreen";
            ResumeLayout(false);
        }

        #endregion

        private Button playerBtn;
        private Button gameMasterBtn;
    }
}