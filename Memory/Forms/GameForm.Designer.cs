
namespace Memory
{
    partial class GameForm
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
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mt_label = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp.ColumnCount = 1;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp.Location = new System.Drawing.Point(12, 64);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 1;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp.Size = new System.Drawing.Size(1395, 765);
            this.tlp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(69, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time elapsed: 0 minutes 0 seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(630, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mistakes: 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(1009, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mistake time:";
            // 
            // mt_label
            // 
            this.mt_label.AutoSize = true;
            this.mt_label.Location = new System.Drawing.Point(1187, 44);
            this.mt_label.Name = "mt_label";
            this.mt_label.Size = new System.Drawing.Size(29, 13);
            this.mt_label.TabIndex = 10;
            this.mt_label.Text = "label";
            // 
            // trackBar3
            // 
            this.trackBar3.LargeChange = 1;
            this.trackBar3.Location = new System.Drawing.Point(1104, 12);
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(210, 45);
            this.trackBar3.TabIndex = 9;
            this.trackBar3.Value = 6;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 841);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mt_label);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tlp);
            this.Name = "GameForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mt_label;
        private System.Windows.Forms.TrackBar trackBar3;
    }
}