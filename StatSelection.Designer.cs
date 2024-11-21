namespace Larpmaster
{
    partial class StatSelection
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
            StatValue1 = new TextBox();
            StatValue2 = new TextBox();
            StatValue3 = new TextBox();
            StatValue4 = new TextBox();
            StatValue5 = new TextBox();
            StatValue6 = new TextBox();
            StatValue7 = new TextBox();
            StatValue8 = new TextBox();
            StatSelectionInstruction = new Label();
            StatValue_Int = new TextBox();
            StatLabel_Int = new Label();
            SuspendLayout();
            // 
            // StatValue1
            // 
            StatValue1.BackColor = SystemColors.Control;
            StatValue1.Location = new Point(81, 47);
            StatValue1.Margin = new Padding(2);
            StatValue1.Name = "StatValue1";
            StatValue1.Size = new Size(35, 23);
            StatValue1.TabIndex = 1;
            StatValue1.Text = "100";
            StatValue1.TextChanged += StatValue1_TextChanged;
            // 
            // StatValue2
            // 
            StatValue2.Location = new Point(81, 73);
            StatValue2.Margin = new Padding(2);
            StatValue2.Name = "StatValue2";
            StatValue2.Size = new Size(35, 23);
            StatValue2.TabIndex = 2;
            // 
            // StatValue3
            // 
            StatValue3.Location = new Point(81, 95);
            StatValue3.Margin = new Padding(2);
            StatValue3.Name = "StatValue3";
            StatValue3.Size = new Size(35, 23);
            StatValue3.TabIndex = 3;
            // 
            // StatValue4
            // 
            StatValue4.Location = new Point(81, 118);
            StatValue4.Margin = new Padding(2);
            StatValue4.Name = "StatValue4";
            StatValue4.Size = new Size(35, 23);
            StatValue4.TabIndex = 4;
            // 
            // StatValue5
            // 
            StatValue5.Location = new Point(81, 140);
            StatValue5.Margin = new Padding(2);
            StatValue5.Name = "StatValue5";
            StatValue5.Size = new Size(35, 23);
            StatValue5.TabIndex = 5;
            // 
            // StatValue6
            // 
            StatValue6.Location = new Point(81, 162);
            StatValue6.Margin = new Padding(2);
            StatValue6.Name = "StatValue6";
            StatValue6.Size = new Size(35, 23);
            StatValue6.TabIndex = 6;
            // 
            // StatValue7
            // 
            StatValue7.Location = new Point(81, 184);
            StatValue7.Margin = new Padding(2);
            StatValue7.Name = "StatValue7";
            StatValue7.Size = new Size(35, 23);
            StatValue7.TabIndex = 7;
            // 
            // StatValue8
            // 
            StatValue8.Location = new Point(81, 206);
            StatValue8.Margin = new Padding(2);
            StatValue8.Name = "StatValue8";
            StatValue8.Size = new Size(35, 23);
            StatValue8.TabIndex = 8;
            // 
            // StatSelectionInstruction
            // 
            StatSelectionInstruction.AutoSize = true;
            StatSelectionInstruction.BackColor = Color.Transparent;
            StatSelectionInstruction.Location = new Point(177, 25);
            StatSelectionInstruction.Margin = new Padding(2, 0, 2, 0);
            StatSelectionInstruction.Name = "StatSelectionInstruction";
            StatSelectionInstruction.Size = new Size(268, 15);
            StatSelectionInstruction.TabIndex = 9;
            StatSelectionInstruction.Text = "Siirrä hiirellä vasemmalta oikealle haluamasi arvot";
            // 
            // StatValue_Int
            // 
            StatValue_Int.AllowDrop = true;
            StatValue_Int.Location = new Point(251, 51);
            StatValue_Int.Margin = new Padding(2);
            StatValue_Int.Name = "StatValue_Int";
            StatValue_Int.Size = new Size(106, 23);
            StatValue_Int.TabIndex = 10;
            StatValue_Int.TextChanged += textBox1_TextChanged;
            // 
            // StatLabel_Int
            // 
            StatLabel_Int.AutoSize = true;
            StatLabel_Int.BackColor = Color.Transparent;
            StatLabel_Int.Location = new Point(183, 51);
            StatLabel_Int.Margin = new Padding(2, 0, 2, 0);
            StatLabel_Int.Name = "StatLabel_Int";
            StatLabel_Int.Size = new Size(53, 15);
            StatLabel_Int.TabIndex = 11;
            StatLabel_Int.Text = "Älykkyys";
            // 
            // StatSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            ClientSize = new Size(771, 352);
            Controls.Add(StatLabel_Int);
            Controls.Add(StatValue_Int);
            Controls.Add(StatSelectionInstruction);
            Controls.Add(StatValue8);
            Controls.Add(StatValue7);
            Controls.Add(StatValue6);
            Controls.Add(StatValue5);
            Controls.Add(StatValue4);
            Controls.Add(StatValue3);
            Controls.Add(StatValue2);
            Controls.Add(StatValue1);
            Margin = new Padding(2);
            Name = "StatSelection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StatSelection";
            Load += StatSelection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox StatValue1;
        private TextBox StatValue2;
        private TextBox StatValue3;
        private TextBox StatValue4;
        private TextBox StatValue5;
        private TextBox StatValue6;
        private TextBox StatValue7;
        private TextBox StatValue8;
        private Label StatSelectionInstruction;
        private TextBox StatValue_Int;
        private Label StatLabel_Int;
    }
}