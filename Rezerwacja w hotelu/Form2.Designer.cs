namespace Rezerwacja_w_hotelu
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberroom_box = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.uzytkownicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza_danychDataSet = new Rezerwacja_w_hotelu.baza_danychDataSet();
            this.uzytkownicyTableAdapter = new Rezerwacja_w_hotelu.baza_danychDataSetTableAdapters.uzytkownicyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uzytkownicyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_danychDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(722, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(467, 240);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "wolne pokoje";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(607, 240);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "liczba miejsc";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtry wyświetlania";
            // 
            // numberroom_box
            // 
            this.numberroom_box.Location = new System.Drawing.Point(607, 270);
            this.numberroom_box.Name = "numberroom_box";
            this.numberroom_box.Size = new System.Drawing.Size(107, 20);
            this.numberroom_box.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Rezerwuj pokoj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Więcej informacji";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 388);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numberroom_box);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pokoje";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::Rezerwacja_w_hotelu.Properties.Resources.logout;
            this.button4.Location = new System.Drawing.Point(18, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 47);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // uzytkownicyBindingSource
            // 
            this.uzytkownicyBindingSource.DataMember = "uzytkownicy";
            this.uzytkownicyBindingSource.DataSource = this.baza_danychDataSet;
            // 
            // baza_danychDataSet
            // 
            this.baza_danychDataSet.DataSetName = "baza_danychDataSet";
            this.baza_danychDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uzytkownicyTableAdapter
            // 
            this.uzytkownicyTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 383);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Panel Recepcjonisty";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uzytkownicyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_danychDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberroom_box;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private baza_danychDataSet baza_danychDataSet;
        private System.Windows.Forms.BindingSource uzytkownicyBindingSource;
        private baza_danychDataSetTableAdapters.uzytkownicyTableAdapter uzytkownicyTableAdapter;
        private System.Windows.Forms.Button button4;


    }
}