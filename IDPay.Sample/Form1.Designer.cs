
namespace IDPay.Sample
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSandBox = new System.Windows.Forms.CheckBox();
            this.txtApi = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCallBack = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAcceptTransaction = new System.Windows.Forms.Button();
            this.btnCreatePayment = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvLastTransactionStatus = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUniqKeyId = new System.Windows.Forms.TextBox();
            this.btnGetLastTransaction = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOrderIdTransaction = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastTransactionStatus)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 669);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbSandBox);
            this.tabPage1.Controls.Add(this.txtApi);
            this.tabPage1.Controls.Add(this.btnLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ورود";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "کلید ورود:";
            // 
            // cbSandBox
            // 
            this.cbSandBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSandBox.AutoSize = true;
            this.cbSandBox.Location = new System.Drawing.Point(262, 292);
            this.cbSandBox.Name = "cbSandBox";
            this.cbSandBox.Size = new System.Drawing.Size(73, 19);
            this.cbSandBox.TabIndex = 2;
            this.cbSandBox.Text = "سندباکس";
            this.cbSandBox.UseVisualStyleBackColor = true;
            // 
            // txtApi
            // 
            this.txtApi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApi.Location = new System.Drawing.Point(262, 263);
            this.txtApi.Name = "txtApi";
            this.txtApi.Size = new System.Drawing.Size(309, 23);
            this.txtApi.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Location = new System.Drawing.Point(496, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "ورود";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtResult);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtDescription);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtCallBack);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.txtPhone);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.txtAmount);
            this.tabPage2.Controls.Add(this.txtOrderId);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnAcceptTransaction);
            this.tabPage2.Controls.Add(this.btnCreatePayment);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ایجاد تراکنش";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 491);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "توضیحات تراکنش :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(276, 456);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(162, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "آدرس بازگشت به سایت پذیرنده :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 421);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(154, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "پست الکترونیک پرداخت کننده: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 518);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(133, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "تلفن همراه پرداخت کننده :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(41, 488);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(210, 50);
            this.txtDescription.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 486);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "نام پرداخت کننده : ";
            // 
            // txtCallBack
            // 
            this.txtCallBack.Location = new System.Drawing.Point(39, 453);
            this.txtCallBack.Name = "txtCallBack";
            this.txtCallBack.Size = new System.Drawing.Size(210, 23);
            this.txtCallBack.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(664, 451);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "مبلغ مورد نظر به ریال :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(39, 418);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(444, 515);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(201, 23);
            this.txtPhone.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(701, 418);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "شماره سفارش :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(444, 483);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 23);
            this.txtName.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(444, 448);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(201, 23);
            this.txtAmount.TabIndex = 2;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(444, 415);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(201, 23);
            this.txtOrderId.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(786, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAcceptTransaction
            // 
            this.btnAcceptTransaction.Enabled = false;
            this.btnAcceptTransaction.Location = new System.Drawing.Point(444, 556);
            this.btnAcceptTransaction.Name = "btnAcceptTransaction";
            this.btnAcceptTransaction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAcceptTransaction.Size = new System.Drawing.Size(201, 23);
            this.btnAcceptTransaction.TabIndex = 1;
            this.btnAcceptTransaction.Text = "تایید تراکنش";
            this.btnAcceptTransaction.UseVisualStyleBackColor = true;
            this.btnAcceptTransaction.Click += new System.EventHandler(this.btnAcceptTransaction_Click);
            // 
            // btnCreatePayment
            // 
            this.btnCreatePayment.Location = new System.Drawing.Point(41, 556);
            this.btnCreatePayment.Name = "btnCreatePayment";
            this.btnCreatePayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCreatePayment.Size = new System.Drawing.Size(214, 23);
            this.btnCreatePayment.TabIndex = 0;
            this.btnCreatePayment.Text = "ایجاد تراکنش";
            this.btnCreatePayment.UseVisualStyleBackColor = true;
            this.btnCreatePayment.Click += new System.EventHandler(this.btnCreatePayment_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvLastTransactionStatus);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 587);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "آخرین وضعیت یک تراکنش";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvLastTransactionStatus
            // 
            this.dgvLastTransactionStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLastTransactionStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLastTransactionStatus.Location = new System.Drawing.Point(3, 322);
            this.dgvLastTransactionStatus.Name = "dgvLastTransactionStatus";
            this.dgvLastTransactionStatus.RowTemplate.Height = 25;
            this.dgvLastTransactionStatus.Size = new System.Drawing.Size(786, 262);
            this.dgvLastTransactionStatus.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUniqKeyId);
            this.panel1.Controls.Add(this.btnGetLastTransaction);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtOrderIdTransaction);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 116);
            this.panel1.TabIndex = 8;
            // 
            // txtUniqKeyId
            // 
            this.txtUniqKeyId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUniqKeyId.Location = new System.Drawing.Point(184, 16);
            this.txtUniqKeyId.Name = "txtUniqKeyId";
            this.txtUniqKeyId.Size = new System.Drawing.Size(309, 23);
            this.txtUniqKeyId.TabIndex = 5;
            // 
            // btnGetLastTransaction
            // 
            this.btnGetLastTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetLastTransaction.Location = new System.Drawing.Point(318, 80);
            this.btnGetLastTransaction.Name = "btnGetLastTransaction";
            this.btnGetLastTransaction.Size = new System.Drawing.Size(75, 23);
            this.btnGetLastTransaction.TabIndex = 4;
            this.btnGetLastTransaction.Text = "استعلام";
            this.btnGetLastTransaction.UseVisualStyleBackColor = true;
            this.btnGetLastTransaction.Click += new System.EventHandler(this.btnGetLastTransaction_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(499, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "کلید منحصر بفرد تراکنش :";
            // 
            // txtOrderIdTransaction
            // 
            this.txtOrderIdTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrderIdTransaction.Location = new System.Drawing.Point(184, 51);
            this.txtOrderIdTransaction.Name = "txtOrderIdTransaction";
            this.txtOrderIdTransaction.Size = new System.Drawing.Size(309, 23);
            this.txtOrderIdTransaction.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "شماره سفارش پذیرنده :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(786, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Black;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtResult.ForeColor = System.Drawing.Color.White;
            this.txtResult.Location = new System.Drawing.Point(3, 588);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(786, 50);
            this.txtResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 669);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastTransactionStatus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtApi;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbSandBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreatePayment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCallBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvLastTransactionStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUniqKeyId;
        private System.Windows.Forms.Button btnGetLastTransaction;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOrderIdTransaction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAcceptTransaction;
        private System.Windows.Forms.TextBox txtResult;
    }
}

