using System;

namespace mana_laade
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
            this.vards = new System.Windows.Forms.TextBox();
            this.velejums = new System.Windows.Forms.TextBox();
            this.platumstb = new System.Windows.Forms.TextBox();
            this.garumstb = new System.Windows.Forms.TextBox();
            this.augstumstb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rekinstb = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.materialstb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vards
            // 
            this.vards.Location = new System.Drawing.Point(226, 31);
            this.vards.Name = "vards";
            this.vards.Size = new System.Drawing.Size(100, 20);
            this.vards.TabIndex = 0;
            this.vards.TextChanged += new System.EventHandler(this.vards_TextChanged);
            // 
            // velejums
            // 
            this.velejums.Location = new System.Drawing.Point(226, 86);
            this.velejums.Name = "velejums";
            this.velejums.Size = new System.Drawing.Size(100, 20);
            this.velejums.TabIndex = 1;
            this.velejums.TextChanged += new System.EventHandler(this.velejums_TextChanged);
            // 
            // platumstb
            // 
            this.platumstb.Location = new System.Drawing.Point(226, 147);
            this.platumstb.Name = "platumstb";
            this.platumstb.Size = new System.Drawing.Size(100, 20);
            this.platumstb.TabIndex = 2;
            this.platumstb.TextChanged += new System.EventHandler(this.platumstb_TextChanged);
            // 
            // garumstb
            // 
            this.garumstb.Location = new System.Drawing.Point(226, 173);
            this.garumstb.Name = "garumstb";
            this.garumstb.Size = new System.Drawing.Size(100, 20);
            this.garumstb.TabIndex = 3;
            this.garumstb.TextChanged += new System.EventHandler(this.garumstb_TextChanged);
            // 
            // augstumstb
            // 
            this.augstumstb.Location = new System.Drawing.Point(226, 199);
            this.augstumstb.Name = "augstumstb";
            this.augstumstb.Size = new System.Drawing.Size(100, 20);
            this.augstumstb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vards";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "velejums";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "platums";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "garums";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "augstums";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "izveidot rekinu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "rekins";
            // 
            // rekinstb
            // 
            this.rekinstb.Location = new System.Drawing.Point(226, 323);
            this.rekinstb.Name = "rekinstb";
            this.rekinstb.Size = new System.Drawing.Size(100, 96);
            this.rekinstb.TabIndex = 12;
            this.rekinstb.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "materiala cena";
            // 
            // materialstb
            // 
            this.materialstb.Location = new System.Drawing.Point(226, 238);
            this.materialstb.Name = "materialstb";
            this.materialstb.Size = new System.Drawing.Size(100, 20);
            this.materialstb.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "rakstas faila";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.materialstb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rekinstb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.augstumstb);
            this.Controls.Add(this.garumstb);
            this.Controls.Add(this.platumstb);
            this.Controls.Add(this.velejums);
            this.Controls.Add(this.vards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void garumstb_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void platumstb_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void velejums_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void vards_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox vards;
        private System.Windows.Forms.TextBox velejums;
        private System.Windows.Forms.TextBox platumstb;
        private System.Windows.Forms.TextBox garumstb;
        private System.Windows.Forms.TextBox augstumstb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rekinstb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox materialstb;
        private System.Windows.Forms.Button button2;
    }
}

