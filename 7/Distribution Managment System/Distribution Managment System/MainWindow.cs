using Distribution_Managment_System.BL;
using Distribution_Managment_System.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Distribution_Managment_System
{
    public partial class MainWindow : Form
    {
        Inventory_Supervisor Actor;
        private static Color colour;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private string nameofUser;
        public MainWindow(Inventory_Supervisor Actor)
        {
            InitializeComponent();
            random = new Random();
            this.Actor=Actor;
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnlTitleBar.BackColor = color;
                    pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    colour = color;
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlWindow.Controls.Add(childForm);
            this.pnlWindow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTtleBar.Text = childForm.Text;
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(8, 1, 51);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void btnUserDashboard_Click(object sender, EventArgs e)
        {
            Product_Dashboard frm = new Product_Dashboard(Actor);
            OpenChildForm(frm, sender);
            lblTtleBar.Text = "Products DashBoard";
            
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {

            
        }

        private void pnlWindow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainWinow_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            Application.Exit();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            ManageSupplier frm = new ManageSupplier(Actor);
            OpenChildForm(frm, sender);
            lblTtleBar.Text = "Supplier DashBoard";
        }

        private void pnlWindow_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
