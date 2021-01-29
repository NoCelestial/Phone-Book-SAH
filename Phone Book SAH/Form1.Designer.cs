namespace Phone_Book_SAH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnper = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmhelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiabout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lblsearchby = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lbltelphone = new System.Windows.Forms.Label();
            this.lbladress = new System.Windows.Forms.Label();
            this.dgvdb = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtadress = new System.Windows.Forms.TextBox();
            this.txttelphone = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblsearchvalue = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnrescue = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(361, 30);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(100, 90);
            this.btnsearch.TabIndex = 12;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(12, 284);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(75, 40);
            this.btnfirst.TabIndex = 8;
            this.btnfirst.Text = "First";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(101, 284);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 40);
            this.btnnext.TabIndex = 10;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(12, 238);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 40);
            this.btnnew.TabIndex = 4;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnsnsde);
            // 
            // btnper
            // 
            this.btnper.Location = new System.Drawing.Point(182, 284);
            this.btnper.Name = "btnper";
            this.btnper.Size = new System.Drawing.Size(75, 40);
            this.btnper.TabIndex = 11;
            this.btnper.Text = "Per...";
            this.btnper.UseVisualStyleBackColor = true;
            this.btnper.Click += new System.EventHandler(this.btnper_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(263, 284);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(75, 40);
            this.btnlast.TabIndex = 9;
            this.btnlast.Text = "Last";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(101, 238);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 40);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsnsde);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(182, 238);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 40);
            this.btnedit.TabIndex = 6;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnsnsde);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(263, 238);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 40);
            this.btndel.TabIndex = 7;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btnsnsde);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmhelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmhelp
            // 
            this.tsmhelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiabout});
            this.tsmhelp.Name = "tsmhelp";
            this.tsmhelp.Size = new System.Drawing.Size(44, 20);
            this.tsmhelp.Text = "&Help";
            // 
            // tsmiabout
            // 
            this.tsmiabout.Image = ((System.Drawing.Image)(resources.GetObject("tsmiabout.Image")));
            this.tsmiabout.Name = "tsmiabout";
            this.tsmiabout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.tsmiabout.Size = new System.Drawing.Size(144, 22);
            this.tsmiabout.Text = "&About";
            this.tsmiabout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(6, 30);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(95, 19);
            this.lblfirstname.TabIndex = 10;
            this.lblfirstname.Text = "First Name :";
            // 
            // lblsearchby
            // 
            this.lblsearchby.AutoSize = true;
            this.lblsearchby.Location = new System.Drawing.Point(467, 33);
            this.lblsearchby.Name = "lblsearchby";
            this.lblsearchby.Size = new System.Drawing.Size(88, 19);
            this.lblsearchby.TabIndex = 11;
            this.lblsearchby.Text = "Search By :";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(6, 63);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(93, 19);
            this.lbllastname.TabIndex = 12;
            this.lbllastname.Text = "Last Name :";
            // 
            // lbltelphone
            // 
            this.lbltelphone.AutoSize = true;
            this.lbltelphone.Location = new System.Drawing.Point(6, 96);
            this.lbltelphone.Name = "lbltelphone";
            this.lbltelphone.Size = new System.Drawing.Size(85, 19);
            this.lbltelphone.TabIndex = 13;
            this.lbltelphone.Text = "TelPhone :";
            // 
            // lbladress
            // 
            this.lbladress.AutoSize = true;
            this.lbladress.Location = new System.Drawing.Point(6, 129);
            this.lbladress.Name = "lbladress";
            this.lbladress.Size = new System.Drawing.Size(67, 19);
            this.lbladress.TabIndex = 14;
            this.lbladress.Text = "Adress :";
            // 
            // dgvdb
            // 
            this.dgvdb.AllowUserToAddRows = false;
            this.dgvdb.AllowUserToDeleteRows = false;
            this.dgvdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdb.Location = new System.Drawing.Point(344, 130);
            this.dgvdb.Name = "dgvdb";
            this.dgvdb.ReadOnly = true;
            this.dgvdb.Size = new System.Drawing.Size(399, 188);
            this.dgvdb.TabIndex = 15;
            this.dgvdb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdb_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(585, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 27);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtadress
            // 
            this.txtadress.Location = new System.Drawing.Point(107, 126);
            this.txtadress.Multiline = true;
            this.txtadress.Name = "txtadress";
            this.txtadress.ReadOnly = true;
            this.txtadress.Size = new System.Drawing.Size(231, 96);
            this.txtadress.TabIndex = 3;
            // 
            // txttelphone
            // 
            this.txttelphone.Location = new System.Drawing.Point(107, 93);
            this.txttelphone.Name = "txttelphone";
            this.txttelphone.ReadOnly = true;
            this.txttelphone.Size = new System.Drawing.Size(231, 27);
            this.txttelphone.TabIndex = 2;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(107, 60);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.ReadOnly = true;
            this.txtlastname.Size = new System.Drawing.Size(231, 27);
            this.txtlastname.TabIndex = 1;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(107, 27);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.ReadOnly = true;
            this.txtfirstname.Size = new System.Drawing.Size(231, 27);
            this.txtfirstname.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "First Name",
            "Last Name",
            "TelPhone",
            "Adress"});
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DisplayMember = "l";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "TelPhone",
            "Adress"});
            this.comboBox1.Location = new System.Drawing.Point(585, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 27);
            this.comboBox1.TabIndex = 13;
            // 
            // lblsearchvalue
            // 
            this.lblsearchvalue.AutoSize = true;
            this.lblsearchvalue.Location = new System.Drawing.Point(467, 66);
            this.lblsearchvalue.Name = "lblsearchvalue";
            this.lblsearchvalue.Size = new System.Drawing.Size(110, 19);
            this.lblsearchvalue.TabIndex = 22;
            this.lblsearchvalue.Text = "Search Value :";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(467, 101);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(115, 19);
            this.lblresult.TabIndex = 23;
            this.lblresult.Text = "Search Result :";
            // 
            // btnrescue
            // 
            this.btnrescue.Location = new System.Drawing.Point(12, 166);
            this.btnrescue.Name = "btnrescue";
            this.btnrescue.Size = new System.Drawing.Size(75, 56);
            this.btnrescue.TabIndex = 24;
            this.btnrescue.Text = "Rescue";
            this.btnrescue.UseVisualStyleBackColor = true;
            this.btnrescue.Click += new System.EventHandler(this.btnsnsde);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 330);
            this.Controls.Add(this.btnrescue);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblsearchvalue);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txttelphone);
            this.Controls.Add(this.txtadress);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvdb);
            this.Controls.Add(this.lbladress);
            this.Controls.Add(this.lbltelphone);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.lblsearchby);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnper);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Phone Book SAH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnper;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmhelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiabout;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lblsearchby;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lbltelphone;
        private System.Windows.Forms.Label lbladress;
        private System.Windows.Forms.DataGridView dgvdb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtadress;
        private System.Windows.Forms.TextBox txttelphone;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblsearchvalue;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnrescue;
    }
}

