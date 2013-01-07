namespace OctopressManager
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.urlVal = new System.Windows.Forms.Label();
            this.titleVal = new System.Windows.Forms.Label();
            this.subtitleVal = new System.Windows.Forms.Label();
            this.authorVal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Octopress Folder";
            // 
            // urlVal
            // 
            this.urlVal.AutoSize = true;
            this.urlVal.Location = new System.Drawing.Point(59, 51);
            this.urlVal.Name = "urlVal";
            this.urlVal.Size = new System.Drawing.Size(93, 13);
            this.urlVal.TabIndex = 3;
            this.urlVal.Text = "No folder selected";
            // 
            // titleVal
            // 
            this.titleVal.AutoSize = true;
            this.titleVal.Location = new System.Drawing.Point(59, 74);
            this.titleVal.Name = "titleVal";
            this.titleVal.Size = new System.Drawing.Size(93, 13);
            this.titleVal.TabIndex = 3;
            this.titleVal.Text = "No folder selected";
            // 
            // subtitleVal
            // 
            this.subtitleVal.AutoSize = true;
            this.subtitleVal.Location = new System.Drawing.Point(59, 97);
            this.subtitleVal.Name = "subtitleVal";
            this.subtitleVal.Size = new System.Drawing.Size(93, 13);
            this.subtitleVal.TabIndex = 3;
            this.subtitleVal.Text = "No folder selected";
            // 
            // authorVal
            // 
            this.authorVal.AutoSize = true;
            this.authorVal.Location = new System.Drawing.Point(59, 120);
            this.authorVal.Name = "authorVal";
            this.authorVal.Size = new System.Drawing.Size(93, 13);
            this.authorVal.TabIndex = 3;
            this.authorVal.Text = "No folder selected";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "url";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "subtitle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "author";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 82);
            this.button2.TabIndex = 4;
            this.button2.Text = "OpenCMD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 82);
            this.button3.TabIndex = 4;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(522, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 82);
            this.button4.TabIndex = 4;
            this.button4.Text = "Deploy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(364, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 82);
            this.button5.TabIndex = 4;
            this.button5.Text = "Preview";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(341, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "New post name";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(452, 150);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Create";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 184);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.authorVal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.subtitleVal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.titleVal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.urlVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Octopress Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label urlVal;
        private System.Windows.Forms.Label titleVal;
        private System.Windows.Forms.Label subtitleVal;
        private System.Windows.Forms.Label authorVal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
    }
}

