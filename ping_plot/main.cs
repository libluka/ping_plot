using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ping_plot
{
    public partial class main : Form
    {
        const int __graph_x_bound = 512;
        const int __graph_y_bound = 500;
        int __ping_refresh_rate = 100;

        double[] __response_list;
        string __target_server;
        Ping ping;

        public main()
        {
            InitializeComponent();

            ping = new Ping();

            ping_plot_obj.Plot.Style(ScottPlot.Style.Black);

            __response_list = new double[__graph_x_bound];
            ping_plot_obj.Plot.Title("PING RESPONSE");
            
            ping_plot_obj.Plot.YLabel("ms");

            ping_plot_obj.Plot.SetAxisLimits(0, __graph_x_bound, 0, __graph_y_bound);

            ping_plot_obj.Plot.AddSignal(__response_list, color: Color.White);

            ping_plot_obj.Configuration.LockHorizontalAxis = true;
            ping_plot_obj.Configuration.LockVerticalAxis = true;
            ping_plot_obj.Configuration.Quality = ScottPlot.Control.QualityMode.High;

            ping_worker.WorkerReportsProgress = true;

            this.MinimumSize = new Size(1000, 500);
        }
        /*commit*/

        private void main_Load(object sender, EventArgs e)
        {
            server_select _server_select = new server_select();
            _server_select.ShowDialog();

            __target_server = _server_select.get_server_address();
            __ping_refresh_rate = _server_select.get_refresh_rate();

            _server_select.Close();
            _server_select.Dispose();

            if (String.IsNullOrEmpty(__target_server))
            {
                MessageBox.Show("Server address cannot be blank or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();

            } else if (__ping_refresh_rate <= 0)
            {
                MessageBox.Show("Refresh rate must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            refresh_rate_label.Text = "Refresh rate: " + __ping_refresh_rate.ToString() + "ms";

            this.Text = "ping_plot - " + __target_server;

            ping_worker.RunWorkerAsync();
        }

        private void ping_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                PingReply reply = ping.Send(__target_server);
                ping_worker.ReportProgress((int)reply.RoundtripTime);

                System.Threading.Thread.Sleep(__ping_refresh_rate);
            }
        }

        private int get_average(double[] list)
        {
            int hold = 0;
            int true_data_num = 0;

            for(int i = 0; i < list.Length; ++i)
            {
                if(list[i] > 0)
                {
                    ++true_data_num;
                    hold += (int)list[i];
                }
            }

            measured_avg_label.Text = "Measured Avg Count: " + true_data_num;

            if(true_data_num == 0 || hold == 0)
            {
                return 0;
            }

            return hold / true_data_num;
        }

        private void ping_worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int round_trip = (int)e.ProgressPercentage;

            for (int i = 0; i < __response_list.Length - 1; ++i)
            {
                __response_list[i] = __response_list[i + 1];
            }

            __response_list[__response_list.Length - 1] = round_trip;

            ping_plot_obj.Render();

            int average_ping = get_average(__response_list);

            current_ping_label.Text = "Ping: " + round_trip + "ms";
            average_ping_label.Text = "Average: " + average_ping + "ms";

        }
    }
}
