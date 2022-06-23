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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Response_List = new System.Windows.Forms.ListBox();
            this.lblHealth_Response = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblShowAll = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctrbxLogo = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstbxSearchList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Response_List
            // 
            this.Response_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Response_List.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Response_List.FormattingEnabled = true;
            this.Response_List.ItemHeight = 23;
            this.Response_List.Location = new System.Drawing.Point(60, 274);
            this.Response_List.Name = "Response_List";
            this.Response_List.Size = new System.Drawing.Size(366, 255);
            this.Response_List.TabIndex = 0;
            // 
            // lblHealth_Response
            // 
            this.lblHealth_Response.AutoSize = true;
            this.lblHealth_Response.BackColor = System.Drawing.Color.Transparent;
            this.lblHealth_Response.Font = new System.Drawing.Font("Bookman Old Style", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth_Response.Location = new System.Drawing.Point(130, 29);
            this.lblHealth_Response.Name = "lblHealth_Response";
            this.lblHealth_Response.Size = new System.Drawing.Size(645, 52);
            this.lblHealth_Response.TabIndex = 3;
            this.lblHealth_Response.Text = "HEALTH FORM RESPONSES";
            this.lblHealth_Response.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(558, 636);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 46);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search ...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAll.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(243, 223);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(89, 28);
            this.btnShowAll.TabIndex = 7;
            this.btnShowAll.Text = "Show";
            this.btnShowAll.UseVisualStyleBackColor = false;
            // 
            // lblShowAll
            // 
            this.lblShowAll.AutoSize = true;
            this.lblShowAll.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowAll.Location = new System.Drawing.Point(41, 225);
            this.lblShowAll.Name = "lblShowAll";
            this.lblShowAll.Size = new System.Drawing.Size(196, 23);
            this.lblShowAll.TabIndex = 8;
            this.lblShowAll.Text = "Show all responses";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(187, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 28);
            this.textBox1.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(623, 172);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 28);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Contact_Tracing.Properties.Resources.White_Pastel_Drawings__9_;
            this.pictureBox1.Location = new System.Drawing.Point(34, 167);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(681, 636);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 46);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lstbxSearchList
            // 
            this.lstbxSearchList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstbxSearchList.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxSearchList.FormattingEnabled = true;
            this.lstbxSearchList.ItemHeight = 23;
            this.lstbxSearchList.Location = new System.Drawing.Point(432, 274);
            this.lstbxSearchList.Name = "lstbxSearchList";
            this.lstbxSearchList.Size = new System.Drawing.Size(366, 255);
            this.lstbxSearchList.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(844, 716);
            this.Controls.Add(this.lstbxSearchList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblShowAll);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHealth_Response);
            this.Controls.Add(this.pctrbxLogo);
            this.Controls.Add(this.Response_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Responses";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Response_List;
        private System.Windows.Forms.PictureBox pctrbxLogo;
        private System.Windows.Forms.Label lblHealth_Response;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblShowAll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstbxSearchList;
    }
}