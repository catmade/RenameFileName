namespace RenameFileName
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoucePath = new System.Windows.Forms.TextBox();
            this.tbTargetPath = new System.Windows.Forms.TextBox();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.btnSelectTarget = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listProgress = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "需要被重名的文件所在的文件目录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "重命名后的文件保存的目录";
            // 
            // tbSoucePath
            // 
            this.tbSoucePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSoucePath.Location = new System.Drawing.Point(70, 57);
            this.tbSoucePath.Name = "tbSoucePath";
            this.tbSoucePath.Size = new System.Drawing.Size(471, 21);
            this.tbSoucePath.TabIndex = 2;
            // 
            // tbTargetPath
            // 
            this.tbTargetPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTargetPath.Location = new System.Drawing.Point(70, 122);
            this.tbTargetPath.Name = "tbTargetPath";
            this.tbTargetPath.Size = new System.Drawing.Size(471, 21);
            this.tbTargetPath.TabIndex = 3;
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectSource.Location = new System.Drawing.Point(547, 55);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(52, 23);
            this.btnSelectSource.TabIndex = 4;
            this.btnSelectSource.Text = "选择";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            this.btnSelectSource.Click += new System.EventHandler(this.BtnSelectSource_Click);
            // 
            // btnSelectTarget
            // 
            this.btnSelectTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectTarget.Location = new System.Drawing.Point(547, 120);
            this.btnSelectTarget.Name = "btnSelectTarget";
            this.btnSelectTarget.Size = new System.Drawing.Size(52, 23);
            this.btnSelectTarget.TabIndex = 4;
            this.btnSelectTarget.Text = "选择";
            this.btnSelectTarget.UseVisualStyleBackColor = true;
            this.btnSelectTarget.Click += new System.EventHandler(this.BtnSelectTarget_Click);
            // 
            // btnAction
            // 
            this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAction.Location = new System.Drawing.Point(525, 322);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(74, 45);
            this.btnAction.TabIndex = 5;
            this.btnAction.Text = "开始重命名";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // listProgress
            // 
            this.listProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProgress.FormattingEnabled = true;
            this.listProgress.ItemHeight = 12;
            this.listProgress.Location = new System.Drawing.Point(70, 171);
            this.listProgress.Name = "listProgress";
            this.listProgress.Size = new System.Drawing.Size(449, 196);
            this.listProgress.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("黑体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(47, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(494, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "注意：如果上述两个目录选择的是同一个目录的话，被重命名的文件会被新的覆盖掉，从而达到重命名的效果\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 421);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listProgress);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.btnSelectTarget);
            this.Controls.Add(this.btnSelectSource);
            this.Controls.Add(this.tbTargetPath);
            this.Controls.Add(this.tbSoucePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "文件批量重命名工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoucePath;
        private System.Windows.Forms.TextBox tbTargetPath;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.Button btnSelectTarget;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listProgress;
        private System.Windows.Forms.Label label3;
    }
}

