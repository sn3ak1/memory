
namespace Memory
{
    partial class SettingsForm
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.size_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lt_label = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.mt_label = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(123, 28);
            this.trackBar1.Minimum = 3;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(210, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.Location = new System.Drawing.Point(206, 60);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(29, 13);
            this.size_label.TabIndex = 1;
            this.size_label.Text = "label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Board size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(28, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Learning time:";
            // 
            // lt_label
            // 
            this.lt_label.AutoSize = true;
            this.lt_label.Location = new System.Drawing.Point(206, 127);
            this.lt_label.Name = "lt_label";
            this.lt_label.Size = new System.Drawing.Size(29, 13);
            this.lt_label.TabIndex = 4;
            this.lt_label.Text = "label";
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 10;
            this.trackBar2.Location = new System.Drawing.Point(123, 95);
            this.trackBar2.Maximum = 120;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(210, 45);
            this.trackBar2.TabIndex = 3;
            this.trackBar2.Value = 6;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(28, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mistake time:";
            // 
            // mt_label
            // 
            this.mt_label.AutoSize = true;
            this.mt_label.Location = new System.Drawing.Point(206, 199);
            this.mt_label.Name = "mt_label";
            this.mt_label.Size = new System.Drawing.Size(29, 13);
            this.mt_label.TabIndex = 7;
            this.mt_label.Text = "label";
            // 
            // trackBar3
            // 
            this.trackBar3.LargeChange = 1;
            this.trackBar3.Location = new System.Drawing.Point(123, 167);
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(210, 45);
            this.trackBar3.TabIndex = 6;
            this.trackBar3.Value = 6;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Computer chooses cell?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(305, 238);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 274);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mt_label);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lt_label);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.size_label);
            this.Controls.Add(this.trackBar1);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lt_label;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mt_label;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}