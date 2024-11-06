namespace Larpmaster
{
    partial class Pelinjohto
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
            editCharBtn = new Button();
            editItemListBtn = new Button();
            newItemBtn = new Button();
            newSpellBtn = new Button();
            newCultBtn = new Button();
            addYearBtn = new Button();
            deleteSpellBtn = new Button();
            deleteCultBtn = new Button();
            SuspendLayout();
            // 
            // editCharBtn
            // 
            editCharBtn.Location = new Point(76, 186);
            editCharBtn.Name = "editCharBtn";
            editCharBtn.Size = new Size(144, 29);
            editCharBtn.TabIndex = 0;
            editCharBtn.Text = "Editoi hahmoa";
            editCharBtn.UseVisualStyleBackColor = true;
            // 
            // editItemListBtn
            // 
            editItemListBtn.Location = new Point(76, 245);
            editItemListBtn.Name = "editItemListBtn";
            editItemListBtn.Size = new Size(140, 29);
            editItemListBtn.TabIndex = 1;
            editItemListBtn.Text = "Editoi esinelistaa";
            editItemListBtn.UseVisualStyleBackColor = true;
            // 
            // newItemBtn
            // 
            newItemBtn.Location = new Point(76, 307);
            newItemBtn.Name = "newItemBtn";
            newItemBtn.Size = new Size(140, 29);
            newItemBtn.TabIndex = 2;
            newItemBtn.Text = "Uusi esine";
            newItemBtn.UseVisualStyleBackColor = true;
            // 
            // newSpellBtn
            // 
            newSpellBtn.Location = new Point(273, 307);
            newSpellBtn.Name = "newSpellBtn";
            newSpellBtn.Size = new Size(94, 29);
            newSpellBtn.TabIndex = 3;
            newSpellBtn.Text = "Uusi loitsu";
            newSpellBtn.UseVisualStyleBackColor = true;
            // 
            // newCultBtn
            // 
            newCultBtn.Location = new Point(396, 307);
            newCultBtn.Name = "newCultBtn";
            newCultBtn.Size = new Size(94, 29);
            newCultBtn.TabIndex = 4;
            newCultBtn.Text = "Uusi kultti";
            newCultBtn.UseVisualStyleBackColor = true;
            // 
            // addYearBtn
            // 
            addYearBtn.Location = new Point(108, 381);
            addYearBtn.Name = "addYearBtn";
            addYearBtn.Size = new Size(94, 29);
            addYearBtn.TabIndex = 5;
            addYearBtn.Text = "Lisää vuosi";
            addYearBtn.UseVisualStyleBackColor = true;
            // 
            // deleteSpellBtn
            // 
            deleteSpellBtn.Location = new Point(302, 382);
            deleteSpellBtn.Name = "deleteSpellBtn";
            deleteSpellBtn.Size = new Size(132, 29);
            deleteSpellBtn.TabIndex = 6;
            deleteSpellBtn.Text = "Poista Loitsu";
            deleteSpellBtn.UseVisualStyleBackColor = true;
            // 
            // deleteCultBtn
            // 
            deleteCultBtn.Location = new Point(472, 382);
            deleteCultBtn.Name = "deleteCultBtn";
            deleteCultBtn.Size = new Size(120, 29);
            deleteCultBtn.TabIndex = 7;
            deleteCultBtn.Text = "Poista Kultti";
            deleteCultBtn.UseVisualStyleBackColor = true;
            // 
            // Pelinjohto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Larpmasterbackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1377, 936);
            Controls.Add(deleteCultBtn);
            Controls.Add(deleteSpellBtn);
            Controls.Add(addYearBtn);
            Controls.Add(newCultBtn);
            Controls.Add(newSpellBtn);
            Controls.Add(newItemBtn);
            Controls.Add(editItemListBtn);
            Controls.Add(editCharBtn);
            Name = "Pelinjohto";
            Text = "AdminPanel";
            ResumeLayout(false);
        }

        #endregion

        private Button editCharBtn;
        private Button editItemListBtn;
        private Button newItemBtn;
        private Button newSpellBtn;
        private Button newCultBtn;
        private Button addYearBtn;
        private Button deleteSpellBtn;
        private Button deleteCultBtn;
    }
}