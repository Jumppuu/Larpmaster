namespace Larpmaster
{
    partial class KingdomSelection
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
            vuoriniittyBtn = new Button();
            vardakovBtn = new Button();
            metsäläisetBtn = new Button();
            noKingdomBtn = new Button();
            choseKingdomLbl = new Label();
            SuspendLayout();
            // 
            // vuoriniittyBtn
            // 
            vuoriniittyBtn.BackgroundImage = Properties.Resources.Larpmasterbackground;
            vuoriniittyBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            vuoriniittyBtn.Location = new Point(224, 201);
            vuoriniittyBtn.Name = "vuoriniittyBtn";
            vuoriniittyBtn.Size = new Size(164, 52);
            vuoriniittyBtn.TabIndex = 0;
            vuoriniittyBtn.Text = "Vuoriniitty";
            vuoriniittyBtn.UseVisualStyleBackColor = true;
            vuoriniittyBtn.Click += vuoriniittyBtn_Click;
            // 
            // vardakovBtn
            // 
            vardakovBtn.BackgroundImage = Properties.Resources.Larpmasterbackground;
            vardakovBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            vardakovBtn.Location = new Point(393, 201);
            vardakovBtn.Name = "vardakovBtn";
            vardakovBtn.Size = new Size(164, 52);
            vardakovBtn.TabIndex = 1;
            vardakovBtn.Text = "Vardakov";
            vardakovBtn.UseVisualStyleBackColor = true;
            vardakovBtn.Click += vardakovBtn_Click;
            // 
            // metsäläisetBtn
            // 
            metsäläisetBtn.BackgroundImage = Properties.Resources.Larpmasterbackground;
            metsäläisetBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            metsäläisetBtn.Location = new Point(224, 260);
            metsäläisetBtn.Name = "metsäläisetBtn";
            metsäläisetBtn.Size = new Size(164, 52);
            metsäläisetBtn.TabIndex = 2;
            metsäläisetBtn.Text = "Metsäläiset";
            metsäläisetBtn.UseVisualStyleBackColor = true;
            metsäläisetBtn.Click += metsäläisetBtn_Click;
            // 
            // noKingdomBtn
            // 
            noKingdomBtn.BackgroundImage = Properties.Resources.Larpmasterbackground;
            noKingdomBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            noKingdomBtn.Location = new Point(393, 260);
            noKingdomBtn.Name = "noKingdomBtn";
            noKingdomBtn.Size = new Size(164, 52);
            noKingdomBtn.TabIndex = 3;
            noKingdomBtn.Text = "Ei kuulu mihinkään";
            noKingdomBtn.UseVisualStyleBackColor = true;
            noKingdomBtn.Click += noKingdomBtn_Click;
            // 
            // choseKingdomLbl
            // 
            choseKingdomLbl.AutoSize = true;
            choseKingdomLbl.BackColor = Color.Transparent;
            choseKingdomLbl.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            choseKingdomLbl.Location = new Point(245, 160);
            choseKingdomLbl.Name = "choseKingdomLbl";
            choseKingdomLbl.Size = new Size(265, 19);
            choseKingdomLbl.TabIndex = 4;
            choseKingdomLbl.Text = "Valitse valtakunta";
            // 
            // KingdomSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            ClientSize = new Size(800, 450);
            Controls.Add(choseKingdomLbl);
            Controls.Add(noKingdomBtn);
            Controls.Add(metsäläisetBtn);
            Controls.Add(vardakovBtn);
            Controls.Add(vuoriniittyBtn);
            MaximizeBox = false;
            Name = "KingdomSelection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Valtakunnan valinta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button vuoriniittyBtn;
        private Button vardakovBtn;
        private Button metsäläisetBtn;
        private Button noKingdomBtn;
        private Label choseKingdomLbl;
    }
}