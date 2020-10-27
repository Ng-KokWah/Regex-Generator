namespace RegexGenerator
{
    partial class RegexGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegexGenerator));
            this.close = new System.Windows.Forms.Label();
            this.minimise = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRangeSample = new System.Windows.Forms.Button();
            this.btnPatternSample = new System.Windows.Forms.Button();
            this.btnExplicitSample = new System.Windows.Forms.Button();
            this.rbExplicitMatch = new System.Windows.Forms.RadioButton();
            this.rbPattern = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.rbRange = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSampleLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(762, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 25);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimise
            // 
            this.minimise.AutoSize = true;
            this.minimise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimise.Location = new System.Drawing.Point(730, 9);
            this.minimise.Name = "minimise";
            this.minimise.Size = new System.Drawing.Size(26, 25);
            this.minimise.TabIndex = 1;
            this.minimise.Text = "--";
            this.minimise.Click += new System.EventHandler(this.minimise_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(232, 84);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(532, 22);
            this.tbInput.TabIndex = 2;
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(232, 353);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.RowHeadersWidth = 51;
            this.dgvOutput.RowTemplate.Height = 24;
            this.dgvOutput.Size = new System.Drawing.Size(532, 209);
            this.dgvOutput.TabIndex = 3;
            this.dgvOutput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutput_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "String To Generate Regular Expression For:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnRangeSample);
            this.panel1.Controls.Add(this.btnPatternSample);
            this.panel1.Controls.Add(this.btnExplicitSample);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 574);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 40);
            this.label5.TabIndex = 3;
            this.label5.Text = "Need Help? \r\nSelect A Sample Above";
            // 
            // btnRangeSample
            // 
            this.btnRangeSample.BackColor = System.Drawing.Color.Black;
            this.btnRangeSample.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRangeSample.ForeColor = System.Drawing.Color.White;
            this.btnRangeSample.Location = new System.Drawing.Point(0, 84);
            this.btnRangeSample.Name = "btnRangeSample";
            this.btnRangeSample.Size = new System.Drawing.Size(201, 42);
            this.btnRangeSample.TabIndex = 2;
            this.btnRangeSample.Text = "Range Sample";
            this.btnRangeSample.UseVisualStyleBackColor = false;
            this.btnRangeSample.Click += new System.EventHandler(this.btnRangeSample_Click);
            // 
            // btnPatternSample
            // 
            this.btnPatternSample.BackColor = System.Drawing.Color.Black;
            this.btnPatternSample.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatternSample.ForeColor = System.Drawing.Color.White;
            this.btnPatternSample.Location = new System.Drawing.Point(0, 42);
            this.btnPatternSample.Name = "btnPatternSample";
            this.btnPatternSample.Size = new System.Drawing.Size(201, 42);
            this.btnPatternSample.TabIndex = 1;
            this.btnPatternSample.Text = "Pattern Sample";
            this.btnPatternSample.UseVisualStyleBackColor = false;
            this.btnPatternSample.Click += new System.EventHandler(this.btnPatternSample_Click);
            // 
            // btnExplicitSample
            // 
            this.btnExplicitSample.BackColor = System.Drawing.Color.Black;
            this.btnExplicitSample.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExplicitSample.ForeColor = System.Drawing.Color.White;
            this.btnExplicitSample.Location = new System.Drawing.Point(0, 0);
            this.btnExplicitSample.Name = "btnExplicitSample";
            this.btnExplicitSample.Size = new System.Drawing.Size(201, 42);
            this.btnExplicitSample.TabIndex = 0;
            this.btnExplicitSample.Text = "Explicit Match Sample";
            this.btnExplicitSample.UseVisualStyleBackColor = false;
            this.btnExplicitSample.Click += new System.EventHandler(this.btnExplicitSample_Click);
            // 
            // rbExplicitMatch
            // 
            this.rbExplicitMatch.AutoSize = true;
            this.rbExplicitMatch.Location = new System.Drawing.Point(228, 262);
            this.rbExplicitMatch.Name = "rbExplicitMatch";
            this.rbExplicitMatch.Size = new System.Drawing.Size(114, 21);
            this.rbExplicitMatch.TabIndex = 7;
            this.rbExplicitMatch.TabStop = true;
            this.rbExplicitMatch.Text = "Explicit Match";
            this.rbExplicitMatch.UseVisualStyleBackColor = true;
            this.rbExplicitMatch.CheckedChanged += new System.EventHandler(this.rbExplicitMatch_CheckedChanged);
            // 
            // rbPattern
            // 
            this.rbPattern.AutoSize = true;
            this.rbPattern.Location = new System.Drawing.Point(348, 262);
            this.rbPattern.Name = "rbPattern";
            this.rbPattern.Size = new System.Drawing.Size(108, 21);
            this.rbPattern.TabIndex = 8;
            this.rbPattern.TabStop = true;
            this.rbPattern.Text = "Pattern Only";
            this.rbPattern.UseVisualStyleBackColor = true;
            this.rbPattern.CheckedChanged += new System.EventHandler(this.rbPattern_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(229, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Recommended Regex(s):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Regular Expression Generator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Explicit or Non-Explicit Match:";
            // 
            // btnGen
            // 
            this.btnGen.BackColor = System.Drawing.Color.Black;
            this.btnGen.ForeColor = System.Drawing.Color.White;
            this.btnGen.Location = new System.Drawing.Point(346, 289);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(274, 37);
            this.btnGen.TabIndex = 12;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = false;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // rbRange
            // 
            this.rbRange.AutoSize = true;
            this.rbRange.Location = new System.Drawing.Point(462, 262);
            this.rbRange.Name = "rbRange";
            this.rbRange.Size = new System.Drawing.Size(71, 21);
            this.rbRange.TabIndex = 21;
            this.rbRange.TabStop = true;
            this.rbRange.Text = "Range";
            this.rbRange.UseVisualStyleBackColor = true;
            this.rbRange.CheckedChanged += new System.EventHandler(this.rbRange_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(225, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(476, 102);
            this.label6.TabIndex = 22;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Sample Label:";
            // 
            // tbSampleLabel
            // 
            this.tbSampleLabel.Location = new System.Drawing.Point(333, 217);
            this.tbSampleLabel.Name = "tbSampleLabel";
            this.tbSampleLabel.ReadOnly = true;
            this.tbSampleLabel.Size = new System.Drawing.Size(431, 22);
            this.tbSampleLabel.TabIndex = 23;
            // 
            // RegexGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSampleLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbRange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbPattern);
            this.Controls.Add(this.rbExplicitMatch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.minimise);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegexGenerator";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label minimise;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbExplicitMatch;
        private System.Windows.Forms.RadioButton rbPattern;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.RadioButton rbRange;
        private System.Windows.Forms.Button btnRangeSample;
        private System.Windows.Forms.Button btnPatternSample;
        private System.Windows.Forms.Button btnExplicitSample;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSampleLabel;
    }
}

