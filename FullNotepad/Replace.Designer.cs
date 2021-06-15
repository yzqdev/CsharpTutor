namespace frmmain
{
    partial class Replace
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replace));
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.txtSearch = new System.Windows.Forms.TextBox();
        	this.txtReplace = new System.Windows.Forms.TextBox();
        	this.checkCase = new System.Windows.Forms.CheckBox();
        	this.btnSearch = new System.Windows.Forms.Button();
        	this.btnReplace = new System.Windows.Forms.Button();
        	this.btnCancel = new System.Windows.Forms.Button();
        	this.btnReplaceAll = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.label1.Location = new System.Drawing.Point(16, 29);
        	this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(95, 20);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "查找内容(&N):";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.label2.Location = new System.Drawing.Point(16, 72);
        	this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(77, 20);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "替換为(&P):";
        	// 
        	// txtSearch
        	// 
        	this.txtSearch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.txtSearch.Location = new System.Drawing.Point(127, 25);
        	this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
        	this.txtSearch.Name = "txtSearch";
        	this.txtSearch.Size = new System.Drawing.Size(220, 27);
        	this.txtSearch.TabIndex = 2;
        	// 
        	// txtReplace
        	// 
        	this.txtReplace.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.txtReplace.Location = new System.Drawing.Point(127, 72);
        	this.txtReplace.Margin = new System.Windows.Forms.Padding(4);
        	this.txtReplace.Name = "txtReplace";
        	this.txtReplace.Size = new System.Drawing.Size(220, 27);
        	this.txtReplace.TabIndex = 3;
        	// 
        	// checkCase
        	// 
        	this.checkCase.AutoSize = true;
        	this.checkCase.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.checkCase.Location = new System.Drawing.Point(19, 137);
        	this.checkCase.Margin = new System.Windows.Forms.Padding(4);
        	this.checkCase.Name = "checkCase";
        	this.checkCase.Size = new System.Drawing.Size(126, 24);
        	this.checkCase.TabIndex = 4;
        	this.checkCase.Text = "区别大小写(&C)";
        	this.checkCase.UseVisualStyleBackColor = true;
        	// 
        	// btnSearch
        	// 
        	this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.btnSearch.Location = new System.Drawing.Point(375, 16);
        	this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
        	this.btnSearch.Name = "btnSearch";
        	this.btnSearch.Size = new System.Drawing.Size(100, 31);
        	this.btnSearch.TabIndex = 5;
        	this.btnSearch.Text = "查找下一个(&F)";
        	this.btnSearch.UseVisualStyleBackColor = true;
        	this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
        	// 
        	// btnReplace
        	// 
        	this.btnReplace.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.btnReplace.Location = new System.Drawing.Point(375, 53);
        	this.btnReplace.Margin = new System.Windows.Forms.Padding(4);
        	this.btnReplace.Name = "btnReplace";
        	this.btnReplace.Size = new System.Drawing.Size(100, 31);
        	this.btnReplace.TabIndex = 6;
        	this.btnReplace.Text = "替换(&R)";
        	this.btnReplace.UseVisualStyleBackColor = true;
        	this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
        	// 
        	// btnCancel
        	// 
        	this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.btnCancel.Location = new System.Drawing.Point(375, 128);
        	this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
        	this.btnCancel.Name = "btnCancel";
        	this.btnCancel.Size = new System.Drawing.Size(100, 31);
        	this.btnCancel.TabIndex = 7;
        	this.btnCancel.Text = "取消";
        	this.btnCancel.UseVisualStyleBackColor = true;
        	this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        	// 
        	// btnReplaceAll
        	// 
        	this.btnReplaceAll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.btnReplaceAll.Location = new System.Drawing.Point(375, 91);
        	this.btnReplaceAll.Margin = new System.Windows.Forms.Padding(4);
        	this.btnReplaceAll.Name = "btnReplaceAll";
        	this.btnReplaceAll.Size = new System.Drawing.Size(100, 31);
        	this.btnReplaceAll.TabIndex = 8;
        	this.btnReplaceAll.Text = "全部替换(&A)";
        	this.btnReplaceAll.UseVisualStyleBackColor = true;
        	this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
        	// 
        	// frmreplace
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(504, 183);
        	this.Controls.Add(this.btnReplaceAll);
        	this.Controls.Add(this.btnCancel);
        	this.Controls.Add(this.btnReplace);
        	this.Controls.Add(this.btnSearch);
        	this.Controls.Add(this.checkCase);
        	this.Controls.Add(this.txtReplace);
        	this.Controls.Add(this.txtSearch);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.HelpButton = true;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Margin = new System.Windows.Forms.Padding(4);
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "frmreplace";
        	this.ShowIcon = false;
        	this.Text = "替换";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmreplace_FormClosing);
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.CheckBox checkCase;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReplaceAll;
    }
}