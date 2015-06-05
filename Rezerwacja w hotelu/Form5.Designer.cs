namespace Rezerwacja_w_hotelu
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Imie_box = new System.Windows.Forms.TextBox();
            this.Nazwisko_box = new System.Windows.Forms.TextBox();
            this.Login_box = new System.Windows.Forms.TextBox();
            this.Pesel_box = new System.Windows.Forms.TextBox();
            this.create_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pesel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Login";
            // 
            // Imie_box
            // 
            this.Imie_box.Location = new System.Drawing.Point(84, 28);
            this.Imie_box.Name = "Imie_box";
            this.Imie_box.Size = new System.Drawing.Size(100, 20);
            this.Imie_box.TabIndex = 4;
            // 
            // Nazwisko_box
            // 
            this.Nazwisko_box.Location = new System.Drawing.Point(279, 28);
            this.Nazwisko_box.Name = "Nazwisko_box";
            this.Nazwisko_box.Size = new System.Drawing.Size(100, 20);
            this.Nazwisko_box.TabIndex = 5;
            // 
            // Login_box
            // 
            this.Login_box.Location = new System.Drawing.Point(279, 80);
            this.Login_box.Name = "Login_box";
            this.Login_box.Size = new System.Drawing.Size(100, 20);
            this.Login_box.TabIndex = 6;
            // 
            // Pesel_box
            // 
            this.Pesel_box.Location = new System.Drawing.Point(84, 80);
            this.Pesel_box.Name = "Pesel_box";
            this.Pesel_box.Size = new System.Drawing.Size(100, 20);
            this.Pesel_box.TabIndex = 7;
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(261, 158);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(75, 23);
            this.create_button.TabIndex = 8;
            this.create_button.Text = "Stwórz";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(109, 158);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 9;
            this.Cancel_button.Text = "Anuluj";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 245);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.Pesel_box);
            this.Controls.Add(this.Login_box);
            this.Controls.Add(this.Nazwisko_box);
            this.Controls.Add(this.Imie_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Imie_box;
        private System.Windows.Forms.TextBox Nazwisko_box;
        private System.Windows.Forms.TextBox Login_box;
        private System.Windows.Forms.TextBox Pesel_box;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}