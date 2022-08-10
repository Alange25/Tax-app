namespace Tax_app
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
            this.label1 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.five_percentbtn = new System.Windows.Forms.Button();
            this.ten_percentbtn = new System.Windows.Forms.Button();
            this.fifteen_percentbtn = new System.Windows.Forms.Button();
            this.twenty_percentbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GrandTotal = new System.Windows.Forms.Label();
            this.Custombtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the total:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(230, 47);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(216, 22);
            this.totalTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add tax amount:";
            // 
            // five_percentbtn
            // 
            this.five_percentbtn.Location = new System.Drawing.Point(211, 102);
            this.five_percentbtn.Name = "five_percentbtn";
            this.five_percentbtn.Size = new System.Drawing.Size(53, 23);
            this.five_percentbtn.TabIndex = 3;
            this.five_percentbtn.Text = "5%";
            this.five_percentbtn.UseVisualStyleBackColor = true;
            this.five_percentbtn.Click += new System.EventHandler(this.five_percentbtn_Click);
            // 
            // ten_percentbtn
            // 
            this.ten_percentbtn.Location = new System.Drawing.Point(279, 102);
            this.ten_percentbtn.Name = "ten_percentbtn";
            this.ten_percentbtn.Size = new System.Drawing.Size(53, 23);
            this.ten_percentbtn.TabIndex = 4;
            this.ten_percentbtn.Text = "10%";
            this.ten_percentbtn.UseVisualStyleBackColor = true;
            this.ten_percentbtn.Click += new System.EventHandler(this.ten_percentbtn_Click);
            // 
            // fifteen_percentbtn
            // 
            this.fifteen_percentbtn.Location = new System.Drawing.Point(348, 102);
            this.fifteen_percentbtn.Name = "fifteen_percentbtn";
            this.fifteen_percentbtn.Size = new System.Drawing.Size(53, 23);
            this.fifteen_percentbtn.TabIndex = 5;
            this.fifteen_percentbtn.Text = "15%";
            this.fifteen_percentbtn.UseVisualStyleBackColor = true;
            this.fifteen_percentbtn.Click += new System.EventHandler(this.fifteen_percentbtn_Click);
            // 
            // twenty_percentbtn
            // 
            this.twenty_percentbtn.Location = new System.Drawing.Point(419, 102);
            this.twenty_percentbtn.Name = "twenty_percentbtn";
            this.twenty_percentbtn.Size = new System.Drawing.Size(53, 23);
            this.twenty_percentbtn.TabIndex = 6;
            this.twenty_percentbtn.Text = "20%";
            this.twenty_percentbtn.UseVisualStyleBackColor = true;
            this.twenty_percentbtn.Click += new System.EventHandler(this.twenty_percentbtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add custom Tax Amount:";
            // 
            // CustomTextBox
            // 
            this.CustomTextBox.Location = new System.Drawing.Point(272, 157);
            this.CustomTextBox.Name = "CustomTextBox";
            this.CustomTextBox.Size = new System.Drawing.Size(174, 22);
            this.CustomTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Grand total:";
            // 
            // GrandTotal
            // 
            this.GrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GrandTotal.Location = new System.Drawing.Point(230, 320);
            this.GrandTotal.Name = "GrandTotal";
            this.GrandTotal.Size = new System.Drawing.Size(216, 23);
            this.GrandTotal.TabIndex = 10;
            // 
            // Custombtn
            // 
            this.Custombtn.Location = new System.Drawing.Point(230, 198);
            this.Custombtn.Name = "Custombtn";
            this.Custombtn.Size = new System.Drawing.Size(102, 49);
            this.Custombtn.TabIndex = 11;
            this.Custombtn.Text = "Calculate custom%";
            this.Custombtn.UseVisualStyleBackColor = true;
            this.Custombtn.Click += new System.EventHandler(this.Custombtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(165, 372);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 23);
            this.Clearbtn.TabIndex = 12;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(301, 372);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 13;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tax:";
            // 
            // tax
            // 
            this.tax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tax.Location = new System.Drawing.Point(232, 265);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(214, 23);
            this.tax.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 407);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Custombtn);
            this.Controls.Add(this.GrandTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.twenty_percentbtn);
            this.Controls.Add(this.fifteen_percentbtn);
            this.Controls.Add(this.ten_percentbtn);
            this.Controls.Add(this.five_percentbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tax app...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button five_percentbtn;
        private System.Windows.Forms.Button ten_percentbtn;
        private System.Windows.Forms.Button fifteen_percentbtn;
        private System.Windows.Forms.Button twenty_percentbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustomTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GrandTotal;
        private System.Windows.Forms.Button Custombtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tax;
    }
}

