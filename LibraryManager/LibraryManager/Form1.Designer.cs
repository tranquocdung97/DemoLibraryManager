namespace LibraryManager
{
    partial class FormMain
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BOOKID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTHOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGECOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOPIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxPage = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitCtrlEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadAllRecordsCtrlRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadAllRecordsCtrlRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordCtrlDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyRecordCtrlMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchRecordCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonReload,
            this.toolStripSeparator1,
            this.buttonAdd,
            this.toolStripSeparator2,
            this.buttonDelete,
            this.toolStripSeparator3,
            this.buttonSearch,
            this.toolStripSeparator4,
            this.buttonModify,
            this.toolStripSeparator5,
            this.buttonExit,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClick);
            // 
            // buttonReload
            // 
            this.buttonReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonReload.Image = global::LibraryManager.Properties.Resources.Button_Refresh_icon;
            this.buttonReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(23, 22);
            this.buttonReload.Text = "Reload";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonAdd
            // 
            this.buttonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAdd.Image = global::LibraryManager.Properties.Resources.Add_icon;
            this.buttonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(23, 22);
            this.buttonAdd.Text = "Add";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonDelete
            // 
            this.buttonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonDelete.Image = global::LibraryManager.Properties.Resources.Button_Delete_icon;
            this.buttonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(23, 22);
            this.buttonDelete.Text = "Delete";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonSearch
            // 
            this.buttonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSearch.Image = global::LibraryManager.Properties.Resources.binoculars_icon;
            this.buttonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(23, 22);
            this.buttonSearch.Text = "Search";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonModify
            // 
            this.buttonModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonModify.Image = global::LibraryManager.Properties.Resources.modify_key_icon;
            this.buttonModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(23, 22);
            this.buttonModify.Text = "Modify";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonExit
            // 
            this.buttonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonExit.Image = global::LibraryManager.Properties.Resources.Apps_session_logout_icon;
            this.buttonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(23, 22);
            this.buttonExit.Text = "Exit";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 310);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(20, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(517, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "";
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BOOKID,
            this.TITLE,
            this.AUTHOR,
            this.PAGECOUNT,
            this.TOPIC,
            this.CODE});
            this.dataGridView1.Location = new System.Drawing.Point(20, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(517, 163);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BOOKID
            // 
            this.BOOKID.DataPropertyName = "BOOKID";
            this.BOOKID.HeaderText = "BOOKID";
            this.BOOKID.Name = "BOOKID";
            this.BOOKID.Visible = false;
            // 
            // TITLE
            // 
            this.TITLE.DataPropertyName = "TITLE";
            this.TITLE.HeaderText = "TITLE";
            this.TITLE.Name = "TITLE";
            // 
            // AUTHOR
            // 
            this.AUTHOR.DataPropertyName = "AUTHOR";
            this.AUTHOR.HeaderText = "AUTHOR";
            this.AUTHOR.Name = "AUTHOR";
            // 
            // PAGECOUNT
            // 
            this.PAGECOUNT.DataPropertyName = "PAGE_COUNT";
            this.PAGECOUNT.HeaderText = "PAGECOUNT";
            this.PAGECOUNT.Name = "PAGECOUNT";
            // 
            // TOPIC
            // 
            this.TOPIC.DataPropertyName = "TOPIC";
            this.TOPIC.HeaderText = "TOPIC";
            this.TOPIC.Name = "TOPIC";
            // 
            // CODE
            // 
            this.CODE.DataPropertyName = "CODE";
            this.CODE.HeaderText = "CODE";
            this.CODE.Name = "CODE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lable1);
            this.groupBox1.Controls.Add(this.textBoxCode);
            this.groupBox1.Controls.Add(this.textBoxPage);
            this.groupBox1.Controls.Add(this.textBoxAuthor);
            this.groupBox1.Controls.Add(this.textBoxTopic);
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Location = new System.Drawing.Point(20, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Topic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(10, 23);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(55, 13);
            this.lable1.TabIndex = 5;
            this.lable1.Text = "Book Title";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(418, 62);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(79, 20);
            this.textBoxCode.TabIndex = 4;
            // 
            // textBoxPage
            // 
            this.textBoxPage.Location = new System.Drawing.Point(274, 62);
            this.textBoxPage.Name = "textBoxPage";
            this.textBoxPage.Size = new System.Drawing.Size(100, 20);
            this.textBoxPage.TabIndex = 3;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(70, 62);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(145, 20);
            this.textBoxAuthor.TabIndex = 2;
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Location = new System.Drawing.Point(274, 19);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(223, 20);
            this.textBoxTopic.TabIndex = 1;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(70, 20);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(145, 20);
            this.textBoxTitle.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelDateTime);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Location = new System.Drawing.Point(466, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 22);
            this.panel2.TabIndex = 3;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(19, 5);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(53, 13);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.Text = "DateTime";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(118, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 15);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-5, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 2);
            this.label1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Library Manager";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitCtrlEToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitCtrlEToolStripMenuItem
            // 
            this.exitCtrlEToolStripMenuItem.Name = "exitCtrlEToolStripMenuItem";
            this.exitCtrlEToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+E";
            this.exitCtrlEToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitCtrlEToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitCtrlEToolStripMenuItem.Text = "Exit";
            this.exitCtrlEToolStripMenuItem.Click += new System.EventHandler(this.menuItemExit);
            // 
            // reloadAllRecordsCtrlRToolStripMenuItem
            // 
            this.reloadAllRecordsCtrlRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadAllRecordsCtrlRToolStripMenuItem1,
            this.addRecordCtrlAToolStripMenuItem,
            this.deleteRecordCtrlDToolStripMenuItem,
            this.modifyRecordCtrlMToolStripMenuItem,
            this.searchRecordCtrlSToolStripMenuItem});
            this.reloadAllRecordsCtrlRToolStripMenuItem.Name = "reloadAllRecordsCtrlRToolStripMenuItem";
            this.reloadAllRecordsCtrlRToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reloadAllRecordsCtrlRToolStripMenuItem.Text = "Actions";
            // 
            // reloadAllRecordsCtrlRToolStripMenuItem1
            // 
            this.reloadAllRecordsCtrlRToolStripMenuItem1.Name = "reloadAllRecordsCtrlRToolStripMenuItem1";
            this.reloadAllRecordsCtrlRToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+R";
            this.reloadAllRecordsCtrlRToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reloadAllRecordsCtrlRToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.reloadAllRecordsCtrlRToolStripMenuItem1.Text = "Reload All Records";
            this.reloadAllRecordsCtrlRToolStripMenuItem1.Click += new System.EventHandler(this.menuItemReload);
            // 
            // addRecordCtrlAToolStripMenuItem
            // 
            this.addRecordCtrlAToolStripMenuItem.Name = "addRecordCtrlAToolStripMenuItem";
            this.addRecordCtrlAToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.addRecordCtrlAToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addRecordCtrlAToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.addRecordCtrlAToolStripMenuItem.Text = "Add Record";
            this.addRecordCtrlAToolStripMenuItem.Click += new System.EventHandler(this.menuItemAdd);
            // 
            // deleteRecordCtrlDToolStripMenuItem
            // 
            this.deleteRecordCtrlDToolStripMenuItem.Name = "deleteRecordCtrlDToolStripMenuItem";
            this.deleteRecordCtrlDToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+D";
            this.deleteRecordCtrlDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteRecordCtrlDToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.deleteRecordCtrlDToolStripMenuItem.Text = "Delete Record";
            this.deleteRecordCtrlDToolStripMenuItem.Click += new System.EventHandler(this.menuItemDelete);
            // 
            // modifyRecordCtrlMToolStripMenuItem
            // 
            this.modifyRecordCtrlMToolStripMenuItem.Name = "modifyRecordCtrlMToolStripMenuItem";
            this.modifyRecordCtrlMToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+M";
            this.modifyRecordCtrlMToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.modifyRecordCtrlMToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.modifyRecordCtrlMToolStripMenuItem.Text = "Modify Record";
            this.modifyRecordCtrlMToolStripMenuItem.Click += new System.EventHandler(this.menuItemModify);
            // 
            // searchRecordCtrlSToolStripMenuItem
            // 
            this.searchRecordCtrlSToolStripMenuItem.Name = "searchRecordCtrlSToolStripMenuItem";
            this.searchRecordCtrlSToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.searchRecordCtrlSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.searchRecordCtrlSToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.searchRecordCtrlSToolStripMenuItem.Text = "Search Record";
            this.searchRecordCtrlSToolStripMenuItem.Click += new System.EventHandler(this.menuItemSearch);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reloadAllRecordsCtrlRToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 417);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Manager";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton buttonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton buttonSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton buttonModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton buttonExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxPage;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitCtrlEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadAllRecordsCtrlRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadAllRecordsCtrlRToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addRecordCtrlAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordCtrlDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyRecordCtrlMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchRecordCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOKID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTHOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGECOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOPIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;

    }
}

