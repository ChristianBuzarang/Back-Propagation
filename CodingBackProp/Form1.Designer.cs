namespace CodingBackProp
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
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.btnStartTraining = new System.Windows.Forms.Button();
            this.txtEpochs = new System.Windows.Forms.TextBox();
            this.txtLearnRate = new System.Windows.Forms.TextBox();
            this.txtMomentum = new System.Windows.Forms.TextBox();
            this.txtDecayRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(18, 93);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxLog.Size = new System.Drawing.Size(770, 345);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            // 
            // btnStartTraining
            // 
            this.btnStartTraining.Location = new System.Drawing.Point(663, 30);
            this.btnStartTraining.Name = "btnStartTraining";
            this.btnStartTraining.Size = new System.Drawing.Size(105, 42);
            this.btnStartTraining.TabIndex = 1;
            this.btnStartTraining.Text = "Start Training";
            this.btnStartTraining.UseVisualStyleBackColor = true;
            // 
            // txtEpochs
            // 
            this.txtEpochs.Location = new System.Drawing.Point(18, 52);
            this.txtEpochs.Name = "txtEpochs";
            this.txtEpochs.Size = new System.Drawing.Size(100, 20);
            this.txtEpochs.TabIndex = 2;
            this.txtEpochs.Text = "1000";
            // 
            // txtLearnRate
            // 
            this.txtLearnRate.Location = new System.Drawing.Point(175, 52);
            this.txtLearnRate.Name = "txtLearnRate";
            this.txtLearnRate.Size = new System.Drawing.Size(100, 20);
            this.txtLearnRate.TabIndex = 3;
            this.txtLearnRate.Text = "0.05";
            // 
            // txtMomentum
            // 
            this.txtMomentum.Location = new System.Drawing.Point(330, 52);
            this.txtMomentum.Name = "txtMomentum";
            this.txtMomentum.Size = new System.Drawing.Size(100, 20);
            this.txtMomentum.TabIndex = 4;
            this.txtMomentum.Text = "0.01";
            // 
            // txtDecayRate
            // 
            this.txtDecayRate.Location = new System.Drawing.Point(486, 52);
            this.txtDecayRate.Name = "txtDecayRate";
            this.txtDecayRate.Size = new System.Drawing.Size(100, 20);
            this.txtDecayRate.TabIndex = 5;
            this.txtDecayRate.Text = "0.0005";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Epochs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Learning Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Momentum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Weight Decay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDecayRate);
            this.Controls.Add(this.txtMomentum);
            this.Controls.Add(this.txtLearnRate);
            this.Controls.Add(this.txtEpochs);
            this.Controls.Add(this.btnStartTraining);
            this.Controls.Add(this.richTextBoxLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Button btnStartTraining;
        private System.Windows.Forms.TextBox txtEpochs;
        private System.Windows.Forms.TextBox txtLearnRate;
        private System.Windows.Forms.TextBox txtMomentum;
        private System.Windows.Forms.TextBox txtDecayRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

