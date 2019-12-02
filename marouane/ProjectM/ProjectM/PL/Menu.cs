using ProjectM.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectMarouane.PL
{
    public partial class Menu : Form
    {
        int mov, movX, movY;
        Provider provider=new Provider();
        Client clt =new Client();
        Category ct = new Category();
        SaleManagement sale = new SaleManagement();
        BuyingManagement buy = new BuyingManagement();
        int PanelH;
        bool hided;
        public Menu()
        {
            InitializeComponent();
          
            SidePanel1.Top = btnProdu.Top;
            SidePanel1.Height = btnProdu.Height;
           // WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.HOR_Positive);
            PanelH = panelRap.Height;
            hided = false;



        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
       
        
      
        private void BtnVente_Click(object sender, EventArgs e)
        {
          
           
        }

      
       
        private void BtnFournisseur_Click(object sender, EventArgs e)
        {
         
          
        }

      


        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

     
      

       

      

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
         
        }

       

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
                

            
          
        }

      
        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void btnProduit_Click_1(object sender, EventArgs e)
        {
            Product prd = new Product();
            prd.Show();
            
        }

        private void btnProduit_MouseHover(object sender, EventArgs e)
        {
            return;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Product prd = new Product();
            prd.Show();
        }

        private void btniClient_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Click_1(object sender, EventArgs e)
        {
            SidePanel1.Top = btnClt.Top;
            SidePanel1.Height = btnClt.Height;
            SidePanel1.Show();

            
            clt.Show();
        }

        private void btnVente_Click_1(object sender, EventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            SidePanel1.Top = btnV.Top;
            SidePanel1.Height = btnV.Height;
            SidePanel1.Show();
            
            sale.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            SidePanel1.Top = btn_frn.Top;
            SidePanel1.Height = btn_frn.Height;
            SidePanel1.Show();
            
            
            
           
            provider.Show();
        }

        private void btnClt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProdu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProdu_Click(object sender, EventArgs e)
        {
            panelParent.Controls.Clear();
            SidePanel1.Height = btnProdu.Height;
            SidePanel1.Top = btnProdu.Top;
            ListeProduit prd = new ListeProduit();
            prd.TopLevel = false;
            prd.AutoScroll = true;
            prd.Width = panelParent.Width;
            prd.Height = panelParent.Height;
            panelParent.Controls.Add(prd);
            prd.Show();
        }

        private void btnClt_Click(object sender, EventArgs e)
        {
            panelParent.Controls.Clear();
            SidePanel1.Height = btnClt.Height;
            SidePanel1.Top = btnClt.Top;
            
            ProjectMarouane.PL.Client clt = new Client();
            clt.TopLevel = false;
            clt.AutoScroll = true;
            clt.Width = panelParent.Width;
            clt.Height = panelParent.Height;
            
            panelParent.Controls.Add(clt);
            clt.Show();
        }

        private void SidePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void BtnHov_MouseHover(object sender, EventArgs e)
        {
            var btn = sender as Panel;
            btn.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        

        private void BtnLeave_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Panel;
            btn.BackColor = Color.Transparent;
        }

        private void btnAch_Click(object sender, EventArgs e)
        {
            panelParent.Controls.Clear();
            BuyingManagement buy = new BuyingManagement();
            SidePanel1.Top = btnAch.Top;
            SidePanel1.Height = btnAch.Height;
            buy.TopLevel = false;
            buy.AutoScroll = true;
            buy.Width = panelParent.Width;
            buy.Height = panelParent.Height;
            panelParent.Controls.Add(buy);
            
            buy.Show();
        }

        private void btn_frn_Click(object sender, EventArgs e)
        {

            panelParent.Controls.Clear();
            SidePanel1.Height = btn_frn.Height;
            SidePanel1.Top = btn_frn.Top;

            PL.Provider pro = new Provider();
            pro.TopLevel = false;
            pro.AutoScroll = true;
            pro.Width = panelParent.Width;
            pro.Height = panelParent.Height;
            panelParent.Controls.Add(pro);
            pro.Show();
        }

        private void PanelParent_ControlAdded(object sender, ControlEventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.HOR_Positive);
        }

        private void PanelParent_Enter(object sender, EventArgs e)
        {
            
        }
        string ss = "";//for test if is hided or not
        private void Button6_Click(object sender, EventArgs e)
        {
            if (hided) ss = "hide";
            else ss = "show";
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (hided)
            {
                panelRap.Height += 20;
                if (panelRap.Height >= PanelH)
                {
                    timer1.Stop();
                    hided = false;
                    this.Refresh();
                }
            }
            else
            {
                panelRap.Height -= 20;
                if (panelRap.Height <=0)
                {
                    timer1.Stop();
                    hided = true;
                    this.Refresh();
                }
            }
        }

        private void Button6_MouseHover(object sender, EventArgs e)
        {

            var btn = sender as Button;
            btn.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void Button6_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.BackColor = Color.Transparent;
        }

        private void Panel3_Click(object sender, EventArgs e)
        {
            SidePanel1.Top = panel3.Top;
            SidePanel1.Height = panel3.Height;
            panelParent.Controls.Clear();
            Gestion gestion = new Gestion();
            gestion.AutoScroll = true;
            gestion.TopLevel = false;
            gestion.Width = panelParent.Width;
            gestion.Height = panelParent.Height;
            panelParent.Controls.Add(gestion);
            gestion.Show();
        }

        private void Panel7_Click(object sender, EventArgs e)
        {
            SidePanel1.Top = panel7.Top;
            SidePanel1.Height = panel7.Height;
            ServiceMontage service = new ServiceMontage();
            service.Show();
            
        }

        private void Panel4_MouseClick(object sender, MouseEventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void Panel11_MouseClick(object sender, MouseEventArgs e)
        {
            Back_Up back_Up = new Back_Up();
            back_Up.ShowDialog();
        }

        private void Panel6_MouseClick(object sender, MouseEventArgs e)
        {
            SidePanel1.Top = panel6.Top;
            SidePanel1.Height = panel6.Height;
            Avoire av = new Avoire();
            av.Show();
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            panelParent.Controls.Clear();
            SidePanel1.Height = btnV.Height;
            SidePanel1.Top = btnV.Top;
            
            PL.SaleManagement sale = new SaleManagement();
            sale.TopLevel = false;
            sale.AutoScroll = true;
            sale.Width = panelParent.Width;
            sale.Height = panelParent.Height;
            panelParent.Controls.Add(sale);
            sale.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
           
            
            
            
        }

  
     

       
    }
}
