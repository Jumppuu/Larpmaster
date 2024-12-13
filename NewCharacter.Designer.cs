namespace Larpmaster
{
    partial class NewCharacter
    {
        private System.ComponentModel.IContainer components = null;
        private Label ChooseRaceLabel;
        private Button RaceBtn_Human;
        private Button RaceBtn_Elf;
        private Button RaceBtn_HalfElf;
        private Button RaceBtn_Peikko;
        private Button BackButton_NewChar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ChooseRaceLabel = new Label();
            RaceBtn_Human = new Button();
            RaceBtn_Elf = new Button();
            RaceBtn_HalfElf = new Button();
            RaceBtn_Peikko = new Button();
            BackButton_NewChar = new Button();
            SuspendLayout();
            // 
            // ChooseRaceLabel
            // 
            ChooseRaceLabel.AutoSize = true;
            ChooseRaceLabel.BackColor = Color.Transparent;
            ChooseRaceLabel.Font = new Font("Elephant", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChooseRaceLabel.Location = new Point(204, 39);
            ChooseRaceLabel.Margin = new Padding(2, 0, 2, 0);
            ChooseRaceLabel.Name = "ChooseRaceLabel";
            ChooseRaceLabel.Size = new Size(105, 21);
            ChooseRaceLabel.TabIndex = 1;
            ChooseRaceLabel.Text = "Valitse rotu:";
            // 
            // RaceBtn_Human
            // 
            RaceBtn_Human.BackColor = Color.Transparent;
            RaceBtn_Human.FlatStyle = FlatStyle.Popup;
            RaceBtn_Human.Location = new Point(204, 99);
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
            RaceBtn_Elf.Location = new Point(279, 99);
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
            RaceBtn_HalfElf.Location = new Point(352, 99);
            RaceBtn_HalfElf.Margin = new Padding(2);
            RaceBtn_HalfElf.Name = "RaceBtn_HalfElf";
            RaceBtn_HalfElf.Size = new Size(78, 27);
            RaceBtn_HalfElf.TabIndex = 4;
            RaceBtn_HalfElf.Text = "Puolihaltija";
            RaceBtn_HalfElf.UseVisualStyleBackColor = false;
            RaceBtn_HalfElf.Click += RaceBtn_HalfElf_Click;
            // 
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
            // 
            // BackButton_NewChar
            // 
            BackButton_NewChar.BackColor = Color.Transparent;
            BackButton_NewChar.FlatStyle = FlatStyle.Popup;
            BackButton_NewChar.Location = new Point(573, 25);
            BackButton_NewChar.Name = "BackButton_NewChar";
            BackButton_NewChar.Size = new Size(75, 23);
            BackButton_NewChar.TabIndex = 5;
            BackButton_NewChar.Text = "Takaisin";
            BackButton_NewChar.UseVisualStyleBackColor = false;
            BackButton_NewChar.Click += BackButton_NewChar_Click;
            // 
            // NewCharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            ClientSize = new Size(660, 369);
            Controls.Add(BackButton_NewChar);
            Controls.Add(RaceBtn_HalfElf);
            Controls.Add(RaceBtn_Elf);
            Controls.Add(RaceBtn_Human);
            Controls.Add(ChooseRaceLabel);
            Margin = new Padding(2);
            Name = "NewCharacter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uusi hahmo";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}