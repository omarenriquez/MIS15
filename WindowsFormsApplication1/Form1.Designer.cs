namespace WindowsFormsApplication1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClearTotals = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEnterUnitOfForce = new System.Windows.Forms.TextBox();
            this.txtAdjustedValueOfForce = new System.Windows.Forms.TextBox();
            this.txtAdjustedPercent = new System.Windows.Forms.TextBox();
            this.txtTotalAmountOfForce = new System.Windows.Forms.TextBox();
            this.txtNumberOfImpacts = new System.Windows.Forms.TextBox();
            this.txtAverageAmountOfForce = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnitOfForce = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(131, 217);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClearTotals
            // 
            this.btnClearTotals.Location = new System.Drawing.Point(212, 217);
            this.btnClearTotals.Name = "btnClearTotals";
            this.btnClearTotals.Size = new System.Drawing.Size(75, 23);
            this.btnClearTotals.TabIndex = 1;
            this.btnClearTotals.Text = "Clear Totals";
            this.btnClearTotals.UseVisualStyleBackColor = true;
            this.btnClearTotals.Click += new System.EventHandler(this.btnClearTotals_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(293, 217);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Unit Of Force:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adjusted Percent:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Impacts:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Amount of Force:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Average Amount of Force:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Adjusted Value of Force:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEnterUnitOfForce
            // 
            this.txtEnterUnitOfForce.Location = new System.Drawing.Point(154, 29);
            this.txtEnterUnitOfForce.Name = "txtEnterUnitOfForce";
            this.txtEnterUnitOfForce.Size = new System.Drawing.Size(100, 20);
            this.txtEnterUnitOfForce.TabIndex = 0;
            // 
            // txtAdjustedValueOfForce
            // 
            this.txtAdjustedValueOfForce.Location = new System.Drawing.Point(154, 129);
            this.txtAdjustedValueOfForce.Name = "txtAdjustedValueOfForce";
            this.txtAdjustedValueOfForce.ReadOnly = true;
            this.txtAdjustedValueOfForce.Size = new System.Drawing.Size(100, 20);
            this.txtAdjustedValueOfForce.TabIndex = 10;
            this.txtAdjustedValueOfForce.TabStop = false;
            // 
            // txtAdjustedPercent
            // 
            this.txtAdjustedPercent.Location = new System.Drawing.Point(154, 95);
            this.txtAdjustedPercent.Name = "txtAdjustedPercent";
            this.txtAdjustedPercent.ReadOnly = true;
            this.txtAdjustedPercent.Size = new System.Drawing.Size(100, 20);
            this.txtAdjustedPercent.TabIndex = 11;
            this.txtAdjustedPercent.TabStop = false;
            // 
            // txtTotalAmountOfForce
            // 
            this.txtTotalAmountOfForce.Location = new System.Drawing.Point(417, 136);
            this.txtTotalAmountOfForce.Name = "txtTotalAmountOfForce";
            this.txtTotalAmountOfForce.ReadOnly = true;
            this.txtTotalAmountOfForce.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmountOfForce.TabIndex = 12;
            this.txtTotalAmountOfForce.TabStop = false;
            // 
            // txtNumberOfImpacts
            // 
            this.txtNumberOfImpacts.Location = new System.Drawing.Point(417, 102);
            this.txtNumberOfImpacts.Name = "txtNumberOfImpacts";
            this.txtNumberOfImpacts.ReadOnly = true;
            this.txtNumberOfImpacts.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfImpacts.TabIndex = 13;
            this.txtNumberOfImpacts.TabStop = false;
            // 
            // txtAverageAmountOfForce
            // 
            this.txtAverageAmountOfForce.Location = new System.Drawing.Point(417, 168);
            this.txtAverageAmountOfForce.Name = "txtAverageAmountOfForce";
            this.txtAverageAmountOfForce.ReadOnly = true;
            this.txtAverageAmountOfForce.Size = new System.Drawing.Size(100, 20);
            this.txtAverageAmountOfForce.TabIndex = 14;
            this.txtAverageAmountOfForce.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(154, 164);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Unit Of Force";
            // 
            // txtUnitOfForce
            // 
            this.txtUnitOfForce.Location = new System.Drawing.Point(154, 61);
            this.txtUnitOfForce.Name = "txtUnitOfForce";
            this.txtUnitOfForce.ReadOnly = true;
            this.txtUnitOfForce.Size = new System.Drawing.Size(100, 20);
            this.txtUnitOfForce.TabIndex = 18;
            this.txtUnitOfForce.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(529, 252);
            this.Controls.Add(this.txtUnitOfForce);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAverageAmountOfForce);
            this.Controls.Add(this.txtNumberOfImpacts);
            this.Controls.Add(this.txtTotalAmountOfForce);
            this.Controls.Add(this.txtAdjustedPercent);
            this.Controls.Add(this.txtAdjustedValueOfForce);
            this.Controls.Add(this.txtEnterUnitOfForce);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearTotals);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modified Invoice Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClearTotals;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEnterUnitOfForce;
        private System.Windows.Forms.TextBox txtAdjustedValueOfForce;
        private System.Windows.Forms.TextBox txtAdjustedPercent;
        private System.Windows.Forms.TextBox txtTotalAmountOfForce;
        private System.Windows.Forms.TextBox txtNumberOfImpacts;
        private System.Windows.Forms.TextBox txtAverageAmountOfForce;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnitOfForce;
    }
}

