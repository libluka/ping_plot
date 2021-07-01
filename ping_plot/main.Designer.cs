
namespace ping_plot
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.ping_plot_obj = new ScottPlot.FormsPlot();
            this.ping_worker = new System.ComponentModel.BackgroundWorker();
            this.average_ping_label = new System.Windows.Forms.Label();
            this.current_ping_label = new System.Windows.Forms.Label();
            this.measured_avg_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ping_plot_obj
            // 
            this.ping_plot_obj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ping_plot_obj.BackColor = System.Drawing.Color.Transparent;
            this.ping_plot_obj.Location = new System.Drawing.Point(0, 0);
            this.ping_plot_obj.Name = "ping_plot_obj";
            this.ping_plot_obj.Size = new System.Drawing.Size(800, 430);
            this.ping_plot_obj.TabIndex = 0;
            // 
            // ping_worker
            // 
            this.ping_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ping_worker_DoWork);
            this.ping_worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ping_worker_ProgressChanged);
            // 
            // average_ping_label
            // 
            this.average_ping_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.average_ping_label.AutoSize = true;
            this.average_ping_label.BackColor = System.Drawing.Color.Black;
            this.average_ping_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.average_ping_label.ForeColor = System.Drawing.Color.White;
            this.average_ping_label.Location = new System.Drawing.Point(155, 419);
            this.average_ping_label.Name = "average_ping_label";
            this.average_ping_label.Size = new System.Drawing.Size(144, 25);
            this.average_ping_label.TabIndex = 1;
            this.average_ping_label.Text = "Average: 0ms";
            // 
            // current_ping_label
            // 
            this.current_ping_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.current_ping_label.AutoSize = true;
            this.current_ping_label.BackColor = System.Drawing.Color.Black;
            this.current_ping_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_ping_label.ForeColor = System.Drawing.Color.White;
            this.current_ping_label.Location = new System.Drawing.Point(12, 419);
            this.current_ping_label.Name = "current_ping_label";
            this.current_ping_label.Size = new System.Drawing.Size(107, 25);
            this.current_ping_label.TabIndex = 2;
            this.current_ping_label.Text = "Ping: 0ms";
            this.current_ping_label.Click += new System.EventHandler(this.current_ping_label_Click);
            // 
            // measured_avg_label
            // 
            this.measured_avg_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.measured_avg_label.AutoSize = true;
            this.measured_avg_label.BackColor = System.Drawing.Color.Black;
            this.measured_avg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measured_avg_label.ForeColor = System.Drawing.Color.White;
            this.measured_avg_label.Location = new System.Drawing.Point(335, 419);
            this.measured_avg_label.Name = "measured_avg_label";
            this.measured_avg_label.Size = new System.Drawing.Size(238, 25);
            this.measured_avg_label.TabIndex = 3;
            this.measured_avg_label.Text = "Measured Avg Count: 0";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.measured_avg_label);
            this.Controls.Add(this.current_ping_label);
            this.Controls.Add(this.average_ping_label);
            this.Controls.Add(this.ping_plot_obj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "ping_plot";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot ping_plot_obj;
        private System.ComponentModel.BackgroundWorker ping_worker;
        private System.Windows.Forms.Label average_ping_label;
        private System.Windows.Forms.Label current_ping_label;
        private System.Windows.Forms.Label measured_avg_label;
    }
}

