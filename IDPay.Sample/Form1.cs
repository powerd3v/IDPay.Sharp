using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDPay.Sharp;

namespace IDPay.Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public IDClient client { get; set; }
        public Sharp.Data.Inquiry.Inquiry LastCreatedTransaction { get; set; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            client = new IDClient(txtApi.Text, cbSandBox.Checked);
            MessageBox.Show("Login Success!");
        }

        private async void btnCreatePayment_Click(object sender, EventArgs e)
        {
            try
            {
                var CreationResult = await client.Create_Payment(new Sharp.Data.Create.Create()
                {
                    amount = int.Parse(txtAmount.Text),
                    callback = txtCallBack.Text,
                    desc = txtDescription.Text,
                    mail = txtEmail.Text,
                    name = txtName.Text,
                    order_id = int.Parse(txtOrderId.Text),
                    phone = txtPhone.Text
                });
                txtResult.Text = $"کلید منحصر به فرد تراکنش : \r\n{CreationResult.id}\r\nلینک پرداخت برای انتقال خریدار به درگاه پرداخت : {CreationResult.link}";
                LastCreatedTransaction = new Sharp.Data.Inquiry.Inquiry()
                {
                    id = CreationResult.id,
                    order_id = txtOrderId.Text
                };
                btnAcceptTransaction.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// ارور های تراکنش رو اینجا نشون میده
            }
        }

        private async void btnGetLastTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                var Transaction = await client.Inquiry_Payment(new Sharp.Data.Inquiry.Inquiry()
                {
                    id = txtUniqKeyId.Text,
                    order_id = txtOrderIdTransaction.Text
                });
                dgvLastTransactionStatus.DataSource = Transaction;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnAcceptTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                var Accept = await client.Verify_Payment(LastCreatedTransaction);
                MessageBox.Show(Accept.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
