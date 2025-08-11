namespace TaskManagerTab
{
    partial class frmTaskManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaskManager));
            this.Mainpanel = new CodeVendor.Controls.Grouper();
            this.gvpanel = new System.Windows.Forms.Panel();
            this.lblselectionwindow = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnhide = new System.Windows.Forms.Button();
            this.comboBoxassigne = new System.Windows.Forms.ComboBox();
            this.lblassigne = new System.Windows.Forms.Label();
            this.numericUpDownexpechours = new System.Windows.Forms.NumericUpDown();
            this.lblexpecthours = new System.Windows.Forms.Label();
            this.dateTimePickerexpectdate = new System.Windows.Forms.DateTimePicker();
            this.lblexpecteddate = new System.Windows.Forms.Label();
            this.dateTimePickertaskdate = new System.Windows.Forms.DateTimePicker();
            this.lbltaskdate = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.txttaskid = new System.Windows.Forms.TextBox();
            this.lbltaskid = new System.Windows.Forms.Label();
            this.groupBox1 = new CodeVendor.Controls.Grouper();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.Mainpanel.SuspendLayout();
            this.gvpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownexpechours)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mainpanel
            // 
            this.Mainpanel.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.Mainpanel.BackgroundGradientColor = System.Drawing.SystemColors.HighlightText;
            this.Mainpanel.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.Vertical;
            this.Mainpanel.BorderColor = System.Drawing.Color.Black;
            this.Mainpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mainpanel.BorderThickness = 1F;
            this.Mainpanel.Controls.Add(this.gvpanel);
            this.Mainpanel.Controls.Add(this.comboBoxassigne);
            this.Mainpanel.Controls.Add(this.lblassigne);
            this.Mainpanel.Controls.Add(this.numericUpDownexpechours);
            this.Mainpanel.Controls.Add(this.lblexpecthours);
            this.Mainpanel.Controls.Add(this.dateTimePickerexpectdate);
            this.Mainpanel.Controls.Add(this.lblexpecteddate);
            this.Mainpanel.Controls.Add(this.dateTimePickertaskdate);
            this.Mainpanel.Controls.Add(this.lbltaskdate);
            this.Mainpanel.Controls.Add(this.txtdescription);
            this.Mainpanel.Controls.Add(this.lbldescription);
            this.Mainpanel.Controls.Add(this.txttaskid);
            this.Mainpanel.Controls.Add(this.lbltaskid);
            this.Mainpanel.CustomGroupBoxColor = System.Drawing.Color.PeachPuff;
            this.Mainpanel.GroupImage = null;
            this.Mainpanel.GroupTitle = "";
            this.Mainpanel.Location = new System.Drawing.Point(4, -10);
            this.Mainpanel.Margin = new System.Windows.Forms.Padding(4);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.Mainpanel.PaintGroupBox = true;
            this.Mainpanel.RoundCorners = 10;
            this.Mainpanel.ShadowColor = System.Drawing.Color.Gray;
            this.Mainpanel.ShadowControl = true;
            this.Mainpanel.ShadowThickness = 4;
            this.Mainpanel.Size = new System.Drawing.Size(1061, 352);
            this.Mainpanel.TabIndex = 345;
            // 
            // gvpanel
            // 
            this.gvpanel.AutoScroll = true;
            this.gvpanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.gvpanel.BackgroundImage = global::TaskManagerTab.Properties.Resources.RighGride;
            this.gvpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gvpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvpanel.Controls.Add(this.lblselectionwindow);
            this.gvpanel.Controls.Add(this.dataGridView1);
            this.gvpanel.Controls.Add(this.btnhide);
            this.gvpanel.Location = new System.Drawing.Point(494, 5);
            this.gvpanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gvpanel.Name = "gvpanel";
            this.gvpanel.Size = new System.Drawing.Size(565, 348);
            this.gvpanel.TabIndex = 12;
            // 
            // lblselectionwindow
            // 
            this.lblselectionwindow.AutoSize = true;
            this.lblselectionwindow.BackColor = System.Drawing.Color.Transparent;
            this.lblselectionwindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectionwindow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblselectionwindow.Location = new System.Drawing.Point(184, 18);
            this.lblselectionwindow.Name = "lblselectionwindow";
            this.lblselectionwindow.Size = new System.Drawing.Size(185, 25);
            this.lblselectionwindow.TabIndex = 264;
            this.lblselectionwindow.Text = "Selection Window";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dataGridView1.Location = new System.Drawing.Point(14, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(540, 264);
            this.dataGridView1.TabIndex = 263;
            // 
            // btnhide
            // 
            this.btnhide.BackColor = System.Drawing.Color.FloralWhite;
            this.btnhide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhide.ImageIndex = 9;
            this.btnhide.Location = new System.Drawing.Point(14, 312);
            this.btnhide.Margin = new System.Windows.Forms.Padding(4);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(84, 28);
            this.btnhide.TabIndex = 262;
            this.btnhide.Text = "Hide";
            this.btnhide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhide.UseVisualStyleBackColor = false;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // comboBoxassigne
            // 
            this.comboBoxassigne.FormattingEnabled = true;
            this.comboBoxassigne.Location = new System.Drawing.Point(169, 301);
            this.comboBoxassigne.Name = "comboBoxassigne";
            this.comboBoxassigne.Size = new System.Drawing.Size(538, 24);
            this.comboBoxassigne.TabIndex = 11;
            // 
            // lblassigne
            // 
            this.lblassigne.AutoSize = true;
            this.lblassigne.Location = new System.Drawing.Point(48, 301);
            this.lblassigne.Name = "lblassigne";
            this.lblassigne.Size = new System.Drawing.Size(103, 16);
            this.lblassigne.TabIndex = 10;
            this.lblassigne.Text = "Asigne Task To";
            // 
            // numericUpDownexpechours
            // 
            this.numericUpDownexpechours.Location = new System.Drawing.Point(611, 252);
            this.numericUpDownexpechours.Name = "numericUpDownexpechours";
            this.numericUpDownexpechours.Size = new System.Drawing.Size(96, 22);
            this.numericUpDownexpechours.TabIndex = 9;
            // 
            // lblexpecthours
            // 
            this.lblexpecthours.AutoSize = true;
            this.lblexpecthours.Location = new System.Drawing.Point(491, 252);
            this.lblexpecthours.Name = "lblexpecthours";
            this.lblexpecthours.Size = new System.Drawing.Size(103, 16);
            this.lblexpecthours.TabIndex = 8;
            this.lblexpecthours.Text = "Expected Hours";
            // 
            // dateTimePickerexpectdate
            // 
            this.dateTimePickerexpectdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerexpectdate.Location = new System.Drawing.Point(169, 258);
            this.dateTimePickerexpectdate.Name = "dateTimePickerexpectdate";
            this.dateTimePickerexpectdate.Size = new System.Drawing.Size(138, 22);
            this.dateTimePickerexpectdate.TabIndex = 7;
            // 
            // lblexpecteddate
            // 
            this.lblexpecteddate.AutoSize = true;
            this.lblexpecteddate.Location = new System.Drawing.Point(48, 258);
            this.lblexpecteddate.Name = "lblexpecteddate";
            this.lblexpecteddate.Size = new System.Drawing.Size(96, 16);
            this.lblexpecteddate.TabIndex = 6;
            this.lblexpecteddate.Text = "Expected Date";
            // 
            // dateTimePickertaskdate
            // 
            this.dateTimePickertaskdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickertaskdate.Location = new System.Drawing.Point(569, 44);
            this.dateTimePickertaskdate.Name = "dateTimePickertaskdate";
            this.dateTimePickertaskdate.Size = new System.Drawing.Size(138, 22);
            this.dateTimePickertaskdate.TabIndex = 5;
            // 
            // lbltaskdate
            // 
            this.lbltaskdate.AutoSize = true;
            this.lbltaskdate.Location = new System.Drawing.Point(482, 44);
            this.lbltaskdate.Name = "lbltaskdate";
            this.lbltaskdate.Size = new System.Drawing.Size(70, 16);
            this.lbltaskdate.TabIndex = 4;
            this.lbltaskdate.Text = "Task Date";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(169, 88);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(538, 141);
            this.txtdescription.TabIndex = 3;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Location = new System.Drawing.Point(48, 88);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(75, 16);
            this.lbldescription.TabIndex = 2;
            this.lbldescription.Text = "Description";
            // 
            // txttaskid
            // 
            this.txttaskid.Location = new System.Drawing.Point(169, 45);
            this.txttaskid.Name = "txttaskid";
            this.txttaskid.Size = new System.Drawing.Size(170, 22);
            this.txttaskid.TabIndex = 1;
            // 
            // lbltaskid
            // 
            this.lbltaskid.AutoSize = true;
            this.lbltaskid.Location = new System.Drawing.Point(48, 45);
            this.lbltaskid.Name = "lbltaskid";
            this.lbltaskid.Size = new System.Drawing.Size(54, 16);
            this.lbltaskid.TabIndex = 0;
            this.lbltaskid.Text = "Task ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.BackgroundGradientColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.BackgroundGradientMode = CodeVendor.Controls.Grouper.GroupBoxGradientMode.Vertical;
            this.groupBox1.BorderColor = System.Drawing.Color.Black;
            this.groupBox1.BorderThickness = 1F;
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.CustomGroupBoxColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.GroupImage = null;
            this.groupBox1.GroupTitle = "";
            this.groupBox1.Location = new System.Drawing.Point(4, 350);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.groupBox1.PaintGroupBox = true;
            this.groupBox1.RoundCorners = 10;
            this.groupBox1.ShadowColor = System.Drawing.Color.Gray;
            this.groupBox1.ShadowControl = true;
            this.groupBox1.ShadowThickness = 4;
            this.groupBox1.Size = new System.Drawing.Size(1061, 66);
            this.groupBox1.TabIndex = 346;
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.ImageIndex = 9;
            this.btnexit.Location = new System.Drawing.Point(931, 23);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(84, 28);
            this.btnexit.TabIndex = 262;
            this.btnexit.Text = "Exit";
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.ImageIndex = 9;
            this.btnShow.Location = new System.Drawing.Point(511, 23);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(84, 28);
            this.btnShow.TabIndex = 261;
            this.btnShow.Text = "Show";
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTaskManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.frmTaskManager_Load);
            this.Mainpanel.ResumeLayout(false);
            this.Mainpanel.PerformLayout();
            this.gvpanel.ResumeLayout(false);
            this.gvpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownexpechours)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CodeVendor.Controls.Grouper Mainpanel;
        private CodeVendor.Controls.Grouper groupBox1;
        private System.Windows.Forms.Label lbltaskid;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.TextBox txttaskid;
        private System.Windows.Forms.Label lbltaskdate;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.DateTimePicker dateTimePickertaskdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerexpectdate;
        private System.Windows.Forms.Label lblexpecteddate;
        private System.Windows.Forms.Label lblexpecthours;
        private System.Windows.Forms.NumericUpDown numericUpDownexpechours;
        private System.Windows.Forms.ComboBox comboBoxassigne;
        private System.Windows.Forms.Label lblassigne;
        private System.Windows.Forms.Panel gvpanel;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnhide;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblselectionwindow;
    }
}

