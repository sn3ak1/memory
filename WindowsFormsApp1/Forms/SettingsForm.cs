using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SettingsForm : Form
    {
        Settings settings;

        public SettingsForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            settings = Settings.GetInstance();
            trackBar1.Value = settings.Size;
            size_label.Text = (trackBar1.Value * (trackBar1.Value+1)).ToString() + " tiles";
            trackBar2.Value = settings.LearingTime;
            lt_label.Text = trackBar2.Value.ToString() + " seconds";
            trackBar3.Value = settings.MistakeTime;
            mt_label.Text = trackBar3.Value.ToString() + " seconds";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            size_label.Text = (trackBar1.Value*(trackBar1.Value+1)).ToString() + " tiles";
            settings.Size = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lt_label.Text = trackBar2.Value.ToString() + " seconds";
            settings.LearingTime = trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            mt_label.Text = trackBar3.Value.ToString() + " seconds";
            settings.MistakeTime = trackBar3.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            settings.ComputerChooses = checkBox1.Checked;
        }
    }
}
