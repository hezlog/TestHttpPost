namespace TestHttpPost
{
	partial class FrmTestHttpPost
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
            this.pnlTool = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cboContentType = new System.Windows.Forms.ComboBox();
            this.lblContentType = new System.Windows.Forms.Label();
            this.cboResEncoding = new System.Windows.Forms.ComboBox();
            this.lblResEncoding = new System.Windows.Forms.Label();
            this.lblPostData = new System.Windows.Forms.Label();
            this.txtPostData = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTool
            // 
            this.pnlTool.Controls.Add(this.label1);
            this.pnlTool.Controls.Add(this.numericUpDown1);
            this.pnlTool.Controls.Add(this.checkBox1);
            this.pnlTool.Controls.Add(this.cboContentType);
            this.pnlTool.Controls.Add(this.lblContentType);
            this.pnlTool.Controls.Add(this.cboResEncoding);
            this.pnlTool.Controls.Add(this.lblResEncoding);
            this.pnlTool.Controls.Add(this.lblPostData);
            this.pnlTool.Controls.Add(this.txtPostData);
            this.pnlTool.Controls.Add(this.btnGo);
            this.pnlTool.Controls.Add(this.txtUrl);
            this.pnlTool.Controls.Add(this.cboMode);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(1100, 211);
            this.pnlTool.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(850, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Delays:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(919, 39);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 25);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(752, 42);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "MuitLine";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cboContentType
            // 
            this.cboContentType.DropDownHeight = 400;
            this.cboContentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContentType.FormattingEnabled = true;
            this.cboContentType.IntegralHeight = false;
            this.cboContentType.Items.AddRange(new object[] {
            "application/json",
            "application/hal+json",
            "application/xml",
            "application/x-www-form-urlencoded",
            "text/html",
            "text/plain"});
            this.cboContentType.Location = new System.Drawing.Point(114, 40);
            this.cboContentType.Margin = new System.Windows.Forms.Padding(4);
            this.cboContentType.Name = "cboContentType";
            this.cboContentType.Size = new System.Drawing.Size(253, 23);
            this.cboContentType.TabIndex = 8;
            // 
            // lblContentType
            // 
            this.lblContentType.AutoSize = true;
            this.lblContentType.Location = new System.Drawing.Point(2, 44);
            this.lblContentType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContentType.Name = "lblContentType";
            this.lblContentType.Size = new System.Drawing.Size(111, 15);
            this.lblContentType.TabIndex = 7;
            this.lblContentType.Text = "Content Type:";
            // 
            // cboResEncoding
            // 
            this.cboResEncoding.DropDownHeight = 400;
            this.cboResEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResEncoding.FormattingEnabled = true;
            this.cboResEncoding.IntegralHeight = false;
            this.cboResEncoding.Location = new System.Drawing.Point(525, 40);
            this.cboResEncoding.Margin = new System.Windows.Forms.Padding(4);
            this.cboResEncoding.Name = "cboResEncoding";
            this.cboResEncoding.Size = new System.Drawing.Size(212, 23);
            this.cboResEncoding.TabIndex = 6;
            this.cboResEncoding.SelectedIndexChanged += new System.EventHandler(this.cboResEncoding_SelectedIndexChanged);
            // 
            // lblResEncoding
            // 
            this.lblResEncoding.AutoSize = true;
            this.lblResEncoding.Location = new System.Drawing.Point(371, 44);
            this.lblResEncoding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResEncoding.Name = "lblResEncoding";
            this.lblResEncoding.Size = new System.Drawing.Size(151, 15);
            this.lblResEncoding.TabIndex = 5;
            this.lblResEncoding.Text = "Response Encoding:";
            // 
            // lblPostData
            // 
            this.lblPostData.AutoSize = true;
            this.lblPostData.Location = new System.Drawing.Point(26, 74);
            this.lblPostData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostData.Name = "lblPostData";
            this.lblPostData.Size = new System.Drawing.Size(87, 15);
            this.lblPostData.TabIndex = 4;
            this.lblPostData.Text = "Post Data:";
            // 
            // txtPostData
            // 
            this.txtPostData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPostData.Location = new System.Drawing.Point(115, 71);
            this.txtPostData.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostData.Multiline = true;
            this.txtPostData.Name = "txtPostData";
            this.txtPostData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPostData.Size = new System.Drawing.Size(984, 136);
            this.txtPostData.TabIndex = 3;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(1015, 0);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(85, 29);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(115, 2);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(891, 25);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "http://localhost/";
            // 
            // cboMode
            // 
            this.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMode.FormattingEnabled = true;
            this.cboMode.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.cboMode.Location = new System.Drawing.Point(4, 2);
            this.cboMode.Margin = new System.Windows.Forms.Padding(4);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(105, 23);
            this.cboMode.TabIndex = 0;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(5, 43);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(1091, 489);
            this.txtLog.TabIndex = 1;
            this.txtLog.WordWrap = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(1015, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 22);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.Location = new System.Drawing.Point(900, 16);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(109, 19);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "log header";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlTool);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnClear);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox2);
            this.splitContainer1.Panel2.Controls.Add(this.txtLog);
            this.splitContainer1.Size = new System.Drawing.Size(1102, 752);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 4;
            // 
            // FrmTestHttpPost
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1102, 752);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(794, 490);
            this.Name = "FrmTestHttpPost";
            this.Text = "TestHttpPost(测试Http的POST方法)";
            this.Load += new System.EventHandler(this.FrmTestHttpPost_Load);
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTool;
		private System.Windows.Forms.ComboBox cboMode;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.TextBox txtPostData;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.Label lblPostData;
		private System.Windows.Forms.Label lblResEncoding;
		private System.Windows.Forms.ComboBox cboResEncoding;
        private System.Windows.Forms.ComboBox cboContentType;
        private System.Windows.Forms.Label lblContentType;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

