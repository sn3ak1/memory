using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public sealed class Settings
    {
        private Settings() { }
        private static Settings _instance;
        public static Settings GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Settings();
            }
            return _instance;
        }

        private int size = 6;
        private int learingTime = 10;
        private int mistakeTime = 3;
        private bool computerChooses = false;

        public int Size { get => size; set => size = value; }
        public int LearingTime { get => learingTime; set => learingTime = value; }
        public int MistakeTime { get => mistakeTime; set => mistakeTime = value; }
        public bool ComputerChooses { get => computerChooses; set => computerChooses = value; }
    }
}
