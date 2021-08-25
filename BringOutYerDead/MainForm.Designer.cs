
namespace BringOutYerDead
{
    partial class BringOutYerDead
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Characters_List = new System.Windows.Forms.ListBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.BirthDate_textbox = new System.Windows.Forms.TextBox();
            this.Sex_combobox = new System.Windows.Forms.ComboBox();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Death_list = new System.Windows.Forms.ListBox();
            this.Deaths_label = new System.Windows.Forms.Label();
            this.Death_button = new System.Windows.Forms.Button();
            this.Birth_button = new System.Windows.Forms.Button();
            this.Births_label = new System.Windows.Forms.Label();
            this.Birth_list = new System.Windows.Forms.ListBox();
            this.Date_textbox = new System.Windows.Forms.TextBox();
            this.Modifier_textbox = new System.Windows.Forms.TextBox();
            this.Remove_button = new System.Windows.Forms.Button();
            this.LoadData_button = new System.Windows.Forms.Button();
            this.SaveData_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Characters_List
            // 
            this.Characters_List.FormattingEnabled = true;
            this.Characters_List.Location = new System.Drawing.Point(12, 12);
            this.Characters_List.Name = "Characters_List";
            this.Characters_List.Size = new System.Drawing.Size(244, 433);
            this.Characters_List.TabIndex = 0;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(368, 12);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Name_textbox
            // 
            this.Name_textbox.AccessibleName = "";
            this.Name_textbox.Location = new System.Drawing.Point(262, 12);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(100, 20);
            this.Name_textbox.TabIndex = 2;
            this.Name_textbox.Text = "Name";
            // 
            // BirthDate_textbox
            // 
            this.BirthDate_textbox.Location = new System.Drawing.Point(262, 62);
            this.BirthDate_textbox.Name = "BirthDate_textbox";
            this.BirthDate_textbox.Size = new System.Drawing.Size(100, 20);
            this.BirthDate_textbox.TabIndex = 4;
            this.BirthDate_textbox.Text = "Birth date";
            // 
            // Sex_combobox
            // 
            this.Sex_combobox.FormattingEnabled = true;
            this.Sex_combobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Sex_combobox.Location = new System.Drawing.Point(262, 37);
            this.Sex_combobox.Name = "Sex_combobox";
            this.Sex_combobox.Size = new System.Drawing.Size(100, 21);
            this.Sex_combobox.TabIndex = 6;
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(368, 37);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(75, 23);
            this.Edit_button.TabIndex = 7;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Death_list
            // 
            this.Death_list.FormattingEnabled = true;
            this.Death_list.Location = new System.Drawing.Point(262, 142);
            this.Death_list.Name = "Death_list";
            this.Death_list.Size = new System.Drawing.Size(204, 303);
            this.Death_list.TabIndex = 8;
            // 
            // Deaths_label
            // 
            this.Deaths_label.AutoSize = true;
            this.Deaths_label.Location = new System.Drawing.Point(262, 117);
            this.Deaths_label.Name = "Deaths_label";
            this.Deaths_label.Size = new System.Drawing.Size(41, 13);
            this.Deaths_label.TabIndex = 9;
            this.Deaths_label.Text = "Deaths";
            // 
            // Death_button
            // 
            this.Death_button.Location = new System.Drawing.Point(304, 112);
            this.Death_button.Name = "Death_button";
            this.Death_button.Size = new System.Drawing.Size(162, 23);
            this.Death_button.TabIndex = 10;
            this.Death_button.Text = "Simulate Deaths";
            this.Death_button.UseVisualStyleBackColor = true;
            this.Death_button.Click += new System.EventHandler(this.Death_button_Click);
            // 
            // Birth_button
            // 
            this.Birth_button.Location = new System.Drawing.Point(514, 112);
            this.Birth_button.Name = "Birth_button";
            this.Birth_button.Size = new System.Drawing.Size(162, 23);
            this.Birth_button.TabIndex = 13;
            this.Birth_button.Text = "Simulate Births";
            this.Birth_button.UseVisualStyleBackColor = true;
            this.Birth_button.Click += new System.EventHandler(this.Birth_button_Click);
            // 
            // Births_label
            // 
            this.Births_label.AutoSize = true;
            this.Births_label.Location = new System.Drawing.Point(475, 117);
            this.Births_label.Name = "Births_label";
            this.Births_label.Size = new System.Drawing.Size(33, 13);
            this.Births_label.TabIndex = 12;
            this.Births_label.Text = "Births";
            // 
            // Birth_list
            // 
            this.Birth_list.FormattingEnabled = true;
            this.Birth_list.Location = new System.Drawing.Point(472, 142);
            this.Birth_list.Name = "Birth_list";
            this.Birth_list.Size = new System.Drawing.Size(204, 303);
            this.Birth_list.TabIndex = 11;
            // 
            // Date_textbox
            // 
            this.Date_textbox.Location = new System.Drawing.Point(682, 142);
            this.Date_textbox.Name = "Date_textbox";
            this.Date_textbox.Size = new System.Drawing.Size(100, 20);
            this.Date_textbox.TabIndex = 14;
            this.Date_textbox.Text = "Date";
            // 
            // Modifier_textbox
            // 
            this.Modifier_textbox.Location = new System.Drawing.Point(682, 168);
            this.Modifier_textbox.Name = "Modifier_textbox";
            this.Modifier_textbox.Size = new System.Drawing.Size(100, 20);
            this.Modifier_textbox.TabIndex = 15;
            this.Modifier_textbox.Text = "Modifier";
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(368, 62);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(75, 23);
            this.Remove_button.TabIndex = 16;
            this.Remove_button.Text = "Remove";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // LoadData_button
            // 
            this.LoadData_button.Location = new System.Drawing.Point(709, 415);
            this.LoadData_button.Name = "LoadData_button";
            this.LoadData_button.Size = new System.Drawing.Size(75, 23);
            this.LoadData_button.TabIndex = 17;
            this.LoadData_button.Text = "Load Data";
            this.LoadData_button.UseVisualStyleBackColor = true;
            // 
            // SaveData_button
            // 
            this.SaveData_button.Location = new System.Drawing.Point(709, 386);
            this.SaveData_button.Name = "SaveData_button";
            this.SaveData_button.Size = new System.Drawing.Size(75, 23);
            this.SaveData_button.TabIndex = 18;
            this.SaveData_button.Text = "Save Data";
            this.SaveData_button.UseVisualStyleBackColor = true;
            // 
            // BringOutYerDead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.SaveData_button);
            this.Controls.Add(this.LoadData_button);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.Modifier_textbox);
            this.Controls.Add(this.Date_textbox);
            this.Controls.Add(this.Birth_button);
            this.Controls.Add(this.Births_label);
            this.Controls.Add(this.Birth_list);
            this.Controls.Add(this.Death_button);
            this.Controls.Add(this.Deaths_label);
            this.Controls.Add(this.Death_list);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Sex_combobox);
            this.Controls.Add(this.BirthDate_textbox);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Characters_List);
            this.Name = "BringOutYerDead";
            this.Text = "BringOutYerDead";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Characters_List;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.TextBox BirthDate_textbox;
        private System.Windows.Forms.ComboBox Sex_combobox;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.ListBox Death_list;
        private System.Windows.Forms.Label Deaths_label;
        private System.Windows.Forms.Button Death_button;
        private System.Windows.Forms.Button Birth_button;
        private System.Windows.Forms.Label Births_label;
        private System.Windows.Forms.ListBox Birth_list;
        private System.Windows.Forms.TextBox Date_textbox;
        private System.Windows.Forms.TextBox Modifier_textbox;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.Button LoadData_button;
        private System.Windows.Forms.Button SaveData_button;
    }
}

