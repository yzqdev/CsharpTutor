namespace Utils
{
    partial class MousePosition
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
            this.labelmouseposition = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelwindowposition = new System.Windows.Forms.Label();
            this.labelwindowsize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelmouseposition
            // 
            this.labelmouseposition.AutoSize = true;
            this.labelmouseposition.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelmouseposition.Location = new System.Drawing.Point(67, 67);
            this.labelmouseposition.Name = "labelmouseposition";
            this.labelmouseposition.Size = new System.Drawing.Size(92, 27);
            this.labelmouseposition.TabIndex = 0;
            this.labelmouseposition.Text = "鼠标位置";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelwindowposition
            // 
            this.labelwindowposition.AutoSize = true;
            this.labelwindowposition.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelwindowposition.Location = new System.Drawing.Point(67, 107);
            this.labelwindowposition.Name = "labelwindowposition";
            this.labelwindowposition.Size = new System.Drawing.Size(92, 27);
            this.labelwindowposition.TabIndex = 0;
            this.labelwindowposition.Text = "窗口位置";
            // 
            // labelwindowsize
            // 
            this.labelwindowsize.AutoSize = true;
            this.labelwindowsize.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelwindowsize.Location = new System.Drawing.Point(67, 151);
            this.labelwindowsize.Name = "labelwindowsize";
            this.labelwindowsize.Size = new System.Drawing.Size(92, 27);
            this.labelwindowsize.TabIndex = 0;
            this.labelwindowsize.Text = "窗口大小";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(380, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "拖到此窗口获取文件路径";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "获取文件类型";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MousePosition
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelwindowsize);
            this.Controls.Add(this.labelwindowposition);
            this.Controls.Add(this.labelmouseposition);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MousePosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MousePosition";
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MousePosition_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmouseposition;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelwindowposition;
        private System.Windows.Forms.Label labelwindowsize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}