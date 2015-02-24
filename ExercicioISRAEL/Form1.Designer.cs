namespace ExercicioISRAEL
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btSoma = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(17, 103);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(70, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNum2.Location = new System.Drawing.Point(98, 103);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(67, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // btSoma
            // 
            this.btSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btSoma.Location = new System.Drawing.Point(17, 134);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(70, 32);
            this.btSoma.TabIndex = 3;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // btSub
            // 
            this.btSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btSub.Location = new System.Drawing.Point(98, 134);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(67, 32);
            this.btSub.TabIndex = 4;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btDiv
            // 
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btDiv.Location = new System.Drawing.Point(17, 188);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(70, 32);
            this.btDiv.TabIndex = 5;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btMult
            // 
            this.btMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btMult.Location = new System.Drawing.Point(98, 188);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(67, 32);
            this.btMult.TabIndex = 6;
            this.btMult.Text = "*";
            this.btMult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Num 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Num 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.txtResult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtResult.Location = new System.Drawing.Point(17, 22);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(148, 62);
            this.txtResult.TabIndex = 2;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblResult.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblResult.Location = new System.Drawing.Point(26, 45);
            this.lblResult.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(136, 35);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 276);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
    }
}

