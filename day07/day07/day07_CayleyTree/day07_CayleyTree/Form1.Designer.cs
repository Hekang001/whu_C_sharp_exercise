namespace day07_CayleyTree
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TreeTh2 = new System.Windows.Forms.Label();
            this.TreeTh1 = new System.Windows.Forms.Label();
            this.TreePer2 = new System.Windows.Forms.Label();
            this.TreePer1 = new System.Windows.Forms.Label();
            this.TreeLength = new System.Windows.Forms.Label();
            this.deep = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.trackBar_length = new System.Windows.Forms.TrackBar();
            this.trackBar_deep = new System.Windows.Forms.TrackBar();
            this.trackBar_Per1 = new System.Windows.Forms.TrackBar();
            this.trackBar_Per2 = new System.Windows.Forms.TrackBar();
            this.trackBar_Th1 = new System.Windows.Forms.TrackBar();
            this.trackBar_Th2 = new System.Windows.Forms.TrackBar();
            this.TreePen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_deep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Per1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Per2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Th1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Th2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_draw);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.trackBar_Th2);
            this.panel.Controls.Add(this.trackBar_Th1);
            this.panel.Controls.Add(this.trackBar_Per2);
            this.panel.Controls.Add(this.trackBar_Per1);
            this.panel.Controls.Add(this.trackBar_deep);
            this.panel.Controls.Add(this.trackBar_length);
            this.panel.Controls.Add(this.TreePen);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.TreeTh2);
            this.panel.Controls.Add(this.TreeTh1);
            this.panel.Controls.Add(this.TreePer2);
            this.panel.Controls.Add(this.TreePer1);
            this.panel.Controls.Add(this.TreeLength);
            this.panel.Controls.Add(this.deep);
            this.panel.Controls.Add(this.button1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Location = new System.Drawing.Point(587, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(282, 571);
            this.panel.TabIndex = 1;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "setting";
            // 
            // TreeTh2
            // 
            this.TreeTh2.AutoSize = true;
            this.TreeTh2.Location = new System.Drawing.Point(16, 276);
            this.TreeTh2.Name = "TreeTh2";
            this.TreeTh2.Size = new System.Drawing.Size(82, 15);
            this.TreeTh2.TabIndex = 10;
            this.TreeTh2.Text = "右分支角度";
            // 
            // TreeTh1
            // 
            this.TreeTh1.AutoSize = true;
            this.TreeTh1.Location = new System.Drawing.Point(16, 235);
            this.TreeTh1.Name = "TreeTh1";
            this.TreeTh1.Size = new System.Drawing.Size(82, 15);
            this.TreeTh1.TabIndex = 9;
            this.TreeTh1.Text = "左分支角度";
            this.TreeTh1.Click += new System.EventHandler(this.label5_Click);
            // 
            // TreePer2
            // 
            this.TreePer2.AutoSize = true;
            this.TreePer2.Location = new System.Drawing.Point(3, 185);
            this.TreePer2.Name = "TreePer2";
            this.TreePer2.Size = new System.Drawing.Size(97, 15);
            this.TreePer2.TabIndex = 8;
            this.TreePer2.Text = "右分支长度比";
            // 
            // TreePer1
            // 
            this.TreePer1.AutoSize = true;
            this.TreePer1.Location = new System.Drawing.Point(3, 135);
            this.TreePer1.Name = "TreePer1";
            this.TreePer1.Size = new System.Drawing.Size(97, 15);
            this.TreePer1.TabIndex = 7;
            this.TreePer1.Text = "左分支长度比";
            // 
            // TreeLength
            // 
            this.TreeLength.AutoSize = true;
            this.TreeLength.Location = new System.Drawing.Point(19, 88);
            this.TreeLength.Name = "TreeLength";
            this.TreeLength.Size = new System.Drawing.Size(67, 15);
            this.TreeLength.TabIndex = 6;
            this.TreeLength.Text = "主干长度";
            // 
            // deep
            // 
            this.deep.AutoSize = true;
            this.deep.Location = new System.Drawing.Point(19, 39);
            this.deep.Name = "deep";
            this.deep.Size = new System.Drawing.Size(67, 15);
            this.deep.TabIndex = 5;
            this.deep.Text = "递归深度";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // trackBar_length
            // 
            this.trackBar_length.Location = new System.Drawing.Point(156, 88);
            this.trackBar_length.Maximum = 200;
            this.trackBar_length.Name = "trackBar_length";
            this.trackBar_length.Size = new System.Drawing.Size(104, 56);
            this.trackBar_length.TabIndex = 16;
            this.trackBar_length.Scroll += new System.EventHandler(this.trackBar_length_Scroll);
            // 
            // trackBar_deep
            // 
            this.trackBar_deep.Location = new System.Drawing.Point(156, 39);
            this.trackBar_deep.Maximum = 20;
            this.trackBar_deep.Name = "trackBar_deep";
            this.trackBar_deep.Size = new System.Drawing.Size(104, 56);
            this.trackBar_deep.TabIndex = 17;
            this.trackBar_deep.Scroll += new System.EventHandler(this.trackBar_deep_Scroll);
            // 
            // trackBar_Per1
            // 
            this.trackBar_Per1.Location = new System.Drawing.Point(156, 135);
            this.trackBar_Per1.Maximum = 100;
            this.trackBar_Per1.Name = "trackBar_Per1";
            this.trackBar_Per1.Size = new System.Drawing.Size(104, 56);
            this.trackBar_Per1.TabIndex = 18;
            this.trackBar_Per1.Scroll += new System.EventHandler(this.trackBar_Per1_Scroll);
            // 
            // trackBar_Per2
            // 
            this.trackBar_Per2.Location = new System.Drawing.Point(156, 185);
            this.trackBar_Per2.Maximum = 100;
            this.trackBar_Per2.Name = "trackBar_Per2";
            this.trackBar_Per2.Size = new System.Drawing.Size(104, 56);
            this.trackBar_Per2.TabIndex = 20;
            this.trackBar_Per2.Scroll += new System.EventHandler(this.trackBar_Per2_Scroll);
            // 
            // trackBar_Th1
            // 
            this.trackBar_Th1.Location = new System.Drawing.Point(156, 226);
            this.trackBar_Th1.Maximum = 100;
            this.trackBar_Th1.Name = "trackBar_Th1";
            this.trackBar_Th1.Size = new System.Drawing.Size(104, 56);
            this.trackBar_Th1.TabIndex = 21;
            this.trackBar_Th1.Scroll += new System.EventHandler(this.trackBar_Th1_Scroll);
            // 
            // trackBar_Th2
            // 
            this.trackBar_Th2.Location = new System.Drawing.Point(156, 276);
            this.trackBar_Th2.Maximum = 100;
            this.trackBar_Th2.Name = "trackBar_Th2";
            this.trackBar_Th2.Size = new System.Drawing.Size(104, 56);
            this.trackBar_Th2.TabIndex = 22;
            this.trackBar_Th2.Scroll += new System.EventHandler(this.trackBar_Th2_Scroll);
            // 
            // TreePen
            // 
            this.TreePen.AutoSize = true;
            this.TreePen.Location = new System.Drawing.Point(19, 330);
            this.TreePen.Name = "TreePen";
            this.TreePen.Size = new System.Drawing.Size(67, 15);
            this.TreePen.TabIndex = 15;
            this.TreePen.Text = "画笔颜色";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "默认";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 571);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_deep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Per1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Per2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Th1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Th2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label TreeTh2;
        private System.Windows.Forms.Label TreeTh1;
        private System.Windows.Forms.Label TreePer2;
        private System.Windows.Forms.Label TreePer1;
        private System.Windows.Forms.Label TreeLength;
        private System.Windows.Forms.Label deep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_Th2;
        private System.Windows.Forms.TrackBar trackBar_Th1;
        private System.Windows.Forms.TrackBar trackBar_Per2;
        private System.Windows.Forms.TrackBar trackBar_Per1;
        private System.Windows.Forms.TrackBar trackBar_deep;
        private System.Windows.Forms.TrackBar trackBar_length;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TreePen;
    }
}

