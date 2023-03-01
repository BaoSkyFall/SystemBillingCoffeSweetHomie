using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CafeSweetHomie
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            //test
        }
        private const int cGrip = 16;
        private const int cCaption = 32;
        private bool isPrint = false;
        protected override void WndProc(ref Message m)
        {
            if(m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if(pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if(pos.X >= this.ClientSize.Width - cGrip && pos.Y>= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }


       

        private void tinhTien(object sender, EventArgs e)
        { //btnTotal
            if (txtDiscount.Text.Length > 0)
            {
                try
                {
                    double disCount = Convert.ToDouble(txtDiscount.Text);
                    if (disCount <= 100 && disCount >= 0)   
                    {

                    //Thuc Uong
                        double denda, suada, bacsiu, cafeSuaTuoi, chocolate, oreo, cafeDaXay, matcha,
                            camchanhday,sinhtodau,chanhtuyet,sinhtobo,sinhtoxoai,dauxoaicam,nuocepcam,nuocepchanh,chanhoi,chanhdao,chanhmatong,nuocepchanhday,
                            suachuadaxay,suachuavietquat,suachuadao,suachuadau,suachuachanhday,sodachanh,bluecucarao,sodadao,sodabacha,sodacam,
                            DamSoMiCutout, aoyemrenno, DamYen,QuanVayDapLyNapTui,AoBeoCo,trahoadaubiecmacchiato,DamCoYemDai,DamXoeCupNguc,
                            CVDenDangDai, SoMiPhi, AoDilysDen,DamSoMiCutoutDen,DamSoMiCutoutTrang,AoBlazerTaBauDen,DamSuongLongVu,ChanVayThietKeSieuDaiOmBodyChamGot,traliptonsua,travietquat,tracammatong,
                            tragungmatong,tralai,thuongtigerbac,thuongstrongbow,thuongbudweiser, updowntigerbac, updownstrongbow, updownbudweiser,dauphongrang,khogalachanh,comchaykhoga,daheo,banhtrang,magarita,deepsea,mojito;
                        //Toppinggggggggggg
                        double tranchauduongden, oreoTopping, planTrung, planchocolate, suongsao, thachphomai, macchiatoTopping, whippingCream;
                        //cafe Viet prices
                        denda = 25000; bacsiu = 29000; suada = 29000; cafeSuaTuoi = 25000;
                        if (checkIsMorning())
                        {
                            denda -= 5000; bacsiu -= 5000; suada -= 5000;
                            cafeSuaTuoi -= 5000;

                        }
                        //Da Xay
                        chocolate = 37000; oreo = 39000; cafeDaXay = 37000; matcha = 39000;
                        //Sinh To
                        camchanhday = 30000; sinhtodau = 30000; chanhtuyet = 30000; sinhtobo = 35000; sinhtoxoai = 30000; dauxoaicam = 30000;
                        //Nuoc Ep
                        nuocepcam= 30000;nuocepchanh= 25000; chanhoi= 30000; chanhdao = 30000; chanhmatong = 30000; nuocepchanhday = 30000;
                        //Sua Chua
                        suachuadaxay = 30000; suachuavietquat=30000; suachuadao= 30000; suachuadau= 30000; suachuachanhday = 30000;
                        //Soda
                        sodachanh =30000; bluecucarao= 30000; sodadao= 30000; sodabacha= 30000; sodacam = 30000;
                        //Tra
                        DamSoMiCutout = 265000; aoyemrenno = 175000; DamYen = 280000; QuanVayDapLyNapTui = 195000; AoBeoCo = 215000; 
                        trahoadaubiecmacchiato = 190000; DamCoYemDai = 250000; DamXoeCupNguc = 250000;
                        CVDenDangDai = 240000; SoMiPhi = 195000; AoDilysDen = 230000; DamSoMiCutoutDen = 265000; DamSoMiCutoutTrang = 265000; AoBlazerTaBauDen = 180000; 
                        DamSuongLongVu = 280000; ChanVayThietKeSieuDaiOmBodyChamGot = 240000; traliptonsua = 30000; travietquat = 35000; tracammatong = 35000;
                        tragungmatong = 30000; tralai = 30000;

                        //Toppinggggg
                        tranchauduongden = 7000; oreoTopping = 7000; planTrung = 5000; planchocolate = 5000; suongsao = 5000; thachphomai = 5000; macchiatoTopping = 7000; whippingCream = 7000;
                        //Beer Thuong
                        thuongtigerbac = 25000; thuongstrongbow = 30000; thuongbudweiser = 35000;
                        //Beer Updown
                        updowntigerbac = 43000; updownstrongbow = 49000; updownbudweiser = 53000;
                        //Do An Vat
                        dauphongrang = 20000; khogalachanh = 25000; comchaykhoga = 25000;daheo = 25000;banhtrang = 15000;
                        //Cocktail
                        magarita = 60000; deepsea = 55000;mojito = 55000;




                        
                        //Tra
                        double DamSoMiCutoutCof = Convert.ToDouble(txtMainDamSoMiCutout.Text);
                        double aoyemrennoCof = Convert.ToDouble(txtAoYemRenNo.Text);
                        double traolongmacchiatoCof = Convert.ToDouble(txtDamYen.Text);
                        double luctramacchiatoCof = Convert.ToDouble(txtQuanVayDapLyNapTui.Text);
                        double traxoaimacchiatoCof = Convert.ToDouble(txtAoBeoCo.Text);
                        double trahoadaubiecmacchiatoCof = Convert.ToDouble(txtDamCoYem3W.Text);
                        double trasuathaixanhCof = Convert.ToDouble(txtDamCoYemDai.Text);
                        double trahoadaubiecCof = Convert.ToDouble(txtDamXoeCupNguc.Text);
                        double trahoacucCof = Convert.ToDouble(txtCVDenDangDai.Text);
                        double trahoacuchatchiaCof = Convert.ToDouble(txtSoMiPhi.Text);
                        double trahoahongmatongCof = Convert.ToDouble(txtAoDilysDen.Text);
                        double tradaoCof = Convert.ToDouble(txtDenDamSoMiCutout.Text);
                        double tradaocamsaCof = Convert.ToDouble(txtTrangDamSoMiCutout.Text);
                        double travaihatchiaCof = Convert.ToDouble(txtAoBlazerTaBauDen.Text);
                        double travaiduahauCof = Convert.ToDouble(txtDamSuongLongVu.Text);
                        double traliptonchanhCof = Convert.ToDouble(txtChanVayThietKeSieuDaiOmBodyChamGot.Text);
                      
            
                       
                 



                        //Cafe eat_in_cafe = new Cafe(denDaCof, suaDaCof, bacSiuCof, cafeSuaTuoiCof,cofCake,redValvet,bForest,bostonCream,lagosChoco,kilbChoco,cheeseCak,rainbow);
                        var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");


                        double drinkCosts =
                            (DamSoMiCutout * DamSoMiCutoutCof) + (aoyemrenno * aoyemrennoCof) + (traolongmacchiatoCof * DamYen) + (QuanVayDapLyNapTui * luctramacchiatoCof)
                            + (traxoaimacchiatoCof * AoBeoCo) + (trahoadaubiecmacchiato * trahoadaubiecmacchiatoCof) + (DamCoYemDai * trasuathaixanhCof) + (DamXoeCupNguc * trahoadaubiecCof)
                            + (CVDenDangDai * trahoacucCof) + (SoMiPhi * trahoacuchatchiaCof) + (AoDilysDen * trahoahongmatongCof) + (DamSoMiCutoutDen * tradaoCof)
                             + (DamSoMiCutoutTrang * tradaocamsaCof) + (AoBlazerTaBauDen * travaihatchiaCof) + (DamSuongLongVu * travaiduahauCof) + (ChanVayThietKeSieuDaiOmBodyChamGot * traliptonchanhCof);
                              
                        lblDrinkCost.Text = Convert.ToString(drinkCosts);
     

                        //double svcCharge = Math.Round(Convert.ToDouble(lblPhiDichVu.Text));
                        double svcCharge = 0;
                        lblChietKhau.Text = Convert.ToString(drinkCosts + svcCharge);
                        lblKhuyenMai.Text = Convert.ToString(disCount);
                        double totalAftTax = Math.Round(Convert.ToDouble(lblKhuyenMai.Text));
                        double total = (drinkCosts + svcCharge) * ((100 - totalAftTax) / 100);

                        lblDrinkCost.Text = String.Format(info, "{0:#,#.}", drinkCosts) + " đ";
                        lblChietKhau.Text = String.Format("{0:#,0}", ( drinkCosts + svcCharge) * ((totalAftTax) / 100)) + " đ";
                        lblKhuyenMai.Text = lblKhuyenMai.Text + " %";
                        lblTotal.Text = String.Format("{0:#,0}", ( drinkCosts + svcCharge) * ((100 - totalAftTax) / 100)) + " đ";


                        rtfReceipt.Clear();

                        // rtfReceipt.AppendText(Environment.NewLine);
                        rtfReceipt.AppendText("---------------------------------------------------------" + Environment.NewLine);
                        rtfReceipt.AppendText("\t   " + "Retinol House" + Environment.NewLine);
                        rtfReceipt.AppendText("---------------------------------------------------------" + Environment.NewLine);
                        //rtfReceipt.AppendText("Tên\tSố lượng\tĐơn giá\tTổng cộng" + Environment.NewLine);
                        rtfReceipt.AppendText("Sản Phẩm/SL\t");
                        rtfReceipt.AppendText("Đơn giá\t");
                        rtfReceipt.AppendText("   Tổng cộng" + Environment.NewLine);

                       
                        //Trà
                        if (txtMainDamSoMiCutout.Text != "0")
                        {
                            rtfReceipt.AppendText("Đầm Sơ Mi Cutout" + Environment.NewLine + txtMainDamSoMiCutout.Text + "\t\t" + string.Format("{0:#,0}", DamSoMiCutout) + "\t   " + string.Format("{0:#,0}", DamSoMiCutoutCof * DamSoMiCutout) + " đ" + Environment.NewLine);

                        }
                        if (txtAoYemRenNo.Text != "0")
                        {
                            rtfReceipt.AppendText("Áo Yếm Ren Nơ" + Environment.NewLine + txtAoYemRenNo.Text + "\t\t" + string.Format("{0:#,0}", aoyemrenno) + "\t   " + string.Format("{0:#,0}", aoyemrennoCof * aoyemrenno) + " đ" + Environment.NewLine);

                        }
                        if (txtDamYen.Text != "0")
                        {
                            rtfReceipt.AppendText("Đầm Yếm" + Environment.NewLine + txtDamYen.Text + "\t\t" + string.Format("{0:#,0}", DamYen) + "\t   " + string.Format("{0:#,0}", traolongmacchiatoCof * DamYen) + " đ" + Environment.NewLine);

                        }
                        if (txtQuanVayDapLyNapTui.Text != "0")
                        {
                            rtfReceipt.AppendText("Quần Váy Dập Ly Nắp Túi" + Environment.NewLine + txtQuanVayDapLyNapTui.Text + "\t\t" + string.Format("{0:#,0}", QuanVayDapLyNapTui) + "\t   " + string.Format("{0:#,0}", luctramacchiatoCof * QuanVayDapLyNapTui) + " đ" + Environment.NewLine);

                        }
                        if (txtAoBeoCo.Text != "0")
                        {
                            rtfReceipt.AppendText("Áo Bèo Cổ" + Environment.NewLine + txtAoBeoCo.Text + "\t\t" + string.Format("{0:#,0}", AoBeoCo) + "\t   " + string.Format("{0:#,0}", traxoaimacchiatoCof * AoBeoCo) + " đ" + Environment.NewLine);

                        }
                        if (txtDamCoYem3W.Text != "0")
                        {
                            rtfReceipt.AppendText("Đầm Cổ YẾM 3W" + Environment.NewLine + txtDamCoYem3W.Text + "\t\t" + string.Format("{0:#,0}", trahoadaubiecmacchiato) + "\t   " + string.Format("{0:#,0}", trahoadaubiecmacchiatoCof * trahoadaubiecmacchiato) + " đ" + Environment.NewLine);

                        }

                        if (txtDamCoYemDai.Text != "0")
                        {
                            rtfReceipt.AppendText("Đầm Cổ Yếm Dài" + Environment.NewLine + txtDamCoYemDai.Text + "\t\t" + string.Format("{0:#,0}", DamCoYemDai) + "\t   " + string.Format("{0:#,0}", trasuathaixanhCof * DamCoYemDai) + " đ" + Environment.NewLine);

                        }
                        if (txtDamXoeCupNguc.Text != "0")
                        {
                            rtfReceipt.AppendText("Đầm Xòe Cúp Ngực" + Environment.NewLine + txtDamXoeCupNguc.Text + "\t\t" + string.Format("{0:#,0}", DamXoeCupNguc) + "\t   " + string.Format("{0:#,0}", trahoadaubiecCof * DamXoeCupNguc) + " đ" + Environment.NewLine);

                        }
                        if (txtCVDenDangDai.Text != "0")
                        {
                            rtfReceipt.AppendText("CV Đen Dáng Dài" + Environment.NewLine + txtCVDenDangDai.Text + "\t\t" + string.Format("{0:#,0}", CVDenDangDai) + "\t   " + string.Format("{0:#,0}", trahoacucCof * CVDenDangDai) + " đ" + Environment.NewLine);

                        }
                        if (txtSoMiPhi.Text != "0")
                        {
                            rtfReceipt.AppendText("Sơ Mi Phi" + Environment.NewLine + txtSoMiPhi.Text + "\t\t" + string.Format("{0:#,0}", SoMiPhi) + "\t   " + string.Format("{0:#,0}", trahoacuchatchiaCof * SoMiPhi) + " đ" + Environment.NewLine);

                        }
                        if (txtAoDilysDen.Text != "0")
                        {
                            rtfReceipt.AppendText("Áo Dilys Đen" + Environment.NewLine + txtAoDilysDen.Text + "\t\t" + string.Format("{0:#,0}", AoDilysDen) + "\t   " + string.Format("{0:#,0}", trahoahongmatongCof * AoDilysDen) + " đ" + Environment.NewLine);

                        }

                        if (txtDenDamSoMiCutout.Text != "0")
                        {
                            rtfReceipt.AppendText("Đầm Sơ Mi Cutout Đen" + Environment.NewLine + txtDenDamSoMiCutout.Text + "\t\t" + string.Format("{0:#,0}", DamSoMiCutoutDen) + "\t   " + string.Format("{0:#,0}", tradaoCof * DamSoMiCutoutDen) + " đ" + Environment.NewLine);

                        }
                        if (txtTrangDamSoMiCutout.Text != "0")
                        {
                            rtfReceipt.AppendText("Đầm Sơ Mi Cutout Trắng" + Environment.NewLine + txtTrangDamSoMiCutout.Text + "\t\t" + string.Format("{0:#,0}", DamSoMiCutoutTrang) + "\t   " + string.Format("{0:#,0}", tradaocamsaCof * DamSoMiCutoutTrang) + " đ" + Environment.NewLine);

                        }
                        if (txtAoBlazerTaBauDen.Text != "0")
                        {
                            rtfReceipt.AppendText("Blazer Tà Bầu Đen" + Environment.NewLine + txtAoBlazerTaBauDen.Text + "\t\t" + string.Format("{0:#,0}", AoBlazerTaBauDen) + "\t   " + string.Format("{0:#,0}", travaihatchiaCof * AoBlazerTaBauDen) + " đ" + Environment.NewLine);

                        }
                    
                        if (txtDamSuongLongVu.Text != "0")
                        {
                            rtfReceipt.AppendText("Đầm Suông Lông Vũ" + Environment.NewLine + txtDamSuongLongVu.Text + "\t\t" + string.Format("{0:#,0}", DamSuongLongVu) + "\t   " + string.Format("{0:#,0}", travaiduahauCof * DamSuongLongVu) + " đ" + Environment.NewLine);

                        }
                        if (txtChanVayThietKeSieuDaiOmBodyChamGot.Text != "0")
                        {
                            rtfReceipt.AppendText("Chân Váy Dài Ôm Body" + Environment.NewLine + txtChanVayThietKeSieuDaiOmBodyChamGot.Text + "\t\t" + string.Format("{0:#,0}", ChanVayThietKeSieuDaiOmBodyChamGot) + "\t   " + string.Format("{0:#,0}", traliptonchanhCof * ChanVayThietKeSieuDaiOmBodyChamGot) + " đ" + Environment.NewLine);

                        }

                        if (totalAftTax != 0)
                        {
                            rtfReceipt.AppendText("---------------------------------------------------------" + Environment.NewLine);
                            rtfReceipt.AppendText("Khuyến Mãi \t\t   " + lblKhuyenMai.Text + Environment.NewLine);
                            rtfReceipt.AppendText("Chiết Khấu \t\t   -" + String.Format("{0:#,0}", (drinkCosts + svcCharge) * ((totalAftTax) / 100)) + " đ" + Environment.NewLine);
                        }

                        rtfReceipt.AppendText("---------------------------------------------------------" + Environment.NewLine);
                        rtfReceipt.AppendText("Tổng Tiền \t\t   " + String.Format("{0:#,0}", ( drinkCosts + svcCharge) * ((100 - totalAftTax) / 100)) + " đ" + Environment.NewLine);
                        rtfReceipt.AppendText("---------------------------------------------------------" + Environment.NewLine);
                        rtfReceipt.AppendText(lblDate.Text + "\t" + lblTimer.Text  + Environment.NewLine + Environment.NewLine + Environment.NewLine);

                        rtfReceipt.AppendText("Instagram: retinol.house99" + Environment.NewLine);
                        rtfReceipt.AppendText("Facebook: Retinol House" + Environment.NewLine);
                        rtfReceipt.AppendText("Địa chỉ: Sài Gòn - Bình Phước" + Environment.NewLine);
                        rtfReceipt.AppendText("Hotline: 0355220035" + Environment.NewLine);
                        rtfReceipt.AppendText("---------------------------------------------------------" + Environment.NewLine);
                        rtfReceipt.AppendText("Cảm ơn bạn đã lựa chọn chúng mình \ntrong vô vàng chọn lựa ^^" + Environment.NewLine);


                        Image img = Image.FromFile("/images/logo.jpg");
                        Clipboard.SetImage(img);
                        rtfReceipt.Paste();
                        rtfReceipt.Focus();
                    }
                }
                catch (Exception)
                {

                }

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            timer1.Start();
            timer2.Start();


            lblDrinkCost.Text = "0";
            lblChietKhau.Text = "0";
            lblKhuyenMai.Text = "0";
            lblTotal.Text = "0";







            rtfReceipt.Clear();

        }

      





        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            float x = 10;
            float y = 0;


            // Draw rectangle to screen.
            // Draw string to screen.
            e.Graphics.DrawString(rtfReceipt.Text, new Font(new System.Drawing.FontFamily("UTM Alexander"), Convert.ToSingle(11)), Brushes.Black, x, y);
            //e.Graphics.DrawString(rtfReceipt.Text, new Font(new System.Drawing.FontFamily("UTM Alexander"), Convert.ToSingle(22)), Brushes.Black, 20, 20);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            tinhTien(null, e);
            string total = lblTotal.Text;
            string totalDrink = lblDrinkCost.Text;


                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("72 x 5000 mm", 284, 5000);
                printPreviewDialog1.Document = printDocument1;

                printDocument1.Print();
                //printDocument1.Print();

            //if (txtDiscount.Text != "100" || txtDiscount.Text != "1000" || txtDiscount.Text != "10000")
            //{
            //    printDocument1.Print();

            //}
            this.isPrint = true;
            
            //printDocument1.DefaultPageSettings.PaperSize = new PaperSize("72 x 5000 mm", 284, 5000);
            //printPreviewDialog1.Document = printDocument1;
            //(printPreviewDialog1 as Form).WindowState = FormWindowState.Maximized;
            //printPreviewDialog1.ShowDialog();

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //this code will open text files
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtfReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //this code will save text files
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";


            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }

        private void rtfReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblSubTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }

        private void chkEspresso_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
        }

        private void checkedChangeLabel(object sender, EventArgs e)
        {
            String label = (sender as CheckBox).Text;
            string name = (sender as CheckBox).Name;
            //Cafe Viet
           
            //Trà
             if (name == "chkMainDamSoMiCutout")
            {
                if (chkMainDamSoMiCutout.Checked == true)
                {
                    txtMainDamSoMiCutout.Enabled = true;
                    txtMainDamSoMiCutout.Text = "1";

                }
                else
                {
                    txtMainDamSoMiCutout.Enabled = false;
                    txtMainDamSoMiCutout.Text = "0";
                }
            }
            else if (label == "Áo Yếm Ren Nơ")
            {
                if (chkAoYemRenNo.Checked == true)
                {
                    txtAoYemRenNo.Enabled = true;
                    txtAoYemRenNo.Text = "1";

                }
                else
                {
                    txtAoYemRenNo.Enabled = false;
                    txtAoYemRenNo.Text = "0";
                }
            }
            else if (label == "Đầm Yếm")
            {
                if (chkDamYen.Checked == true)
                {
                    txtDamYen.Enabled = true;
                    txtDamYen.Text = "1";

                }
                else
                {
                    txtDamYen.Enabled = false;
                    txtDamYen.Text = "0";
                }
            }
            else if (label == "Quần Váy Dập Ly Nắp Túi")
            {
                if (chkQuanVayDapLyNapTui.Checked == true)
                {
                    txtQuanVayDapLyNapTui.Enabled = true;
                    txtQuanVayDapLyNapTui.Text = "1";

                }
                else
                {
                    txtQuanVayDapLyNapTui.Enabled = false;
                    txtQuanVayDapLyNapTui.Text = "0";
                }
            }
            else if (label == "Áo Bèo Cổ")
            {
                if (chkAoBeoCo.Checked == true)
                {
                    txtAoBeoCo.Enabled = true;
                    txtAoBeoCo.Text = "1";

                }
                else
                {
                    txtAoBeoCo.Enabled = false;
                    txtAoBeoCo.Text = "0";
                }
            }
            else if (name == "chkDamCoYem3W")
            {
                if (chkDamCoYem3W.Checked == true)
                {
                    txtDamCoYem3W.Enabled = true;
                    txtDamCoYem3W.Text = "1";

                }
                else
                {
                    txtDamCoYem3W.Enabled = false;
                    txtDamCoYem3W.Text = "0";
                }
            }
            else if (label == "Đầm Cổ Yếm Dài")
            {
                if (chkDamCoYemDai.Checked == true)
                {
                    txtDamCoYemDai.Enabled = true;
                    txtDamCoYemDai.Text = "1";

                }
                else
                {
                    txtDamCoYemDai.Enabled = false;
                    txtDamCoYemDai.Text = "0";
                }
            }
            else if (name == "chkDamXoeCupNguc")
            {
                if (chkDamXoeCupNguc.Checked == true)
                {
                    txtDamXoeCupNguc.Enabled = true;
                    txtDamXoeCupNguc.Text = "1";

                }
                else
                {
                    txtDamXoeCupNguc.Enabled = false;
                    txtDamXoeCupNguc.Text = "0";
                }
            }
            else if (name == "chkCVDenDangDai")
            {
                if (chkCVDenDangDai.Checked == true)
                {
                    txtCVDenDangDai.Enabled = true;
                    txtCVDenDangDai.Text = "1";

                }
                else
                {
                    txtCVDenDangDai.Enabled = false;
                    txtCVDenDangDai.Text = "0";
                }
            }
            else if (name == "chkSoMiPhi")
            {
                if (chkSoMiPhi.Checked == true)
                {
                    txtSoMiPhi.Enabled = true;
                    txtSoMiPhi.Text = "1";

                }
                else
                {
                    txtSoMiPhi.Enabled = false;
                    txtSoMiPhi.Text = "0";
                }
            }
            else if (name == "chkAoDilysDen")
            {
                if (chkAoDilysDen.Checked == true)
                {
                    txtAoDilysDen.Enabled = true;
                    txtAoDilysDen.Text = "1";

                }
                else
                {
                    txtAoDilysDen.Enabled = false;
                    txtAoDilysDen.Text = "0";
                }
            }
            else if (name == "chkDenDamSoMiCutout")
            {
                if (chkDenDamSoMiCutout.Checked == true)
                {
                    txtDenDamSoMiCutout.Enabled = true;
                    txtDenDamSoMiCutout.Text = "1";

                }
                else
                {
                    txtDenDamSoMiCutout.Enabled = false;
                    txtDenDamSoMiCutout.Text = "0";
                }
            }
            else if (name == "txtTrangDamSoMiCutout")
            {
                if (chkTrangDamSoMiCutout.Checked == true)
                {
                    txtTrangDamSoMiCutout.Enabled = true;
                    txtTrangDamSoMiCutout.Text = "1";

                }
                else
                {
                    txtTrangDamSoMiCutout.Enabled = false;
                    txtTrangDamSoMiCutout.Text = "0";
                }
            }
            else if (name == "chkAoBlazerTaBauDen")
            {
                if (chkAoBlazerTaBauDen.Checked == true)
                {
                    txtAoBlazerTaBauDen.Enabled = true;
                    txtAoBlazerTaBauDen.Text = "1";

                }
                else
                {
                    txtAoBlazerTaBauDen.Enabled = false;
                    txtAoBlazerTaBauDen.Text = "0";
                }
            }
            else if (name == "chkDamSuongLongVu")
            {
                if (chkDamSuongLongVu.Checked == true)
                {
                    txtDamSuongLongVu.Enabled = true;
                    txtDamSuongLongVu.Text = "1";

                }
                else
                {
                    txtDamSuongLongVu.Enabled = false;
                    txtDamSuongLongVu.Text = "0";
                }
            }
            else if (name == "chkChanVayThietKeSieuDaiOmBodyChamGot")
            {
                if (chkChanVayThietKeSieuDaiOmBodyChamGot.Checked == true)
                {
                    txtChanVayThietKeSieuDaiOmBodyChamGot.Enabled = true;
                    txtChanVayThietKeSieuDaiOmBodyChamGot.Text = "1";

                }
                else
                {
                    txtChanVayThietKeSieuDaiOmBodyChamGot.Enabled = false;
                    txtChanVayThietKeSieuDaiOmBodyChamGot.Text = "0";
                }
            }
           
           
            //End
        }



        private void plus_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Name;
           
            //TraAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
             if (s.Contains("MainDamSoMiCutout"))
            {
                if (!chkMainDamSoMiCutout.Checked)
                {
                    chkMainDamSoMiCutout.Checked = true;

                    txtMainDamSoMiCutout.Enabled = true;
                    txtMainDamSoMiCutout.Text = "1";

                }
                else
                    txtMainDamSoMiCutout.Text = (Int32.Parse(txtMainDamSoMiCutout.Text) + 1).ToString();

            }
            else if (s.Contains("AoYemRenNo"))
            {
                if (!chkAoYemRenNo.Checked)
                {
                    chkAoYemRenNo.Checked = true;

                    txtAoYemRenNo.Enabled = true;
                    txtAoYemRenNo.Text = "1";

                }
                else
                    txtAoYemRenNo.Text = (Int32.Parse(txtAoYemRenNo.Text) + 1).ToString();

            }
            else if (s.Contains("DamYen"))
            {
                if (!chkDamYen.Checked)
                {
                    chkDamYen.Checked = true;

                    txtDamYen.Enabled = true;
                    txtDamYen.Text = "1";

                }
                else
                    txtDamYen.Text = (Int32.Parse(txtDamYen.Text) + 1).ToString();

            }
            else if (s.Contains("QuanVayDapLyNapTui"))
            {
                if (!chkQuanVayDapLyNapTui.Checked)
                {
                    chkQuanVayDapLyNapTui.Checked = true;

                    txtQuanVayDapLyNapTui.Enabled = true;
                    txtQuanVayDapLyNapTui.Text = "1";

                }
                else
                    txtQuanVayDapLyNapTui.Text = (Int32.Parse(txtQuanVayDapLyNapTui.Text) + 1).ToString();

            }
            else if (s.Contains("AoBeoCo"))
            {
                if (!chkAoBeoCo.Checked)
                {
                    chkAoBeoCo.Checked = true;

                    txtAoBeoCo.Enabled = true;
                    txtAoBeoCo.Text = "1";

                }
                else
                    txtAoBeoCo.Text = (Int32.Parse(txtAoBeoCo.Text) + 1).ToString();

            }
            else if (s.Contains("DamCoYem3W"))
            {
                if (!chkDamCoYem3W.Checked)
                {
                    chkDamCoYem3W.Checked = true;

                    txtDamCoYem3W.Enabled = true;
                    txtDamCoYem3W.Text = "1";

                }
                else
                    txtDamCoYem3W.Text = (Int32.Parse(txtDamCoYem3W.Text) + 1).ToString();

            }
            else if (s.Contains("DamCoYemDai"))
            {
                if (!chkDamCoYemDai.Checked)
                {
                    chkDamCoYemDai.Checked = true;

                    txtDamCoYemDai.Enabled = true;
                    txtDamCoYemDai.Text = "1";

                }
                else
                    txtDamCoYemDai.Text = (Int32.Parse(txtDamCoYemDai.Text) + 1).ToString();

            }
            else if (s.Contains("DamXoeCupNguc"))
            {
                if (!chkDamXoeCupNguc.Checked)
                {
                    chkDamXoeCupNguc.Checked = true;

                    txtDamXoeCupNguc.Enabled = true;
                    txtDamXoeCupNguc.Text = "1";

                }
                else
                    txtDamXoeCupNguc.Text = (Int32.Parse(txtDamXoeCupNguc.Text) + 1).ToString();

            }
            else if (s.Contains("CVDenDangDai"))
            {
                if (!chkCVDenDangDai.Checked)
                {
                    chkCVDenDangDai.Checked = true;

                    txtCVDenDangDai.Enabled = true;
                    txtCVDenDangDai.Text = "1";

                }
                else
                    txtCVDenDangDai.Text = (Int32.Parse(txtCVDenDangDai.Text) + 1).ToString();

            }
            else if (s.Contains("SoMiPhi"))
            {
                if (!chkSoMiPhi.Checked)
                {
                    chkSoMiPhi.Checked = true;

                    txtSoMiPhi.Enabled = true;
                    txtSoMiPhi.Text = "1";

                }
                else
                    txtSoMiPhi.Text = (Int32.Parse(txtSoMiPhi.Text) + 1).ToString();

            }
            else if (s.Contains("AoDilysDen"))
            {
                if (!chkAoDilysDen.Checked)
                {
                    chkAoDilysDen.Checked = true;

                    txtAoDilysDen.Enabled = true;
                    txtAoDilysDen.Text = "1";

                }
                else
                    txtAoDilysDen.Text = (Int32.Parse(txtAoDilysDen.Text) + 1).ToString();

            }
            else if (s.Contains("DenDamSoMiCutout"))
            {
                if (!chkDenDamSoMiCutout.Checked)
                {
                    chkDenDamSoMiCutout.Checked = true;

                    txtDenDamSoMiCutout.Enabled = true;
                    txtDenDamSoMiCutout.Text = "1";

                }
                else
                    txtDenDamSoMiCutout.Text = (Int32.Parse(txtDenDamSoMiCutout.Text) + 1).ToString();

            }
            else if (s.Contains("TrangDamSoMiCutout"))
            {
                if (!chkTrangDamSoMiCutout.Checked)
                {
                    chkTrangDamSoMiCutout.Checked = true;

                    txtTrangDamSoMiCutout.Enabled = true;
                    txtTrangDamSoMiCutout.Text = "1";

                }
                else
                    txtTrangDamSoMiCutout.Text = (Int32.Parse(txtTrangDamSoMiCutout.Text) + 1).ToString();

            }
            else if (s.Contains("AoBlazerTaBauDen"))
            {
                if (!chkAoBlazerTaBauDen.Checked)
                {
                    chkAoBlazerTaBauDen.Checked = true;

                    txtAoBlazerTaBauDen.Enabled = true;
                    txtAoBlazerTaBauDen.Text = "1";

                }
                else
                    txtAoBlazerTaBauDen.Text = (Int32.Parse(txtAoBlazerTaBauDen.Text) + 1).ToString();

            }
            else if (s.Contains("DamSuongLongVu"))
            {
                if (!chkDamSuongLongVu.Checked)
                {
                    chkDamSuongLongVu.Checked = true;

                    txtDamSuongLongVu.Enabled = true;
                    txtDamSuongLongVu.Text = "1";

                }
                else
                    txtDamSuongLongVu.Text = (Int32.Parse(txtDamSuongLongVu.Text) + 1).ToString();

            }
            else if (s.Contains("ChanVayThietKeSieuDaiOmBodyChamGot"))
            {
                if (!chkChanVayThietKeSieuDaiOmBodyChamGot.Checked)
                {
                    chkChanVayThietKeSieuDaiOmBodyChamGot.Checked = true;

                    txtChanVayThietKeSieuDaiOmBodyChamGot.Enabled = true;
                    txtChanVayThietKeSieuDaiOmBodyChamGot.Text = "1";

                }
                else
                    txtChanVayThietKeSieuDaiOmBodyChamGot.Text = (Int32.Parse(txtChanVayThietKeSieuDaiOmBodyChamGot.Text) + 1).ToString();

            }
            
            //Endddddddddddddd



        }
        private void minus_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Name;
            //Cafe Viet
            
            //Tra
             if (s.Contains("MainDamSoMiCutout"))
            {
                if (Int32.Parse(txtMainDamSoMiCutout.Text) > 1)
                {
                    txtMainDamSoMiCutout.Text = (Int32.Parse(txtMainDamSoMiCutout.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtMainDamSoMiCutout.Text) == 1)
                {
                    chkMainDamSoMiCutout.Checked = false;
                    txtMainDamSoMiCutout.Enabled = false;
                    txtMainDamSoMiCutout.Text = "0";
                }

            }
            else if (s.Contains("MatchaMacchiato"))
            {
                if (Int32.Parse(txtAoYemRenNo.Text) > 1)
                {
                    txtAoYemRenNo.Text = (Int32.Parse(txtAoYemRenNo.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtAoYemRenNo.Text) == 1)
                {
                    chkAoYemRenNo.Checked = false;
                    txtAoYemRenNo.Enabled = false;
                    txtAoYemRenNo.Text = "0";
                }

            }
            else if (s.Contains("DamYen"))
            {
                if (Int32.Parse(txtDamYen.Text) > 1)
                {
                    txtDamYen.Text = (Int32.Parse(txtDamYen.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtDamYen.Text) == 1)
                {
                    chkDamYen.Checked = false;
                    txtDamYen.Enabled = false;
                    txtDamYen.Text = "0";
                }

            }
            else if (s.Contains("QuanVayDapLyNapTui"))
            {
                if (Int32.Parse(txtQuanVayDapLyNapTui.Text) > 1)
                {
                    txtQuanVayDapLyNapTui.Text = (Int32.Parse(txtQuanVayDapLyNapTui.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtQuanVayDapLyNapTui.Text) == 1)
                {
                    chkQuanVayDapLyNapTui.Checked = false;
                    txtQuanVayDapLyNapTui.Enabled = false;
                    txtQuanVayDapLyNapTui.Text = "0";
                }

            }
            else if (s.Contains("AoBeoCo"))
            {
                if (Int32.Parse(txtAoBeoCo.Text) > 1)
                {
                    txtAoBeoCo.Text = (Int32.Parse(txtAoBeoCo.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtAoBeoCo.Text) == 1)
                {
                    chkAoBeoCo.Checked = false;
                    txtAoBeoCo.Enabled = false;
                    txtAoBeoCo.Text = "0";
                }

            }
            else if (s.Contains("AoYemRenNo"))
            {
                if (Int32.Parse(txtAoYemRenNo.Text) > 1)
                {
                    txtAoYemRenNo.Text = (Int32.Parse(txtAoYemRenNo.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtAoYemRenNo.Text) == 1)
                {
                    chkAoYemRenNo.Checked = false;
                    txtAoYemRenNo.Enabled = false;
                    txtAoYemRenNo.Text = "0";
                }

            }
            else if (s.Contains("DamCoYem3W"))
            {
                if (Int32.Parse(txtDamCoYem3W.Text) > 1)
                {
                    txtDamCoYem3W.Text = (Int32.Parse(txtDamCoYem3W.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtDamCoYem3W.Text) == 1)
                {
                    chkDamCoYem3W.Checked = false;
                    txtDamCoYem3W.Enabled = false;
                    txtDamCoYem3W.Text = "0";
                }

            }
            else if (s.Contains("DamCoYemDai"))
            {
                if (Int32.Parse(txtDamCoYemDai.Text) > 1)
                {
                    txtDamCoYemDai.Text = (Int32.Parse(txtDamCoYemDai.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtDamCoYemDai.Text) == 1)
                {
                    chkDamCoYemDai.Checked = false;
                    txtDamCoYemDai.Enabled = false;
                    txtDamCoYemDai.Text = "0";
                }

            }
            else if (s.Contains("DamXoeCupNguc"))
            {
                if (Int32.Parse(txtDamXoeCupNguc.Text) > 1)
                {
                    txtDamXoeCupNguc.Text = (Int32.Parse(txtDamXoeCupNguc.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtDamXoeCupNguc.Text) == 1)
                {
                    chkDamXoeCupNguc.Checked = false;
                    txtDamXoeCupNguc.Enabled = false;
                    txtDamXoeCupNguc.Text = "0";
                }

               
                }
            else if (s.Contains("CVDenDangDai"))
            {
                if (Int32.Parse(txtCVDenDangDai.Text) > 1)
                {
                    txtCVDenDangDai.Text = (Int32.Parse(txtCVDenDangDai.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtCVDenDangDai.Text) == 1)
                {
                    chkCVDenDangDai.Checked = false;
                    txtCVDenDangDai.Enabled = false;
                    txtCVDenDangDai.Text = "0";
                }

            }
            else if (s.Contains("SoMiPhi"))
            {
                if (Int32.Parse(txtSoMiPhi.Text) > 1)
                {
                    txtSoMiPhi.Text = (Int32.Parse(txtSoMiPhi.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtSoMiPhi.Text) == 1)
                {
                    chkSoMiPhi.Checked = false;
                    txtSoMiPhi.Enabled = false;
                    txtSoMiPhi.Text = "0";
                }

            }
            else if (s.Contains("AoDilysDen"))
            {
                if (Int32.Parse(txtAoDilysDen.Text) > 1)
                {
                    txtAoDilysDen.Text = (Int32.Parse(txtAoDilysDen.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtAoDilysDen.Text) == 1)
                {
                    chkAoDilysDen.Checked = false;
                    txtAoDilysDen.Enabled = false;
                    txtAoDilysDen.Text = "0";
                }

            }
            else if (s == "DenDamSoMiCutout")
            {
                if (Int32.Parse(txtDenDamSoMiCutout.Text) > 1)
                {
                    txtDenDamSoMiCutout.Text = (Int32.Parse(txtDenDamSoMiCutout.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtDenDamSoMiCutout.Text) == 1)
                {
                    chkDenDamSoMiCutout.Checked = false;
                    txtDenDamSoMiCutout.Enabled = false;
                    txtDenDamSoMiCutout.Text = "0";
                }

            


            }
            else if (s == "TrangDamSoMiCutout")
            {
                if (Int32.Parse(txtTrangDamSoMiCutout.Text) > 1)
                {
                    txtTrangDamSoMiCutout.Text = (Int32.Parse(txtTrangDamSoMiCutout.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTrangDamSoMiCutout.Text) == 1)
                {
                    chkTrangDamSoMiCutout.Checked = false;
                    txtTrangDamSoMiCutout.Enabled = false;
                    txtTrangDamSoMiCutout.Text = "0";
                }

            }
            else if (s == "AoBlazerTaBauDen")
            {
                if (Int32.Parse(txtAoBlazerTaBauDen.Text) > 1)
                {
                    txtAoBlazerTaBauDen.Text = (Int32.Parse(txtAoBlazerTaBauDen.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtAoBlazerTaBauDen.Text) == 1)
                {
                    chkAoBlazerTaBauDen.Checked = false;
                    txtAoBlazerTaBauDen.Enabled = false;
                    txtAoBlazerTaBauDen.Text = "0";
                }

            }
            else if (s == "DamSuongLongVu")
            {
                if (Int32.Parse(txtDamSuongLongVu.Text) > 1)
                {
                    txtDamSuongLongVu.Text = (Int32.Parse(txtDamSuongLongVu.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtDamSuongLongVu.Text) == 1)
                {
                    chkDamSuongLongVu.Checked = false;
                    txtDamSuongLongVu.Enabled = false;
                    txtDamSuongLongVu.Text = "0";
                }

            }
            else if (s.Contains("ChanVayThietKeSieuDaiOmBodyChamGot"))
            {
                if (Int32.Parse(txtChanVayThietKeSieuDaiOmBodyChamGot.Text) > 1)
                {
                    txtChanVayThietKeSieuDaiOmBodyChamGot.Text = (Int32.Parse(txtChanVayThietKeSieuDaiOmBodyChamGot.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtChanVayThietKeSieuDaiOmBodyChamGot.Text) == 1)
                {
                    chkChanVayThietKeSieuDaiOmBodyChamGot.Checked = false;
                    txtChanVayThietKeSieuDaiOmBodyChamGot.Enabled = false;
                    txtChanVayThietKeSieuDaiOmBodyChamGot.Text = "0";
                }

            }
          
        }

     

        private void reset(object sender, EventArgs e)
        {
            this.isPrint = false;
            
            //Trà
            chkMainDamSoMiCutout.Checked = false;
            chkAoYemRenNo.Checked = false;
            chkDamYen.Checked = false;
            chkQuanVayDapLyNapTui.Checked = false;
            chkAoBeoCo.Checked = false;
            chkDamCoYem3W.Checked = false;
            chkDamCoYemDai.Checked = false;
            chkDamXoeCupNguc.Checked = false;
            chkCVDenDangDai.Checked = false;
            chkSoMiPhi.Checked = false;
            chkAoDilysDen.Checked = false;
            chkDenDamSoMiCutout.Checked = false;
            chkTrangDamSoMiCutout.Checked = false;
            chkAoBlazerTaBauDen.Checked = false;
            chkDamSuongLongVu.Checked = false;
            chkChanVayThietKeSieuDaiOmBodyChamGot.Checked = false;
           

            //txtDiscount
            txtDiscount.Text = "0";

           


        }
        public bool checkIsMorning()
        {
            TimeSpan start = new TimeSpan(7, 0, 0); //7 o'clock Am
            TimeSpan end = new TimeSpan(13, 0, 0); //11 o'clock Am
            TimeSpan now = DateTime.Now.TimeOfDay;

            return (now > start) && (now < end);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(this.isPrint)
            {
                reset(sender, e);

            }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
