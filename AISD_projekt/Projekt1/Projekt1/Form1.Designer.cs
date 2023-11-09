namespace Projekt1
{
    partial class Form1
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
            this.text_box1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label_czas_1 = new System.Windows.Forms.Label();
            this.label_czas = new System.Windows.Forms.Label();
            this.btn_sb = new System.Windows.Forms.Button();
            this.btn_ss = new System.Windows.Forms.Button();
            this.btn_si = new System.Windows.Forms.Button();
            this.btn_sm = new System.Windows.Forms.Button();
            this.btn_sq = new System.Windows.Forms.Button();
            this.btn_generuj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_box1
            // 
            this.text_box1.Location = new System.Drawing.Point(62, 50);
            this.text_box1.Name = "text_box1";
            this.text_box1.Size = new System.Drawing.Size(193, 20);
            this.text_box1.TabIndex = 0;
            this.text_box1.TextChanged += new System.EventHandler(this.text_box1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(297, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Losuj";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(497, 50);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(171, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label_czas_1
            // 
            this.label_czas_1.AutoSize = true;
            this.label_czas_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_czas_1.Location = new System.Drawing.Point(361, 288);
            this.label_czas_1.Name = "label_czas_1";
            this.label_czas_1.Size = new System.Drawing.Size(133, 20);
            this.label_czas_1.TabIndex = 3;
            this.label_czas_1.Text = "Czas Sortowania:";
            // 
            // label_czas
            // 
            this.label_czas.AutoSize = true;
            this.label_czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_czas.Location = new System.Drawing.Point(506, 288);
            this.label_czas.Name = "label_czas";
            this.label_czas.Size = new System.Drawing.Size(0, 20);
            this.label_czas.TabIndex = 4;
            // 
            // btn_sb
            // 
            this.btn_sb.Location = new System.Drawing.Point(48, 356);
            this.btn_sb.Name = "btn_sb";
            this.btn_sb.Size = new System.Drawing.Size(90, 48);
            this.btn_sb.TabIndex = 5;
            this.btn_sb.Text = "SB";
            this.btn_sb.UseVisualStyleBackColor = true;
            this.btn_sb.Click += new System.EventHandler(this.btn_sb_Click);
            // 
            // btn_ss
            // 
            this.btn_ss.Location = new System.Drawing.Point(165, 356);
            this.btn_ss.Name = "btn_ss";
            this.btn_ss.Size = new System.Drawing.Size(90, 48);
            this.btn_ss.TabIndex = 6;
            this.btn_ss.Text = "SS";
            this.btn_ss.UseVisualStyleBackColor = true;
            this.btn_ss.Click += new System.EventHandler(this.btn_ss_Click);
            // 
            // btn_si
            // 
            this.btn_si.Location = new System.Drawing.Point(283, 356);
            this.btn_si.Name = "btn_si";
            this.btn_si.Size = new System.Drawing.Size(90, 48);
            this.btn_si.TabIndex = 7;
            this.btn_si.Text = "SI";
            this.btn_si.UseVisualStyleBackColor = true;
            this.btn_si.Click += new System.EventHandler(this.btn_si_Click);
            // 
            // btn_sm
            // 
            this.btn_sm.Location = new System.Drawing.Point(404, 356);
            this.btn_sm.Name = "btn_sm";
            this.btn_sm.Size = new System.Drawing.Size(90, 48);
            this.btn_sm.TabIndex = 8;
            this.btn_sm.Text = "SM";
            this.btn_sm.UseVisualStyleBackColor = true;
            this.btn_sm.Click += new System.EventHandler(this.btn_sm_Click);
            // 
            // btn_sq
            // 
            this.btn_sq.Location = new System.Drawing.Point(520, 356);
            this.btn_sq.Name = "btn_sq";
            this.btn_sq.Size = new System.Drawing.Size(90, 48);
            this.btn_sq.TabIndex = 9;
            this.btn_sq.Text = "SQ";
            this.btn_sq.UseVisualStyleBackColor = true;
            this.btn_sq.Click += new System.EventHandler(this.btn_sq_Click);
            // 
            // btn_generuj
            // 
            this.btn_generuj.Location = new System.Drawing.Point(497, 88);
            this.btn_generuj.Name = "btn_generuj";
            this.btn_generuj.Size = new System.Drawing.Size(171, 43);
            this.btn_generuj.TabIndex = 10;
            this.btn_generuj.Text = "Generuj";
            this.btn_generuj.UseVisualStyleBackColor = true;
            this.btn_generuj.Click += new System.EventHandler(this.btn_generuj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(58, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_generuj);
            this.Controls.Add(this.btn_sq);
            this.Controls.Add(this.btn_sm);
            this.Controls.Add(this.btn_si);
            this.Controls.Add(this.btn_ss);
            this.Controls.Add(this.btn_sb);
            this.Controls.Add(this.label_czas);
            this.Controls.Add(this.label_czas_1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.text_box1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_box1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label_czas_1;
        private System.Windows.Forms.Label label_czas;
        private System.Windows.Forms.Button btn_sb;
        private System.Windows.Forms.Button btn_ss;
        private System.Windows.Forms.Button btn_si;
        private System.Windows.Forms.Button btn_sm;
        private System.Windows.Forms.Button btn_sq;
        private System.Windows.Forms.Button btn_generuj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

