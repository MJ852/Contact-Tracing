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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Response_List = new System.Windows.Forms.ListBox();
            this.lblHealth_Response = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pctrbxLogo = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpbxSort = new System.Windows.Forms.GroupBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDateSearch = new System.Windows.Forms.Button();
            this.btnVaccination = new System.Windows.Forms.Button();
            this.cntxtmnVaccination = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlstrpFull = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpFirst = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpNot = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cntxtDateSearch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlstrpDateSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxLogo)).BeginInit();
            this.grpbxSort.SuspendLayout();
            this.cntxtmnVaccination.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cntxtDateSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // Response_List
            // 
            this.Response_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Response_List.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Response_List.FormattingEnabled = true;
            this.Response_List.ItemHeight = 23;
            this.Response_List.Location = new System.Drawing.Point(197, 185);
            this.Response_List.Name = "Response_List";
            this.Response_List.Size = new System.Drawing.Size(616, 301);
            this.Response_List.TabIndex = 0;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search ...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(304, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 28);
            this.textBox1.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::Contact_Tracing.Properties.Resources.White_Pastel_Drawings__9_;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(754, 133);
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
            // 
            // grpbxSort
            // 
            this.grpbxSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpbxSort.Controls.Add(this.btnVaccination);
            this.grpbxSort.Controls.Add(this.btnDateSearch);
            this.grpbxSort.Controls.Add(this.button1);
            this.grpbxSort.Location = new System.Drawing.Point(22, 185);
            this.grpbxSort.Name = "grpbxSort";
            this.grpbxSort.Size = new System.Drawing.Size(162, 335);
            this.grpbxSort.TabIndex = 12;
            this.grpbxSort.TabStop = false;
            this.grpbxSort.Text = " ";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(19, 4);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(126, 24);
            this.lblSort.TabIndex = 13;
            this.lblSort.Text = "Sort by . . .";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(2, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "See all";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.AllowDrop = true;
            this.btnDateSearch.BackColor = System.Drawing.Color.White;
            this.btnDateSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDateSearch.ContextMenuStrip = this.cntxtDateSearch;
            this.btnDateSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDateSearch.FlatAppearance.BorderSize = 0;
            this.btnDateSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDateSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateSearch.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateSearch.Location = new System.Drawing.Point(4, 46);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(153, 28);
            this.btnDateSearch.TabIndex = 15;
            this.btnDateSearch.Text = "Date";
            this.btnDateSearch.UseVisualStyleBackColor = false;
            this.btnDateSearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVaccination
            // 
            this.btnVaccination.AllowDrop = true;
            this.btnVaccination.BackColor = System.Drawing.Color.White;
            this.btnVaccination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVaccination.ContextMenuStrip = this.cntxtmnVaccination;
            this.btnVaccination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaccination.FlatAppearance.BorderSize = 0;
            this.btnVaccination.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnVaccination.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnVaccination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaccination.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaccination.Location = new System.Drawing.Point(2, 80);
            this.btnVaccination.Name = "btnVaccination";
            this.btnVaccination.Size = new System.Drawing.Size(153, 28);
            this.btnVaccination.TabIndex = 16;
            this.btnVaccination.Text = "Vaccination";
            this.btnVaccination.UseVisualStyleBackColor = false;
            this.btnVaccination.Click += new System.EventHandler(this.btnVaccination_Click);
            // 
            // cntxtmnVaccination
            // 
            this.cntxtmnVaccination.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxtmnVaccination.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpFull,
            this.tlstrpFirst,
            this.tlstrpNot});
            this.cntxtmnVaccination.Name = "cntxtmnVaccination";
            this.cntxtmnVaccination.Size = new System.Drawing.Size(206, 76);
            this.cntxtmnVaccination.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tlstrpFull
            // 
            this.tlstrpFull.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlstrpFull.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlstrpFull.Name = "tlstrpFull";
            this.tlstrpFull.Size = new System.Drawing.Size(205, 24);
            this.tlstrpFull.Text = "Fully Vaccinated";
            // 
            // tlstrpFirst
            // 
            this.tlstrpFirst.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlstrpFirst.Name = "tlstrpFirst";
            this.tlstrpFirst.Size = new System.Drawing.Size(205, 24);
            this.tlstrpFirst.Text = "First Dose";
            // 
            // tlstrpNot
            // 
            this.tlstrpNot.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlstrpNot.Name = "tlstrpNot";
            this.tlstrpNot.Size = new System.Drawing.Size(205, 24);
            this.tlstrpNot.Text = "Not vaccinated";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblSort);
            this.panel1.Location = new System.Drawing.Point(22, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 31);
            this.panel1.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(460, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 28);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(529, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 28);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(197, 483);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 31);
            this.panel2.TabIndex = 16;
            // 
            // cntxtDateSearch
            // 
            this.cntxtDateSearch.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxtDateSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpDateSearch});
            this.cntxtDateSearch.Name = "cntxtmnVaccination";
            this.cntxtDateSearch.Size = new System.Drawing.Size(162, 28);
            // 
            // tlstrpDateSearch
            // 
            this.tlstrpDateSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlstrpDateSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.tlstrpDateSearch.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlstrpDateSearch.Name = "tlstrpDateSearch";
            this.tlstrpDateSearch.Size = new System.Drawing.Size(161, 24);
            this.tlstrpDateSearch.Text = "Enter Date";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(844, 624);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpbxSort);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHealth_Response);
            this.Controls.Add(this.pctrbxLogo);
            this.Controls.Add(this.Response_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Responses";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxLogo)).EndInit();
            this.grpbxSort.ResumeLayout(false);
            this.cntxtmnVaccination.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.cntxtDateSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Response_List;
        private System.Windows.Forms.PictureBox pctrbxLogo;
        private System.Windows.Forms.Label lblHealth_Response;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpbxSort;
        private System.Windows.Forms.Button btnDateSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Button btnVaccination;
        private System.Windows.Forms.ContextMenuStrip cntxtmnVaccination;
        private System.Windows.Forms.ToolStripMenuItem tlstrpFull;
        private System.Windows.Forms.ToolStripMenuItem tlstrpFirst;
        private System.Windows.Forms.ToolStripMenuItem tlstrpNot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip cntxtDateSearch;
        private System.Windows.Forms.ToolStripMenuItem tlstrpDateSearch;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}