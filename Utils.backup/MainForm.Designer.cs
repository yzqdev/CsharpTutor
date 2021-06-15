namespace Utils
{
    partial class MainForm
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
            this.mouseposition = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.getfilestyle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "点我";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mouseposition
            // 
            this.mouseposition.Location = new System.Drawing.Point(207, 37);
            this.mouseposition.Name = "mouseposition";
            this.mouseposition.Size = new System.Drawing.Size(119, 54);
            this.mouseposition.TabIndex = 1;
            this.mouseposition.Text = "鼠标位置";
            this.mouseposition.UseVisualStyleBackColor = true;
            this.mouseposition.Click += new System.EventHandler(this.Mouseposition_Click);
            // 
            // getfilestyle
            // 
            this.getfilestyle.Location = new System.Drawing.Point(362, 37);
            this.getfilestyle.Name = "getfilestyle";
            this.getfilestyle.Size = new System.Drawing.Size(119, 54);
            this.getfilestyle.TabIndex = 1;
            this.getfilestyle.Text = "获取文件类型";
            this.getfilestyle.UseVisualStyleBackColor = true;
            this.getfilestyle.Click += new System.EventHandler(this.Getfilestyle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.getfilestyle);
            this.Controls.Add(this.mouseposition);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button mouseposition;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button getfilestyle;
    }
}

