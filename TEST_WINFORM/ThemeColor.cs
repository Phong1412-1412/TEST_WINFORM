using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_WINFORM
{
     public static class ThemeColor
    {
        public static List<string> ColorList = new List<string> { 
                                                    "#8B4513",
                                                    "#F4A460",
                                                    "#0000FF",
                                                    "#00BFFF",
            "#FFEFD5",
            "#FFE4B5",
            "#F0FFF0",
            "#00EE76"
        };

        public static Color changeColor(Color color ,double db)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if(db < 0)
            {
                db = 1 + db;
                red *= db; green *= db; blue *= db;
            }
            else
            {
                red = (255 - red) * db + red;
                green = (255 - green) * db + green;
                blue = (255 - blue) * db + blue;
            }
            return Color.FromArgb(color.A,(byte)red,(byte)green, (byte)blue);
        }
    }
}
