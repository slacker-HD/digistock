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
            this.Tm_main = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Set = new System.Windows.Forms.Button();
            this.Dgv_data = new System.Windows.Forms.DataGridView();
            this.codecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_data)).BeginInit();
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
            // Tm_main
            // 
            this.Tm_main.Enabled = true;
            this.Tm_main.Interval = 5000;
            this.Tm_main.Tick += new System.EventHandler(this.Tm_main_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_Set, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Dgv_data, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 362);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Btn_Set
            // 
            this.Btn_Set.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Set.Location = new System.Drawing.Point(3, 317);
            this.Btn_Set.Name = "Btn_Set";
            this.Btn_Set.Size = new System.Drawing.Size(276, 42);
            this.Btn_Set.TabIndex = 9;
            this.Btn_Set.Text = "开始";
            this.Btn_Set.UseVisualStyleBackColor = true;
            this.Btn_Set.Click += new System.EventHandler(this.Btn_Set_Click);
            // 
            // Dgv_data
            // 
            this.Dgv_data.AllowUserToResizeColumns = false;
            this.Dgv_data.AllowUserToResizeRows = false;
            this.Dgv_data.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codecol});
            this.Dgv_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_data.Location = new System.Drawing.Point(4, 4);
            this.Dgv_data.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_data.Name = "Dgv_data";
            this.Dgv_data.RowHeadersWidth = 51;
            this.Dgv_data.RowTemplate.Height = 23;
            this.Dgv_data.Size = new System.Drawing.Size(274, 306);
            this.Dgv_data.TabIndex = 8;
            // 
            // codecol
            // 
            this.codecol.HeaderText = "股票代码";
            this.codecol.MinimumWidth = 6;
            this.codecol.Name = "codecol";
            this.codecol.Width = 125;
            // 
            // Frm_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Setting";
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Setting_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Setting_Load);
            this.Resize += new System.EventHandler(this.Frm_Setting_Resize);
            this.cm.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon nf_config;
        private System.Windows.Forms.ContextMenuStrip cm;
        private System.Windows.Forms.ToolStripMenuItem mn_quit;
        private System.Windows.Forms.Timer Tm_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView Dgv_data;
        private System.Windows.Forms.Button Btn_Set;
        private System.Windows.Forms.DataGridViewTextBoxColumn codecol;
    }
}

