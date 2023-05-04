namespace SAM_Random_Generator
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttSett = new System.Windows.Forms.Button();
            this.buttIdent = new System.Windows.Forms.Button();
            this.buttUser = new System.Windows.Forms.Button();
            this.buttPass = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttSett);
            this.panelMenu.Controls.Add(this.buttIdent);
            this.panelMenu.Controls.Add(this.buttUser);
            this.panelMenu.Controls.Add(this.buttPass);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // buttSett
            // 
            this.buttSett.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttSett.FlatAppearance.BorderSize = 0;
            this.buttSett.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttSett.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttSett.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttSett.Image = global::SAM_Random_Generator.Properties.Resources.settings;
            this.buttSett.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttSett.Location = new System.Drawing.Point(0, 260);
            this.buttSett.Name = "buttSett";
            this.buttSett.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttSett.Size = new System.Drawing.Size(220, 60);
            this.buttSett.TabIndex = 4;
            this.buttSett.Text = "  Settings";
            this.buttSett.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttSett.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttSett.UseVisualStyleBackColor = true;
            this.buttSett.Click += new System.EventHandler(this.buttSett_Click);
            // 
            // buttIdent
            // 
            this.buttIdent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttIdent.FlatAppearance.BorderSize = 0;
            this.buttIdent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttIdent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttIdent.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttIdent.Image = global::SAM_Random_Generator.Properties.Resources.id_card;
            this.buttIdent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttIdent.Location = new System.Drawing.Point(0, 200);
            this.buttIdent.Name = "buttIdent";
            this.buttIdent.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttIdent.Size = new System.Drawing.Size(220, 60);
            this.buttIdent.TabIndex = 3;
            this.buttIdent.Text = "  Identity Generator";
            this.buttIdent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttIdent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttIdent.UseVisualStyleBackColor = true;
            this.buttIdent.Click += new System.EventHandler(this.buttIdent_Click);
            // 
            // buttUser
            // 
            this.buttUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttUser.FlatAppearance.BorderSize = 0;
            this.buttUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttUser.Image = global::SAM_Random_Generator.Properties.Resources.id_card_1_;
            this.buttUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttUser.Location = new System.Drawing.Point(0, 140);
            this.buttUser.Name = "buttUser";
            this.buttUser.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttUser.Size = new System.Drawing.Size(220, 60);
            this.buttUser.TabIndex = 1;
            this.buttUser.Text = "  Username Generator";
            this.buttUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttUser.UseVisualStyleBackColor = true;
            this.buttUser.Click += new System.EventHandler(this.buttUser_Click);
            // 
            // buttPass
            // 
            this.buttPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttPass.FlatAppearance.BorderSize = 0;
            this.buttPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttPass.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttPass.Image = global::SAM_Random_Generator.Properties.Resources._lock;
            this.buttPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttPass.Location = new System.Drawing.Point(0, 80);
            this.buttPass.Name = "buttPass";
            this.buttPass.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttPass.Size = new System.Drawing.Size(220, 60);
            this.buttPass.TabIndex = 0;
            this.buttPass.Text = "  Password Generator";
            this.buttPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttPass.UseVisualStyleBackColor = true;
            this.buttPass.Click += new System.EventHandler(this.buttPass_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(81, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(964, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::SAM_Random_Generator.Properties.Resources.minus;
            this.btnMinimize.Location = new System.Drawing.Point(862, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = global::SAM_Random_Generator.Properties.Resources.minus_1_;
            this.btnMaximize.Location = new System.Drawing.Point(898, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::SAM_Random_Generator.Properties.Resources.turn_off;
            this.btnClose.Location = new System.Drawing.Point(934, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::SAM_Random_Generator.Properties.Resources.cross_3_;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(454, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.dateTimePicker2);
            this.panelDesktopPane.Controls.Add(this.dateTimePicker1);
            this.panelDesktopPane.Controls.Add(this.pictureBox1);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(964, 481);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(353, 246);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(137, 23);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(525, 66);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::SAM_Random_Generator.Properties.Resources.mem__9_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(964, 486);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "FormMainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button buttSett;
        private Button buttIdent;
        private Button buttUser;
        private Button buttPass;
        private Panel panelLogo;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label1;
        private Panel panelDesktopPane;
        private Button btnCloseChildForm;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
    }
}