namespace customer_database
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxPrevCustomer = new System.Windows.Forms.CheckBox();
            this.checkBoxTerms = new System.Windows.Forms.CheckBox();
            this.checkBoxPaperwork = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxRegion = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonPremium = new System.Windows.Forms.RadioButton();
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localDataSet = new customer_database.LocalDataSet();
            this.customerTableAdapter = new customer_database.LocalDataSetTableAdapters.CustomerTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(55, 23);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(125, 20);
            this.textName.TabIndex = 1;
            this.textName.Leave += new System.EventHandler(this.textName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(55, 52);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(125, 20);
            this.textEmail.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxPrevCustomer);
            this.groupBox1.Controls.Add(this.checkBoxTerms);
            this.groupBox1.Controls.Add(this.checkBoxPaperwork);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.listBoxRegion);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // checkBoxPrevCustomer
            // 
            this.checkBoxPrevCustomer.AutoSize = true;
            this.checkBoxPrevCustomer.Location = new System.Drawing.Point(9, 235);
            this.checkBoxPrevCustomer.Name = "checkBoxPrevCustomer";
            this.checkBoxPrevCustomer.Size = new System.Drawing.Size(114, 17);
            this.checkBoxPrevCustomer.TabIndex = 8;
            this.checkBoxPrevCustomer.Text = "Previous Customer";
            this.checkBoxPrevCustomer.UseVisualStyleBackColor = true;
            // 
            // checkBoxTerms
            // 
            this.checkBoxTerms.AutoSize = true;
            this.checkBoxTerms.Location = new System.Drawing.Point(9, 212);
            this.checkBoxTerms.Name = "checkBoxTerms";
            this.checkBoxTerms.Size = new System.Drawing.Size(128, 17);
            this.checkBoxTerms.TabIndex = 7;
            this.checkBoxTerms.Text = "Terms and Conditions";
            this.checkBoxTerms.UseVisualStyleBackColor = true;
            // 
            // checkBoxPaperwork
            // 
            this.checkBoxPaperwork.AutoSize = true;
            this.checkBoxPaperwork.Location = new System.Drawing.Point(9, 189);
            this.checkBoxPaperwork.Name = "checkBoxPaperwork";
            this.checkBoxPaperwork.Size = new System.Drawing.Size(130, 17);
            this.checkBoxPaperwork.TabIndex = 6;
            this.checkBoxPaperwork.Text = "Completed Paperwork";
            this.checkBoxPaperwork.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Region";
            // 
            // listBoxRegion
            // 
            this.listBoxRegion.FormattingEnabled = true;
            this.listBoxRegion.Items.AddRange(new object[] {
            "United States",
            "Mexico",
            "Puerto Rico"});
            this.listBoxRegion.Location = new System.Drawing.Point(55, 91);
            this.listBoxRegion.Name = "listBoxRegion";
            this.listBoxRegion.Size = new System.Drawing.Size(125, 82);
            this.listBoxRegion.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(104, 56);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(118, 20);
            this.textNumber.TabIndex = 4;
            this.textNumber.Leave += new System.EventHandler(this.textNumber_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enrollment Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textNumber);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(227, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 129);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone Number";
            // 
            // radioButtonPremium
            // 
            this.radioButtonPremium.AutoSize = true;
            this.radioButtonPremium.Location = new System.Drawing.Point(15, 22);
            this.radioButtonPremium.Name = "radioButtonPremium";
            this.radioButtonPremium.Size = new System.Drawing.Size(65, 17);
            this.radioButtonPremium.TabIndex = 6;
            this.radioButtonPremium.TabStop = true;
            this.radioButtonPremium.Text = "Premium";
            this.radioButtonPremium.UseVisualStyleBackColor = true;
            // 
            // radioButtonDefault
            // 
            this.radioButtonDefault.AutoSize = true;
            this.radioButtonDefault.Location = new System.Drawing.Point(86, 22);
            this.radioButtonDefault.Name = "radioButtonDefault";
            this.radioButtonDefault.Size = new System.Drawing.Size(59, 17);
            this.radioButtonDefault.TabIndex = 7;
            this.radioButtonDefault.TabStop = true;
            this.radioButtonDefault.Text = "Default";
            this.radioButtonDefault.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonDefault);
            this.groupBox3.Controls.Add(this.radioButtonPremium);
            this.groupBox3.Location = new System.Drawing.Point(559, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 128);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment Plan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(541, 205);
            this.dataGridView1.TabIndex = 9;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.localDataSet;
            // 
            // localDataSet
            // 
            this.localDataSet.DataSetName = "LocalDataSet";
            this.localDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxPrevCustomer;
        private System.Windows.Forms.CheckBox checkBoxTerms;
        private System.Windows.Forms.CheckBox checkBoxPaperwork;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxRegion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonPremium;
        private System.Windows.Forms.RadioButton radioButtonDefault;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LocalDataSet localDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private LocalDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
    }
}

