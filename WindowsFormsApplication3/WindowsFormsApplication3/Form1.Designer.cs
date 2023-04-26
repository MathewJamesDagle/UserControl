namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTwo = new System.Windows.Forms.Button();
            this.panelOne = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userControl11 = new WindowsFormsApplication3.UserControl1();
            this.userControl21 = new WindowsFormsApplication3.UserControl2();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTwo);
            this.panel1.Controls.Add(this.panelOne);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 389);
            this.panel1.TabIndex = 0;
            // 
            // panelTwo
            // 
            this.panelTwo.Location = new System.Drawing.Point(59, 197);
            this.panelTwo.Name = "panelTwo";
            this.panelTwo.Size = new System.Drawing.Size(83, 34);
            this.panelTwo.TabIndex = 1;
            this.panelTwo.Text = "Panel Two";
            this.panelTwo.UseVisualStyleBackColor = true;
            this.panelTwo.Click += new System.EventHandler(this.panelTwo_Click);
            // 
            // panelOne
            // 
            this.panelOne.Location = new System.Drawing.Point(59, 112);
            this.panelOne.Name = "panelOne";
            this.panelOne.Size = new System.Drawing.Size(83, 32);
            this.panelOne.TabIndex = 0;
            this.panelOne.Text = "Panel One";
            this.panelOne.UseVisualStyleBackColor = true;
            this.panelOne.Click += new System.EventHandler(this.panelOne_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(745, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 389);
            this.panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Input Two";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Input One";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Control Panel Application";
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Wheat;
            this.userControl11.Location = new System.Drawing.Point(259, 76);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(450, 313);
            this.userControl11.TabIndex = 3;
            this.userControl11.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.userControl21.Location = new System.Drawing.Point(259, 76);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(450, 313);
            this.userControl21.TabIndex = 4;
            this.userControl21.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 389);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button panelTwo;
        private System.Windows.Forms.Button panelOne;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
    }
}

