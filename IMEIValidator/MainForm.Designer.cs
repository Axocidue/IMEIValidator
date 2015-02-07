namespace IMEIValidator
{
    partial class MainForm
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
            this.tbx_IMEI = new System.Windows.Forms.TextBox();
            this.lbl_Input = new System.Windows.Forms.Label();
            this.btn_Verify = new System.Windows.Forms.Button();
            this.tbx_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbx_IMEI
            // 
            this.tbx_IMEI.Font = new System.Drawing.Font("Tahoma", 16F);
            this.tbx_IMEI.Location = new System.Drawing.Point(42, 79);
            this.tbx_IMEI.Name = "tbx_IMEI";
            this.tbx_IMEI.Size = new System.Drawing.Size(415, 33);
            this.tbx_IMEI.TabIndex = 1;
            this.tbx_IMEI.Text = "357409051313384";
            // 
            // lbl_Input
            // 
            this.lbl_Input.AutoSize = true;
            this.lbl_Input.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbl_Input.Location = new System.Drawing.Point(37, 29);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(270, 27);
            this.lbl_Input.TabIndex = 0;
            this.lbl_Input.Text = "Input the IMEI to validate:";
            // 
            // btn_Verify
            // 
            this.btn_Verify.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btn_Verify.Location = new System.Drawing.Point(477, 78);
            this.btn_Verify.Name = "btn_Verify";
            this.btn_Verify.Size = new System.Drawing.Size(110, 33);
            this.btn_Verify.TabIndex = 2;
            this.btn_Verify.Text = "&Validate";
            this.btn_Verify.UseVisualStyleBackColor = true;
            this.btn_Verify.Click += new System.EventHandler(this.btn_Verify_Click);
            // 
            // tbx_Result
            // 
            this.tbx_Result.Enabled = false;
            this.tbx_Result.Font = new System.Drawing.Font("Tahoma", 16F);
            this.tbx_Result.Location = new System.Drawing.Point(42, 136);
            this.tbx_Result.Multiline = true;
            this.tbx_Result.Name = "tbx_Result";
            this.tbx_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Result.Size = new System.Drawing.Size(545, 194);
            this.tbx_Result.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(624, 362);
            this.Controls.Add(this.tbx_Result);
            this.Controls.Add(this.btn_Verify);
            this.Controls.Add(this.lbl_Input);
            this.Controls.Add(this.tbx_IMEI);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMEI Validator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_IMEI;
        private System.Windows.Forms.Label lbl_Input;
        private System.Windows.Forms.Button btn_Verify;
        private System.Windows.Forms.TextBox tbx_Result;
    }
}

