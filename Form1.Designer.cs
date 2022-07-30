namespace testforpower
{
    partial class Form
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
            this.Title = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.result = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("微软雅黑 Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(622, 45);
            this.Title.TabIndex = 0;
            this.Title.Text = title;
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start.Location = new System.Drawing.Point(12, 70);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(602, 35);
            this.Start.TabIndex = 0;
            this.Start.Text = StartButtonText;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 111);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(602, 25);
            this.progressBar1.TabIndex = 2;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.Control;
            this.result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.result.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result.ForeColor = System.Drawing.Color.Gold;
            this.result.Location = new System.Drawing.Point(0, 148);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(622, 36);
            this.result.TabIndex = 3;
            this.result.Text = ResultText2;
            this.result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "English",
            "中文（简体）",
            "中文（繁體）",
            "日本語"});
            this.comboBox1.Location = new System.Drawing.Point(501, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = language;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 184);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = title;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

