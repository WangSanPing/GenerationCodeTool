namespace GenerationCodeTool.View
{
    partial class TestWindow
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
            this.btnLoadGrid = new System.Windows.Forms.Button();
            this.loadColumn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGrid = new System.Windows.Forms.Button();
            this.btnPie = new System.Windows.Forms.Button();
            this.btnColumn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadGrid
            // 
            this.btnLoadGrid.Location = new System.Drawing.Point(12, 182);
            this.btnLoadGrid.Name = "btnLoadGrid";
            this.btnLoadGrid.Size = new System.Drawing.Size(75, 23);
            this.btnLoadGrid.TabIndex = 13;
            this.btnLoadGrid.Text = "读取列表";
            this.btnLoadGrid.UseVisualStyleBackColor = true;
            // 
            // loadColumn
            // 
            this.loadColumn.Location = new System.Drawing.Point(103, 182);
            this.loadColumn.Name = "loadColumn";
            this.loadColumn.Size = new System.Drawing.Size(75, 23);
            this.loadColumn.TabIndex = 12;
            this.loadColumn.Text = "读取柱状图";
            this.loadColumn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "读取饼状图";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnGrid
            // 
            this.btnGrid.Location = new System.Drawing.Point(12, 226);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(75, 23);
            this.btnGrid.TabIndex = 10;
            this.btnGrid.Text = "列表";
            this.btnGrid.UseVisualStyleBackColor = true;
            // 
            // btnPie
            // 
            this.btnPie.Location = new System.Drawing.Point(197, 226);
            this.btnPie.Name = "btnPie";
            this.btnPie.Size = new System.Drawing.Size(75, 23);
            this.btnPie.TabIndex = 9;
            this.btnPie.Text = "饼状图";
            this.btnPie.UseVisualStyleBackColor = true;
            // 
            // btnColumn
            // 
            this.btnColumn.Location = new System.Drawing.Point(103, 226);
            this.btnColumn.Name = "btnColumn";
            this.btnColumn.Size = new System.Drawing.Size(75, 23);
            this.btnColumn.TabIndex = 8;
            this.btnColumn.Text = "圆柱图";
            this.btnColumn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "测试连接";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLoadGrid);
            this.Controls.Add(this.loadColumn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGrid);
            this.Controls.Add(this.btnPie);
            this.Controls.Add(this.btnColumn);
            this.Controls.Add(this.button1);
            this.Name = "TestWindow";
            this.Text = "TestWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadGrid;
        private System.Windows.Forms.Button loadColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGrid;
        private System.Windows.Forms.Button btnPie;
        private System.Windows.Forms.Button btnColumn;
        private System.Windows.Forms.Button button1;
    }
}