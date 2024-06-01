using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_nhom3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm tạo mật khẩu ngẫu nhiên
        private string GenerateRandomPassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
            StringBuilder password = new StringBuilder();
            Random rnd = new Random();

            while (0 < length--)
            {
                password.Append(validChars[rnd.Next(validChars.Length)]);
            }

            return password.ToString();
        }

        private void btngui_Click(object sender, EventArgs e)

        {
            // Ẩn màn hình đen của ChromeDriver
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            // Khởi tạo trình duyệt Chrome
            IWebDriver driver = new ChromeDriver(chrome);
            driver.Navigate().GoToUrl(txta.Text);

            try
            {
                // Bước 2: Điều hướng đến trang đăng ký
                driver.FindElement(By.LinkText("My Account")).Click();
                Thread.Sleep(2000);

                // Bước 3: Điền thông tin đăng ký
                string email = "42_MaNguyenNhatTan" + DateTime.Now.Ticks + "@gmail.com"; // Sử dụng email duy nhất mỗi lần
                string password = GenerateRandomPassword(0);

                // Hiển thị email và mật khẩu lên Form
                txtemail.Text = email;
                txtpassword.Text = password;

                IWebElement registerEmailBox = driver.FindElement(By.Id("reg_email"));
                IWebElement registerPasswordBox = driver.FindElement(By.Id("reg_password"));
                IWebElement registerButton = driver.FindElement(By.Name("register"));

                registerEmailBox.SendKeys(email);
                registerPasswordBox.SendKeys(password);
                registerButton.Click();

                Thread.Sleep(5000); // Chờ quá trình đăng ký hoàn tất

                // Bước 4: Đăng xuất
                driver.FindElement(By.LinkText("Sign out")).Click();
                Thread.Sleep(2000);

                // Bước 5: Đăng nhập lại với tài khoản đã đăng ký
                IWebElement loginEmailBox = driver.FindElement(By.Id("username"));
                IWebElement loginPasswordBox = driver.FindElement(By.Id("password"));
                IWebElement loginButton = driver.FindElement(By.Name("login"));

                loginEmailBox.SendKeys(email);
                loginPasswordBox.SendKeys(password);
                loginButton.Click();

                Thread.Sleep(5000); // Chờ quá trình đăng nhập hoàn tất

                // Bước 6: Điều hướng đến shop
                driver.FindElement(By.LinkText("Shop")).Click(); 
                 driver.FindElement(By.Id("site-logo")).Click();
                Thread.Sleep(2000);

                // bước 7

            }
            finally
            {
                // Đóng trình duyệt
                driver.Quit(); 
            }
            /* // Tạo một phiên bản mới của ChromeDriver và ẩn cửa sổ dòng lệnh
             ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
             chrome.HideCommandPromptWindow = true;
             IWebDriver driver = new ChromeDriver(chrome);

             // Điều hướng tới URL
             driver.Navigate().GoToUrl(new Uri("https://practice.automationtesting.in/"));

             // Tìm phần tử ô tìm kiếm bằng id
             IWebElement searchBox = driver.FindElement(By.Id("s"));

             // Nhập từ khóa tìm kiếm vào ô tìm kiếm
             searchBox.SendKeys("ANDROID");

             // Gửi từ khóa tìm kiếm (ấn Enter)
             searchBox.SendKeys(OpenQA.Selenium.Keys.Enter);

             // Đợi một chút để trang tải kết quả
             System.Threading.Thread.Sleep(2000);

             // Lấy danh sách kết quả tìm kiếm (ví dụ: tên sách, sản phẩm)
             var results = driver.FindElements(By.CssSelector("products masonry-done"));

             // Đóng trình duyệt
             driver.Quit(); */
            //-----------------------------
            /* // Khởi tạo trình duyệt
            IWebDriver driver_22_NguyenThiThanhMai = new ChromeDriver();

            // Mở trình duyệt và đi tới URL
            driver_22_NguyenThiThanhMai.Navigate().GoToUrl("http://practice.automationtesting.in/");

            // Nhấp vào Menu Cửa hàng
            IWebElement store_menu_22_NguyenThiThanhMai = driver_22_NguyenThiThanhMai.FindElement(By.LinkText("Shop"));
            store_menu_22_NguyenThiThanhMai.Click();

            // Chọn danh mục cụ thể (ví dụ: "HTML")
            string categoryName = "HTML";
            IWebElement category_link = driver_22_NguyenThiThanhMai.FindElement(By.LinkText(categoryName));
            category_link.Click();
            // Đóng trình duyệt
            driver_22_NguyenThiThanhMai.Quit(); */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
