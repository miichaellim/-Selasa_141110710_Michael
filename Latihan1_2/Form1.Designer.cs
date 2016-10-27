namespace Latihan_2
{
    partial class Form1
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
            this.calender = new System.Windows.Forms.DateTimePicker();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calender
            // 
            this.calender.Location = new System.Drawing.Point(164, 28);
            this.calender.Name = "calender";
            this.calender.Size = new System.Drawing.Size(374, 20);
            this.calender.TabIndex = 0;
            this.calender.ValueChanged += new System.EventHandler(this.calender_ValueChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(97, 86);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(96, 253);
            this.vScrollBar1.TabIndex = 2;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(544, 86);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(96, 253);
            this.vScrollBar2.TabIndex = 2;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "MIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "MAX";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(262, 209);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(23, 31);
            this.min.TabIndex = 7;
            this.min.Text = "-";
            this.min.Click += new System.EventHandler(this.label3_Click);
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max.Location = new System.Drawing.Point(427, 209);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(23, 31);
            this.max.TabIndex = 8;
            this.max.Text = "-";
            this.max.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(345, 86);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(23, 31);
            this.lbl5.TabIndex = 9;
            this.lbl5.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 418);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.calender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker calender;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label lbl5;
    }
}

