namespace EclipsusAurora
{
    partial class EclipsusAurora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EclipsusAurora));
            this.panel1 = new System.Windows.Forms.Panel();
            this.showerthing = new System.Windows.Forms.Panel();
            this.MoreSection = new System.Windows.Forms.GroupBox();
            this.PortGen = new System.Windows.Forms.Button();
            this.Pinger = new System.Windows.Forms.Button();
            this.WifiPasswords = new System.Windows.Forms.Button();
            this.WifiStats = new System.Windows.Forms.Button();
            this.MyIp = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Ports = new System.Windows.Forms.Button();
            this.Ip = new System.Windows.Forms.Button();
            this.DNS = new System.Windows.Forms.Button();
            this.Geo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.ConsoleOBJ = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.Label();
            this.ClearConsole = new System.Windows.Forms.Button();
            this.Primary = new System.Windows.Forms.TextBox();
            this.Seconday = new System.Windows.Forms.TextBox();
            this.SecondaryLabel = new System.Windows.Forms.Label();
            this.PrimaryLabel = new System.Windows.Forms.Label();
            this.EnterOBJ = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.MoreSection.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.showerthing);
            this.panel1.Controls.Add(this.MoreSection);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.Ports);
            this.panel1.Controls.Add(this.Ip);
            this.panel1.Controls.Add(this.DNS);
            this.panel1.Controls.Add(this.Geo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 1057);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // showerthing
            // 
            this.showerthing.BackColor = System.Drawing.Color.White;
            this.showerthing.Location = new System.Drawing.Point(-21, 120);
            this.showerthing.Name = "showerthing";
            this.showerthing.Size = new System.Drawing.Size(3, 100);
            this.showerthing.TabIndex = 10;
            // 
            // MoreSection
            // 
            this.MoreSection.Controls.Add(this.PortGen);
            this.MoreSection.Controls.Add(this.Pinger);
            this.MoreSection.Controls.Add(this.WifiPasswords);
            this.MoreSection.Controls.Add(this.WifiStats);
            this.MoreSection.Controls.Add(this.MyIp);
            this.MoreSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoreSection.Location = new System.Drawing.Point(12, 567);
            this.MoreSection.Name = "MoreSection";
            this.MoreSection.Size = new System.Drawing.Size(120, 478);
            this.MoreSection.TabIndex = 5;
            this.MoreSection.TabStop = false;
            this.MoreSection.Visible = false;
            // 
            // PortGen
            // 
            this.PortGen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PortGen.FlatAppearance.BorderSize = 0;
            this.PortGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortGen.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortGen.ForeColor = System.Drawing.Color.White;
            this.PortGen.Image = ((System.Drawing.Image)(resources.GetObject("PortGen.Image")));
            this.PortGen.Location = new System.Drawing.Point(6, 296);
            this.PortGen.Name = "PortGen";
            this.PortGen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PortGen.Size = new System.Drawing.Size(108, 67);
            this.PortGen.TabIndex = 10;
            this.PortGen.Tag = "Enabled";
            this.PortGen.Text = "Port generator";
            this.PortGen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.PortGen.UseVisualStyleBackColor = true;
            this.PortGen.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Pinger
            // 
            this.Pinger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pinger.FlatAppearance.BorderSize = 0;
            this.Pinger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pinger.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pinger.ForeColor = System.Drawing.Color.White;
            this.Pinger.Image = ((System.Drawing.Image)(resources.GetObject("Pinger.Image")));
            this.Pinger.Location = new System.Drawing.Point(6, 236);
            this.Pinger.Name = "Pinger";
            this.Pinger.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Pinger.Size = new System.Drawing.Size(108, 67);
            this.Pinger.TabIndex = 9;
            this.Pinger.Tag = "Enabled";
            this.Pinger.Text = "Pinger";
            this.Pinger.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Pinger.UseVisualStyleBackColor = true;
            this.Pinger.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // WifiPasswords
            // 
            this.WifiPasswords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WifiPasswords.FlatAppearance.BorderSize = 0;
            this.WifiPasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WifiPasswords.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WifiPasswords.ForeColor = System.Drawing.Color.White;
            this.WifiPasswords.Image = global::EclipsusAurora.Properties.Resources.wifi_password_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            this.WifiPasswords.Location = new System.Drawing.Point(6, 165);
            this.WifiPasswords.Name = "WifiPasswords";
            this.WifiPasswords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WifiPasswords.Size = new System.Drawing.Size(108, 67);
            this.WifiPasswords.TabIndex = 8;
            this.WifiPasswords.Tag = "Enabled";
            this.WifiPasswords.Text = "See Wifi Passwords";
            this.WifiPasswords.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.WifiPasswords.UseVisualStyleBackColor = true;
            this.WifiPasswords.Click += new System.EventHandler(this.WifiPasswords_Click);
            // 
            // WifiStats
            // 
            this.WifiStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WifiStats.FlatAppearance.BorderSize = 0;
            this.WifiStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WifiStats.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WifiStats.ForeColor = System.Drawing.Color.White;
            this.WifiStats.Image = global::EclipsusAurora.Properties.Resources.wifi_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            this.WifiStats.Location = new System.Drawing.Point(6, 92);
            this.WifiStats.Name = "WifiStats";
            this.WifiStats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WifiStats.Size = new System.Drawing.Size(108, 67);
            this.WifiStats.TabIndex = 7;
            this.WifiStats.Tag = "Enabled";
            this.WifiStats.Text = "Wifi Stats";
            this.WifiStats.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.WifiStats.UseVisualStyleBackColor = true;
            this.WifiStats.Click += new System.EventHandler(this.button1_Click);
            // 
            // MyIp
            // 
            this.MyIp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyIp.FlatAppearance.BorderSize = 0;
            this.MyIp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyIp.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyIp.ForeColor = System.Drawing.Color.White;
            this.MyIp.Image = global::EclipsusAurora.Properties.Resources.text_compare_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            this.MyIp.Location = new System.Drawing.Point(6, 19);
            this.MyIp.Name = "MyIp";
            this.MyIp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MyIp.Size = new System.Drawing.Size(108, 67);
            this.MyIp.TabIndex = 6;
            this.MyIp.Tag = "Enabled";
            this.MyIp.Text = "What Is My Ip";
            this.MyIp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.MyIp.UseVisualStyleBackColor = true;
            this.MyIp.Click += new System.EventHandler(this.MyIp_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::EclipsusAurora.Properties.Resources.density_medium_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            this.button5.Location = new System.Drawing.Point(3, 467);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 94);
            this.button5.TabIndex = 4;
            this.button5.Text = "More";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Ports
            // 
            this.Ports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ports.FlatAppearance.BorderSize = 0;
            this.Ports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ports.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ports.ForeColor = System.Drawing.Color.White;
            this.Ports.Image = global::EclipsusAurora.Properties.Resources.text_compare_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            this.Ports.Location = new System.Drawing.Point(3, 348);
            this.Ports.Name = "Ports";
            this.Ports.Size = new System.Drawing.Size(141, 113);
            this.Ports.TabIndex = 3;
            this.Ports.Text = "Scan Open Ports";
            this.Ports.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Ports.UseVisualStyleBackColor = true;
            this.Ports.Click += new System.EventHandler(this.Ports_Click);
            // 
            // Ip
            // 
            this.Ip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ip.FlatAppearance.BorderSize = 0;
            this.Ip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ip.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ip.ForeColor = System.Drawing.Color.White;
            this.Ip.Image = global::EclipsusAurora.Properties.Resources.oxygen_saturation_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            this.Ip.Location = new System.Drawing.Point(3, 110);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(141, 113);
            this.Ip.TabIndex = 2;
            this.Ip.Text = "Ip Sniff";
            this.Ip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Ip.UseVisualStyleBackColor = true;
            this.Ip.Click += new System.EventHandler(this.Ip_Click);
            // 
            // DNS
            // 
            this.DNS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DNS.FlatAppearance.BorderSize = 0;
            this.DNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DNS.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNS.ForeColor = System.Drawing.Color.White;
            this.DNS.Image = global::EclipsusAurora.Properties.Resources.dns_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            this.DNS.Location = new System.Drawing.Point(3, 229);
            this.DNS.Name = "DNS";
            this.DNS.Size = new System.Drawing.Size(141, 113);
            this.DNS.TabIndex = 1;
            this.DNS.Text = "DNS Dump";
            this.DNS.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DNS.UseVisualStyleBackColor = true;
            this.DNS.Click += new System.EventHandler(this.DNS_Click);
            // 
            // Geo
            // 
            this.Geo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Geo.FlatAppearance.BorderSize = 0;
            this.Geo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Geo.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Geo.ForeColor = System.Drawing.Color.White;
            this.Geo.Image = global::EclipsusAurora.Properties.Resources.map_search_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            this.Geo.Location = new System.Drawing.Point(3, 3);
            this.Geo.Name = "Geo";
            this.Geo.Size = new System.Drawing.Size(141, 113);
            this.Geo.TabIndex = 0;
            this.Geo.Text = "Geolocator";
            this.Geo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Geo.UseVisualStyleBackColor = true;
            this.Geo.Click += new System.EventHandler(this.Geo_Click);
            this.Geo.Enter += new System.EventHandler(this.Geo_Enter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.Title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(147, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 93);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Transparent;
            this.Title.Location = new System.Drawing.Point(6, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(356, 44);
            this.Title.TabIndex = 0;
            this.Title.Text = "ECLIPSUS AURORA";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConsoleOBJ
            // 
            this.ConsoleOBJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ConsoleOBJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleOBJ.Cursor = System.Windows.Forms.Cursors.Default;
            this.ConsoleOBJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleOBJ.ForeColor = System.Drawing.SystemColors.Window;
            this.ConsoleOBJ.Location = new System.Drawing.Point(216, 523);
            this.ConsoleOBJ.Name = "ConsoleOBJ";
            this.ConsoleOBJ.Size = new System.Drawing.Size(886, 303);
            this.ConsoleOBJ.TabIndex = 3;
            this.ConsoleOBJ.Text = "";
            this.ConsoleOBJ.TextChanged += new System.EventHandler(this.ConsoleOBJ_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(210, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Console";
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode.ForeColor = System.Drawing.Color.Transparent;
            this.Mode.Location = new System.Drawing.Point(162, 121);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(376, 44);
            this.Mode.TabIndex = 4;
            this.Mode.Tag = "None";
            this.Mode.Text = "Current Mode: None";
            this.Mode.Click += new System.EventHandler(this.label3_Click);
            // 
            // ClearConsole
            // 
            this.ClearConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.ClearConsole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearConsole.FlatAppearance.BorderSize = 0;
            this.ClearConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearConsole.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearConsole.ForeColor = System.Drawing.Color.White;
            this.ClearConsole.Location = new System.Drawing.Point(904, 464);
            this.ClearConsole.Name = "ClearConsole";
            this.ClearConsole.Size = new System.Drawing.Size(103, 41);
            this.ClearConsole.TabIndex = 5;
            this.ClearConsole.Text = "Clear all";
            this.ClearConsole.UseVisualStyleBackColor = false;
            this.ClearConsole.Click += new System.EventHandler(this.ClearConsole_Click);
            // 
            // Primary
            // 
            this.Primary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Primary.ForeColor = System.Drawing.SystemColors.Window;
            this.Primary.Location = new System.Drawing.Point(216, 258);
            this.Primary.Name = "Primary";
            this.Primary.Size = new System.Drawing.Size(886, 20);
            this.Primary.TabIndex = 6;
            this.Primary.TextChanged += new System.EventHandler(this.Primary_TextChanged);
            // 
            // Seconday
            // 
            this.Seconday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Seconday.ForeColor = System.Drawing.Color.White;
            this.Seconday.Location = new System.Drawing.Point(216, 401);
            this.Seconday.Name = "Seconday";
            this.Seconday.Size = new System.Drawing.Size(886, 20);
            this.Seconday.TabIndex = 7;
            // 
            // SecondaryLabel
            // 
            this.SecondaryLabel.AutoSize = true;
            this.SecondaryLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F);
            this.SecondaryLabel.ForeColor = System.Drawing.Color.Transparent;
            this.SecondaryLabel.Location = new System.Drawing.Point(211, 372);
            this.SecondaryLabel.Name = "SecondaryLabel";
            this.SecondaryLabel.Size = new System.Drawing.Size(209, 26);
            this.SecondaryLabel.TabIndex = 8;
            this.SecondaryLabel.Text = "Secondary textbox";
            this.SecondaryLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PrimaryLabel
            // 
            this.PrimaryLabel.AutoSize = true;
            this.PrimaryLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrimaryLabel.ForeColor = System.Drawing.Color.Transparent;
            this.PrimaryLabel.Location = new System.Drawing.Point(211, 229);
            this.PrimaryLabel.Name = "PrimaryLabel";
            this.PrimaryLabel.Size = new System.Drawing.Size(180, 26);
            this.PrimaryLabel.TabIndex = 9;
            this.PrimaryLabel.Text = "Primary textbox";
            // 
            // EnterOBJ
            // 
            this.EnterOBJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.EnterOBJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterOBJ.FlatAppearance.BorderSize = 0;
            this.EnterOBJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterOBJ.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterOBJ.ForeColor = System.Drawing.Color.White;
            this.EnterOBJ.Location = new System.Drawing.Point(1013, 464);
            this.EnterOBJ.Name = "EnterOBJ";
            this.EnterOBJ.Size = new System.Drawing.Size(89, 41);
            this.EnterOBJ.TabIndex = 5;
            this.EnterOBJ.Text = "Enter";
            this.EnterOBJ.UseVisualStyleBackColor = false;
            this.EnterOBJ.Click += new System.EventHandler(this.EnterOBJ_Click);
            // 
            // EclipsusAurora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1503, 1057);
            this.Controls.Add(this.EnterOBJ);
            this.Controls.Add(this.PrimaryLabel);
            this.Controls.Add(this.SecondaryLabel);
            this.Controls.Add(this.Seconday);
            this.Controls.Add(this.Primary);
            this.Controls.Add(this.ClearConsole);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConsoleOBJ);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EclipsusAurora";
            this.Text = "Eclipsus Aurora Demo";
            this.panel1.ResumeLayout(false);
            this.MoreSection.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        // Add the missing method definition for 'backgroundWorker1_DoWork_1' in the EclipsusAurora class.

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Geo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Ports;
        private System.Windows.Forms.Button Ip;
        private System.Windows.Forms.Button DNS;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.RichTextBox ConsoleOBJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Mode;
        private System.Windows.Forms.Button ClearConsole;
        private System.Windows.Forms.TextBox Primary;
        private System.Windows.Forms.TextBox Seconday;
        private System.Windows.Forms.Label SecondaryLabel;
        private System.Windows.Forms.Label PrimaryLabel;
        private System.Windows.Forms.Button EnterOBJ;
        private System.Windows.Forms.GroupBox MoreSection;
        private System.Windows.Forms.Button MyIp;
        private System.Windows.Forms.Panel showerthing;
        private System.Windows.Forms.Button WifiStats;
        private System.Windows.Forms.Button WifiPasswords;
        private System.Windows.Forms.Button Pinger;
        private System.Windows.Forms.Button PortGen;
    }
}

