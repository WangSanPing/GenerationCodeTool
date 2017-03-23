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
            this.btnColumn = new System.Windows.Forms.Button();
            this.btnPie = new System.Windows.Forms.Button();
            this.btnGrid = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.loadColumn = new System.Windows.Forms.Button();
            this.btnLoadGrid = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "测试连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnColumn
            // 
            this.btnColumn.Location = new System.Drawing.Point(101, 164);
            this.btnColumn.Name = "btnColumn";
            this.btnColumn.Size = new System.Drawing.Size(75, 23);
            this.btnColumn.TabIndex = 1;
            this.btnColumn.Text = "圆柱图";
            this.btnColumn.UseVisualStyleBackColor = true;
            this.btnColumn.Click += new System.EventHandler(this.btnColumn_Click);
            // 
            // btnPie
            // 
            this.btnPie.Location = new System.Drawing.Point(195, 164);
            this.btnPie.Name = "btnPie";
            this.btnPie.Size = new System.Drawing.Size(75, 23);
            this.btnPie.TabIndex = 2;
            this.btnPie.Text = "饼状图";
            this.btnPie.UseVisualStyleBackColor = true;
            this.btnPie.Click += new System.EventHandler(this.btnPie_Click);
            // 
            // btnGrid
            // 
            this.btnGrid.Location = new System.Drawing.Point(10, 164);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(75, 23);
            this.btnGrid.TabIndex = 3;
            this.btnGrid.Text = "列表";
            this.btnGrid.UseVisualStyleBackColor = true;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "读取饼状图";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loadColumn
            // 
            this.loadColumn.Location = new System.Drawing.Point(101, 220);
            this.loadColumn.Name = "loadColumn";
            this.loadColumn.Size = new System.Drawing.Size(75, 23);
            this.loadColumn.TabIndex = 5;
            this.loadColumn.Text = "读取柱状图";
            this.loadColumn.UseVisualStyleBackColor = true;
            this.loadColumn.Click += new System.EventHandler(this.loadColumn_Click);
            // 
            // btnLoadGrid
            // 
            this.btnLoadGrid.Location = new System.Drawing.Point(10, 220);
            this.btnLoadGrid.Name = "btnLoadGrid";
            this.btnLoadGrid.Size = new System.Drawing.Size(75, 23);
            this.btnLoadGrid.TabIndex = 6;
            this.btnLoadGrid.Text = "读取列表";
            this.btnLoadGrid.UseVisualStyleBackColor = true;
            this.btnLoadGrid.Click += new System.EventHandler(this.btnLoadGrid_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "读取Xml";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLoadGrid);
            this.Controls.Add(this.loadColumn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGrid);
            this.Controls.Add(this.btnPie);
            this.Controls.Add(this.btnColumn);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnColumn;
        private System.Windows.Forms.Button btnPie;
        private System.Windows.Forms.Button btnGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button loadColumn;
        private System.Windows.Forms.Button btnLoadGrid;
        private System.Windows.Forms.Button button3;
    }
}