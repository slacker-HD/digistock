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
            this.nf_config = new System.Windows.Forms.NotifyIcon(this.components);
            this.cm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mn_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.codecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mincol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.cm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_data, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.25926F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.74074F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 511);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToAddRows = false;
            this.dgv_data.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codecol,
            this.mincol,
            this.maxcol,
            this.Column1});
            this.dgv_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_data.Location = new System.Drawing.Point(4, 4);
            this.dgv_data.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersWidth = 51;
            this.dgv_data.RowTemplate.Height = 23;
            this.dgv_data.Size = new System.Drawing.Size(641, 320);
            this.dgv_data.TabIndex = 8;
            // 
            // codecol
            // 
            this.codecol.HeaderText = "股票代码";
            this.codecol.MinimumWidth = 6;
            this.codecol.Name = "codecol";
            this.codecol.Width = 160;
            // 
            // mincol
            // 
            this.mincol.HeaderText = "名称";
            this.mincol.MinimumWidth = 6;
            this.mincol.Name = "mincol";
            this.mincol.Width = 160;
            // 
            // maxcol
            // 
            this.maxcol.HeaderText = "实时价格";
            this.maxcol.MinimumWidth = 6;
            this.maxcol.Name = "maxcol";
            this.maxcol.Width = 160;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "涨跌幅";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 331);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(643, 177);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Frm_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Setting";
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Setting_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Setting_Load);
            this.Resize += new System.EventHandler(this.Frm_Setting_Resize);
            this.cm.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon nf_config;
        private System.Windows.Forms.ContextMenuStrip cm;
        private System.Windows.Forms.ToolStripMenuItem mn_quit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn codecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn mincol;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
    }
}

