namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxProductName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);
            ProductService productService = new ProductService();
            var affectedRows = productService.CreateNewProduct(name, price);
            string message = affectedRows > 0 ? "Başarılı" : "Başarısız";
            MessageBox.Show(message);
            EmailService emailService = new EmailService();
            emailService.SendInfoMail("ürün eklendi");
        }     

      

        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog()== DialogResult.OK)
            {
                BackColor = colorDialog.Color;
            }
        }


        /*
         * Her nesne sadece tek bir sorumluluğa sahip olmalı.
         * 
         * Bir nesnede değişiklik yapmak için birden fazla sebebiniz olursa; prensibi ihlal ediyorsunuz.
         */

    }
}
