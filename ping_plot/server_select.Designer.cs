
namespace ping_plot
{
    partial class server_select
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
            this.server_address_textbox = new System.Windows.Forms.TextBox();
            this.accept_button = new System.Windows.Forms.Button();
            this.server_address_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ping_rate_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // server_address_textbox
            // 
            this.server_address_textbox.BackColor = System.Drawing.Color.Black;
            this.server_address_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_address_textbox.ForeColor = System.Drawing.Color.White;
            this.server_address_textbox.Location = new System.Drawing.Point(184, 7);
            this.server_address_textbox.Name = "server_address_textbox";
            this.server_address_textbox.Size = new System.Drawing.Size(161, 29);
            this.server_address_textbox.TabIndex = 0;
            this.server_address_textbox.Text = "8.8.8.8";
            this.server_address_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.server_address_textbox_KeyDown);
            // 
            // accept_button
            // 
            this.accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept_button.ForeColor = System.Drawing.Color.White;
            this.accept_button.Location = new System.Drawing.Point(342, 97);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(88, 29);
            this.accept_button.TabIndex = 1;
            this.accept_button.Text = "OK";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // server_address_label
            // 
            this.server_address_label.AutoSize = true;
            this.server_address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_address_label.ForeColor = System.Drawing.Color.White;
            this.server_address_label.Location = new System.Drawing.Point(12, 9);
            this.server_address_label.Name = "server_address_label";
            this.server_address_label.Size = new System.Drawing.Size(166, 25);
            this.server_address_label.TabIndex = 2;
            this.server_address_label.Text = "Server Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ping Rate (ms):";
            // 
            // ping_rate_textbox
            // 
            this.ping_rate_textbox.BackColor = System.Drawing.Color.Black;
            this.ping_rate_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ping_rate_textbox.ForeColor = System.Drawing.Color.White;
            this.ping_rate_textbox.Location = new System.Drawing.Point(184, 44);
            this.ping_rate_textbox.Name = "ping_rate_textbox";
            this.ping_rate_textbox.Size = new System.Drawing.Size(68, 29);
            this.ping_rate_textbox.TabIndex = 4;
            this.ping_rate_textbox.Text = "100";
            // 
            // server_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(442, 138);
            this.Controls.Add(this.ping_rate_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.server_address_label);
            this.Controls.Add(this.accept_button);
            this.Controls.Add(this.server_address_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "server_select";
            this.ShowIcon = false;
            this.Text = "server_select";
            this.Load += new System.EventHandler(this.server_select_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox server_address_textbox;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Label server_address_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ping_rate_textbox;
    }
}