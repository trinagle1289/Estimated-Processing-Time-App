
namespace Estimated_Processing_Time_App
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.radioButton_FR500 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_FR6000 = new System.Windows.Forms.RadioButton();
            this.radioButton_FR5000 = new System.Windows.Forms.RadioButton();
            this.radioButton_FR4000 = new System.Windows.Forms.RadioButton();
            this.radioButton_FR3000 = new System.Windows.Forms.RadioButton();
            this.radioButton_FR1000 = new System.Windows.Forms.RadioButton();
            this.radioButton_FR2000 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPredict = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_FR500
            // 
            this.radioButton_FR500.AutoSize = true;
            this.radioButton_FR500.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_FR500.Location = new System.Drawing.Point(3, 3);
            this.radioButton_FR500.Name = "radioButton_FR500";
            this.radioButton_FR500.Size = new System.Drawing.Size(197, 39);
            this.radioButton_FR500.TabIndex = 1;
            this.radioButton_FR500.TabStop = true;
            this.radioButton_FR500.Text = "500 mm/min";
            this.radioButton_FR500.UseVisualStyleBackColor = true;
            this.radioButton_FR500.Click += new System.EventHandler(this.radioButton_FR500_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 459);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇Feedrate";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.radioButton_FR6000, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.radioButton_FR5000, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.radioButton_FR4000, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.radioButton_FR500, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButton_FR3000, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.radioButton_FR1000, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.radioButton_FR2000, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 37);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(322, 419);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // radioButton_FR6000
            // 
            this.radioButton_FR6000.AutoSize = true;
            this.radioButton_FR6000.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_FR6000.Location = new System.Drawing.Point(3, 273);
            this.radioButton_FR6000.Name = "radioButton_FR6000";
            this.radioButton_FR6000.Size = new System.Drawing.Size(213, 39);
            this.radioButton_FR6000.TabIndex = 7;
            this.radioButton_FR6000.TabStop = true;
            this.radioButton_FR6000.Text = "6000 mm/min";
            this.radioButton_FR6000.UseVisualStyleBackColor = true;
            this.radioButton_FR6000.Click += new System.EventHandler(this.radioButton_FR6000_Click);
            // 
            // radioButton_FR5000
            // 
            this.radioButton_FR5000.AutoSize = true;
            this.radioButton_FR5000.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_FR5000.Location = new System.Drawing.Point(3, 228);
            this.radioButton_FR5000.Name = "radioButton_FR5000";
            this.radioButton_FR5000.Size = new System.Drawing.Size(213, 39);
            this.radioButton_FR5000.TabIndex = 6;
            this.radioButton_FR5000.TabStop = true;
            this.radioButton_FR5000.Text = "5000 mm/min";
            this.radioButton_FR5000.UseVisualStyleBackColor = true;
            this.radioButton_FR5000.Click += new System.EventHandler(this.radioButton_FR5000_Click);
            // 
            // radioButton_FR4000
            // 
            this.radioButton_FR4000.AutoSize = true;
            this.radioButton_FR4000.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_FR4000.Location = new System.Drawing.Point(3, 183);
            this.radioButton_FR4000.Name = "radioButton_FR4000";
            this.radioButton_FR4000.Size = new System.Drawing.Size(213, 39);
            this.radioButton_FR4000.TabIndex = 5;
            this.radioButton_FR4000.TabStop = true;
            this.radioButton_FR4000.Text = "4000 mm/min";
            this.radioButton_FR4000.UseVisualStyleBackColor = true;
            this.radioButton_FR4000.Click += new System.EventHandler(this.radioButton_FR4000_Click);
            // 
            // radioButton_FR3000
            // 
            this.radioButton_FR3000.AutoSize = true;
            this.radioButton_FR3000.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_FR3000.Location = new System.Drawing.Point(3, 138);
            this.radioButton_FR3000.Name = "radioButton_FR3000";
            this.radioButton_FR3000.Size = new System.Drawing.Size(213, 39);
            this.radioButton_FR3000.TabIndex = 4;
            this.radioButton_FR3000.TabStop = true;
            this.radioButton_FR3000.Text = "3000 mm/min";
            this.radioButton_FR3000.UseVisualStyleBackColor = true;
            this.radioButton_FR3000.Click += new System.EventHandler(this.radioButton_FR3000_Click);
            // 
            // radioButton_FR1000
            // 
            this.radioButton_FR1000.AutoSize = true;
            this.radioButton_FR1000.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_FR1000.Location = new System.Drawing.Point(3, 48);
            this.radioButton_FR1000.Name = "radioButton_FR1000";
            this.radioButton_FR1000.Size = new System.Drawing.Size(213, 39);
            this.radioButton_FR1000.TabIndex = 2;
            this.radioButton_FR1000.TabStop = true;
            this.radioButton_FR1000.Text = "1000 mm/min";
            this.radioButton_FR1000.UseVisualStyleBackColor = true;
            this.radioButton_FR1000.Click += new System.EventHandler(this.radioButton_FR1000_Click);
            // 
            // radioButton_FR2000
            // 
            this.radioButton_FR2000.AutoSize = true;
            this.radioButton_FR2000.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_FR2000.Location = new System.Drawing.Point(3, 93);
            this.radioButton_FR2000.Name = "radioButton_FR2000";
            this.radioButton_FR2000.Size = new System.Drawing.Size(213, 39);
            this.radioButton_FR2000.TabIndex = 3;
            this.radioButton_FR2000.TabStop = true;
            this.radioButton_FR2000.Text = "2000 mm/min";
            this.radioButton_FR2000.UseVisualStyleBackColor = true;
            this.radioButton_FR2000.Click += new System.EventHandler(this.radioButton_FR2000_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.12371F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.87629F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPredict, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMessage, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.57162F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.42838F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 761);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // buttonPredict
            // 
            this.buttonPredict.BackColor = System.Drawing.Color.LightYellow;
            this.buttonPredict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPredict.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPredict.Location = new System.Drawing.Point(20, 559);
            this.buttonPredict.Margin = new System.Windows.Forms.Padding(20, 60, 20, 60);
            this.buttonPredict.Name = "buttonPredict";
            this.buttonPredict.Size = new System.Drawing.Size(328, 142);
            this.buttonPredict.TabIndex = 3;
            this.buttonPredict.Text = "讀取G-code\r\n並進行加工時間預估";
            this.buttonPredict.UseVisualStyleBackColor = false;
            this.buttonPredict.Click += new System.EventHandler(this.buttonPredict_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMessage.Location = new System.Drawing.Point(378, 10);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.textBoxMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.SetRowSpan(this.textBoxMessage, 2);
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(883, 741);
            this.textBoxMessage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "加工時間預估";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton_FR500;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_FR2000;
        private System.Windows.Forms.RadioButton radioButton_FR1000;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButton_FR3000;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonPredict;
        private System.Windows.Forms.RadioButton radioButton_FR4000;
        private System.Windows.Forms.RadioButton radioButton_FR5000;
        private System.Windows.Forms.RadioButton radioButton_FR6000;
        private System.Windows.Forms.TextBox textBoxMessage;
    }
}

