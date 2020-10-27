namespace RegexGenerator
{
    partial class TestPatternRegex
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
            this.minimise = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbRegex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTestString = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnShowPassed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minimise
            // 
            this.minimise.AutoSize = true;
            this.minimise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimise.Location = new System.Drawing.Point(368, 9);
            this.minimise.Name = "minimise";
            this.minimise.Size = new System.Drawing.Size(26, 25);
            this.minimise.TabIndex = 3;
            this.minimise.Text = "--";
            this.minimise.Click += new System.EventHandler(this.minimise_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(400, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 25);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 564);
            this.panel1.TabIndex = 4;
            // 
            // tbRegex
            // 
            this.tbRegex.Location = new System.Drawing.Point(125, 203);
            this.tbRegex.Name = "tbRegex";
            this.tbRegex.ReadOnly = true;
            this.tbRegex.Size = new System.Drawing.Size(301, 22);
            this.tbRegex.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Regex:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Test Regex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "String To Test:";
            // 
            // tbTestString
            // 
            this.tbTestString.Location = new System.Drawing.Point(175, 293);
            this.tbTestString.Name = "tbTestString";
            this.tbTestString.Size = new System.Drawing.Size(251, 22);
            this.tbTestString.TabIndex = 8;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Black;
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(125, 417);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(235, 46);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnShowPassed
            // 
            this.btnShowPassed.Location = new System.Drawing.Point(175, 321);
            this.btnShowPassed.Name = "btnShowPassed";
            this.btnShowPassed.Size = new System.Drawing.Size(251, 31);
            this.btnShowPassed.TabIndex = 11;
            this.btnShowPassed.UseVisualStyleBackColor = true;
            // 
            // TestPatternRegex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 564);
            this.Controls.Add(this.btnShowPassed);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTestString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRegex);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minimise);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestPatternRegex";
            this.Text = "TestPatternRegex";
            this.Load += new System.EventHandler(this.TestPatternRegex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimise;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbRegex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTestString;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnShowPassed;
    }
}