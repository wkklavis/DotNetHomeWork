
namespace demo01
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
            this.draw = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lengTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.per1TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.per2TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.th1TextBox = new System.Windows.Forms.TextBox();
            this.th2TextBox = new System.Windows.Forms.TextBox();
            this.penListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // draw
            // 
            this.draw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.draw.Location = new System.Drawing.Point(777, 12);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(84, 30);
            this.draw.TabIndex = 0;
            this.draw.Text = "draw";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.53247F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.46753F));
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.nTextBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lengTextBox, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.per1TextBox, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.per2TextBox, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.th1TextBox, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.th2TextBox, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.penListBox, 1, 6);
            this.tableLayoutPanel.Location = new System.Drawing.Point(630, 99);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(231, 222);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "递归深度(n)";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(159, 3);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(69, 25);
            this.nTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "主干长度(leng)";
            // 
            // lengTextBox
            // 
            this.lengTextBox.Location = new System.Drawing.Point(159, 33);
            this.lengTextBox.Name = "lengTextBox";
            this.lengTextBox.Size = new System.Drawing.Size(69, 25);
            this.lengTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "右分支长度比(per1)";
            // 
            // per1TextBox
            // 
            this.per1TextBox.Location = new System.Drawing.Point(159, 63);
            this.per1TextBox.Name = "per1TextBox";
            this.per1TextBox.Size = new System.Drawing.Size(69, 25);
            this.per1TextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "左分支长度比(per2)";
            // 
            // per2TextBox
            // 
            this.per2TextBox.Location = new System.Drawing.Point(159, 93);
            this.per2TextBox.Name = "per2TextBox";
            this.per2TextBox.Size = new System.Drawing.Size(69, 25);
            this.per2TextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "右分支角度(th1)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "左分支角度(th2)";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "画笔颜色(pen)";
            // 
            // th1TextBox
            // 
            this.th1TextBox.Location = new System.Drawing.Point(159, 123);
            this.th1TextBox.Name = "th1TextBox";
            this.th1TextBox.Size = new System.Drawing.Size(69, 25);
            this.th1TextBox.TabIndex = 11;
            // 
            // th2TextBox
            // 
            this.th2TextBox.Location = new System.Drawing.Point(159, 153);
            this.th2TextBox.Name = "th2TextBox";
            this.th2TextBox.Size = new System.Drawing.Size(69, 25);
            this.th2TextBox.TabIndex = 12;
            // 
            // penListBox
            // 
            this.penListBox.FormattingEnabled = true;
            this.penListBox.ItemHeight = 15;
            this.penListBox.Items.AddRange(new object[] {
            "黑色",
            "红色",
            "蓝色"});
            this.penListBox.Location = new System.Drawing.Point(159, 183);
            this.penListBox.Name = "penListBox";
            this.penListBox.Size = new System.Drawing.Size(69, 34);
            this.penListBox.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 501);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.draw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lengTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox per1TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox per2TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox th1TextBox;
        private System.Windows.Forms.TextBox th2TextBox;
        private System.Windows.Forms.ListBox penListBox;
        private System.Windows.Forms.Panel panel1;
    }
}

