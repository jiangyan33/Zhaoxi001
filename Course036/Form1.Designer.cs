﻿
namespace Course036
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
            this.btnSync = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.btnAsyncAd = new System.Windows.Forms.Button();
            this.btnThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(71, 45);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(176, 77);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "同步方法";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(71, 165);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(176, 77);
            this.btnAsync.TabIndex = 1;
            this.btnAsync.Text = "异步方法";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // btnAsyncAd
            // 
            this.btnAsyncAd.Location = new System.Drawing.Point(71, 294);
            this.btnAsyncAd.Name = "btnAsyncAd";
            this.btnAsyncAd.Size = new System.Drawing.Size(176, 77);
            this.btnAsyncAd.TabIndex = 2;
            this.btnAsyncAd.Text = "Async异步方法";
            this.btnAsyncAd.UseVisualStyleBackColor = true;
            this.btnAsyncAd.Click += new System.EventHandler(this.btnAsyncAd_Click);
            // 
            // btnThread
            // 
            this.btnThread.Location = new System.Drawing.Point(71, 411);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(176, 77);
            this.btnThread.TabIndex = 3;
            this.btnThread.Text = "Thread";
            this.btnThread.UseVisualStyleBackColor = true;
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 552);
            this.Controls.Add(this.btnThread);
            this.Controls.Add(this.btnAsyncAd);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnSync);
            this.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Button btnAsyncAd;
        private System.Windows.Forms.Button btnThread;
    }
}

