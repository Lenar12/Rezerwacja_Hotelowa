namespace Rezerwacja_w_hotelu
{
    partial class Form4
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
            this.numroom_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fromrez_box = new System.Windows.Forms.TextBox();
            this.Torez_box = new System.Windows.Forms.TextBox();
            this.Login_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ExistAcc_rbutton = new System.Windows.Forms.RadioButton();
            this.NewAcc_rbutton = new System.Windows.Forms.RadioButton();
            this.MakeAcc_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Tick_label = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // numroom_box
            // 
            this.numroom_box.Location = new System.Drawing.Point(96, 22);
            this.numroom_box.Name = "numroom_box";
            this.numroom_box.Size = new System.Drawing.Size(100, 20);
            this.numroom_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numer Pokoju";
            // 
            // fromrez_box
            // 
            this.fromrez_box.Location = new System.Drawing.Point(96, 66);
            this.fromrez_box.Name = "fromrez_box";
            this.fromrez_box.Size = new System.Drawing.Size(100, 20);
            this.fromrez_box.TabIndex = 26;
            this.fromrez_box.Click += new System.EventHandler(this.visible_calendar1);
            // 
            // Torez_box
            // 
            this.Torez_box.Location = new System.Drawing.Point(253, 66);
            this.Torez_box.Name = "Torez_box";
            this.Torez_box.Size = new System.Drawing.Size(100, 20);
            this.Torez_box.TabIndex = 3;
            this.Torez_box.Click += new System.EventHandler(this.visible_calendar2);
            // 
            // Login_box
            // 
            this.Login_box.Location = new System.Drawing.Point(230, 150);
            this.Login_box.Name = "Login_box";
            this.Login_box.Size = new System.Drawing.Size(100, 20);
            this.Login_box.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rezerwacja Od";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Do";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExistAcc_rbutton
            // 
            this.ExistAcc_rbutton.AutoSize = true;
            this.ExistAcc_rbutton.CausesValidation = false;
            this.ExistAcc_rbutton.Location = new System.Drawing.Point(230, 117);
            this.ExistAcc_rbutton.Name = "ExistAcc_rbutton";
            this.ExistAcc_rbutton.Size = new System.Drawing.Size(78, 17);
            this.ExistAcc_rbutton.TabIndex = 18;
            this.ExistAcc_rbutton.Text = "Mam konto";
            this.ExistAcc_rbutton.UseVisualStyleBackColor = true;
            this.ExistAcc_rbutton.CheckedChanged += new System.EventHandler(this.NewAcc_rbutton_CheckedChanged);
            // 
            // NewAcc_rbutton
            // 
            this.NewAcc_rbutton.AutoSize = true;
            this.NewAcc_rbutton.CausesValidation = false;
            this.NewAcc_rbutton.Checked = true;
            this.NewAcc_rbutton.Location = new System.Drawing.Point(16, 117);
            this.NewAcc_rbutton.Name = "NewAcc_rbutton";
            this.NewAcc_rbutton.Size = new System.Drawing.Size(96, 17);
            this.NewAcc_rbutton.TabIndex = 19;
            this.NewAcc_rbutton.TabStop = true;
            this.NewAcc_rbutton.Text = "Nie mam konta";
            this.NewAcc_rbutton.UseVisualStyleBackColor = true;
            this.NewAcc_rbutton.CheckedChanged += new System.EventHandler(this.ExistAcc_rbutton_CheckedChanged);
            // 
            // MakeAcc_button
            // 
            this.MakeAcc_button.Location = new System.Drawing.Point(16, 150);
            this.MakeAcc_button.Name = "MakeAcc_button";
            this.MakeAcc_button.Size = new System.Drawing.Size(105, 21);
            this.MakeAcc_button.TabIndex = 20;
            this.MakeAcc_button.Text = "Stwórz konto";
            this.MakeAcc_button.UseVisualStyleBackColor = true;
            this.MakeAcc_button.Click += new System.EventHandler(this.MakeAcc_button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Check";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Tick_label
            // 
            this.Tick_label.Location = new System.Drawing.Point(336, 150);
            this.Tick_label.Name = "Tick_label";
            this.Tick_label.Size = new System.Drawing.Size(31, 18);
            this.Tick_label.TabIndex = 24;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(96, 91);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 25;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(253, 91);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 27;
            this.monthCalendar2.Visible = false;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 310);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Tick_label);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.MakeAcc_button);
            this.Controls.Add(this.NewAcc_rbutton);
            this.Controls.Add(this.ExistAcc_rbutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login_box);
            this.Controls.Add(this.Torez_box);
            this.Controls.Add(this.fromrez_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numroom_box);
            this.Name = "Form4";
            this.Text = "Rezerwacja pokoju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numroom_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromrez_box;
        private System.Windows.Forms.TextBox Torez_box;
        private System.Windows.Forms.TextBox Login_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MakeAcc_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Tick_label;
        private System.Windows.Forms.RadioButton NewAcc_rbutton;
        private System.Windows.Forms.RadioButton ExistAcc_rbutton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
    }
}