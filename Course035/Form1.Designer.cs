
namespace Course035
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTask = new System.Windows.Forms.Button();
            this.btnTaskAdvanced = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(82, 57);
            this.btnTask.Margin = new System.Windows.Forms.Padding(7);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(174, 117);
            this.btnTask.TabIndex = 0;
            this.btnTask.Text = "Task";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnTaskAdvanced
            // 
            this.btnTaskAdvanced.Location = new System.Drawing.Point(82, 232);
            this.btnTaskAdvanced.Margin = new System.Windows.Forms.Padding(7);
            this.btnTaskAdvanced.Name = "btnTaskAdvanced";
            this.btnTaskAdvanced.Size = new System.Drawing.Size(174, 117);
            this.btnTaskAdvanced.TabIndex = 1;
            this.btnTaskAdvanced.Text = "TaskAdvanced";
            this.btnTaskAdvanced.UseVisualStyleBackColor = true;
            this.btnTaskAdvanced.Click += new System.EventHandler(this.btnTaskAdvanced_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 542);
            this.Controls.Add(this.btnTaskAdvanced);
            this.Controls.Add(this.btnTask);
            this.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnTaskAdvanced;
    }
}

