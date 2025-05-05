namespace kliens_alkalmazas
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
            this.buttonKeszlet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonExport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAllapot = new System.Windows.Forms.Label();
            this.buttonRiport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKeszlet
            // 
            this.buttonKeszlet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKeszlet.Location = new System.Drawing.Point(504, 11);
            this.buttonKeszlet.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeszlet.Name = "buttonKeszlet";
            this.buttonKeszlet.Size = new System.Drawing.Size(85, 37);
            this.buttonKeszlet.TabIndex = 1;
            this.buttonKeszlet.Text = "Készlet Betöltése";
            this.buttonKeszlet.UseVisualStyleBackColor = true;
            this.buttonKeszlet.Click += new System.EventHandler(this.buttonKeszlet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 272);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Location = new System.Drawing.Point(466, 331);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(123, 23);
            this.buttonExport.TabIndex = 3;
            this.buttonExport.Text = "Termékjelentés Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Keresés:";
            // 
            // labelAllapot
            // 
            this.labelAllapot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAllapot.AutoSize = true;
            this.labelAllapot.Location = new System.Drawing.Point(12, 336);
            this.labelAllapot.Name = "labelAllapot";
            this.labelAllapot.Size = new System.Drawing.Size(0, 13);
            this.labelAllapot.TabIndex = 7;
            // 
            // buttonRiport
            // 
            this.buttonRiport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRiport.Location = new System.Drawing.Point(385, 331);
            this.buttonRiport.Name = "buttonRiport";
            this.buttonRiport.Size = new System.Drawing.Size(75, 23);
            this.buttonRiport.TabIndex = 8;
            this.buttonRiport.Text = "Kimutatás";
            this.buttonRiport.UseVisualStyleBackColor = true;
            this.buttonRiport.Click += new System.EventHandler(this.buttonRiport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonRiport);
            this.Controls.Add(this.labelAllapot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonKeszlet);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKeszlet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAllapot;
        private System.Windows.Forms.Button buttonRiport;
    }
}

