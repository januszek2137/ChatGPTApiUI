namespace ChatGPTApiUI {
    partial class frm_apikey {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btn_apikey = new System.Windows.Forms.Button();
            this.txtbox_apikey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_apikey
            // 
            this.btn_apikey.Location = new System.Drawing.Point(12, 51);
            this.btn_apikey.Name = "btn_apikey";
            this.btn_apikey.Size = new System.Drawing.Size(417, 58);
            this.btn_apikey.TabIndex = 0;
            this.btn_apikey.Text = "Send!";
            this.btn_apikey.UseVisualStyleBackColor = true;
            this.btn_apikey.Click += new System.EventHandler(this.btn_apikey_Click);
            // 
            // txtbox_apikey
            // 
            this.txtbox_apikey.Location = new System.Drawing.Point(12, 25);
            this.txtbox_apikey.Name = "txtbox_apikey";
            this.txtbox_apikey.Size = new System.Drawing.Size(417, 20);
            this.txtbox_apikey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please input Your ChatGPT API key";
            // 
            // frm_apikey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 122);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_apikey);
            this.Controls.Add(this.btn_apikey);
            this.Name = "frm_apikey";
            this.Text = "frm_apikey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_apikey;
        private System.Windows.Forms.TextBox txtbox_apikey;
        private System.Windows.Forms.Label label1;
    }
}