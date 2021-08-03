
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
            this.buttonRead = new System.Windows.Forms.Button();
            this.radioButton_SR500 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_SR4000 = new System.Windows.Forms.RadioButton();
            this.radioButton_SR1000 = new System.Windows.Forms.RadioButton();
            this.radioButton_SR2000 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPredict = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRead
            // 
            this.buttonRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRead.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRead.Location = new System.Drawing.Point(3, 3);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(220, 92);
            this.buttonRead.TabIndex = 0;
            this.buttonRead.Text = "讀取G-CODE";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // radioButton_SR500
            // 
            this.radioButton_SR500.AutoSize = true;
            this.radioButton_SR500.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_SR500.Location = new System.Drawing.Point(3, 3);
            this.radioButton_SR500.Name = "radioButton_SR500";
            this.radioButton_SR500.Size = new System.Drawing.Size(81, 39);
            this.radioButton_SR500.TabIndex = 1;
            this.radioButton_SR500.TabStop = true;
            this.radioButton_SR500.Text = "500";
            this.radioButton_SR500.UseVisualStyleBackColor = true;
            this.radioButton_SR500.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton_SR500_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇SpeedRate";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.radioButton_SR500, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButton_SR4000, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.radioButton_SR1000, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.radioButton_SR2000, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 37);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(214, 233);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // radioButton_SR4000
            // 
            this.radioButton_SR4000.AutoSize = true;
            this.radioButton_SR4000.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_SR4000.Location = new System.Drawing.Point(3, 138);
            this.radioButton_SR4000.Name = "radioButton_SR4000";
            this.radioButton_SR4000.Size = new System.Drawing.Size(97, 39);
            this.radioButton_SR4000.TabIndex = 4;
            this.radioButton_SR4000.TabStop = true;
            this.radioButton_SR4000.Text = "4000";
            this.radioButton_SR4000.UseVisualStyleBackColor = true;
            this.radioButton_SR4000.Click += new System.EventHandler(this.radioButton_SR4000_Click);
            // 
            // radioButton_SR1000
            // 
            this.radioButton_SR1000.AutoSize = true;
            this.radioButton_SR1000.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_SR1000.Location = new System.Drawing.Point(3, 48);
            this.radioButton_SR1000.Name = "radioButton_SR1000";
            this.radioButton_SR1000.Size = new System.Drawing.Size(97, 39);
            this.radioButton_SR1000.TabIndex = 2;
            this.radioButton_SR1000.TabStop = true;
            this.radioButton_SR1000.Text = "1000";
            this.radioButton_SR1000.UseVisualStyleBackColor = true;
            this.radioButton_SR1000.Click += new System.EventHandler(this.radioButton_SR1000_Click);
            // 
            // radioButton_SR2000
            // 
            this.radioButton_SR2000.AutoSize = true;
            this.radioButton_SR2000.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_SR2000.Location = new System.Drawing.Point(3, 93);
            this.radioButton_SR2000.Name = "radioButton_SR2000";
            this.radioButton_SR2000.Size = new System.Drawing.Size(97, 39);
            this.radioButton_SR2000.TabIndex = 3;
            this.radioButton_SR2000.TabStop = true;
            this.radioButton_SR2000.Text = "2000";
            this.radioButton_SR2000.UseVisualStyleBackColor = true;
            this.radioButton_SR2000.Click += new System.EventHandler(this.radioButton_SR2000_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.12371F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.87629F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonRead, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPredict, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMessage, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.52846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.09129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.57676F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 482);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // buttonPredict
            // 
            this.buttonPredict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPredict.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPredict.Location = new System.Drawing.Point(3, 380);
            this.buttonPredict.Name = "buttonPredict";
            this.buttonPredict.Size = new System.Drawing.Size(220, 99);
            this.buttonPredict.TabIndex = 3;
            this.buttonPredict.Text = "加工時間預估";
            this.buttonPredict.UseVisualStyleBackColor = true;
            this.buttonPredict.Click += new System.EventHandler(this.buttonPredict_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMessage.Location = new System.Drawing.Point(229, 3);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.textBoxMessage, 3);
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(544, 476);
            this.textBoxMessage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.RadioButton radioButton_SR500;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_SR2000;
        private System.Windows.Forms.RadioButton radioButton_SR1000;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButton_SR4000;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonPredict;
        private System.Windows.Forms.TextBox textBoxMessage;
    }
}

