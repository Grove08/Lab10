using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Angle
    {
        int gradus;
        int min;
        int sec;
        public bool isCorrect = true;
        
        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value >= 0 && value < 360)
                    gradus = value;
                else
                    isCorrect = false;
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value >= 0 && value < 60)
                    min = value;
                else
                {
                    Gradus += value / 60;
                    min = value % 60;
                }
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value >= 0 && value < 60)
                    sec = value;
                else
                {
                    Min += value / 60;
                    sec = value % 60;
                }
            }
        }

        public Angle(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
        public double ToRadians()
        {
            return (gradus + (min / 60.0) + (sec / 3600.0)) * Math.PI / 180.0;
        }
    }
}
