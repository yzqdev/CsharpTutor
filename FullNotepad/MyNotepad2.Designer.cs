namespace frmmain
{
    partial class MyNotepad2
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //下载于www.mycodes.net
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyNotepad2));
            this.richTxt = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Undo1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cut1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Del1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAll1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddsaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindNextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplaceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GotoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateTimeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewLineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopicsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTxt
            // 
            this.richTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxt.ContextMenuStrip = this.contextMenuStrip1;
            this.richTxt.EnableAutoDragDrop = true;
            this.richTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTxt.Location = new System.Drawing.Point(0, 33);
            this.richTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTxt.Name = "richTxt";
            this.richTxt.Size = new System.Drawing.Size(678, 367);
            this.richTxt.TabIndex = 0;
            this.richTxt.Text = "";
            this.richTxt.SelectionChanged += new System.EventHandler(this.richTxt_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Undo1MenuItem,
            this.Cut1MenuItem,
            this.Copy1MenuItem,
            this.Paste1MenuItem,
            this.Del1MenuItem,
            this.SelectAll1MenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 148);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Undo1MenuItem
            // 
            this.Undo1MenuItem.Name = "Undo1MenuItem";
            this.Undo1MenuItem.Size = new System.Drawing.Size(129, 24);
            this.Undo1MenuItem.Text = "撤消(&U)";
            this.Undo1MenuItem.Click += new System.EventHandler(this.Undo1MenuItem_Click);
            // 
            // Cut1MenuItem
            // 
            this.Cut1MenuItem.Name = "Cut1MenuItem";
            this.Cut1MenuItem.Size = new System.Drawing.Size(129, 24);
            this.Cut1MenuItem.Text = "剪切(&T)";
            this.Cut1MenuItem.Click += new System.EventHandler(this.Cut1MenuItem_Click);
            // 
            // Copy1MenuItem
            // 
            this.Copy1MenuItem.Name = "Copy1MenuItem";
            this.Copy1MenuItem.Size = new System.Drawing.Size(129, 24);
            this.Copy1MenuItem.Text = "复制(&C)";
            this.Copy1MenuItem.Click += new System.EventHandler(this.Copy1MenuItem_Click);
            // 
            // Paste1MenuItem
            // 
            this.Paste1MenuItem.Name = "Paste1MenuItem";
            this.Paste1MenuItem.Size = new System.Drawing.Size(129, 24);
            this.Paste1MenuItem.Text = "粘贴(&P)";
            this.Paste1MenuItem.Click += new System.EventHandler(this.Paste1MenuItem_Click);
            // 
            // Del1MenuItem
            // 
            this.Del1MenuItem.Name = "Del1MenuItem";
            this.Del1MenuItem.Size = new System.Drawing.Size(129, 24);
            this.Del1MenuItem.Text = "删除(&D)";
            this.Del1MenuItem.Click += new System.EventHandler(this.Del1MenuItem_Click);
            // 
            // SelectAll1MenuItem
            // 
            this.SelectAll1MenuItem.Name = "SelectAll1MenuItem";
            this.SelectAll1MenuItem.Size = new System.Drawing.Size(129, 24);
            this.SelectAll1MenuItem.Text = "全选(&A)";
            this.SelectAll1MenuItem.Click += new System.EventHandler(this.SelectAll1MenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.EditMenuItem,
            this.FormMenuItem,
            this.ViewMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(678, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.AddsaveMenuItem,
            this.PageMenuItem,
            this.PrintMenuItem,
            this.ExitMenuItem});
            this.文件FToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(82, 28);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewMenuItem.Size = new System.Drawing.Size(238, 28);
            this.NewMenuItem.Text = "新建(&N)";
            this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenMenuItem.Size = new System.Drawing.Size(238, 28);
            this.OpenMenuItem.Text = "打开(&O)...";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMenuItem.Size = new System.Drawing.Size(238, 28);
            this.SaveMenuItem.Text = "保存(&S)";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // AddsaveMenuItem
            // 
            this.AddsaveMenuItem.Name = "AddsaveMenuItem";
            this.AddsaveMenuItem.Size = new System.Drawing.Size(238, 28);
            this.AddsaveMenuItem.Text = "另存为(&A)...";
            this.AddsaveMenuItem.Click += new System.EventHandler(this.AddsaveMenuItem_Click);
            // 
            // PageMenuItem
            // 
            this.PageMenuItem.Name = "PageMenuItem";
            this.PageMenuItem.Size = new System.Drawing.Size(238, 28);
            this.PageMenuItem.Text = "页面设置(&U)...";
            this.PageMenuItem.Click += new System.EventHandler(this.PageMenuItem_Click);
            // 
            // PrintMenuItem
            // 
            this.PrintMenuItem.Name = "PrintMenuItem";
            this.PrintMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintMenuItem.Size = new System.Drawing.Size(238, 28);
            this.PrintMenuItem.Text = "打印(&P)...";
            this.PrintMenuItem.Click += new System.EventHandler(this.PrintMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(238, 28);
            this.ExitMenuItem.Text = "退出(&X)";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoMenuItem,
            this.CutMenuItem,
            this.CopyMenuItem,
            this.PasteMenuItem,
            this.DelMenuItem,
            this.FindMenuItem,
            this.FindNextItem,
            this.ReplaceMenuItem,
            this.GotoMenuItem,
            this.SelectAllMenuItem,
            this.DateTimeMenuItem});
            this.EditMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(82, 28);
            this.EditMenuItem.Text = "编辑(&E)";
            this.EditMenuItem.DropDownOpened += new System.EventHandler(this.EditMenuItem_DropDownOpened);
            // 
            // UndoMenuItem
            // 
            this.UndoMenuItem.Name = "UndoMenuItem";
            this.UndoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoMenuItem.Size = new System.Drawing.Size(242, 28);
            this.UndoMenuItem.Text = "撤消(&U)";
            this.UndoMenuItem.Click += new System.EventHandler(this.UndoMenuItem_Click);
            // 
            // CutMenuItem
            // 
            this.CutMenuItem.Name = "CutMenuItem";
            this.CutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutMenuItem.Size = new System.Drawing.Size(242, 28);
            this.CutMenuItem.Text = "剪切(&T)";
            this.CutMenuItem.Click += new System.EventHandler(this.CutMenuItem_Click);
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyMenuItem.Size = new System.Drawing.Size(242, 28);
            this.CopyMenuItem.Text = "复制(&C)";
            this.CopyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // PasteMenuItem
            // 
            this.PasteMenuItem.Name = "PasteMenuItem";
            this.PasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteMenuItem.Size = new System.Drawing.Size(242, 28);
            this.PasteMenuItem.Text = "粘贴(&P)";
            this.PasteMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
            // 
            // DelMenuItem
            // 
            this.DelMenuItem.Name = "DelMenuItem";
            this.DelMenuItem.ShortcutKeyDisplayString = "Del";
            this.DelMenuItem.Size = new System.Drawing.Size(242, 28);
            this.DelMenuItem.Text = "删除(&L)";
            this.DelMenuItem.Click += new System.EventHandler(this.DelMenuItem_Click);
            // 
            // FindMenuItem
            // 
            this.FindMenuItem.Name = "FindMenuItem";
            this.FindMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FindMenuItem.Size = new System.Drawing.Size(242, 28);
            this.FindMenuItem.Text = "查找(&F)...";
            this.FindMenuItem.Click += new System.EventHandler(this.FindMenuItem_Click);
            // 
            // FindNextItem
            // 
            this.FindNextItem.Name = "FindNextItem";
            this.FindNextItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.FindNextItem.Size = new System.Drawing.Size(242, 28);
            this.FindNextItem.Text = "查找下一个(&N)";
            this.FindNextItem.Click += new System.EventHandler(this.FindNextItem_Click);
            // 
            // ReplaceMenuItem
            // 
            this.ReplaceMenuItem.Name = "ReplaceMenuItem";
            this.ReplaceMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.ReplaceMenuItem.Size = new System.Drawing.Size(242, 28);
            this.ReplaceMenuItem.Text = "替换(&R)";
            this.ReplaceMenuItem.Click += new System.EventHandler(this.ReplaceMenuItem_Click);
            // 
            // GotoMenuItem
            // 
            this.GotoMenuItem.Name = "GotoMenuItem";
            this.GotoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.GotoMenuItem.Size = new System.Drawing.Size(242, 28);
            this.GotoMenuItem.Text = "转到(&G)";
            this.GotoMenuItem.Click += new System.EventHandler(this.GotoMenuItem_Click);
            // 
            // SelectAllMenuItem
            // 
            this.SelectAllMenuItem.Name = "SelectAllMenuItem";
            this.SelectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllMenuItem.Size = new System.Drawing.Size(242, 28);
            this.SelectAllMenuItem.Text = "全选(&A)";
            this.SelectAllMenuItem.Click += new System.EventHandler(this.SelectAllMenuItem_Click);
            // 
            // DateTimeMenuItem
            // 
            this.DateTimeMenuItem.Name = "DateTimeMenuItem";
            this.DateTimeMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.DateTimeMenuItem.Size = new System.Drawing.Size(242, 28);
            this.DateTimeMenuItem.Text = "日期/时间(&D)";
            this.DateTimeMenuItem.Click += new System.EventHandler(this.DateTimeMenuItem_Click);
            // 
            // FormMenuItem
            // 
            this.FormMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewLineMenuItem,
            this.FontMenuItem});
            this.FormMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormMenuItem.Name = "FormMenuItem";
            this.FormMenuItem.Size = new System.Drawing.Size(87, 28);
            this.FormMenuItem.Text = "格式(&O)";
            // 
            // NewLineMenuItem
            // 
            this.NewLineMenuItem.Checked = true;
            this.NewLineMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NewLineMenuItem.Name = "NewLineMenuItem";
            this.NewLineMenuItem.Size = new System.Drawing.Size(196, 28);
            this.NewLineMenuItem.Text = "自动换行(&W)";
            this.NewLineMenuItem.CheckedChanged += new System.EventHandler(this.NewLineMenuItem_CheckedChanged);
            this.NewLineMenuItem.Click += new System.EventHandler(this.NewLineMenuItem_Click);
            // 
            // FontMenuItem
            // 
            this.FontMenuItem.Name = "FontMenuItem";
            this.FontMenuItem.Size = new System.Drawing.Size(196, 28);
            this.FontMenuItem.Text = "字体(&F)...";
            this.FontMenuItem.Click += new System.EventHandler(this.FontMenuItem_Click);
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMenuItem});
            this.ViewMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewMenuItem.Name = "ViewMenuItem";
            this.ViewMenuItem.Size = new System.Drawing.Size(84, 28);
            this.ViewMenuItem.Text = "查看(&V)";
            this.ViewMenuItem.DropDownOpened += new System.EventHandler(this.ViewMenuItem_DropDownOpened);
            // 
            // StatusMenuItem
            // 
            this.StatusMenuItem.Name = "StatusMenuItem";
            this.StatusMenuItem.Size = new System.Drawing.Size(170, 28);
            this.StatusMenuItem.Text = "状态栏(&S)";
            this.StatusMenuItem.Click += new System.EventHandler(this.StatusMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TopicsMenuItem,
            this.AboutMenuItem});
            this.HelpMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(86, 28);
            this.HelpMenuItem.Text = "帮助(&H)";
            // 
            // TopicsMenuItem
            // 
            this.TopicsMenuItem.Name = "TopicsMenuItem";
            this.TopicsMenuItem.Size = new System.Drawing.Size(209, 28);
            this.TopicsMenuItem.Text = "帮助主题(&H)";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(209, 28);
            this.AboutMenuItem.Text = "关于记事本(&A)";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 799);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(916, 28);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip2.Location = new System.Drawing.Point(0, 402);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(678, 26);
            this.statusStrip2.TabIndex = 3;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(39, 20);
            this.toolStripStatusLabel2.Text = "就绪";
            // 
            // MyNotepad2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 428);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTxt);
            this.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MyNotepad2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "无标题-MyNotepad2";
            this.TransparencyKey = System.Drawing.SystemColors.ButtonFace;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem AddsaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindNextItem;
        private System.Windows.Forms.ToolStripMenuItem ReplaceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GotoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DateTimeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewLineMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatusMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TopicsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Undo1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Cut1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Copy1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Paste1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Del1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAll1MenuItem;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

