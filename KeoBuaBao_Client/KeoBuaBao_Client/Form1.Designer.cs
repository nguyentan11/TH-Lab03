namespace KeoBuaBao_Client
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
            this.txtChoice = new System.Windows.Forms.TextBox();
            this.lblChoice = new System.Windows.Forms.Label();
            this.btnKeo = new System.Windows.Forms.Button();
            this.btnBao = new System.Windows.Forms.Button();
            this.btnBua = new System.Windows.Forms.Button();
            this.lblKq = new System.Windows.Forms.Label();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.lblSVC = new System.Windows.Forms.Label();
            this.txtSVC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtChoice
            // 
            this.txtChoice.Location = new System.Drawing.Point(102, 12);
            this.txtChoice.Name = "txtChoice";
            this.txtChoice.ReadOnly = true;
            this.txtChoice.Size = new System.Drawing.Size(118, 20);
            this.txtChoice.TabIndex = 0;
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Location = new System.Drawing.Point(26, 15);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(67, 13);
            this.lblChoice.TabIndex = 1;
            this.lblChoice.Text = "Your choice:";
            // 
            // btnKeo
            // 
            this.btnKeo.Location = new System.Drawing.Point(18, 74);
            this.btnKeo.Name = "btnKeo";
            this.btnKeo.Size = new System.Drawing.Size(85, 79);
            this.btnKeo.TabIndex = 2;
            this.btnKeo.Text = "Scissor";
            this.btnKeo.UseVisualStyleBackColor = true;
            this.btnKeo.Click += new System.EventHandler(this.btnKeo_Click);
            // 
            // btnBao
            // 
            this.btnBao.Location = new System.Drawing.Point(292, 74);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(86, 79);
            this.btnBao.TabIndex = 3;
            this.btnBao.Text = "Paper";
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // btnBua
            // 
            this.btnBua.Location = new System.Drawing.Point(152, 74);
            this.btnBua.Name = "btnBua";
            this.btnBua.Size = new System.Drawing.Size(83, 79);
            this.btnBua.TabIndex = 4;
            this.btnBua.Text = "Rock";
            this.btnBua.UseVisualStyleBackColor = true;
            this.btnBua.Click += new System.EventHandler(this.btnBua_Click);
            // 
            // lblKq
            // 
            this.lblKq.AutoSize = true;
            this.lblKq.Location = new System.Drawing.Point(26, 206);
            this.lblKq.Name = "lblKq";
            this.lblKq.Size = new System.Drawing.Size(40, 13);
            this.lblKq.TabIndex = 5;
            this.lblKq.Text = "Result:";
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(102, 203);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(118, 20);
            this.txtKq.TabIndex = 6;
            // 
            // lblSVC
            // 
            this.lblSVC.AutoSize = true;
            this.lblSVC.Location = new System.Drawing.Point(26, 180);
            this.lblSVC.Name = "lblSVC";
            this.lblSVC.Size = new System.Drawing.Size(74, 13);
            this.lblSVC.TabIndex = 5;
            this.lblSVC.Text = "Server Choice";
            // 
            // txtSVC
            // 
            this.txtSVC.Location = new System.Drawing.Point(102, 177);
            this.txtSVC.Name = "txtSVC";
            this.txtSVC.Size = new System.Drawing.Size(118, 20);
            this.txtSVC.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 235);
            this.Controls.Add(this.txtSVC);
            this.Controls.Add(this.lblSVC);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.lblKq);
            this.Controls.Add(this.btnBua);
            this.Controls.Add(this.btnBao);
            this.Controls.Add(this.btnKeo);
            this.Controls.Add(this.lblChoice);
            this.Controls.Add(this.txtChoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChoice;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.Button btnKeo;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.Button btnBua;
        private System.Windows.Forms.Label lblKq;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Label lblSVC;
        private System.Windows.Forms.TextBox txtSVC;
    }
}

