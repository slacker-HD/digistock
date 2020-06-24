namespace StockInfo
{
    partial class Frm_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Setting));
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.nf_config = new System.Windows.Forms.NotifyIcon(this.components);
            this.cm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mn_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.codecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mincol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.cm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codecol,
            this.mincol,
            this.maxcol});
            this.dgv_data.Location = new System.Drawing.Point(13, 13);
            this.dgv_data.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersWidth = 51;
            this.dgv_data.RowTemplate.Height = 23;
            this.dgv_data.Size = new System.Drawing.Size(667, 316);
            this.dgv_data.TabIndex = 6;
            // 
            // nf_config
            // 
            this.nf_config.ContextMenuStrip = this.cm;
            this.nf_config.Icon = ((System.Drawing.Icon)(resources.GetObject("nf_config.Icon")));
            this.nf_config.Visible = true;
            this.nf_config.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Nf_config_MouseClick);
            this.nf_config.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Nf_config_MouseDoubleClick);
            // 
            // cm
            // 
            this.cm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_quit});
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(109, 28);
            // 
            // mn_quit
            // 
            this.mn_quit.Name = "mn_quit";
            this.mn_quit.Size = new System.Drawing.Size(108, 24);
            this.mn_quit.Text = "退出";
            this.mn_quit.Click += new System.EventHandler(this.Mn_quit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 25);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codecol
            // 
            this.codecol.HeaderText = "股票代码";
            this.codecol.MinimumWidth = 6;
            this.codecol.Name = "codecol";
            this.codecol.Width = 200;
            // 
            // mincol
            // 
            this.mincol.HeaderText = "名称";
            this.mincol.MinimumWidth = 6;
            this.mincol.Name = "mincol";
            this.mincol.Width = 200;
            // 
            // maxcol
            // 
            this.maxcol.HeaderText = "实时价格";
            this.maxcol.MinimumWidth = 6;
            this.maxcol.Name = "maxcol";
            this.maxcol.Width = 200;
            // 
            // Frm_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Setting";
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Setting_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Setting_Load);
            this.Resize += new System.EventHandler(this.Frm_Setting_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.cm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.NotifyIcon nf_config;
        private System.Windows.Forms.ContextMenuStrip cm;
        private System.Windows.Forms.ToolStripMenuItem mn_quit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn mincol;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxcol;
        private System.Windows.Forms.Timer timer1;
    }
}

