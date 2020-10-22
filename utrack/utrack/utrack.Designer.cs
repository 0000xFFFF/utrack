namespace utrack
{
    partial class utrack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(utrack));
            this.show_cpu_usage = new System.Windows.Forms.Label();
            this.show_ram_usage = new System.Windows.Forms.Label();
            this.SystemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label_cpu = new System.Windows.Forms.Label();
            this.label_ram = new System.Windows.Forms.Label();
            this.label_delay = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // show_cpu_usage
            // 
            this.show_cpu_usage.AutoSize = true;
            this.show_cpu_usage.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.show_cpu_usage.ForeColor = System.Drawing.Color.Cyan;
            this.show_cpu_usage.Location = new System.Drawing.Point(121, 27);
            this.show_cpu_usage.Name = "show_cpu_usage";
            this.show_cpu_usage.Size = new System.Drawing.Size(28, 15);
            this.show_cpu_usage.TabIndex = 0;
            this.show_cpu_usage.Text = "...";
            // 
            // show_ram_usage
            // 
            this.show_ram_usage.AutoSize = true;
            this.show_ram_usage.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.show_ram_usage.ForeColor = System.Drawing.Color.Lime;
            this.show_ram_usage.Location = new System.Drawing.Point(121, 42);
            this.show_ram_usage.Name = "show_ram_usage";
            this.show_ram_usage.Size = new System.Drawing.Size(28, 15);
            this.show_ram_usage.TabIndex = 1;
            this.show_ram_usage.Text = "...";
            // 
            // SystemTrayIcon
            // 
            this.SystemTrayIcon.Text = "...";
            this.SystemTrayIcon.Visible = true;
            this.SystemTrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SystemTrayIcon_MouseClick);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pictureBox.Location = new System.Drawing.Point(15, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // label_cpu
            // 
            this.label_cpu.AutoSize = true;
            this.label_cpu.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cpu.ForeColor = System.Drawing.Color.Cyan;
            this.label_cpu.Location = new System.Drawing.Point(12, 9);
            this.label_cpu.Name = "label_cpu";
            this.label_cpu.Size = new System.Drawing.Size(28, 15);
            this.label_cpu.TabIndex = 7;
            this.label_cpu.Text = "CPU";
            // 
            // label_ram
            // 
            this.label_ram.AutoSize = true;
            this.label_ram.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ram.ForeColor = System.Drawing.Color.Lime;
            this.label_ram.Location = new System.Drawing.Point(87, 9);
            this.label_ram.Name = "label_ram";
            this.label_ram.Size = new System.Drawing.Size(28, 15);
            this.label_ram.TabIndex = 8;
            this.label_ram.Text = "RAM";
            // 
            // label_delay
            // 
            this.label_delay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_delay.AutoSize = true;
            this.label_delay.Location = new System.Drawing.Point(12, 189);
            this.label_delay.Name = "label_delay";
            this.label_delay.Size = new System.Drawing.Size(85, 13);
            this.label_delay.TabIndex = 10;
            this.label_delay.Text = "Delay: ... ms";
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.LargeChange = 100;
            this.trackBar.Location = new System.Drawing.Point(15, 141);
            this.trackBar.Maximum = 3000;
            this.trackBar.Minimum = 50;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(457, 45);
            this.trackBar.TabIndex = 14;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar.Value = 200;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // utrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.label_delay);
            this.Controls.Add(this.label_ram);
            this.Controls.Add(this.label_cpu);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.show_ram_usage);
            this.Controls.Add(this.show_cpu_usage);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "utrack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU & RAM Watcher";
            this.Load += new System.EventHandler(this.utrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label show_cpu_usage;
        private System.Windows.Forms.Label show_ram_usage;
        private System.Windows.Forms.NotifyIcon SystemTrayIcon;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label_cpu;
        private System.Windows.Forms.Label label_ram;
        private System.Windows.Forms.Label label_delay;
        private System.Windows.Forms.TrackBar trackBar;
    }
}

