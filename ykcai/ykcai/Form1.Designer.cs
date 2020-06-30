namespace ykcai
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reult = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxOp2 = new System.Windows.Forms.TextBox();
            this.textBoxOp1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.Reult.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Reult);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 542);
            this.panel1.TabIndex = 0;
            // 
            // Reult
            // 
            this.Reult.Controls.Add(this.labelResult);
            this.Reult.Location = new System.Drawing.Point(327, 55);
            this.Reult.Name = "Reult";
            this.Reult.Size = new System.Drawing.Size(238, 100);
            this.Reult.TabIndex = 2;
            this.Reult.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint_1);
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(76, 38);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(124, 41);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Result";
            this.labelResult.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(558, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 227);
            this.panel3.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(90, 117);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "=";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(90, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxOp2);
            this.panel2.Controls.Add(this.textBoxOp1);
            this.panel2.Location = new System.Drawing.Point(327, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 145);
            this.panel2.TabIndex = 0;
            // 
            // textBoxOp2
            // 
            this.textBoxOp2.Location = new System.Drawing.Point(0, 108);
            this.textBoxOp2.Name = "textBoxOp2";
            this.textBoxOp2.Size = new System.Drawing.Size(179, 23);
            this.textBoxOp2.TabIndex = 1;
            // 
            // textBoxOp1
            // 
            this.textBoxOp1.Location = new System.Drawing.Point(0, 79);
            this.textBoxOp1.Name = "textBoxOp1";
            this.textBoxOp1.Size = new System.Drawing.Size(179, 23);
            this.textBoxOp1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.Reult.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Reult;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxOp2;
        private System.Windows.Forms.TextBox textBoxOp1;
        private System.Windows.Forms.Button labelResult;
    }
}

