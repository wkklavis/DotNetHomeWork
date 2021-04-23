
namespace Demo
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.urlListView = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exceptionListView = new System.Windows.Forms.ListView();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.crawlerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 79);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1001, 500);
            this.splitContainer1.SplitterDistance = 758;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.urlListView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已经爬取URL";
            // 
            // urlListView
            // 
            this.urlListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlListView.Font = new System.Drawing.Font("仿宋", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.urlListView.HideSelection = false;
            this.urlListView.Location = new System.Drawing.Point(3, 21);
            this.urlListView.Name = "urlListView";
            this.urlListView.Size = new System.Drawing.Size(752, 476);
            this.urlListView.TabIndex = 0;
            this.urlListView.TileSize = new System.Drawing.Size(400, 45);
            this.urlListView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exceptionListView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 500);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "错误URL信息";
            // 
            // exceptionListView
            // 
            this.exceptionListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exceptionListView.HideSelection = false;
            this.exceptionListView.Location = new System.Drawing.Point(3, 21);
            this.exceptionListView.Name = "exceptionListView";
            this.exceptionListView.Size = new System.Drawing.Size(233, 476);
            this.exceptionListView.TabIndex = 0;
            this.exceptionListView.UseCompatibleStateImageBehavior = false;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(12, 12);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(370, 25);
            this.urlTextBox.TabIndex = 2;
            // 
            // crawlerButton
            // 
            this.crawlerButton.Location = new System.Drawing.Point(388, 14);
            this.crawlerButton.Name = "crawlerButton";
            this.crawlerButton.Size = new System.Drawing.Size(75, 23);
            this.crawlerButton.TabIndex = 3;
            this.crawlerButton.Text = "爬取";
            this.crawlerButton.UseVisualStyleBackColor = true;
            this.crawlerButton.Click += new System.EventHandler(this.crawlerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 579);
            this.Controls.Add(this.crawlerButton);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button crawlerButton;
        private System.Windows.Forms.ListView urlListView;
        private System.Windows.Forms.ListView exceptionListView;
    }
}

