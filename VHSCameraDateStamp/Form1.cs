using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace VHSCameraDateStamp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Font vcr = new Font("VCR OSD Mono", 18);
        public string fileNameOut;
        public void imageCreate(int hrs, int mins, int secs, string date, string filepath)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Seconds = Convert.ToInt32(Math.Round(startSecs.Value, 0)); ;
            int Minutes = Convert.ToInt32(Math.Round(startMins.Value, 0));
            int Hrs = Convert.ToInt32(Math.Round(startHours.Value, 0));
            string Date = "";
            string dayValue = Convert.ToString(Day.Value);
            if (dayValue == "0") { dayValue = "0" + dayValue; } else if (dayValue == "1") { dayValue = "0" + dayValue; } else if (dayValue == "2") { dayValue = "0" + dayValue; } else if (dayValue == "3") { dayValue = "0" + dayValue; } else if (dayValue == "4") { dayValue = "0" + dayValue; } else if (dayValue == "5") { dayValue = "0" + dayValue; } else if (dayValue == "6") { dayValue = "0" + dayValue; } else if (dayValue == "7") { dayValue = "0" + dayValue; } else if (dayValue == "8") { dayValue = "0" + dayValue; } else if (dayValue == "9") { dayValue = "0" + dayValue; }
            int videoLength = (Convert.ToInt32(Math.Round(lengthHours.Value, 0)) * 3600) + (Convert.ToInt32(Math.Round(lengthMins.Value, 0)) * 60) + Convert.ToInt32(Math.Round(lengthSecs.Value, 0));
            Date = Convert.ToString(dayValue) + " " + Convert.ToString(Month.SelectedItem) + " " + Convert.ToString(year.Value);

            for (int i = 0; i < (videoLength * 6); i++)
            {
                //Timer
                Seconds++;
                if (Seconds == 60)
                {
                    Seconds = 0;
                    Minutes++;
                }
                if (Minutes == 60)
                {
                    Minutes = 0;
                    Hrs++;
                }


                Bitmap bmp = new Bitmap("filename.bmp");
                Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
                RectangleF rectf = new RectangleF(0, 0, 1000, 800);
                int fontSize = 25;
                string Hours = Convert.ToString(Hrs);
                string Mins = Convert.ToString(Minutes);
                string Secs = Convert.ToString(Seconds);

                if (Hours == "0") { Hours = "0" + Hours; } else if (Hours == "1") { Hours = "0" + Hours; } else if (Hours == "2") { Hours = "0" + Hours; } else if (Hours == "3") { Hours = "0" + Hours; } else if (Hours == "4") { Hours = "0" + Hours; } else if (Hours == "5") { Hours = "0" + Hours; } else if (Hours == "6") { Hours = "0" + Hours; } else if (Hours == "7") { Hours = "0" + Hours; } else if (Hours == "8") { Hours = "0" + Hours; } else if (Hours == "9") { Hours = "0" + Hours; }
                if (Mins == "0") { Mins = "0" + Mins; } else if (Mins == "1") { Mins = "0" + Mins; } else if (Mins == "2") { Mins = "0" + Mins; } else if (Mins == "3") { Mins = "0" + Mins; } else if (Mins == "4") { Mins = "0" + Mins; } else if (Mins == "5") { Mins = "0" + Mins; } else if (Mins == "6") { Mins = "0" + Mins; } else if (Mins == "7") { Mins = "0" + Mins; } else if (Mins == "8") { Mins = "0" + Mins; } else if (Mins == "9") { Mins = "0" + Mins; }
                if (Secs == "0") { Secs = "0" + Secs; } else if (Secs == "1") { Secs = "0" + Secs; } else if (Secs == "2") { Secs = "0" + Secs; } else if (Secs == "3") { Secs = "0" + Secs; } else if (Secs == "4") { Secs = "0" + Secs; } else if (Secs == "5") { Secs = "0" + Secs; } else if (Secs == "6") { Secs = "0" + Secs; } else if (Secs == "7") { Secs = "0" + Secs; } else if (Secs == "8") { Secs = "0" + Secs; } else if (Secs == "9") { Secs = "0" + Secs; }
                string Time = Hours + ":" + Mins + ":" + Secs;
                Graphics g = Graphics.FromImage(bmp);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.DrawString(Time, new Font("VCR OSD Mono", fontSize), Brushes.White, rectf);
                rectf = new RectangleF(0, 30, 1000, 800);
                g.DrawString(Date, new Font("VCR OSD Mono", fontSize), Brushes.White, rectf);
                GraphicsPath p = new GraphicsPath();
                p.AddString(
                    Time,             // text to draw
                    vcr.FontFamily,  // or any other font family
                    (int)FontStyle.Regular,      // font style (bold, italic, etc.)
                    g.DpiY * fontSize / 72,       // em size
                    new Point(0, 0),              // location where to draw text
                    new StringFormat());          // set options here (e.g. center alignment)
                p.AddString(
                    Date,             // text to draw
                    vcr.FontFamily,  // or any other font family
                    (int)FontStyle.Regular,      // font style (bold, italic, etc.)
                    g.DpiY * fontSize / 72,       // em size
                    new Point(0, 30),              // location where to draw text
                    new StringFormat());
                g.DrawPath(blackPen, p);
                g.Flush();
                //System.Windows.Forms.MessageBox.Show(Date,Time);
                //MessageBox.Show(Month.Vake)
                image.Image = bmp;
                string name = string.Format("image{0:d5}.png", i);
                bmp.Save((name), ImageFormat.Png);
                i++;
                name = string.Format("image{0:d5}.png", i);
                bmp.Save((name), ImageFormat.Png);
                i++;
                name = string.Format("image{0:d5}.png", i);
                bmp.Save((name), ImageFormat.Png);
                i++;
                name = string.Format("image{0:d5}.png", i);
                bmp.Save((name), ImageFormat.Png);
                i++;
                name = string.Format("image{0:d5}.png", i);
                bmp.Save((name), ImageFormat.Png);
                i++;
                name = string.Format("image{0:d5}.png", i);
                bmp.Save((name), ImageFormat.Png);




            }
            string strCmdText;
            strCmdText = "/C ffmpeg -framerate 6 -start_number 0 -i image%5d.png \"" + Location.Text + "\"  & del image*.png /Q & exit";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Motion Picture Experts Group 4 Video File|*.mp4|Matroska Video|*.mkv|Other Formats|*.*";
            saveFileDialog1.Title = "Save Video File";
            saveFileDialog1.ShowDialog();
            Location.Text = saveFileDialog1.FileName;
        }
    }
}
