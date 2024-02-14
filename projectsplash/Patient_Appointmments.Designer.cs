namespace projectsplash
{
    partial class Patient_Appointmments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_show = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.com_specialisty = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_docName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dataGridView_Appoinments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appoinmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialistyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appoinmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet5 = new projectsplash.HospitalDataSet5();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.hospitalDataSet2 = new projectsplash.HospitalDataSet2();
            this.appoinmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appoinmentsTableAdapter = new projectsplash.HospitalDataSet2TableAdapters.AppoinmentsTableAdapter();
            this.appoinmentsTableAdapter1 = new projectsplash.HospitalDataSet5TableAdapters.AppoinmentsTableAdapter();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appoinments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(400, 738);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(423, 68);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(171, 32);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Appoinments";
            // 
            // btn_show
            // 
            this.btn_show.Animated = true;
            this.btn_show.AutoRoundedCorners = true;
            this.btn_show.BorderRadius = 21;
            this.btn_show.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_show.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_show.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_show.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_show.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_show.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.btn_show.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_show.ForeColor = System.Drawing.Color.White;
            this.btn_show.IndicateFocus = true;
            this.btn_show.Location = new System.Drawing.Point(1175, 176);
            this.btn_show.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(143, 44);
            this.btn_show.TabIndex = 21;
            this.btn_show.Text = "Show";
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(417, 190);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(127, 20);
            this.guna2HtmlLabel2.TabIndex = 22;
            this.guna2HtmlLabel2.Text = "Select Specialisty";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(841, 190);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(86, 20);
            this.guna2HtmlLabel3.TabIndex = 22;
            this.guna2HtmlLabel3.Text = "Enter Name";
            // 
            // com_specialisty
            // 
            this.com_specialisty.AutoRoundedCorners = true;
            this.com_specialisty.BackColor = System.Drawing.Color.Transparent;
            this.com_specialisty.BorderRadius = 17;
            this.com_specialisty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.com_specialisty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_specialisty.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.com_specialisty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.com_specialisty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.com_specialisty.ForeColor = System.Drawing.Color.Black;
            this.com_specialisty.ItemHeight = 30;
            this.com_specialisty.Items.AddRange(new object[] {
            "Allergy and Immunology",
            "Dental Surgeon",
            "Anesthesiology",
            "Dermatology",
            "Diagnostic radiology",
            "Emergency medicine",
            "Family medicine",
            "Internal Medicine",
            "Neurology",
            "Obstetrics and Gynecology"});
            this.com_specialisty.Location = new System.Drawing.Point(565, 176);
            this.com_specialisty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.com_specialisty.Name = "com_specialisty";
            this.com_specialisty.Size = new System.Drawing.Size(248, 36);
            this.com_specialisty.TabIndex = 23;
            // 
            // txt_docName
            // 
            this.txt_docName.Animated = true;
            this.txt_docName.AutoRoundedCorners = true;
            this.txt_docName.BorderRadius = 21;
            this.txt_docName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_docName.DefaultText = "";
            this.txt_docName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_docName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_docName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_docName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_docName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_docName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_docName.ForeColor = System.Drawing.Color.Black;
            this.txt_docName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_docName.Location = new System.Drawing.Point(945, 176);
            this.txt_docName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_docName.Name = "txt_docName";
            this.txt_docName.PasswordChar = '\0';
            this.txt_docName.PlaceholderText = "";
            this.txt_docName.SelectedText = "";
            this.txt_docName.Size = new System.Drawing.Size(221, 44);
            this.txt_docName.TabIndex = 24;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.dataGridView_Appoinments);
            this.guna2GradientPanel1.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.SystemColors.MenuText;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(471, 279);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(772, 332);
            this.guna2GradientPanel1.TabIndex = 25;
            // 
            // dataGridView_Appoinments
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_Appoinments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Appoinments.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Appoinments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Appoinments.ColumnHeadersHeight = 4;
            this.dataGridView_Appoinments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_Appoinments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.appoinmentDateDataGridViewTextBoxColumn,
            this.specialistyDataGridViewTextBoxColumn,
            this.ddoctorDataGridViewTextBoxColumn});
            this.dataGridView_Appoinments.DataSource = this.appoinmentsBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Appoinments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Appoinments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Appoinments.Location = new System.Drawing.Point(44, 42);
            this.dataGridView_Appoinments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Appoinments.Name = "dataGridView_Appoinments";
            this.dataGridView_Appoinments.RowHeadersVisible = false;
            this.dataGridView_Appoinments.RowHeadersWidth = 51;
            this.dataGridView_Appoinments.Size = new System.Drawing.Size(687, 238);
            this.dataGridView_Appoinments.TabIndex = 0;
            this.dataGridView_Appoinments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Appoinments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_Appoinments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Appoinments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_Appoinments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Appoinments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Appoinments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Appoinments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_Appoinments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Appoinments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Appoinments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Appoinments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_Appoinments.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView_Appoinments.ThemeStyle.ReadOnly = false;
            this.dataGridView_Appoinments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Appoinments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Appoinments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Appoinments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_Appoinments.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_Appoinments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Appoinments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // appoinmentDateDataGridViewTextBoxColumn
            // 
            this.appoinmentDateDataGridViewTextBoxColumn.DataPropertyName = "Appoinment_Date";
            this.appoinmentDateDataGridViewTextBoxColumn.HeaderText = "Appoinment_Date";
            this.appoinmentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appoinmentDateDataGridViewTextBoxColumn.Name = "appoinmentDateDataGridViewTextBoxColumn";
            // 
            // specialistyDataGridViewTextBoxColumn
            // 
            this.specialistyDataGridViewTextBoxColumn.DataPropertyName = "Specialisty";
            this.specialistyDataGridViewTextBoxColumn.HeaderText = "Specialisty";
            this.specialistyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specialistyDataGridViewTextBoxColumn.Name = "specialistyDataGridViewTextBoxColumn";
            // 
            // ddoctorDataGridViewTextBoxColumn
            // 
            this.ddoctorDataGridViewTextBoxColumn.DataPropertyName = "Ddoctor";
            this.ddoctorDataGridViewTextBoxColumn.HeaderText = "Ddoctor";
            this.ddoctorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ddoctorDataGridViewTextBoxColumn.Name = "ddoctorDataGridViewTextBoxColumn";
            // 
            // appoinmentsBindingSource1
            // 
            this.appoinmentsBindingSource1.DataMember = "Appoinments";
            this.appoinmentsBindingSource1.DataSource = this.hospitalDataSet5;
            // 
            // hospitalDataSet5
            // 
            this.hospitalDataSet5.DataSetName = "HospitalDataSet5";
            this.hospitalDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Separator1.FillThickness = 5;
            this.guna2Separator1.Location = new System.Drawing.Point(417, 107);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(900, 25);
            this.guna2Separator1.TabIndex = 27;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 14;
            this.guna2Button1.DefaultAutoSize = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button1.Location = new System.Drawing.Point(417, 15);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(80, 30);
            this.guna2Button1.TabIndex = 28;
            this.guna2Button1.Text = "⬅ Back";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // hospitalDataSet2
            // 
            this.hospitalDataSet2.DataSetName = "HospitalDataSet2";
            this.hospitalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appoinmentsBindingSource
            // 
            this.appoinmentsBindingSource.DataMember = "Appoinments";
            this.appoinmentsBindingSource.DataSource = this.hospitalDataSet2;
            // 
            // appoinmentsTableAdapter
            // 
            this.appoinmentsTableAdapter.ClearBeforeFill = true;
            // 
            // appoinmentsTableAdapter1
            // 
            this.appoinmentsTableAdapter1.ClearBeforeFill = true;
            // 
            // Patient_Appointmments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 738);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.txt_docName);
            this.Controls.Add(this.com_specialisty);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Patient_Appointmments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Patient_Appointmments_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appoinments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_show;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox com_specialisty;
        private Guna.UI2.WinForms.Guna2TextBox txt_docName;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_Appoinments;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private HospitalDataSet2 hospitalDataSet2;
        private System.Windows.Forms.BindingSource appoinmentsBindingSource;
        private HospitalDataSet2TableAdapters.AppoinmentsTableAdapter appoinmentsTableAdapter;
        private HospitalDataSet5 hospitalDataSet5;
        private System.Windows.Forms.BindingSource appoinmentsBindingSource1;
        private HospitalDataSet5TableAdapters.AppoinmentsTableAdapter appoinmentsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appoinmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialistyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddoctorDataGridViewTextBoxColumn;
    }
}