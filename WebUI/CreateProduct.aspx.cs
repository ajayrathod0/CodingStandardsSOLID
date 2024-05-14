using BusinessAccessLayer;
using DataAccessLayer;
using Models;
using System;
using System.IO;


namespace WebUI
{
    public partial class CreateProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            string imageVirtualPath = string.Empty;

            if (imgFile.HasFile)
            {
                string imageFolderPath = Server.MapPath("~/Images");
                string filename = imgFile.FileName;

                string path = Path.Combine(imageFolderPath, filename);

                imgFile.SaveAs(path);
                imageVirtualPath = $"~/Images/{filename}";
            }

            Product product = new Product()
            {
                Name = name,
                Price = price,
                ImagePath = imageVirtualPath
            };

            ProductBL bl = new ProductBL(new ProductDB());
            bool status = bl.CreateProduct(product);
            if (status)
            {
                lblMessage.Text = "Product Created Successfully";
            }
            else
            {
                lblMessage.Text = "Product Created failed";
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
        }
    }
}