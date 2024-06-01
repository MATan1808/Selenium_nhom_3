using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Keys = OpenQA.Selenium.Keys;
namespace Selenium_46_NguyenPhuocTho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_46_NguyenPhuocTho_Click(object sender, EventArgs e)
        {
            
            ///////////////////////////////////////////////////////////////////////
            //tắt màn hình đen
            ChromeDriverService chrome_46NguyenPhuocTho = ChromeDriverService.CreateDefaultService();
            chrome_46NguyenPhuocTho.HideCommandPromptWindow = true;
            ////dieu huong trinh duyet
        
            //
            IWebDriver driver_46NguyenPhuocTho = new ChromeDriver(chrome_46NguyenPhuocTho);
            driver_46NguyenPhuocTho.Navigate().GoToUrl("https://practice.automationtesting.in/");
            
            // XPath thêm vài giỏ hàng
            driver_46NguyenPhuocTho.FindElement(By.XPath("//*[@id=\"text-22-sub_row_1-0-2-0-0\"]/div/ul/li/a[2]")).Click();
            //// đợi load dl
            System.Threading.Thread.Sleep(1000);
            driver_46NguyenPhuocTho.FindElement(By.XPath("//*[@id=\"text-22-sub_row_1-0-2-1-0\"]/div/ul/li/a[2]")).Click();

            //thêm vào giỏ hàng nhiều lần xem có lỗi

            //for (int i = 0; i < 60; i++)
            //{
            //    driver_46NguyenPhuocTho.FindElement(By.XPath("//*[@id=\"text-22-sub_row_1-0-2-0-0\"]/div/ul/li/a[2]")).Click();
            //    driver_46NguyenPhuocTho.FindElement(By.XPath("//*[@id=\"text-22-sub_row_1-0-2-1-0\"]/div/ul/li/a[2]")).Click();
            //    driver_46NguyenPhuocTho.FindElement(By.XPath("//*[@id=\"text-22-sub_row_1-0-2-2-0\"]/div/ul/li/a[2]")).Click();
            //}
            ////
            /////Nếu giỏ hàng không có gì thì đứa đến trang shop ngược lại thì đưa đến trang basket
            //driver_46NguyenPhuocTho.FindElement(By.ClassName("wpmenucart-contents")).Click();
            // nhiều lần ko lỗi
            //for (int i = 0; i < 60; i++)
            //{
            //    driver_46NguyenPhuocTho.FindElement(By.ClassName("wpmenucart-contents")).Click();
            //}
            //Chọn Sản Phẩm ở Trang chủ->xem thông tin -> thêm vào giỏ hàng
            //driver_46NguyenPhuocTho.FindElement(By.ClassName("woocommerce-Price-currencySymbol")).Click();
            //driver_46NguyenPhuocTho.FindElement(By.ClassName("single_add_to_cart_button")).Click();
            //chọn trang shop-> thêm sp
            driver_46NguyenPhuocTho.FindElement(By.LinkText("Shop")).Click();
            driver_46NguyenPhuocTho.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[1]/a[2]")).Click();
            driver_46NguyenPhuocTho.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[2]/a[2]")).Click();
            driver_46NguyenPhuocTho.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[3]/a[2]")).Click();
            driver_46NguyenPhuocTho.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[4]/a[2]")).Click();
            driver_46NguyenPhuocTho.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[5]/a[2]")).Click();
            driver_46NguyenPhuocTho.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[6]/a[2]")).Click();
            driver_46NguyenPhuocTho.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[7]/a[2]")).Click();
            driver_46NguyenPhuocTho.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[8]/a[2]")).Click();
            //chọn trang shop -> xem thông tin sp ->thêm sản phẩm
           
            driver_46NguyenPhuocTho.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[1]/a[1]/img")).Click();
            driver_46NguyenPhuocTho.FindElement(By.ClassName("single_add_to_cart_button")).Click();

            ////--------------------------------------------- THANH TOÁN---------------------------
            // driver_46NguyenPhuocTho.FindElement(By.ClassName("wc-proceed-to-checkout")).Click();
            // //nhiều lần thì lỗi
            // //driver_46NguyenPhuocTho.FindElement(By.ClassName("wc-proceed-to-checkout")).Click();
            // //driver_46NguyenPhuocTho.FindElement(By.ClassName("wc-proceed-to-checkout")).Click();
            // driver_46NguyenPhuocTho.FindElement(By.Id("place_order")).Click();
            // //không nhập thông tin
            // //buộc nhập các thông tin sau:
            // //Billing First Name is a required field.
            // //Billing Last Name is a required field.
            // //Billing Email Address is a required field.
            // //Billing Phone is a required field.
            // //Billing Address is a required field.
            // //Billing Town / City is a required field.
            // //Billing Postcode / ZIP is a required field
            ////nhập thông tin first name
            // IWebElement FirstNameInput_46NguyenPhuocTho = driver_46NguyenPhuocTho.FindElement(By.Name("billing_first_name"));
            // FirstNameInput_46NguyenPhuocTho.SendKeys("46_NguyenPhuocTho");
            ////nhập thông tin last name
            // IWebElement LastNameInput_46NguyenPhuocTho = driver_46NguyenPhuocTho.FindElement(By.Name("billing_last_name"));
            // LastNameInput_46NguyenPhuocTho.SendKeys("46_NguyenPhuocTho");
            ////nhập thông tin company
            // IWebElement CompanyInput_46NguyenPhuocTho = driver_46NguyenPhuocTho.FindElement(By.Name("billing_company"));
            // CompanyInput_46NguyenPhuocTho.SendKeys("46_NguyenPhuocTho");
            ////nhập thông tin email
            // IWebElement EmailInput_46NguyenPhuocTho = driver_46NguyenPhuocTho.FindElement(By.Name("billing_email"));
            // EmailInput_46NguyenPhuocTho.SendKeys("46_NguyenPhuocTho@gmail.com");
            ////nhập thông tin sdt
            // IWebElement PhoneInput_46NguyenPhuocTho = driver_46NguyenPhuocTho.FindElement(By.Name("billing_phone"));
            // PhoneInput_46NguyenPhuocTho.SendKeys("4646464646");

            // //tên quốc gia

            // // Tìm và click vào phần tử input để mở danh sách kết quả
            // IWebElement inputElementQG_46NguyenPhuocTho = driver_46NguyenPhuocTho.FindElement(By.CssSelector("span.select2-chosen"));
            // inputElementQG_46NguyenPhuocTho.Click();

            // // Tìm và click vào phần tử "Albania" trong danh sách kết quả
            // IWebElement albaniaOption = driver_46NguyenPhuocTho.FindElement(By.CssSelector("li.select2-results-dept-0[role='presentation']:nth-child(3) div.select2-result-label"));
            // albaniaOption.Click();
            ////nhập thông tin địa chỉ
            // IWebElement AddressInput_46NguyenPhuocTho = driver_46NguyenPhuocTho.FindElement(By.Name("billing_address_1"));
            // AddressInput_46NguyenPhuocTho.SendKeys("46_Tho");
            ////nhập thông tin dia chi
            // IWebElement Address2Input_46NguyenPhuocTho = driver_46NguyenPhuocTho.FindElement(By.Name("billing_address_2"));
            // Address2Input_46NguyenPhuocTho.SendKeys("46_NguyenPhuocTho");
            ////nhập thông tin city
            // IWebElement CityInput_46NguyenPhuocTho = driver_46NguyenPhuocTho.FindElement(By.Name("billing_city"));
            // CityInput_46NguyenPhuocTho.SendKeys("4646464646");
            ////nhập thông tin state
            // IWebElement StateInput_46NguyenPhuocTho = driver_46NguyenPhuocTho.FindElement(By.Name("billing_state"));
            // StateInput_46NguyenPhuocTho.SendKeys("4646464646");
            ////nhập thông tin code
            // IWebElement PostcodeInput_46NguyenPhuocTho = driver_46NguyenPhuocTho.FindElement(By.Name("billing_postcode"));
            // PostcodeInput_46NguyenPhuocTho.SendKeys("464");
            ////Chọn radioButton Phương thức thanh toán
            // IWebElement CKradioButton_46_NguyenPhuocTho = driver_46NguyenPhuocTho.FindElement(By.Id("payment_method_cod"));
            // CKradioButton_46_NguyenPhuocTho.Click();
            // //IWebElement KTradioButton_46_NguyenPhuocTho = driver_46NguyenPhuocTho.FindElement(By.Id("payment_method_bacs"));
            // //KTradioButton_46_NguyenPhuocTho.Click();
            // //IWebElement GHradioButton_46_NguyenPhuocTho = driver_46NguyenPhuocTho.FindElement(By.Id("payment_method_cheque"));
            // //GHradioButton_46_NguyenPhuocTho.Click();
            // //IWebElement PPradioButton_46_NguyenPhuocTho = driver_46NguyenPhuocTho.FindElement(By.Id("payment_method_ppec_paypal"));
            // //PPradioButton_46_NguyenPhuocTho.Click();
            ////chọn Thanh toán
            //driver_46NguyenPhuocTho.FindElement(By.Id("place_order")).Click();






        }
    }
}
