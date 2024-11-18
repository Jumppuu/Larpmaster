namespace Larpmaster
{
    partial class NewCharacter
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
            ChooseRaceLabel = new Label();
            RaceBtn_Human = new Button();
            RaceBtn_Elf = new Button();
            RaceBtn_HalfElf = new Button();
            SuspendLayout();
            // 
            // ChooseRaceLabel
            // 
            ChooseRaceLabel.AutoSize = true;
            ChooseRaceLabel.BackColor = Color.Transparent;
            ChooseRaceLabel.Location = new Point(47, 38);
            ChooseRaceLabel.Name = "ChooseRaceLabel";
            ChooseRaceLabel.Size = new Size(104, 25);
            ChooseRaceLabel.TabIndex = 1;
            ChooseRaceLabel.Text = "Valitse rotu:";
            // 
            // RaceBtn_Human
            // 
            RaceBtn_Human.BackColor = Color.Transparent;
            RaceBtn_Human.BackgroundImage = Properties.Resources.Larpmasterbackground;
            RaceBtn_Human.Location = new Point(54, 96);
            RaceBtn_Human.Name = "RaceBtn_Human";
            RaceBtn_Human.Size = new Size(112, 34);
            RaceBtn_Human.TabIndex = 2;
            RaceBtn_Human.Text = "Ihminen";
            RaceBtn_Human.UseVisualStyleBackColor = false;
            RaceBtn_Human.Click += RaceBtn_Human_Click;
            // 
            // RaceBtn_Elf
            // 
            RaceBtn_Elf.BackgroundImage = Properties.Resources.Larpmasterbackground;
            RaceBtn_Elf.Location = new Point(156, 96);
            RaceBtn_Elf.Name = "RaceBtn_Elf";
            RaceBtn_Elf.Size = new Size(112, 34);
            RaceBtn_Elf.TabIndex = 3;
            RaceBtn_Elf.Text = "Haltija";
            RaceBtn_Elf.UseVisualStyleBackColor = true;
            RaceBtn_Elf.Click += RaceBtn_Elf_Click;
            // 
            // RaceBtn_HalfElf
            // 
            RaceBtn_HalfElf.BackgroundImage = Properties.Resources.Larpmasterbackground;
            RaceBtn_HalfElf.Location = new Point(257, 96);
            RaceBtn_HalfElf.Name = "RaceBtn_HalfElf";
            RaceBtn_HalfElf.Size = new Size(112, 34);
            RaceBtn_HalfElf.TabIndex = 4;
            RaceBtn_HalfElf.Text = "Puolihaltija";
            RaceBtn_HalfElf.UseVisualStyleBackColor = true;
            RaceBtn_HalfElf.Click += RaceBtn_HalfElf_Click;
            // 
            // NewCharacter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            ClientSize = new Size(800, 450);
            Controls.Add(RaceBtn_HalfElf);
            Controls.Add(RaceBtn_Elf);
            Controls.Add(RaceBtn_Human);
            Controls.Add(ChooseRaceLabel);
            Name = "NewCharacter";
            Text = "Uusi hahmo";
            WindowState = FormWindowState.Maximized;
            Load += NewCharacter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ChooseRaceLabel;
        private Button RaceBtn_Human;
        private Button RaceBtn_Elf;
        private Button RaceBtn_HalfElf;
    }
}