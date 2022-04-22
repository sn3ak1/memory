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

namespace WindowsFormsApp1
{
    public partial class GameForm : Form
    {
        private readonly Timer timer1 = new Timer();
        private readonly Timer timer2 = new Timer();
        private readonly Timer timer3 = new Timer();

        private Cell[] lastClick;
        private bool clickable = false;

        private Settings settings;

        private uint timeElapsed = 0;
        private uint mistakes = 0;

        private string nick;
        private uint matched = 0;

        private List<HighScore> highScores;

        private Random random;

        public GameForm(string nick, List<HighScore> highScores)
        {
            InitializeComponent();
            this.nick = nick;
            this.highScores = highScores;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            settings = Settings.GetInstance();

            trackBar3.Value = settings.MistakeTime;
            mt_label.Text = trackBar3.Value.ToString() + " seconds";

            lastClick = new Cell[2];

            tlp.ColumnCount = settings.Size+1;
            tlp.RowCount = settings.Size;

            tlp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            tlp.RowStyles.RemoveAt(0);
            tlp.ColumnStyles.RemoveAt(0);
            for (int i = 0; i < tlp.RowCount; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / tlp.ColumnCount));
            }
            for (int i = 0; i < tlp.ColumnCount; i++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / tlp.ColumnCount));
            }

            tlp.SuspendLayout();

            List<int> indexes = Enumerable.Range(0, tlp.RowCount * tlp.ColumnCount).ToList();
            random = new Random();

            for (int i=0; indexes.Count!=0; i++)
            {
                Cell cc = new Cell
                {
                    ImgID = (i + 1) % 2 == 0 ? i/2 : (i+1)/2
                };
                cc.Click += cell_Click;
                int r = random.Next(indexes.Count);
                int index = indexes[r];
                indexes.RemoveAt(r);
                tlp.Controls.Add(cc, index % tlp.ColumnCount, index / tlp.ColumnCount );
            }

            
            tlp.ResumeLayout();

            timer1.Tick += Timer1EventProcessor;
            timer2.Tick += Timer2EventProcessor;
            timer3.Tick += Timer3EventProcessor;

            timer1.Interval = settings.LearingTime*1000;
            timer2.Interval = settings.MistakeTime * 1000;
            timer3.Interval = 1000;

            timer1.Start();
            timer3.Start();
        }


        private void cell_Click(object sender, EventArgs e)
        {
            if (!clickable || sender==lastClick[0]) return;

            lastClick[1] = (Cell)sender;
            lastClick[1].Image = lastClick[1].Img;
            if (lastClick[0] == null) lastClick[0] = lastClick[1];
            else
            {
                if(lastClick[0].ImgID != lastClick[1].ImgID)
                {
                    clickable = false;
                    mistakes++;
                    label2.Text = "Mistakes: " + mistakes.ToString();
                    timer2.Start();
                }
                else
                {
                    for (int i = 0; i < lastClick.Length; i++)
                    {
                        tlp.Controls.Remove(lastClick[i]);
                        lastClick[i].Dispose();
                        lastClick[i] = null;
                        matched++;
                        if (tlp.RowCount * tlp.ColumnCount == matched) gameOver();
                    }

                    if (settings.ComputerChooses && tlp.Controls.Count>0)
                    {
                        cell_Click(tlp.Controls[random.Next(tlp.Controls.Count)], EventArgs.Empty);
                    }
                }
            }
        }

        private void Timer1EventProcessor(object myObject, EventArgs myEventArgs)
        {
            timer1.Stop();
            foreach (var control in tlp.Controls)
            {
                var c = (Cell)control;
                c.Image = null;
            }
            clickable = true;

            if (settings.ComputerChooses)
            {
                cell_Click(tlp.Controls[random.Next(tlp.Controls.Count)], EventArgs.Empty);
            }
        }

        private void Timer2EventProcessor(object myObject, EventArgs myEventArgs)
        {
            timer2.Stop();
            for (int i = 0; i < lastClick.Length; i++)
            {
                lastClick[i].Image = null;
                lastClick[i] = null;
            }
            clickable = true;

            if (settings.ComputerChooses)
            {
                cell_Click(tlp.Controls[random.Next(tlp.Controls.Count)], EventArgs.Empty);
            }
        }

        private void Timer3EventProcessor(object myObject, EventArgs myEventArgs)
        {
            timeElapsed++;
            label1.Text = "Time elapsed: " + (timeElapsed / 60).ToString() + " minutes " + (timeElapsed % 60).ToString() +" seconds";
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            mt_label.Text = trackBar3.Value.ToString() + " seconds";
            settings.MistakeTime = trackBar3.Value;
            timer2.Interval = settings.MistakeTime * 1000;
        }


        private void gameOver()
        {
            var serializer = new XmlSerializer(highScores.GetType(), "HighScores.Scores");

            var score = new HighScore() { Score = (int)((1000*tlp.RowCount*tlp.ColumnCount)/(timeElapsed+mistakes*10)), Nick = nick };

            var index = highScores.BinarySearch(score);
            if (index < 0) index = ~index;
            highScores.Insert(index, score);

            using (var writer = new StreamWriter("highscores.xml", false))
            {
                serializer.Serialize(writer.BaseStream, highScores);
            }

            ScoresForm scores = new ScoresForm(highScores);
            scores.ShowDialog();
            this.Close();
        }
    }
}
