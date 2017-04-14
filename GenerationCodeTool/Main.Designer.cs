namespace GenerationCodeTool
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.模块名 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrimaryPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "测试连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "读取Xml";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(101, 55);
            this.txtSave.Name = "txtSave";
            this.txtSave.ReadOnly = true;
            this.txtSave.Size = new System.Drawing.Size(358, 21);
            this.txtSave.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "保存路径：";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(465, 55);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPath.TabIndex = 10;
            this.btnSelectPath.Text = "浏览";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "选择XML：";
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(101, 16);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.ReadOnly = true;
            this.txtSelect.Size = new System.Drawing.Size(358, 21);
            this.txtSelect.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(465, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "浏览";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtModule
            // 
            this.txtModule.Location = new System.Drawing.Point(327, 86);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(132, 21);
            this.txtModule.TabIndex = 14;
            // 
            // 模块名
            // 
            this.模块名.AutoSize = true;
            this.模块名.Location = new System.Drawing.Point(30, 89);
            this.模块名.Name = "模块名";
            this.模块名.Size = new System.Drawing.Size(65, 12);
            this.模块名.TabIndex = 15;
            this.模块名.Text = "一级路径：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "模块名：";
            // 
            // txtPrimaryPath
            // 
            this.txtPrimaryPath.Location = new System.Drawing.Point(101, 86);
            this.txtPrimaryPath.Name = "txtPrimaryPath";
            this.txtPrimaryPath.Size = new System.Drawing.Size(132, 21);
            this.txtPrimaryPath.TabIndex = 16;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrimaryPath);
            this.Controls.Add(this.模块名);
            this.Controls.Add(this.txtModule);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.Label 模块名;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrimaryPath;
    }
}