using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Memory
{
    public partial class MainForm : Form
    {
        private List<HighScore> highScores;
        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            highScores = new List<HighScore>();

            var serializer = new XmlSerializer(highScores.GetType(), "HighScores.Scores");

            object obj;
            try
            {
                using (var reader = new StreamReader("highscores.xml"))
                {
                    obj = serializer.Deserialize(reader.BaseStream);
                }

                highScores = (List<HighScore>)obj;
            }
            catch (FileNotFoundException) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm game = new GameForm(textBox1.Text, highScores);
            game.Closed += (s, args) => this.Show();
            game.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ScoresForm scores = new ScoresForm(highScores);
            scores.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.Text != "";
        }
    }
}
