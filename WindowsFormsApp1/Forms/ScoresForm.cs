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
       public partial class ScoresForm : Form
    {
        public ScoresForm(List<HighScore> highScores)
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.Columns.Add("Score");
            listView1.Columns.Add("Name");
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.GridLines = true;

            foreach (var s in highScores)
            {
                listView1.Items.Add(new ListViewItem(new string[] { s.Score.ToString(), s.Nick }));
            }
        }
    }
}
