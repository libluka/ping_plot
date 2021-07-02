using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ping_plot
{
    class FormState
    {
        private FormBorderStyle __form_border_style;
        private FormWindowState __form_window_state;
        private bool __is_top_most;

        public void set_form_state(Form form)
        {
            __form_border_style = form.FormBorderStyle;
            __form_window_state = form.WindowState;
            __is_top_most = form.TopMost;
        }

        public void apply_form_state(Form form)
        {
            form.FormBorderStyle = __form_border_style;
            form.WindowState = __form_window_state;
            form.TopMost = __is_top_most;
        }
    }
}
