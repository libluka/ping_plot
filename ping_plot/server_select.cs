using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ping_plot
{
    public partial class server_select : Form
    {
        string __server_address;
        int __ping_refresh_rate;
        public server_select()
        {
            InitializeComponent();
        }

        private void server_select_Load(object sender, EventArgs e)
        {
            /**/
        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            this.self_exit();
        }

        public string get_server_address()
        {
            return this.__server_address;
        }

        public int get_refresh_rate()
        {
            return this.__ping_refresh_rate;
        }

        private void self_exit()
        {
            __server_address = server_address_textbox.Text;
            __ping_refresh_rate = Int32.Parse(ping_rate_textbox.Text);
            this.Hide();
        }

        private void server_address_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.self_exit();
            }
        }

        private void ping_rate_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.self_exit();
            }
        }
    }
}
