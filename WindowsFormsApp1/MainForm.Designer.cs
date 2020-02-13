namespace RijndaelEncryption
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_brofiles = new System.Windows.Forms.Button();
            this.tbx_path = new System.Windows.Forms.TextBox();
            this.lbl_path = new System.Windows.Forms.Label();
            this.btn_ect = new System.Windows.Forms.Button();
            this.btn_dct = new System.Windows.Forms.Button();
            this.lbl_key = new System.Windows.Forms.Label();
            this.tbx_key = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_brofiles
            // 
            resources.ApplyResources(this.btn_brofiles, "btn_brofiles");
            this.btn_brofiles.Name = "btn_brofiles";
            this.btn_brofiles.UseVisualStyleBackColor = true;
            this.btn_brofiles.Click += new System.EventHandler(this.Btn_brofiles_Click);
            // 
            // tbx_path
            // 
            resources.ApplyResources(this.tbx_path, "tbx_path");
            this.tbx_path.Name = "tbx_path";
            // 
            // lbl_path
            // 
            resources.ApplyResources(this.lbl_path, "lbl_path");
            this.lbl_path.Name = "lbl_path";
            // 
            // btn_ect
            // 
            resources.ApplyResources(this.btn_ect, "btn_ect");
            this.btn_ect.Name = "btn_ect";
            this.btn_ect.UseVisualStyleBackColor = true;
            this.btn_ect.Click += new System.EventHandler(this.Btn_ect_Click);
            // 
            // btn_dct
            // 
            resources.ApplyResources(this.btn_dct, "btn_dct");
            this.btn_dct.Name = "btn_dct";
            this.btn_dct.UseVisualStyleBackColor = true;
            this.btn_dct.Click += new System.EventHandler(this.Btn_dct_Click);
            // 
            // lbl_key
            // 
            resources.ApplyResources(this.lbl_key, "lbl_key");
            this.lbl_key.Name = "lbl_key";
            // 
            // tbx_key
            // 
            resources.ApplyResources(this.tbx_key, "tbx_key");
            this.tbx_key.Name = "tbx_key";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbx_key);
            this.Controls.Add(this.lbl_key);
            this.Controls.Add(this.btn_dct);
            this.Controls.Add(this.btn_ect);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.tbx_path);
            this.Controls.Add(this.btn_brofiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_brofiles;
        private System.Windows.Forms.TextBox tbx_path;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.Button btn_ect;
        private System.Windows.Forms.Button btn_dct;
        private System.Windows.Forms.Label lbl_key;
        private System.Windows.Forms.TextBox tbx_key;
    }
}

