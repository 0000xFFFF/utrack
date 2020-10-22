using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Management;
using System.Runtime.InteropServices;

namespace utrack
{
    public partial class utrack : Form
    {
        public utrack()
        {
            InitializeComponent();
        }

        private void utrack_Load(object sender, EventArgs e)
        {
            startMonitorThread();
            updateValue();
        }

        private void startMonitorThread()
        {
            new Thread(Monitor) { IsBackground = true }.Start();
        }

        private static bool quit = false;
        private void Monitor()
        {
            try
            {

                PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

                while (!quit)
                {
                    double cpu = Math.Round(cpuCounter.NextValue(), 2);
                    double ram = 0;

                    ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
                    ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(objectQuery);
                    ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
                    foreach (ManagementObject managementObject in managementObjectCollection)
                    {
                        double tot = double.Parse(managementObject["TotalVisibleMemorySize"].ToString()) * 1024;
                        double free = double.Parse(managementObject["FreePhysicalMemory"].ToString()) * 1024;
                        double virttot = double.Parse(managementObject["TotalVirtualMemorySize"].ToString()) * 1024;
                        double virtfree = double.Parse(managementObject["FreeVirtualMemory"].ToString()) * 1024;

                        ram = Math.Round(100 - free / tot * 100, 2);

                        show_ram_usage.Text =
                          "RAM USAGE: " + ram + "%"                    + Environment.NewLine
                        + "|- Total Visible Memory.: " + ROund(tot)      + " (" + tot      + "B)"  + Environment.NewLine
                        + "|- Free Physical Memory.: " + ROund(free)     + " (" + free     + " B)" + Environment.NewLine
                        + "|- Total Virtual Memory.: " + ROund(virttot)  + " (" + virttot  + " B)" + Environment.NewLine
                        + "+- Free Virtual Memory..: " + ROund(virtfree) + " (" + virtfree + " B)";
                    }

                    //print
                    show_cpu_usage.Text = "CPU USAGE: " + cpu + "%";
                    //show_ram_usage.Text = "RAM: " + Math.Round(ram, 2) + "MB";
                    SystemTrayIcon.Text =
                          "CPU: " + cpu.ToString() + "%" + Environment.NewLine
                        + "RAM: " + ram.ToString() + "%";

                    Bitmap bmp = draw_image(cpu, ram);

                    //convert and show on icon
                    SystemTrayIcon.Icon = Icon.FromHandle(bmp.GetHicon());

                    pictureBox.Image = bmp;

                    Thread.Sleep(trackBar.Value);
                }
            }
            catch (Exception e) { Console.Error.WriteLine(e.Message); startMonitorThread(); }
        }

        private Bitmap draw_image(double cpu_usage, double ram_usage)
        {
            Bitmap image = new Bitmap(100, 100);

            using (Graphics g = Graphics.FromImage(image))
            {
                g.Clear(Color.FromArgb(10, 10, 10));
                g.FillRectangle(Brushes.Cyan, new Rectangle(0, 0, image.Width / 2 - 5, (int)cpu_usage));
                g.FillRectangle(Brushes.Lime, new Rectangle(image.Width / 2 + 5, 0, image.Width / 2 + 5, (int)ram_usage));

                Rectangle rect = new Rectangle(0, 0, 100, 100);
                int penWidth = 5;
                using (Pen pen = new Pen(Color.Red, penWidth))
                {
                    float shrinkAmount = pen.Width / 2;
                    g.DrawRectangle(
                        pen,
                        rect.X + shrinkAmount,   // move half a pen-width to the right
                        rect.Y + shrinkAmount,   // move half a pen-width to the down
                        rect.Width - penWidth,   // shrink width with one pen-width
                        rect.Height - penWidth); // shrink height with one pen-width
                }
            }
            //flip vert
            image.RotateFlip(RotateFlipType.Rotate180FlipX);
            return image;
        }
        
        private void SystemTrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:  this.Visible = !this.Visible;  break;
                case MouseButtons.Right: Environment.Exit(0);           break;
            }
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            updateValue();
        }

        void updateValue()
        {
            label_delay.Text = "Delay: " + trackBar.Value + " ms";
        }

        public static string ROund(double len)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }
            return string.Format("{0:0.##} {1}", len, sizes[order]);
        }
    }
}
