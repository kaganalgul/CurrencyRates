
namespace CurrencyWindowsFormsUI
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
            this.dtpDatePicker = new System.Windows.Forms.DateTimePicker();
            this.cboMainCurrency = new System.Windows.Forms.ComboBox();
            this.cboTargetCurrency = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSeeIt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDatePicker
            // 
            this.dtpDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePicker.Location = new System.Drawing.Point(12, 121);
            this.dtpDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDatePicker.Name = "dtpDatePicker";
            this.dtpDatePicker.Size = new System.Drawing.Size(276, 26);
            this.dtpDatePicker.TabIndex = 0;
            // 
            // cboMainCurrency
            // 
            this.cboMainCurrency.FormattingEnabled = true;
            this.cboMainCurrency.Location = new System.Drawing.Point(12, 32);
            this.cboMainCurrency.Name = "cboMainCurrency";
            this.cboMainCurrency.Size = new System.Drawing.Size(133, 28);
            this.cboMainCurrency.TabIndex = 1;
            // 
            // cboTargetCurrency
            // 
            this.cboTargetCurrency.FormattingEnabled = true;
            this.cboTargetCurrency.Location = new System.Drawing.Point(151, 32);
            this.cboTargetCurrency.Name = "cboTargetCurrency";
            this.cboTargetCurrency.Size = new System.Drawing.Size(137, 28);
            this.cboTargetCurrency.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(12, 63);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(276, 55);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Main Currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Target Currency";
            // 
            // btnSeeIt
            // 
            this.btnSeeIt.Location = new System.Drawing.Point(13, 151);
            this.btnSeeIt.Name = "btnSeeIt";
            this.btnSeeIt.Size = new System.Drawing.Size(275, 31);
            this.btnSeeIt.TabIndex = 6;
            this.btnSeeIt.Text = "See It";
            this.btnSeeIt.UseVisualStyleBackColor = true;
            this.btnSeeIt.Click += new System.EventHandler(this.btnSeeIt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 190);
            this.Controls.Add(this.btnSeeIt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cboTargetCurrency);
            this.Controls.Add(this.cboMainCurrency);
            this.Controls.Add(this.dtpDatePicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "How Much is This Currency?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatePicker;
        private System.Windows.Forms.ComboBox cboMainCurrency;
        private System.Windows.Forms.ComboBox cboTargetCurrency;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSeeIt;
    }
}

