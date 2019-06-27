namespace BinaryTool
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtBinary = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBinary2String = new System.Windows.Forms.Button();
            this.btnString2Binary = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtString = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBinary
            // 
            this.txtBinary.Location = new System.Drawing.Point(14, 24);
            this.txtBinary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.Size = new System.Drawing.Size(435, 459);
            this.txtBinary.TabIndex = 0;
            this.txtBinary.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBinary);
            this.groupBox1.Location = new System.Drawing.Point(14, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(462, 507);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入二进制字符串";
            // 
            // btnBinary2String
            // 
            this.btnBinary2String.Location = new System.Drawing.Point(505, 183);
            this.btnBinary2String.Name = "btnBinary2String";
            this.btnBinary2String.Size = new System.Drawing.Size(92, 30);
            this.btnBinary2String.TabIndex = 2;
            this.btnBinary2String.Text = "转字符>>";
            this.btnBinary2String.UseVisualStyleBackColor = true;
            this.btnBinary2String.Click += new System.EventHandler(this.btnBinary2String_Click);
            // 
            // btnString2Binary
            // 
            this.btnString2Binary.Location = new System.Drawing.Point(505, 253);
            this.btnString2Binary.Name = "btnString2Binary";
            this.btnString2Binary.Size = new System.Drawing.Size(92, 30);
            this.btnString2Binary.TabIndex = 3;
            this.btnString2Binary.Text = "<<转二进制";
            this.btnString2Binary.UseVisualStyleBackColor = true;
            this.btnString2Binary.Click += new System.EventHandler(this.btnString2Binary_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtString);
            this.groupBox2.Location = new System.Drawing.Point(624, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(462, 507);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输入字符串";
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(21, 24);
            this.txtString.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(435, 459);
            this.txtString.TabIndex = 0;
            this.txtString.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(505, 324);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 30);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 544);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnString2Binary);
            this.Controls.Add(this.btnBinary2String);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "转换工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBinary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBinary2String;
        private System.Windows.Forms.Button btnString2Binary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtString;
        private System.Windows.Forms.Button btnClear;
    }
}

