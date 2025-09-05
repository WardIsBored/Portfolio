namespace Discord_Messager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            TxtTitle = new Label();
            panel2 = new Panel();
            BtnNuke = new Button();
            BtnSendMsg = new Button();
            TxtbPrimary = new TextBox();
            TxtbSecondary = new TextBox();
            TxtPrimary = new Label();
            TxtSecondary = new Label();
            TxtbConsole = new RichTextBox();
            TxtConsole = new Label();
            BtnEnter = new Button();
            BtnClear = new Button();
            TxtMode = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 63, 116);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(TxtTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 60);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(375, 17);
            label1.Name = "label1";
            label1.Size = new Size(185, 30);
            label1.TabIndex = 13;
            label1.Text = "Made by tb0n31";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.discord;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.discord;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // TxtTitle
            // 
            TxtTitle.AutoSize = true;
            TxtTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtTitle.ForeColor = Color.White;
            TxtTitle.Location = new Point(118, 3);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(251, 47);
            TxtTitle.TabIndex = 11;
            TxtTitle.Text = "Discord Tools!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(59, 63, 116);
            panel2.Controls.Add(BtnNuke);
            panel2.Controls.Add(BtnSendMsg);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(147, 390);
            panel2.TabIndex = 1;
            // 
            // BtnNuke
            // 
            BtnNuke.Cursor = Cursors.Hand;
            BtnNuke.FlatAppearance.BorderSize = 0;
            BtnNuke.FlatStyle = FlatStyle.Flat;
            BtnNuke.ForeColor = Color.White;
            BtnNuke.Image = (Image)resources.GetObject("BtnNuke.Image");
            BtnNuke.Location = new Point(0, 74);
            BtnNuke.Name = "BtnNuke";
            BtnNuke.Size = new Size(145, 39);
            BtnNuke.TabIndex = 1;
            BtnNuke.Text = "Nuke-A-Webhook";
            BtnNuke.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnNuke.UseVisualStyleBackColor = true;
            BtnNuke.Click += button1_Click_2;
            // 
            // BtnSendMsg
            // 
            BtnSendMsg.Cursor = Cursors.Hand;
            BtnSendMsg.FlatAppearance.BorderSize = 0;
            BtnSendMsg.FlatStyle = FlatStyle.Flat;
            BtnSendMsg.ForeColor = Color.White;
            BtnSendMsg.Image = Properties.Resources.chat_add_on_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            BtnSendMsg.Location = new Point(0, 19);
            BtnSendMsg.Name = "BtnSendMsg";
            BtnSendMsg.Size = new Size(133, 49);
            BtnSendMsg.TabIndex = 0;
            BtnSendMsg.Text = "Send Message";
            BtnSendMsg.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnSendMsg.UseVisualStyleBackColor = true;
            BtnSendMsg.Click += button1_Click_1;
            // 
            // TxtbPrimary
            // 
            TxtbPrimary.BackColor = Color.FromArgb(78, 93, 148);
            TxtbPrimary.BorderStyle = BorderStyle.FixedSingle;
            TxtbPrimary.ForeColor = Color.White;
            TxtbPrimary.Location = new Point(153, 161);
            TxtbPrimary.Name = "TxtbPrimary";
            TxtbPrimary.Size = new Size(635, 23);
            TxtbPrimary.TabIndex = 2;
            // 
            // TxtbSecondary
            // 
            TxtbSecondary.BackColor = Color.FromArgb(78, 93, 148);
            TxtbSecondary.BorderStyle = BorderStyle.FixedSingle;
            TxtbSecondary.ForeColor = Color.White;
            TxtbSecondary.Location = new Point(153, 244);
            TxtbSecondary.Name = "TxtbSecondary";
            TxtbSecondary.Size = new Size(635, 23);
            TxtbSecondary.TabIndex = 3;
            // 
            // TxtPrimary
            // 
            TxtPrimary.AutoSize = true;
            TxtPrimary.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPrimary.ForeColor = Color.White;
            TxtPrimary.Location = new Point(153, 117);
            TxtPrimary.Name = "TxtPrimary";
            TxtPrimary.Size = new Size(160, 30);
            TxtPrimary.TabIndex = 4;
            TxtPrimary.Text = "Primary Textbox";
            // 
            // TxtSecondary
            // 
            TxtSecondary.AutoSize = true;
            TxtSecondary.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSecondary.ForeColor = Color.White;
            TxtSecondary.Location = new Point(153, 211);
            TxtSecondary.Name = "TxtSecondary";
            TxtSecondary.Size = new Size(186, 30);
            TxtSecondary.TabIndex = 5;
            TxtSecondary.Text = "Secondary Textbox";
            // 
            // TxtbConsole
            // 
            TxtbConsole.BackColor = Color.FromArgb(78, 93, 148);
            TxtbConsole.BorderStyle = BorderStyle.None;
            TxtbConsole.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtbConsole.ForeColor = SystemColors.Window;
            TxtbConsole.Location = new Point(153, 354);
            TxtbConsole.Name = "TxtbConsole";
            TxtbConsole.Size = new Size(635, 96);
            TxtbConsole.TabIndex = 6;
            TxtbConsole.Text = "";
            // 
            // TxtConsole
            // 
            TxtConsole.AutoSize = true;
            TxtConsole.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtConsole.ForeColor = Color.White;
            TxtConsole.Location = new Point(153, 313);
            TxtConsole.Name = "TxtConsole";
            TxtConsole.Size = new Size(87, 30);
            TxtConsole.TabIndex = 7;
            TxtConsole.Text = "Console";
            // 
            // BtnEnter
            // 
            BtnEnter.Cursor = Cursors.Hand;
            BtnEnter.FlatAppearance.BorderSize = 0;
            BtnEnter.FlatStyle = FlatStyle.Flat;
            BtnEnter.ForeColor = Color.White;
            BtnEnter.Location = new Point(585, 321);
            BtnEnter.Name = "BtnEnter";
            BtnEnter.Size = new Size(75, 23);
            BtnEnter.TabIndex = 8;
            BtnEnter.Text = "Enter";
            BtnEnter.UseVisualStyleBackColor = true;
            BtnEnter.Click += BtnEnter_Click;
            // 
            // BtnClear
            // 
            BtnClear.Cursor = Cursors.Hand;
            BtnClear.FlatAppearance.BorderSize = 0;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.ForeColor = Color.White;
            BtnClear.Location = new Point(684, 321);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 23);
            BtnClear.TabIndex = 9;
            BtnClear.Text = "Clear All";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // TxtMode
            // 
            TxtMode.AutoSize = true;
            TxtMode.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMode.ForeColor = Color.White;
            TxtMode.Location = new Point(153, 79);
            TxtMode.Name = "TxtMode";
            TxtMode.Size = new Size(129, 30);
            TxtMode.TabIndex = 10;
            TxtMode.Tag = "None";
            TxtMode.Text = "Mode: None";
            TxtMode.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(121, 131, 245);
            ClientSize = new Size(800, 450);
            Controls.Add(TxtMode);
            Controls.Add(BtnClear);
            Controls.Add(BtnEnter);
            Controls.Add(TxtConsole);
            Controls.Add(TxtbConsole);
            Controls.Add(TxtSecondary);
            Controls.Add(TxtPrimary);
            Controls.Add(TxtbSecondary);
            Controls.Add(TxtbPrimary);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Discord Tools";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button BtnSendMsg;
        private TextBox TxtbPrimary;
        private TextBox TxtbSecondary;
        private Label TxtPrimary;
        private Label TxtSecondary;
        private RichTextBox TxtbConsole;
        private Label TxtConsole;
        private Button BtnEnter;
        private Button BtnClear;
        private Label TxtMode;
        private PictureBox pictureBox1;
        private Label TxtTitle;
        private Label label1;
        private Button BtnNuke;
        private System.Windows.Forms.Timer timer1;
    }
}
