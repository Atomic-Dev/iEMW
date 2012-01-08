namespace kPhone
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusTime = new System.Windows.Forms.Label();
            this.homescreen = new System.Windows.Forms.TableLayoutPanel();
            this.dockPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.phoneApp = new System.Windows.Forms.Button();
            this.mailApp = new System.Windows.Forms.Button();
            this.safariApp = new System.Windows.Forms.Button();
            this.musicApp = new System.Windows.Forms.Button();
            this.appPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.messagesApp = new System.Windows.Forms.Button();
            this.calendarApp = new System.Windows.Forms.Button();
            this.photosApp = new System.Windows.Forms.Button();
            this.cameraApp = new System.Windows.Forms.Button();
            this.youtubeApp = new System.Windows.Forms.Button();
            this.stocksApp = new System.Windows.Forms.Button();
            this.calcApp = new System.Windows.Forms.Button();
            this.prefsApp = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.homescreen.SuspendLayout();
            this.dockPanel.SuspendLayout();
            this.appPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.703704F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.homescreen, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.613757F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.38625F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(216, 333);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.statusTime);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 15);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDoubleClick);
            this.flowLayoutPanel1.MouseHover += new System.EventHandler(this.flowLayoutPanel1_MouseHover);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "iPhone";
            // 
            // statusTime
            // 
            this.statusTime.AutoSize = true;
            this.statusTime.Location = new System.Drawing.Point(65, 0);
            this.statusTime.Name = "statusTime";
            this.statusTime.Size = new System.Drawing.Size(44, 17);
            this.statusTime.TabIndex = 3;
            this.statusTime.Text = "00:00";
            // 
            // homescreen
            // 
            this.homescreen.BackgroundImage = global::kPhone.Properties.Resources.model_x240;
            this.homescreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homescreen.ColumnCount = 1;
            this.homescreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.homescreen.Controls.Add(this.dockPanel, 0, 1);
            this.homescreen.Controls.Add(this.appPanel, 0, 0);
            this.homescreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homescreen.Location = new System.Drawing.Point(5, 28);
            this.homescreen.Name = "homescreen";
            this.homescreen.RowCount = 2;
            this.homescreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.homescreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.homescreen.Size = new System.Drawing.Size(206, 300);
            this.homescreen.TabIndex = 1;
            this.homescreen.Paint += new System.Windows.Forms.PaintEventHandler(this.homescreen_Paint);
            // 
            // dockPanel
            // 
            this.dockPanel.BackColor = System.Drawing.Color.Transparent;
            this.dockPanel.Controls.Add(this.phoneApp);
            this.dockPanel.Controls.Add(this.mailApp);
            this.dockPanel.Controls.Add(this.safariApp);
            this.dockPanel.Controls.Add(this.musicApp);
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Location = new System.Drawing.Point(3, 250);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(200, 47);
            this.dockPanel.TabIndex = 0;
            // 
            // phoneApp
            // 
            this.phoneApp.BackgroundImage = global::kPhone.Properties.Resources.phone;
            this.phoneApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.phoneApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.phoneApp.ForeColor = System.Drawing.Color.Transparent;
            this.phoneApp.Location = new System.Drawing.Point(3, 3);
            this.phoneApp.Name = "phoneApp";
            this.phoneApp.Size = new System.Drawing.Size(43, 43);
            this.phoneApp.TabIndex = 1;
            this.phoneApp.UseVisualStyleBackColor = true;
            this.phoneApp.Click += new System.EventHandler(this.phoneApp_Click);
            // 
            // mailApp
            // 
            this.mailApp.BackgroundImage = global::kPhone.Properties.Resources._1025928073;
            this.mailApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mailApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mailApp.ForeColor = System.Drawing.Color.Transparent;
            this.mailApp.Location = new System.Drawing.Point(52, 3);
            this.mailApp.Name = "mailApp";
            this.mailApp.Size = new System.Drawing.Size(43, 43);
            this.mailApp.TabIndex = 2;
            this.mailApp.UseVisualStyleBackColor = true;
            this.mailApp.Click += new System.EventHandler(this.mailApp_Click);
            // 
            // safariApp
            // 
            this.safariApp.BackgroundImage = global::kPhone.Properties.Resources.B_icon;
            this.safariApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.safariApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.safariApp.ForeColor = System.Drawing.Color.Transparent;
            this.safariApp.Location = new System.Drawing.Point(101, 3);
            this.safariApp.Name = "safariApp";
            this.safariApp.Size = new System.Drawing.Size(43, 43);
            this.safariApp.TabIndex = 3;
            this.safariApp.UseVisualStyleBackColor = true;
            this.safariApp.Click += new System.EventHandler(this.safariApp_Click);
            // 
            // musicApp
            // 
            this.musicApp.BackgroundImage = global::kPhone.Properties.Resources.ipod_icon;
            this.musicApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.musicApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.musicApp.ForeColor = System.Drawing.Color.Transparent;
            this.musicApp.Location = new System.Drawing.Point(150, 3);
            this.musicApp.Name = "musicApp";
            this.musicApp.Size = new System.Drawing.Size(43, 43);
            this.musicApp.TabIndex = 0;
            this.musicApp.UseVisualStyleBackColor = true;
            // 
            // appPanel
            // 
            this.appPanel.BackColor = System.Drawing.Color.Transparent;
            this.appPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.appPanel.Controls.Add(this.messagesApp);
            this.appPanel.Controls.Add(this.calendarApp);
            this.appPanel.Controls.Add(this.photosApp);
            this.appPanel.Controls.Add(this.cameraApp);
            this.appPanel.Controls.Add(this.youtubeApp);
            this.appPanel.Controls.Add(this.stocksApp);
            this.appPanel.Controls.Add(this.calcApp);
            this.appPanel.Controls.Add(this.prefsApp);
            this.appPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appPanel.Location = new System.Drawing.Point(3, 3);
            this.appPanel.Name = "appPanel";
            this.appPanel.Size = new System.Drawing.Size(200, 241);
            this.appPanel.TabIndex = 1;
            // 
            // messagesApp
            // 
            this.messagesApp.BackgroundImage = global::kPhone.Properties.Resources.sms_3;
            this.messagesApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.messagesApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.messagesApp.ForeColor = System.Drawing.Color.Transparent;
            this.messagesApp.Location = new System.Drawing.Point(3, 3);
            this.messagesApp.Name = "messagesApp";
            this.messagesApp.Size = new System.Drawing.Size(43, 43);
            this.messagesApp.TabIndex = 2;
            this.messagesApp.UseVisualStyleBackColor = true;
            this.messagesApp.Click += new System.EventHandler(this.messagesApp_Click);
            // 
            // calendarApp
            // 
            this.calendarApp.BackgroundImage = global::kPhone.Properties.Resources.ical_blank;
            this.calendarApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calendarApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calendarApp.Font = new System.Drawing.Font("Albertus Extra Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarApp.ForeColor = System.Drawing.Color.Black;
            this.calendarApp.Location = new System.Drawing.Point(52, 3);
            this.calendarApp.Name = "calendarApp";
            this.calendarApp.Size = new System.Drawing.Size(43, 43);
            this.calendarApp.TabIndex = 3;
            this.calendarApp.Text = "29";
            this.calendarApp.UseVisualStyleBackColor = true;
            this.calendarApp.Click += new System.EventHandler(this.calendarApp_Click);
            // 
            // photosApp
            // 
            this.photosApp.BackgroundImage = global::kPhone.Properties.Resources.photos;
            this.photosApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photosApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.photosApp.Font = new System.Drawing.Font("Albertus Extra Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photosApp.ForeColor = System.Drawing.Color.Black;
            this.photosApp.Location = new System.Drawing.Point(101, 3);
            this.photosApp.Name = "photosApp";
            this.photosApp.Size = new System.Drawing.Size(43, 43);
            this.photosApp.TabIndex = 4;
            this.photosApp.UseVisualStyleBackColor = true;
            // 
            // cameraApp
            // 
            this.cameraApp.BackgroundImage = global::kPhone.Properties.Resources.iphone_photo;
            this.cameraApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cameraApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cameraApp.ForeColor = System.Drawing.Color.Transparent;
            this.cameraApp.Location = new System.Drawing.Point(150, 3);
            this.cameraApp.Name = "cameraApp";
            this.cameraApp.Size = new System.Drawing.Size(43, 43);
            this.cameraApp.TabIndex = 5;
            this.cameraApp.UseVisualStyleBackColor = true;
            this.cameraApp.Click += new System.EventHandler(this.cameraApp_Click);
            // 
            // youtubeApp
            // 
            this.youtubeApp.BackgroundImage = global::kPhone.Properties.Resources.youtube_5;
            this.youtubeApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.youtubeApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.youtubeApp.ForeColor = System.Drawing.Color.Transparent;
            this.youtubeApp.Location = new System.Drawing.Point(3, 52);
            this.youtubeApp.Name = "youtubeApp";
            this.youtubeApp.Size = new System.Drawing.Size(43, 43);
            this.youtubeApp.TabIndex = 6;
            this.youtubeApp.UseVisualStyleBackColor = true;
            this.youtubeApp.Click += new System.EventHandler(this.youtubeApp_Click);
            // 
            // stocksApp
            // 
            this.stocksApp.BackgroundImage = global::kPhone.Properties.Resources.graph_3;
            this.stocksApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stocksApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stocksApp.ForeColor = System.Drawing.Color.Transparent;
            this.stocksApp.Location = new System.Drawing.Point(52, 52);
            this.stocksApp.Name = "stocksApp";
            this.stocksApp.Size = new System.Drawing.Size(43, 43);
            this.stocksApp.TabIndex = 7;
            this.stocksApp.UseVisualStyleBackColor = true;
            this.stocksApp.Click += new System.EventHandler(this.stocksApp_Click);
            // 
            // calcApp
            // 
            this.calcApp.BackgroundImage = global::kPhone.Properties.Resources.iphone_calculator;
            this.calcApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calcApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcApp.ForeColor = System.Drawing.Color.Transparent;
            this.calcApp.Location = new System.Drawing.Point(101, 52);
            this.calcApp.Name = "calcApp";
            this.calcApp.Size = new System.Drawing.Size(43, 43);
            this.calcApp.TabIndex = 11;
            this.calcApp.UseVisualStyleBackColor = true;
            this.calcApp.Click += new System.EventHandler(this.calcApp_Click);
            // 
            // prefsApp
            // 
            this.prefsApp.BackgroundImage = global::kPhone.Properties.Resources.iphone_tools;
            this.prefsApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prefsApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prefsApp.ForeColor = System.Drawing.Color.Transparent;
            this.prefsApp.Location = new System.Drawing.Point(150, 52);
            this.prefsApp.Name = "prefsApp";
            this.prefsApp.Size = new System.Drawing.Size(43, 43);
            this.prefsApp.TabIndex = 13;
            this.prefsApp.UseVisualStyleBackColor = true;
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 333);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iEMW";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.homescreen.ResumeLayout(false);
            this.dockPanel.ResumeLayout(false);
            this.appPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusTime;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.TableLayoutPanel homescreen;
        private System.Windows.Forms.FlowLayoutPanel dockPanel;
        private System.Windows.Forms.Button musicApp;
        private System.Windows.Forms.Button phoneApp;
        private System.Windows.Forms.Button mailApp;
        private System.Windows.Forms.Button safariApp;
        private System.Windows.Forms.FlowLayoutPanel appPanel;
        private System.Windows.Forms.Button messagesApp;
        private System.Windows.Forms.Button calendarApp;
        private System.Windows.Forms.Button photosApp;
        private System.Windows.Forms.Button cameraApp;
        private System.Windows.Forms.Button youtubeApp;
        private System.Windows.Forms.Button stocksApp;
        private System.Windows.Forms.Button calcApp;
        private System.Windows.Forms.Button prefsApp;
    }
}

