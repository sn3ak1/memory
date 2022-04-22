using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable()]
    public class HighScore : IComparable
    {
        public int Score { get; set; }
        public string Nick { get; set; }

        public int CompareTo(object obj)
        {
            return ((HighScore)obj).Score-this.Score;
        }
    }
}
