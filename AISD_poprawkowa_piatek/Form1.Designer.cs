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
            this.btnstart = new System.Windows.Forms.Button();
            this.nudliczban = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.nudliczban)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(667, 382);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(121, 56);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // nudliczban
            // 
            this.nudliczban.Location = new System.Drawing.Point(358, 171);
            this.nudliczban.Name = "nudliczban";
            this.nudliczban.Size = new System.Drawing.Size(120, 23);
            this.nudliczban.TabIndex = 1;
            this.nudliczban.ValueChanged += new System.EventHandler(this.nudliczban_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudliczban);
            this.Controls.Add(this.btnstart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudliczban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnstart;
        private NumericUpDown nudliczban;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}