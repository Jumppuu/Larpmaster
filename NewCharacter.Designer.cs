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
<<<<<<< Updated upstream
            RaceBtn_Peikko = new Button();
=======
            BackButton_NewChar = new Button();
>>>>>>> Stashed changes
            SuspendLayout();
            // 
            // ChooseRaceLabel
            // 
            ChooseRaceLabel.AutoSize = true;
            ChooseRaceLabel.BackColor = Color.Transparent;
            ChooseRaceLabel.Location = new Point(98, 43);
            ChooseRaceLabel.Margin = new Padding(2, 0, 2, 0);
            ChooseRaceLabel.Name = "ChooseRaceLabel";
            ChooseRaceLabel.Size = new Size(68, 15);
            ChooseRaceLabel.TabIndex = 1;
            ChooseRaceLabel.Text = "Valitse rotu:";
            // 
            // RaceBtn_Human
            // 
            RaceBtn_Human.BackColor = Color.Transparent;
            RaceBtn_Human.FlatStyle = FlatStyle.Popup;
            RaceBtn_Human.Location = new Point(23, 84);
            RaceBtn_Human.Margin = new Padding(2);
            RaceBtn_Human.Name = "RaceBtn_Human";
            RaceBtn_Human.Size = new Size(78, 27);
            RaceBtn_Human.TabIndex = 2;
            RaceBtn_Human.Text = "Ihminen";
            RaceBtn_Human.UseVisualStyleBackColor = false;
            RaceBtn_Human.Click += RaceBtn_Human_Click;
            // 
            // RaceBtn_Elf
            // 
            RaceBtn_Elf.BackColor = Color.Transparent;
            RaceBtn_Elf.FlatStyle = FlatStyle.Popup;
            RaceBtn_Elf.Location = new Point(98, 84);
            RaceBtn_Elf.Margin = new Padding(2);
            RaceBtn_Elf.Name = "RaceBtn_Elf";
            RaceBtn_Elf.Size = new Size(78, 27);
            RaceBtn_Elf.TabIndex = 3;
            RaceBtn_Elf.Text = "Haltija";
            RaceBtn_Elf.UseVisualStyleBackColor = false;
            RaceBtn_Elf.Click += RaceBtn_Elf_Click;
            // 
            // RaceBtn_HalfElf
            // 
            RaceBtn_HalfElf.BackColor = Color.Transparent;
            RaceBtn_HalfElf.FlatStyle = FlatStyle.Popup;
            RaceBtn_HalfElf.ForeColor = SystemColors.ControlText;
            RaceBtn_HalfElf.Location = new Point(171, 84);
            RaceBtn_HalfElf.Margin = new Padding(2);
            RaceBtn_HalfElf.Name = "RaceBtn_HalfElf";
            RaceBtn_HalfElf.Size = new Size(78, 27);
            RaceBtn_HalfElf.TabIndex = 4;
            RaceBtn_HalfElf.Text = "Puolihaltija";
            RaceBtn_HalfElf.UseVisualStyleBackColor = false;
            RaceBtn_HalfElf.Click += RaceBtn_HalfElf_Click;
            // 
<<<<<<< Updated upstream
            // RaceBtn_Peikko
            // 
            RaceBtn_Peikko.BackgroundImage = Properties.Resources.Larpmasterbackground;
            RaceBtn_Peikko.Location = new Point(253, 58);
            RaceBtn_Peikko.Name = "RaceBtn_Peikko";
            RaceBtn_Peikko.Size = new Size(68, 20);
            RaceBtn_Peikko.TabIndex = 5;
            RaceBtn_Peikko.Text = "Peikko";
            RaceBtn_Peikko.UseVisualStyleBackColor = true;
            RaceBtn_Peikko.Click += RaceBtn_Peikko_Click;
=======
            // BackButton_NewChar
            // 
            BackButton_NewChar.BackColor = Color.Transparent;
            BackButton_NewChar.FlatStyle = FlatStyle.Popup;
            BackButton_NewChar.Location = new Point(464, 206);
            BackButton_NewChar.Name = "BackButton_NewChar";
            BackButton_NewChar.Size = new Size(75, 23);
            BackButton_NewChar.TabIndex = 5;
            BackButton_NewChar.Text = "Takaisin";
            BackButton_NewChar.UseVisualStyleBackColor = false;
            BackButton_NewChar.Click += BackButton_NewChar_Click;
>>>>>>> Stashed changes
            // 
            // NewCharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
<<<<<<< Updated upstream
            ClientSize = new Size(560, 270);
            Controls.Add(RaceBtn_Peikko);
=======
            ClientSize = new Size(660, 369);
            Controls.Add(BackButton_NewChar);
>>>>>>> Stashed changes
            Controls.Add(RaceBtn_HalfElf);
            Controls.Add(RaceBtn_Elf);
            Controls.Add(RaceBtn_Human);
            Controls.Add(ChooseRaceLabel);
            Margin = new Padding(2);
            Name = "NewCharacter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uusi hahmo";
            Load += NewCharacter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ChooseRaceLabel;
        private Button RaceBtn_Human;
        private Button RaceBtn_Elf;
        private Button RaceBtn_HalfElf;
<<<<<<< Updated upstream
        private Button RaceBtn_Peikko;
=======
        private Button BackButton_NewChar;
>>>>>>> Stashed changes
    }
}