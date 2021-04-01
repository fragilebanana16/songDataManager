namespace InsertInfo
{
    partial class DataMangementForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.Button();
            this.songFirstLetter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnResetDB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 8000;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(12, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(650, 252);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Song";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Author";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Capo";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Chords";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.author);
            this.groupBox1.Controls.Add(this.songFirstLetter);
            this.groupBox1.Location = new System.Drawing.Point(666, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 165);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 21);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 21);
            this.textBox1.TabIndex = 4;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(12, 60);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(102, 24);
            this.author.TabIndex = 1;
            this.author.Text = "author";
            this.author.UseVisualStyleBackColor = true;
            this.author.Click += new System.EventHandler(this.author_Click);
            // 
            // songFirstLetter
            // 
            this.songFirstLetter.Location = new System.Drawing.Point(12, 126);
            this.songFirstLetter.Name = "songFirstLetter";
            this.songFirstLetter.Size = new System.Drawing.Size(102, 24);
            this.songFirstLetter.TabIndex = 2;
            this.songFirstLetter.Text = "songFirstLetter";
            this.songFirstLetter.UseVisualStyleBackColor = true;
            this.songFirstLetter.Click += new System.EventHandler(this.songFirstLetter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnReload);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.insert);
            this.groupBox2.Location = new System.Drawing.Point(12, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 72);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQL Operation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "chords";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "capo";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(444, 26);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(96, 21);
            this.textBox6.TabIndex = 1;
            this.textBox6.Tag = "kkk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "author";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(360, 26);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(30, 21);
            this.textBox5.TabIndex = 1;
            this.textBox5.Tag = "kkk";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(234, 26);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 21);
            this.textBox4.TabIndex = 1;
            this.textBox4.Tag = "kkk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "songname";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 21);
            this.textBox3.TabIndex = 1;
            this.textBox3.Tag = "kkk";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(552, 24);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(102, 24);
            this.insert.TabIndex = 0;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(666, 25);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(102, 23);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "btnReload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnResetDB
            // 
            this.btnResetDB.Location = new System.Drawing.Point(678, 192);
            this.btnResetDB.Name = "btnResetDB";
            this.btnResetDB.Size = new System.Drawing.Size(102, 23);
            this.btnResetDB.TabIndex = 6;
            this.btnResetDB.Text = "btnResetDB";
            this.btnResetDB.UseVisualStyleBackColor = true;
            this.btnResetDB.Click += new System.EventHandler(this.btnResetDB_Click);
            // 
            // DataMangementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 371);
            this.Controls.Add(this.btnResetDB);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DataMangementForm";
            this.Text = "DataMangementForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button author;
        private System.Windows.Forms.Button songFirstLetter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnResetDB;

    }
}

