namespace AISD_poprawkowa_piatek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnstart = new Button();
            nudliczban = new NumericUpDown();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnsort = new Button();
            btn_selectsort = new Button();
            ((System.ComponentModel.ISupportInitialize)nudliczban).BeginInit();
            SuspendLayout();
            // 
            // btnstart
            // 
            btnstart.Location = new Point(667, 382);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(121, 56);
            btnstart.TabIndex = 0;
            btnstart.Text = "Start";
            btnstart.UseVisualStyleBackColor = true;
            btnstart.Click += btnstart_Click;
            // 
            // nudliczban
            // 
            nudliczban.Location = new Point(358, 171);
            nudliczban.Name = "nudliczban";
            nudliczban.Size = new Size(120, 23);
            nudliczban.TabIndex = 1;
            nudliczban.ValueChanged += nudliczban_ValueChanged;
            // 
            // btnsort
            // 
            btnsort.Location = new Point(555, 382);
            btnsort.Name = "btnsort";
            btnsort.Size = new Size(106, 56);
            btnsort.TabIndex = 2;
            btnsort.Text = "Sortowanie Bąbelkowe";
            btnsort.UseVisualStyleBackColor = true;
            btnsort.Click += btnsort_Click;
            // 
            // btn_selectsort
            // 
            btn_selectsort.Location = new Point(427, 382);
            btn_selectsort.Name = "btn_selectsort";
            btn_selectsort.Size = new Size(116, 56);
            btn_selectsort.TabIndex = 3;
            btn_selectsort.Text = "Sortowanie Select Swap";
            btn_selectsort.UseVisualStyleBackColor = true;
            btn_selectsort.Click += btn_selectsort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 447);
            Controls.Add(btn_selectsort);
            Controls.Add(btnsort);
            Controls.Add(nudliczban);
            Controls.Add(btnstart);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudliczban).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnstart;
        private NumericUpDown nudliczban;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnsort;
        private Button btn_selectsort;
    }
}