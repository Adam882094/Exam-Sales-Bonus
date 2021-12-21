
namespace Exam_AdamBrennan_82094_
{
    partial class frmMailOrder
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.lblTotalMonthly = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.txtTotalMonthly = new System.Windows.Forms.TextBox();
            this.txtSalesBonus = new System.Windows.Forms.TextBox();
            this.lblTotalBonus = new System.Windows.Forms.Label();
            this.grpLang = new System.Windows.Forms.GroupBox();
            this.rdoSpanish = new System.Windows.Forms.RadioButton();
            this.rdoFrench = new System.Windows.Forms.RadioButton();
            this.rdoEnglish = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpLang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(59, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Employee Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(76, 114);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(67, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Employee ID";
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Location = new System.Drawing.Point(40, 161);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(103, 13);
            this.lblTotalHours.TabIndex = 2;
            this.lblTotalHours.Text = "Total Hours Worked";
            // 
            // lblTotalMonthly
            // 
            this.lblTotalMonthly.AutoSize = true;
            this.lblTotalMonthly.Location = new System.Drawing.Point(43, 207);
            this.lblTotalMonthly.Name = "lblTotalMonthly";
            this.lblTotalMonthly.Size = new System.Drawing.Size(100, 13);
            this.lblTotalMonthly.TabIndex = 3;
            this.lblTotalMonthly.Text = "Total Monthly Sales";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(186, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(186, 114);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(186, 161);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.txtHoursWorked.TabIndex = 6;
            // 
            // txtTotalMonthly
            // 
            this.txtTotalMonthly.Location = new System.Drawing.Point(186, 207);
            this.txtTotalMonthly.Name = "txtTotalMonthly";
            this.txtTotalMonthly.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMonthly.TabIndex = 7;
            // 
            // txtSalesBonus
            // 
            this.txtSalesBonus.Location = new System.Drawing.Point(186, 251);
            this.txtSalesBonus.Name = "txtSalesBonus";
            this.txtSalesBonus.ReadOnly = true;
            this.txtSalesBonus.Size = new System.Drawing.Size(100, 20);
            this.txtSalesBonus.TabIndex = 8;
            // 
            // lblTotalBonus
            // 
            this.lblTotalBonus.AutoSize = true;
            this.lblTotalBonus.Location = new System.Drawing.Point(76, 251);
            this.lblTotalBonus.Name = "lblTotalBonus";
            this.lblTotalBonus.Size = new System.Drawing.Size(66, 13);
            this.lblTotalBonus.TabIndex = 9;
            this.lblTotalBonus.Text = "Sales Bonus";
            // 
            // grpLang
            // 
            this.grpLang.Controls.Add(this.rdoSpanish);
            this.grpLang.Controls.Add(this.rdoFrench);
            this.grpLang.Controls.Add(this.rdoEnglish);
            this.grpLang.Location = new System.Drawing.Point(12, 298);
            this.grpLang.Name = "grpLang";
            this.grpLang.Size = new System.Drawing.Size(200, 100);
            this.grpLang.TabIndex = 10;
            this.grpLang.TabStop = false;
            this.grpLang.Text = "Languages";
            // 
            // rdoSpanish
            // 
            this.rdoSpanish.AutoSize = true;
            this.rdoSpanish.Location = new System.Drawing.Point(7, 67);
            this.rdoSpanish.Name = "rdoSpanish";
            this.rdoSpanish.Size = new System.Drawing.Size(63, 17);
            this.rdoSpanish.TabIndex = 2;
            this.rdoSpanish.TabStop = true;
            this.rdoSpanish.Text = "Spanish";
            this.rdoSpanish.UseVisualStyleBackColor = true;
            this.rdoSpanish.CheckedChanged += new System.EventHandler(this.rdoSpanish_CheckedChanged);
            // 
            // rdoFrench
            // 
            this.rdoFrench.AutoSize = true;
            this.rdoFrench.Location = new System.Drawing.Point(7, 44);
            this.rdoFrench.Name = "rdoFrench";
            this.rdoFrench.Size = new System.Drawing.Size(58, 17);
            this.rdoFrench.TabIndex = 1;
            this.rdoFrench.Text = "French";
            this.rdoFrench.UseVisualStyleBackColor = true;
            this.rdoFrench.CheckedChanged += new System.EventHandler(this.rdoFrench_CheckedChanged);
            // 
            // rdoEnglish
            // 
            this.rdoEnglish.AutoSize = true;
            this.rdoEnglish.Checked = true;
            this.rdoEnglish.Location = new System.Drawing.Point(7, 20);
            this.rdoEnglish.Name = "rdoEnglish";
            this.rdoEnglish.Size = new System.Drawing.Size(59, 17);
            this.rdoEnglish.TabIndex = 0;
            this.rdoEnglish.TabStop = true;
            this.rdoEnglish.Text = "English";
            this.rdoEnglish.UseVisualStyleBackColor = true;
            this.rdoEnglish.CheckedChanged += new System.EventHandler(this.rdoEnglish_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exam_AdamBrennan_82094_.Properties.Resources.mailOrder;
            this.pictureBox1.Location = new System.Drawing.Point(399, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 230);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(279, 342);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(389, 342);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(502, 342);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmMailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpLang);
            this.Controls.Add(this.lblTotalBonus);
            this.Controls.Add(this.txtSalesBonus);
            this.Controls.Add(this.txtTotalMonthly);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTotalMonthly);
            this.Controls.Add(this.lblTotalHours);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblName);
            this.Name = "frmMailOrder";
            this.Text = "Welcome To The Form!";
            this.grpLang.ResumeLayout(false);
            this.grpLang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.Label lblTotalMonthly;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.TextBox txtTotalMonthly;
        private System.Windows.Forms.TextBox txtSalesBonus;
        private System.Windows.Forms.Label lblTotalBonus;
        private System.Windows.Forms.GroupBox grpLang;
        private System.Windows.Forms.RadioButton rdoFrench;
        private System.Windows.Forms.RadioButton rdoEnglish;
        private System.Windows.Forms.RadioButton rdoSpanish;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrint;
    }
}

