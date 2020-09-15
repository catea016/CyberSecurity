namespace SecurityBenchmarkingTool
{
    partial class SBT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SBT));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BrowseMultipleButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveAudit = new System.Windows.Forms.Button();
            this.BindButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Label_Status = new System.Windows.Forms.Label();
            this.PoliciesListView = new System.Windows.Forms.ListView();
            this.Policies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectDeselectAll = new System.Windows.Forms.RadioButton();
            this.CreateNewAuditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ParseButton
            // 
            this.ParseButton.BackColor = System.Drawing.Color.DarkBlue;
            this.ParseButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ParseButton.Location = new System.Drawing.Point(167, 365);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(117, 54);
            this.ParseButton.TabIndex = 3;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = false;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Security Benchmarking Tool";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(34, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrowseMultipleButton
            // 
            this.BrowseMultipleButton.BackColor = System.Drawing.Color.DarkBlue;
            this.BrowseMultipleButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrowseMultipleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BrowseMultipleButton.Location = new System.Drawing.Point(34, 425);
            this.BrowseMultipleButton.Name = "BrowseMultipleButton";
            this.BrowseMultipleButton.Size = new System.Drawing.Size(530, 54);
            this.BrowseMultipleButton.TabIndex = 6;
            this.BrowseMultipleButton.Text = "Browse Multiple Files";
            this.BrowseMultipleButton.UseVisualStyleBackColor = false;
            this.BrowseMultipleButton.Click += new System.EventHandler(this.BrowseMultipleButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(34, 496);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(418, 140);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DarkBlue;
            this.SaveButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveButton.Location = new System.Drawing.Point(286, 365);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(278, 54);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save to database";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveAudit
            // 
            this.SaveAudit.BackColor = System.Drawing.Color.DarkBlue;
            this.SaveAudit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveAudit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveAudit.Location = new System.Drawing.Point(1079, 199);
            this.SaveAudit.Name = "SaveAudit";
            this.SaveAudit.Size = new System.Drawing.Size(162, 62);
            this.SaveAudit.TabIndex = 10;
            this.SaveAudit.Text = "Save new audit";
            this.SaveAudit.UseVisualStyleBackColor = false;
            this.SaveAudit.Click += new System.EventHandler(this.SaveAudit_Click);
            // 
            // BindButton
            // 
            this.BindButton.BackColor = System.Drawing.Color.DarkBlue;
            this.BindButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BindButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BindButton.Location = new System.Drawing.Point(1079, 105);
            this.BindButton.Name = "BindButton";
            this.BindButton.Size = new System.Drawing.Size(162, 91);
            this.BindButton.TabIndex = 11;
            this.BindButton.Text = "Bind CheckedList Box";
            this.BindButton.UseVisualStyleBackColor = false;
            this.BindButton.Click += new System.EventHandler(this.BindButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1079, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.DarkBlue;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchButton.Location = new System.Drawing.Point(1079, 332);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(105, 38);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Label_Status
            // 
            this.Label_Status.AutoSize = true;
            this.Label_Status.Location = new System.Drawing.Point(1206, 342);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(56, 20);
            this.Label_Status.TabIndex = 14;
            this.Label_Status.Text = "Status";
            this.Label_Status.Click += new System.EventHandler(this.Label_Status_Click);
            // 
            // PoliciesListView
            // 
            this.PoliciesListView.CheckBoxes = true;
            this.PoliciesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Policies});
            this.PoliciesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.PoliciesListView.HideSelection = false;
            this.PoliciesListView.Location = new System.Drawing.Point(585, 105);
            this.PoliciesListView.Name = "PoliciesListView";
            this.PoliciesListView.Size = new System.Drawing.Size(470, 430);
            this.PoliciesListView.TabIndex = 15;
            this.PoliciesListView.UseCompatibleStateImageBehavior = false;
            this.PoliciesListView.View = System.Windows.Forms.View.Details;
            this.PoliciesListView.SelectedIndexChanged += new System.EventHandler(this.PoliciesListView_SelectedIndexChanged);
            // 
            // Policies
            // 
            this.Policies.Width = 1000;
            // 
            // SelectDeselectAll
            // 
            this.SelectDeselectAll.AutoSize = true;
            this.SelectDeselectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectDeselectAll.Location = new System.Drawing.Point(585, 75);
            this.SelectDeselectAll.Name = "SelectDeselectAll";
            this.SelectDeselectAll.Size = new System.Drawing.Size(185, 26);
            this.SelectDeselectAll.TabIndex = 17;
            this.SelectDeselectAll.TabStop = true;
            this.SelectDeselectAll.Text = "Select/Deselect All";
            this.SelectDeselectAll.UseVisualStyleBackColor = true;
            this.SelectDeselectAll.CheckedChanged += new System.EventHandler(this.SelectDeselectAll_CheckedChanged);
            this.SelectDeselectAll.Click += new System.EventHandler(this.SelectDeselectAll_Click);
            // 
            // CreateNewAuditButton
            // 
            this.CreateNewAuditButton.BackColor = System.Drawing.Color.DarkBlue;
            this.CreateNewAuditButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateNewAuditButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreateNewAuditButton.Location = new System.Drawing.Point(1247, 105);
            this.CreateNewAuditButton.Name = "CreateNewAuditButton";
            this.CreateNewAuditButton.Size = new System.Drawing.Size(136, 91);
            this.CreateNewAuditButton.TabIndex = 18;
            this.CreateNewAuditButton.Text = "Create new audit";
            this.CreateNewAuditButton.UseVisualStyleBackColor = false;
            this.CreateNewAuditButton.Click += new System.EventHandler(this.CreateNewAuditButton_Click);
            // 
            // SBT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1472, 741);
            this.Controls.Add(this.CreateNewAuditButton);
            this.Controls.Add(this.SelectDeselectAll);
            this.Controls.Add(this.PoliciesListView);
            this.Controls.Add(this.Label_Status);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BindButton);
            this.Controls.Add(this.SaveAudit);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BrowseMultipleButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SBT";
            this.Text = "Security Benchmarking Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BrowseMultipleButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SaveAudit;
        private System.Windows.Forms.Button BindButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label Label_Status;
        private System.Windows.Forms.ListView PoliciesListView;
        private System.Windows.Forms.ColumnHeader Policies;
        private System.Windows.Forms.RadioButton SelectDeselectAll;
        private System.Windows.Forms.Button CreateNewAuditButton;
    }
}

