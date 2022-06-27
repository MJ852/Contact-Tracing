namespace Contact_Tracing
{
    partial class Form2
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblHealth_Response = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pctrbxLogo = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpbxSort = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.btnSeeAll = new System.Windows.Forms.Button();
            this.pnlSortDesign = new System.Windows.Forms.Panel();
            this.lblSort = new System.Windows.Forms.Label();
            this.lstvwSort = new System.Windows.Forms.ListView();
            this.clmnhDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstbxSeeAll = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxLogo)).BeginInit();
            this.grpbxSort.SuspendLayout();
            this.pnlSortDesign.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHealth_Response
            // 
            this.lblHealth_Response.AutoSize = true;
            this.lblHealth_Response.BackColor = System.Drawing.Color.Transparent;
            this.lblHealth_Response.Font = new System.Drawing.Font("Bookman Old Style", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth_Response.Location = new System.Drawing.Point(130, 29);
            this.lblHealth_Response.Name = "lblHealth_Response";
            this.lblHealth_Response.Size = new System.Drawing.Size(629, 48);
            this.lblHealth_Response.TabIndex = 3;
            this.lblHealth_Response.Text = "HEALTH FORM RESPONSES";
            this.lblHealth_Response.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(573, 554);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 36);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(634, 150);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(125, 23);
            this.lblInformation.TabIndex = 5;
            this.lblInformation.Text = "Information";
            this.lblInformation.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::Contact_Tracing.Properties.Resources.White_Pastel_Drawings__9_;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(579, 139);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 43);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = " ";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // pctrbxLogo
            // 
            this.pctrbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxLogo.Image = global::Contact_Tracing.Properties.Resources.White_Pastel_Drawings_3;
            this.pctrbxLogo.Location = new System.Drawing.Point(12, 11);
            this.pctrbxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctrbxLogo.Name = "pctrbxLogo";
            this.pctrbxLogo.Size = new System.Drawing.Size(112, 96);
            this.pctrbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbxLogo.TabIndex = 1;
            this.pctrbxLogo.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(696, 554);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 36);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpbxSort
            // 
            this.grpbxSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpbxSort.Controls.Add(this.lblDate);
            this.grpbxSort.Controls.Add(this.datepicker);
            this.grpbxSort.Controls.Add(this.btnSeeAll);
            this.grpbxSort.Controls.Add(this.pnlSortDesign);
            this.grpbxSort.Location = new System.Drawing.Point(22, 160);
            this.grpbxSort.Name = "grpbxSort";
            this.grpbxSort.Size = new System.Drawing.Size(162, 335);
            this.grpbxSort.TabIndex = 12;
            this.grpbxSort.TabStop = false;
            this.grpbxSort.Text = " ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(5, 52);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 21);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = " Date";
            // 
            // datepicker
            // 
            this.datepicker.CalendarFont = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker.Location = new System.Drawing.Point(14, 76);
            this.datepicker.MinDate = new System.DateTime(2018, 3, 25, 0, 0, 0, 0);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(131, 22);
            this.datepicker.TabIndex = 42;
            this.datepicker.Value = new System.DateTime(2022, 6, 24, 23, 59, 59, 0);
            this.datepicker.ValueChanged += new System.EventHandler(this.datepicker_ValueChanged);
            // 
            // btnSeeAll
            // 
            this.btnSeeAll.BackColor = System.Drawing.Color.White;
            this.btnSeeAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSeeAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeAll.FlatAppearance.BorderSize = 0;
            this.btnSeeAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSeeAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnSeeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeAll.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAll.Location = new System.Drawing.Point(5, 111);
            this.btnSeeAll.Name = "btnSeeAll";
            this.btnSeeAll.Size = new System.Drawing.Size(154, 28);
            this.btnSeeAll.TabIndex = 14;
            this.btnSeeAll.Text = "See all";
            this.btnSeeAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeeAll.UseVisualStyleBackColor = false;
            this.btnSeeAll.Click += new System.EventHandler(this.btnSeeAll_Click);
            // 
            // pnlSortDesign
            // 
            this.pnlSortDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlSortDesign.Controls.Add(this.lblSort);
            this.pnlSortDesign.Location = new System.Drawing.Point(1, 1);
            this.pnlSortDesign.Name = "pnlSortDesign";
            this.pnlSortDesign.Size = new System.Drawing.Size(162, 31);
            this.pnlSortDesign.TabIndex = 15;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(16, 5);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(126, 24);
            this.lblSort.TabIndex = 13;
            this.lblSort.Text = "Sort by . . .";
            // 
            // lstvwSort
            // 
            this.lstvwSort.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnhDate});
            this.lstvwSort.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvwSort.HideSelection = false;
            this.lstvwSort.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lstvwSort.Location = new System.Drawing.Point(223, 186);
            this.lstvwSort.Name = "lstvwSort";
            this.lstvwSort.Size = new System.Drawing.Size(547, 306);
            this.lstvwSort.TabIndex = 17;
            this.lstvwSort.UseCompatibleStateImageBehavior = false;
            this.lstvwSort.View = System.Windows.Forms.View.Details;
            this.lstvwSort.SelectedIndexChanged += new System.EventHandler(this.lstvwSort_SelectedIndexChanged);
            // 
            // clmnhDate
            // 
            this.clmnhDate.Text = "Date";
            this.clmnhDate.Width = 135;
            // 
            // lstbxSeeAll
            // 
            this.lstbxSeeAll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstbxSeeAll.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxSeeAll.FormattingEnabled = true;
            this.lstbxSeeAll.HorizontalScrollbar = true;
            this.lstbxSeeAll.ItemHeight = 20;
            this.lstbxSeeAll.Location = new System.Drawing.Point(401, 186);
            this.lstbxSeeAll.Name = "lstbxSeeAll";
            this.lstbxSeeAll.Size = new System.Drawing.Size(372, 304);
            this.lstbxSeeAll.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(226, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 27);
            this.panel1.TabIndex = 16;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(470, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 25);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(844, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstbxSeeAll);
            this.Controls.Add(this.lstvwSort);
            this.Controls.Add(this.grpbxSort);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHealth_Response);
            this.Controls.Add(this.pctrbxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Responses";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxLogo)).EndInit();
            this.grpbxSort.ResumeLayout(false);
            this.grpbxSort.PerformLayout();
            this.pnlSortDesign.ResumeLayout(false);
            this.pnlSortDesign.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pctrbxLogo;
        private System.Windows.Forms.Label lblHealth_Response;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpbxSort;
        private System.Windows.Forms.Button btnSeeAll;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Panel pnlSortDesign;
        private System.Windows.Forms.ListView lstvwSort;
        private System.Windows.Forms.ColumnHeader clmnhDate;
        private System.Windows.Forms.ListBox lstbxSeeAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Button btnClear;
    }
}