namespace frmmain
{
    partial class Find
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
        	this.label1 = new System.Windows.Forms.Label();
        	this.Txtfind = new System.Windows.Forms.TextBox();
        	this.checkCase = new System.Windows.Forms.CheckBox();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.radioDown = new System.Windows.Forms.RadioButton();
        	this.radioUp = new System.Windows.Forms.RadioButton();
        	this.btnNext = new System.Windows.Forms.Button();
        	this.btnCancel = new System.Windows.Forms.Button();
        	this.groupBox1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.label1.Location = new System.Drawing.Point(16, 24);
        	this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(95, 20);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "查找内容(&N):";
        	// 
        	// Txtfind
        	// 
        	this.Txtfind.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.Txtfind.Location = new System.Drawing.Point(127, 20);
        	this.Txtfind.Margin = new System.Windows.Forms.Padding(4);
        	this.Txtfind.Name = "Txtfind";
        	this.Txtfind.Size = new System.Drawing.Size(237, 27);
        	this.Txtfind.TabIndex = 0;
        	this.Txtfind.TextChanged += new System.EventHandler(this.Txtfind_TextChanged);
        	// 
        	// checkCase
        	// 
        	this.checkCase.AutoSize = true;
        	this.checkCase.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.checkCase.Location = new System.Drawing.Point(19, 81);
        	this.checkCase.Margin = new System.Windows.Forms.Padding(4);
        	this.checkCase.Name = "checkCase";
        	this.checkCase.Size = new System.Drawing.Size(126, 24);
        	this.checkCase.TabIndex = 1;
        	this.checkCase.Text = "区分大小写(&C)";
        	this.checkCase.UseVisualStyleBackColor = true;
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.radioDown);
        	this.groupBox1.Controls.Add(this.radioUp);
        	this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.groupBox1.Location = new System.Drawing.Point(163, 56);
        	this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
        	this.groupBox1.Size = new System.Drawing.Size(203, 64);
        	this.groupBox1.TabIndex = 3;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "方向";
        	// 
        	// radioDown
        	// 
        	this.radioDown.AutoSize = true;
        	this.radioDown.Checked = true;
        	this.radioDown.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.radioDown.Location = new System.Drawing.Point(108, 24);
        	this.radioDown.Margin = new System.Windows.Forms.Padding(4);
        	this.radioDown.Name = "radioDown";
        	this.radioDown.Size = new System.Drawing.Size(81, 24);
        	this.radioDown.TabIndex = 1;
        	this.radioDown.TabStop = true;
        	this.radioDown.Text = "向下(&D)";
        	this.radioDown.UseVisualStyleBackColor = true;
        	// 
        	// radioUp
        	// 
        	this.radioUp.AutoSize = true;
        	this.radioUp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.radioUp.Location = new System.Drawing.Point(8, 24);
        	this.radioUp.Margin = new System.Windows.Forms.Padding(4);
        	this.radioUp.Name = "radioUp";
        	this.radioUp.Size = new System.Drawing.Size(81, 24);
        	this.radioUp.TabIndex = 0;
        	this.radioUp.Text = "向上(&U)";
        	this.radioUp.UseVisualStyleBackColor = true;
        	// 
        	// btnNext
        	// 
        	this.btnNext.Enabled = false;
        	this.btnNext.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.btnNext.Location = new System.Drawing.Point(389, 20);
        	this.btnNext.Margin = new System.Windows.Forms.Padding(4);
        	this.btnNext.Name = "btnNext";
        	this.btnNext.Size = new System.Drawing.Size(115, 31);
        	this.btnNext.TabIndex = 2;
        	this.btnNext.Text = "查找下一个";
        	this.btnNext.UseVisualStyleBackColor = true;
        	this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
        	// 
        	// btnCancel
        	// 
        	this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.btnCancel.Location = new System.Drawing.Point(389, 71);
        	this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
        	this.btnCancel.Name = "btnCancel";
        	this.btnCancel.Size = new System.Drawing.Size(115, 31);
        	this.btnCancel.TabIndex = 3;
        	this.btnCancel.Text = "取消";
        	this.btnCancel.UseVisualStyleBackColor = true;
        	this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        	// 
        	// FrmFind
        	// 
        	this.AcceptButton = this.btnNext;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(516, 135);
        	this.Controls.Add(this.btnCancel);
        	this.Controls.Add(this.btnNext);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.checkCase);
        	this.Controls.Add(this.Txtfind);
        	this.Controls.Add(this.label1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.HelpButton = true;
        	this.Margin = new System.Windows.Forms.Padding(4);
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "FrmFind";
        	this.ShowIcon = false;
        	this.ShowInTaskbar = false;
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        	this.Text = "查找";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFind_FormClosing);
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtfind;
        private System.Windows.Forms.CheckBox checkCase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioDown;
        private System.Windows.Forms.RadioButton radioUp;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
    }
}