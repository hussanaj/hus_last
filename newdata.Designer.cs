
namespace WindowsFormsApp_testone
{
    partial class newdata
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
            this.label5 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textwi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texthi = new System.Windows.Forms.TextBox();
            this.buttonsave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 116);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "ข้อมูล";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(97, 194);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(251, 22);
            this.textname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "อายุ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textage
            // 
            this.textage.Location = new System.Drawing.Point(97, 267);
            this.textage.Name = "textage";
            this.textage.Size = new System.Drawing.Size(251, 22);
            this.textage.TabIndex = 3;
            this.textage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "น้ำหนัก";
            // 
            // textwi
            // 
            this.textwi.Location = new System.Drawing.Point(97, 341);
            this.textwi.Name = "textwi";
            this.textwi.Size = new System.Drawing.Size(251, 22);
            this.textwi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "ส่วนสูง";
            // 
            // texthi
            // 
            this.texthi.Location = new System.Drawing.Point(97, 412);
            this.texthi.Name = "texthi";
            this.texthi.Size = new System.Drawing.Size(251, 22);
            this.texthi.TabIndex = 7;
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(97, 485);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(75, 23);
            this.buttonsave.TabIndex = 9;
            this.buttonsave.Text = "บันทึก";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 10;
            // 
            // newdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 536);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.texthi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textwi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.panel1);
            this.Name = "newdata";
            this.Text = "newdata";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textwi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texthi;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}