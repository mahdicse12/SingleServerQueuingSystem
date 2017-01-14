namespace SingleServerQueuingSystem
{
    partial class SingleServerQueuingSystem
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
            this.label_MIT = new System.Windows.Forms.Label();
            this.textBox_MIT = new System.Windows.Forms.TextBox();
            this.textBox_MST = new System.Windows.Forms.TextBox();
            this.label_MST = new System.Windows.Forms.Label();
            this.textBox_NOC = new System.Windows.Forms.TextBox();
            this.label_NOC = new System.Windows.Forms.Label();
            this.label_su = new System.Windows.Forms.Label();
            this.label_aniq = new System.Windows.Forms.Label();
            this.label_adiq = new System.Windows.Forms.Label();
            this.button_Evaluate = new System.Windows.Forms.Button();
            this.label_tse = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_MIT
            // 
            this.label_MIT.Location = new System.Drawing.Point(12, 25);
            this.label_MIT.Name = "label_MIT";
            this.label_MIT.Size = new System.Drawing.Size(139, 22);
            this.label_MIT.TabIndex = 0;
            this.label_MIT.Text = "Mean Interarrival Time :";
            // 
            // textBox_MIT
            // 
            this.textBox_MIT.Location = new System.Drawing.Point(157, 25);
            this.textBox_MIT.Name = "textBox_MIT";
            this.textBox_MIT.Size = new System.Drawing.Size(223, 22);
            this.textBox_MIT.TabIndex = 1;
            // 
            // textBox_MST
            // 
            this.textBox_MST.Location = new System.Drawing.Point(157, 67);
            this.textBox_MST.Name = "textBox_MST";
            this.textBox_MST.Size = new System.Drawing.Size(223, 22);
            this.textBox_MST.TabIndex = 3;
            // 
            // label_MST
            // 
            this.label_MST.Location = new System.Drawing.Point(12, 67);
            this.label_MST.Name = "label_MST";
            this.label_MST.Size = new System.Drawing.Size(139, 22);
            this.label_MST.TabIndex = 2;
            this.label_MST.Text = "Mean Service Time :";
            // 
            // textBox_NOC
            // 
            this.textBox_NOC.Location = new System.Drawing.Point(157, 110);
            this.textBox_NOC.Name = "textBox_NOC";
            this.textBox_NOC.Size = new System.Drawing.Size(223, 22);
            this.textBox_NOC.TabIndex = 5;
            // 
            // label_NOC
            // 
            this.label_NOC.Location = new System.Drawing.Point(12, 110);
            this.label_NOC.Name = "label_NOC";
            this.label_NOC.Size = new System.Drawing.Size(139, 22);
            this.label_NOC.TabIndex = 4;
            this.label_NOC.Text = "Number Of Customers :";
            // 
            // label_su
            // 
            this.label_su.Location = new System.Drawing.Point(12, 284);
            this.label_su.Name = "label_su";
            this.label_su.Size = new System.Drawing.Size(368, 22);
            this.label_su.TabIndex = 8;
            // 
            // label_aniq
            // 
            this.label_aniq.Location = new System.Drawing.Point(12, 241);
            this.label_aniq.Name = "label_aniq";
            this.label_aniq.Size = new System.Drawing.Size(368, 22);
            this.label_aniq.TabIndex = 7;
            // 
            // label_adiq
            // 
            this.label_adiq.Location = new System.Drawing.Point(12, 199);
            this.label_adiq.Name = "label_adiq";
            this.label_adiq.Size = new System.Drawing.Size(368, 22);
            this.label_adiq.TabIndex = 6;
            // 
            // button_Evaluate
            // 
            this.button_Evaluate.Location = new System.Drawing.Point(224, 149);
            this.button_Evaluate.Name = "button_Evaluate";
            this.button_Evaluate.Size = new System.Drawing.Size(75, 23);
            this.button_Evaluate.TabIndex = 9;
            this.button_Evaluate.Text = "Evaluate";
            this.button_Evaluate.UseVisualStyleBackColor = true;
            this.button_Evaluate.Click += new System.EventHandler(this.button_Evaluate_Click);
            // 
            // label_tse
            // 
            this.label_tse.Location = new System.Drawing.Point(12, 330);
            this.label_tse.Name = "label_tse";
            this.label_tse.Size = new System.Drawing.Size(368, 22);
            this.label_tse.TabIndex = 10;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(305, 149);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 11;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // SingleServerQueuingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label_tse);
            this.Controls.Add(this.button_Evaluate);
            this.Controls.Add(this.label_su);
            this.Controls.Add(this.label_aniq);
            this.Controls.Add(this.label_adiq);
            this.Controls.Add(this.textBox_NOC);
            this.Controls.Add(this.label_NOC);
            this.Controls.Add(this.textBox_MST);
            this.Controls.Add(this.label_MST);
            this.Controls.Add(this.textBox_MIT);
            this.Controls.Add(this.label_MIT);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SingleServerQueuingSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Single Server Queuing System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MIT;
        private System.Windows.Forms.TextBox textBox_MIT;
        private System.Windows.Forms.TextBox textBox_MST;
        private System.Windows.Forms.Label label_MST;
        private System.Windows.Forms.TextBox textBox_NOC;
        private System.Windows.Forms.Label label_NOC;
        private System.Windows.Forms.Label label_su;
        private System.Windows.Forms.Label label_aniq;
        private System.Windows.Forms.Label label_adiq;
        private System.Windows.Forms.Button button_Evaluate;
        private System.Windows.Forms.Label label_tse;
        private System.Windows.Forms.Button button_Clear;
    }
}

