
namespace WindowsFormCalcul
{
    partial class FormCal
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
            this.Btdiv = new System.Windows.Forms.Button();
            this.Btmult = new System.Windows.Forms.Button();
            this.Btsous = new System.Windows.Forms.Button();
            this.Btplus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtz = new System.Windows.Forms.TextBox();
            this.Txty = new System.Windows.Forms.TextBox();
            this.Txtx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btdiv
            // 
            this.Btdiv.Location = new System.Drawing.Point(262, 124);
            this.Btdiv.Name = "Btdiv";
            this.Btdiv.Size = new System.Drawing.Size(75, 23);
            this.Btdiv.TabIndex = 19;
            this.Btdiv.Text = "/";
            this.Btdiv.UseVisualStyleBackColor = true;
            this.Btdiv.Click += new System.EventHandler(this.Btdiv_Click);
            // 
            // Btmult
            // 
            this.Btmult.Location = new System.Drawing.Point(181, 124);
            this.Btmult.Name = "Btmult";
            this.Btmult.Size = new System.Drawing.Size(75, 23);
            this.Btmult.TabIndex = 18;
            this.Btmult.Text = "*";
            this.Btmult.UseVisualStyleBackColor = true;
            this.Btmult.Click += new System.EventHandler(this.Btmult_Click);
            // 
            // Btsous
            // 
            this.Btsous.Location = new System.Drawing.Point(100, 124);
            this.Btsous.Name = "Btsous";
            this.Btsous.Size = new System.Drawing.Size(75, 23);
            this.Btsous.TabIndex = 17;
            this.Btsous.Text = "-";
            this.Btsous.UseVisualStyleBackColor = true;
            this.Btsous.Click += new System.EventHandler(this.Btsous_Click);
            // 
            // Btplus
            // 
            this.Btplus.Location = new System.Drawing.Point(19, 124);
            this.Btplus.Name = "Btplus";
            this.Btplus.Size = new System.Drawing.Size(75, 23);
            this.Btplus.TabIndex = 16;
            this.Btplus.Text = "+";
            this.Btplus.UseVisualStyleBackColor = true;
            this.Btplus.Click += new System.EventHandler(this.Btplus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "x";
            // 
            // Txtz
            // 
            this.Txtz.Location = new System.Drawing.Point(142, 83);
            this.Txtz.Name = "Txtz";
            this.Txtz.ReadOnly = true;
            this.Txtz.Size = new System.Drawing.Size(124, 20);
            this.Txtz.TabIndex = 12;
            // 
            // Txty
            // 
            this.Txty.Location = new System.Drawing.Point(142, 57);
            this.Txty.Name = "Txty";
            this.Txty.Size = new System.Drawing.Size(124, 20);
            this.Txty.TabIndex = 11;
            // 
            // Txtx
            // 
            this.Txtx.Location = new System.Drawing.Point(142, 31);
            this.Txtx.Name = "Txtx";
            this.Txtx.Size = new System.Drawing.Size(126, 20);
            this.Txtx.TabIndex = 10;
            // 
            // FormCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 178);
            this.Controls.Add(this.Btdiv);
            this.Controls.Add(this.Btmult);
            this.Controls.Add(this.Btsous);
            this.Controls.Add(this.Btplus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtz);
            this.Controls.Add(this.Txty);
            this.Controls.Add(this.Txtx);
            this.Name = "FormCal";
            this.Text = "Calculatrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btdiv;
        private System.Windows.Forms.Button Btmult;
        private System.Windows.Forms.Button Btsous;
        private System.Windows.Forms.Button Btplus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtz;
        private System.Windows.Forms.TextBox Txty;
        private System.Windows.Forms.TextBox Txtx;
    }
}

