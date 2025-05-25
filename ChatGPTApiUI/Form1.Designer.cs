namespace ChatGPTApiUI {
    partial class frm_main {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeApiKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rchtxtbox_prompt = new System.Windows.Forms.RichTextBox();
            this.btn_prompt_send = new System.Windows.Forms.Button();
            this.rchtxtbox_response = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeApiKeyToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeApiKeyToolStripMenuItem
            // 
            this.changeApiKeyToolStripMenuItem.Name = "changeApiKeyToolStripMenuItem";
            this.changeApiKeyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeApiKeyToolStripMenuItem.Text = "Change ApiKey";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 443);
            this.panel1.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_name.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(849, 66);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "ChatGPT API Client";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchtxtbox_response);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(417, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 371);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Response";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_prompt_send);
            this.groupBox1.Controls.Add(this.rchtxtbox_prompt);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(3, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 371);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prompt";
            // 
            // rchtxtbox_prompt
            // 
            this.rchtxtbox_prompt.BackColor = System.Drawing.Color.LightGray;
            this.rchtxtbox_prompt.Dock = System.Windows.Forms.DockStyle.Top;
            this.rchtxtbox_prompt.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rchtxtbox_prompt.Location = new System.Drawing.Point(3, 22);
            this.rchtxtbox_prompt.Name = "rchtxtbox_prompt";
            this.rchtxtbox_prompt.Size = new System.Drawing.Size(402, 290);
            this.rchtxtbox_prompt.TabIndex = 0;
            this.rchtxtbox_prompt.Text = "";
            // 
            // btn_prompt_send
            // 
            this.btn_prompt_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_prompt_send.Location = new System.Drawing.Point(3, 312);
            this.btn_prompt_send.Name = "btn_prompt_send";
            this.btn_prompt_send.Size = new System.Drawing.Size(402, 56);
            this.btn_prompt_send.TabIndex = 1;
            this.btn_prompt_send.Text = "Send!";
            this.btn_prompt_send.UseVisualStyleBackColor = true;
            this.btn_prompt_send.Click += new System.EventHandler(this.btn_prompt_send_Click);
            // 
            // rchtxtbox_response
            // 
            this.rchtxtbox_response.BackColor = System.Drawing.Color.LightGray;
            this.rchtxtbox_response.Dock = System.Windows.Forms.DockStyle.Top;
            this.rchtxtbox_response.Location = new System.Drawing.Point(3, 22);
            this.rchtxtbox_response.Name = "rchtxtbox_response";
            this.rchtxtbox_response.ReadOnly = true;
            this.rchtxtbox_response.Size = new System.Drawing.Size(423, 290);
            this.rchtxtbox_response.TabIndex = 0;
            this.rchtxtbox_response.Text = "";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(849, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeApiKeyToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rchtxtbox_prompt;
        private System.Windows.Forms.Button btn_prompt_send;
        private System.Windows.Forms.RichTextBox rchtxtbox_response;
    }
}

