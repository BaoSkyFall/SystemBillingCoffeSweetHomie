﻿using System;
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
        private double bacsiu;
        private int cafeSuaTuoi;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //test
        }

        private void button3_Click(object sender, EventArgs e)
        { //btnReset
            txtDenDa.Text = "0";
            txtSuaDa.Text = "0";
            txtBacSiu.Text = "0";
            txtCafeSuaTuoi.Text = "0";



            lblCakeCost.Text = "0";
            lblDrinkCost.Text = "0";
            lblPhiDichVu.Text = "0";
            lblKhuyenMai.Text = "0";
            lblChietKhau.Text = "0";
            lblTotal.Text = "0";

            chkDenDa.Checked = false;
            chkSuaDa.Checked = false;
            chkBacSiu.Checked = false;
            chkCafeSuaTuoi.Checked = false;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //btnReceipt
            rtfReceipt.Clear();

            // rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("\t\t" + "Cafe Sweet Dream" + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------" + Environment.NewLine);
            //rtfReceipt.AppendText("Tên\tSố lượng\tĐơn giá\tTổng cộng" + Environment.NewLine);
            rtfReceipt.AppendText("Tên\t\t\t\t");
            rtfReceipt.AppendText("Số lượng\t\t");
            rtfReceipt.AppendText("Đơn giá\t\t");
            rtfReceipt.AppendText("Tổng cộng" + Environment.NewLine);


            if (txtDenDa.Text != "0")
            {
                rtfReceipt.AppendText("Cafe Đen Đá \t\t5\t\t25.000\t\t125.000" + Environment.NewLine);

            }
            if (txtSuaDa.Text != "0")
            {
                rtfReceipt.AppendText("Cafe Sữa Đá \t\t\t\t" + txtSuaDa.Text + Environment.NewLine);

            }
            if (txtBacSiu.Text != "0")
            {
                rtfReceipt.AppendText("Bạc Sỉu \t\t\t\t" + txtBacSiu.Text + Environment.NewLine);

            }
            if (txtCafeSuaTuoi.Text != "0")
            {
                rtfReceipt.AppendText("Cafe Sữa Tươi \t\t\t" + txtCafeSuaTuoi.Text + Environment.NewLine);

            }





            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Phí Dịch Vụ \t\t\t" + lblPhiDichVu.Text + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Khuyến Mãi \t\t\t\t" + lblKhuyenMai.Text + Environment.NewLine);
            rtfReceipt.AppendText("Tổng Cộng \t\t\t" + lblChietKhau.Text + Environment.NewLine);
            rtfReceipt.AppendText("Tổng Cộng \t\t\t" + lblTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblTimer.Text + "\t" + lblDate.Text);

        }

        private void tinhTien(object sender, EventArgs e)
        { //btnTotal
            if (txtDiscount.Text.Length > 0)
            {
                try
                {
                    double disCount = Convert.ToDouble(txtDiscount.Text);
                    if (disCount < 100 && disCount >= 0)
                    {

                    //Thuc Uong
                        double denda, suada, bacsiu, cafeSuaTuoi, chocolate, oreo, cafeDaXay, matcha,
                            camchanhday,sinhtodau,chanhtuyet,sinhtobo,sinhtoxoai,dauxoaicam,nuocepcam,nuocepchanh,chanhoi,chanhdao,chanhmatong,nuocepchanhday,
                            suachuadaxay,suachuavietquat,suachuadao,suachuadau,suachuachanhday,sodachanh,bluecucarao,sodadao,sodabacha,sodacam,
                            tradenmacchiato,matchamacchiato,traolongmacchiato,luctramacchiato,traxoaimacchiato,trahoadaubiecmacchiato,trasuathaixanh,trahoadaubiec,
                            trahoacuc, trahoacuchatchia, trahoahongmatong,tradao,tradaocamsa,travaihatchia,travaiduahau,traliptonchanh,traliptonsua,travietquat,tracammatong,
                            tragungmatong,tralai;
                        //Toppinggggggggggg
                        double tranchauduongden, oreoTopping, planTrung, planchocolate, suongsao, thachphomai, macchiatoTopping, whippingCream;
                        double tax;
                        tax = 0.45;
                        //cafe Viet pries
                        denda = 25000; bacsiu = 29000; suada = 29000; cafeSuaTuoi = 25000;
                        //Da Xay
                        chocolate = 37000; oreo = 39000; cafeDaXay = 37000; matcha = 39000;
                        //Sinh To
                        camchanhday = 30000; sinhtodau = 30000; chanhtuyet = 30000; sinhtobo = 35000; sinhtoxoai = 30000; dauxoaicam = 30000;
                        //Nuoc Ep
                        nuocepcam= 28000;nuocepchanh= 25000; chanhoi= 28000; chanhdao = 28000; chanhmatong = 30000; nuocepchanhday = 28000;
                        //Sua Chua
                        suachuadaxay = 30000; suachuavietquat=30000; suachuadao= 30000; suachuadau= 30000; suachuachanhday = 30000;
                        //Soda
                        sodachanh =30000; bluecucarao= 30000; sodadao= 30000; sodabacha= 30000; sodacam = 30000;
                        //Tra
                        tradenmacchiato = 35000; matchamacchiato = 35000; traolongmacchiato = 35000; luctramacchiato = 35000; traxoaimacchiato = 35000; 
                        trahoadaubiecmacchiato = 39000; trasuathaixanh = 25000; trahoadaubiec = 35000;
                        trahoacuc = 30000; trahoacuchatchia = 35000; trahoahongmatong = 35000; tradao = 30000; tradaocamsa = 35000; travaihatchia = 30000; 
                        travaiduahau = 35000; traliptonchanh = 30000; traliptonsua = 30000; travietquat = 35000; tracammatong = 35000;
                        tragungmatong = 30000; tralai = 30000;

                        //Toppinggggg
                        tranchauduongden = 7000; oreoTopping = 7000; planTrung = 5000; planchocolate = 5000; suongsao = 5000; thachphomai = 5000; macchiatoTopping = 7000; whippingCream = 7000;

                        //Cafe Viet
                        double denDaCof = Convert.ToDouble(txtDenDa.Text);
                        double suaDaCof = Convert.ToDouble(txtSuaDa.Text);
                        double bacSiuCof = Convert.ToDouble(txtBacSiu.Text);
                        double cafeSuaTuoiCof = Convert.ToDouble(txtCafeSuaTuoi.Text);
                        //Da Xay
                        double chocolateCof = Convert.ToDouble(txtChocolate.Text);
                        double oreoCof = Convert.ToDouble(txtOreo.Text);
                        double cafeDaXayCof = Convert.ToDouble(txtCafeDaXay.Text);
                        double matchaCof = Convert.ToDouble(txtMatcha.Text);
                        //Sinh To
                        double camchanhdayCof = Convert.ToDouble(txtCamChanhDay.Text);
                        double sinhtodauCof = Convert.ToDouble(txtSinhToDau.Text);
                        double chanhtuyetCof = Convert.ToDouble(txtChanhTuyet.Text);
                        double sinhtoBoCof = Convert.ToDouble(txtSinhToBo.Text);
                        double sinhtoXoaiCof = Convert.ToDouble(txtSinhToXoai.Text);
                        double dauxoaicamCof = Convert.ToDouble(txtDauXoaiCam.Text);
                        //Nuoc Ep
                        double nuocepcamCof = Convert.ToDouble(txtNuocEpCam.Text);
                        double nuocepchanhCof = Convert.ToDouble(txtNuocEpChanh.Text);
                        double chanhoiCof = Convert.ToDouble(txtChanhOi.Text);
                        double chanhdaoCof = Convert.ToDouble(txtChanhDao.Text);
                        double chanhmatongCof = Convert.ToDouble(txtChanhMatOng.Text);
                        double nuocepchanhdayCof = Convert.ToDouble(txtNuocEpChanhDay.Text);

                        //Sua Chua
                        double suachuadaxayCof = Convert.ToDouble(txtSuaChuaDaXay.Text);
                        double suachuavietquatCof = Convert.ToDouble(txtSuaChuaVietQuat.Text);
                        double suachuadaoCof = Convert.ToDouble(txtSuaChuaDao.Text);
                        double suachuadauCof = Convert.ToDouble(txtSuaChuaDau.Text);
                        double suachuachanhdayCof = Convert.ToDouble(txtSuaChuaChanhDay.Text);
                        //Soda
                        double sodachanhCof = Convert.ToDouble(txtSodaChanh.Text);
                        double bluecucaraoCof = Convert.ToDouble(txtBlueCucarao.Text);
                        double sodadaoCof = Convert.ToDouble(txtSodaDao.Text);
                        double sodabachaCof = Convert.ToDouble(txtSodaBacHa.Text);
                        double sodacamCof = Convert.ToDouble(txtSodaCam.Text);
                        //Tra
                        double tradenmacchiatoCof = Convert.ToDouble(txtTraDenMacchiato.Text);
                        double matchamacchiatoCof = Convert.ToDouble(txtMatchaMacchiato.Text);
                        double traolongmacchiatoCof = Convert.ToDouble(txtTraOLongMacchiato.Text);
                        double luctramacchiatoCof = Convert.ToDouble(txtLucTraMacchiato.Text);
                        double traxoaimacchiatoCof = Convert.ToDouble(txtTraXoaiMacchiato.Text);
                        double trahoadaubiecmacchiatoCof = Convert.ToDouble(txtHoaDauBiecMacchiato.Text);
                        double trasuathaixanhCof = Convert.ToDouble(txtTraSuaThaiXanh.Text);
                        double trahoadaubiecCof = Convert.ToDouble(txtTraHoaDauBiec.Text);
                        double trahoacucCof = Convert.ToDouble(txtTraHoaCuc.Text);
                        double trahoacuchatchiaCof = Convert.ToDouble(txtTraHoaCucHatChia.Text);
                        double trahoahongmatongCof = Convert.ToDouble(txtTraHoaHongMatOng.Text);
                        double tradaoCof = Convert.ToDouble(txtTraDao.Text);
                        double tradaocamsaCof = Convert.ToDouble(txtTraDaoCamSa.Text);
                        double travaihatchiaCof = Convert.ToDouble(txtTraVaiHatChia.Text);
                        double travaiduahauCof = Convert.ToDouble(txtTraVaiDuaHau.Text);
                        double traliptonchanhCof = Convert.ToDouble(txtTraLiptonChanh.Text);
                        double traliptonsuaCof = Convert.ToDouble(txtTraLiptonSua.Text);
                        double travietquatCof = Convert.ToDouble(txtTraVietQuat.Text);
                        double tracammatongCof = Convert.ToDouble(txtTraCamMatOng.Text);
                        double tragungmatongCof = Convert.ToDouble(txtTraGungMatOng.Text);
                        double tralaiCof = Convert.ToDouble(txtTraLai.Text);
            
                        //Topinggggg
                        double tranchauduongdenCof = Convert.ToDouble(txtTranChauDuongDen.Text);
                        double oreotoppingCof = Convert.ToDouble(txtOreoTopping.Text);
                        double plantrungCof = Convert.ToDouble(txtPlanTrung.Text);
                        double planchocolateCof = Convert.ToDouble(txtPlanChocolate.Text);
                        double suongsaoCof = Convert.ToDouble(txtSuongSao.Text);
                        double thachphomaiCof = Convert.ToDouble(txtThachPhoMai.Text);
                        double machiatotoppingCof = Convert.ToDouble(txtMacchiatoTopping.Text);
                        double whippincreamCof = Convert.ToDouble(txtWhippinCream.Text);
           
                        //Cafe eat_in_cafe = new Cafe(denDaCof, suaDaCof, bacSiuCof, cafeSuaTuoiCof,cofCake,redValvet,bForest,bostonCream,lagosChoco,kilbChoco,cheeseCak,rainbow);
                        var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");


                        double drinkCosts = (denDaCof * denda) + (suaDaCof * suada) + (bacSiuCof * bacsiu) + (cafeSuaTuoiCof * cafeSuaTuoi)
                            + (chocolateCof * chocolate) + (oreoCof * oreo) + (cafeDaXayCof * cafeDaXay) + (matchaCof * matcha) +
                            (camchanhdayCof * camchanhday) + (sinhtodauCof * sinhtodau) + (chanhtuyetCof * chanhtuyet) + (sinhtoBoCof * sinhtobo)
                            + (sinhtoXoaiCof * sinhtoxoai) + (dauxoaicam * dauxoaicamCof) + (nuocepcam * nuocepcamCof) + (nuocepchanh * nuocepchanhCof)
                            + (chanhoi * chanhoiCof) + (chanhdao * chanhdaoCof) + (chanhmatong * chanhmatongCof) + (nuocepchanhday * nuocepchanhdayCof)
                            + (suachuadaxay * suachuadaxayCof) + (suachuavietquat * suachuavietquatCof) + (suachuadao * suachuadaoCof) + (suachuadau * suachuadauCof)+ (suachuachanhday*suachuachanhdayCof)
                            + (sodachanh * sodachanhCof) + (bluecucarao * bluecucaraoCof) + (sodadao * sodadaoCof) + (sodabacha * sodabachaCof)
                            + (sodacam * sodacamCof) +
                            (tradenmacchiato * tradenmacchiatoCof) + (matchamacchiatoCof * matchamacchiato) + (traolongmacchiatoCof * traolongmacchiato) + (luctramacchiato * luctramacchiatoCof)
                            + (traxoaimacchiatoCof * traxoaimacchiato) + (trahoadaubiecmacchiato * trahoadaubiecmacchiatoCof) + (trasuathaixanh * trasuathaixanhCof) + (trahoadaubiec * trahoadaubiecCof)
                            + (trahoacuc * trahoacucCof) + (trahoacuchatchia * trahoacuchatchiaCof) + (trahoahongmatong * trahoahongmatongCof) + (tradao * tradaoCof)
                             + (tradaocamsa * tradaocamsaCof) + (travaihatchia * travaihatchiaCof) + (travaiduahau * travaiduahauCof) + (traliptonchanh * traliptonchanhCof)
                              + (traliptonsua * traliptonsuaCof) + (travietquat * travietquatCof) + (tracammatong * tracammatongCof) + (tragungmatong * tragungmatongCof) + (tralai * tralaiCof);
                        lblDrinkCost.Text = Convert.ToString(drinkCosts);
                        double cakeCosts = (tranchauduongdenCof * tranchauduongden) + (oreotoppingCof * oreoTopping) + (plantrungCof * planTrung) +
                            (planchocolateCof * planchocolate) + (suongsaoCof * suongsao) + (thachphomaiCof * thachphomai) + (machiatotoppingCof * macchiatoTopping)
                            +(whippincreamCof* whippingCream);
                        lblCakeCost.Text = Convert.ToString(cakeCosts);

                        //double svcCharge = Math.Round(Convert.ToDouble(lblPhiDichVu.Text));
                        double svcCharge = 0;
                        lblChietKhau.Text = Convert.ToString(cakeCosts + drinkCosts + svcCharge);
                        lblKhuyenMai.Text = Convert.ToString(disCount);
                        double totalAftTax = Math.Round(Convert.ToDouble(lblKhuyenMai.Text));
                        double total = (cakeCosts + drinkCosts + svcCharge) * ((100 - totalAftTax) / 100);

                        lblDrinkCost.Text = String.Format(info, "{0:#,#.}", drinkCosts) + " đ";
                        lblCakeCost.Text = cakeCosts > 0 ? String.Format(info, "{0:#,#.}", cakeCosts) : 0 + " đ";
                        lblPhiDichVu.Text = svcCharge > 0 ? String.Format(info, "{0:#,#.}", svcCharge) : 0 + " đ";
                        lblChietKhau.Text = String.Format("{0:#,0}", (cakeCosts + drinkCosts + svcCharge) * ((totalAftTax) / 100)) + " đ";
                        lblKhuyenMai.Text = lblKhuyenMai.Text + " %";
                        lblTotal.Text = String.Format("{0:#,0}", (cakeCosts + drinkCosts + svcCharge) * ((100 - totalAftTax) / 100)) + " đ";


                        rtfReceipt.Clear();

                        // rtfReceipt.AppendText(Environment.NewLine);
                        rtfReceipt.AppendText("---------------------------------------------------------" + Environment.NewLine);
                        rtfReceipt.AppendText("\t   " + "Cafe Sweet Homiee" + Environment.NewLine);
                        rtfReceipt.AppendText("---------------------------------------------------------" + Environment.NewLine);
                        //rtfReceipt.AppendText("Tên\tSố lượng\tĐơn giá\tTổng cộng" + Environment.NewLine);
                        rtfReceipt.AppendText("Số lượng\t\t");
                        rtfReceipt.AppendText("Đơn giá\t");
                        rtfReceipt.AppendText("   Tổng cộng" + Environment.NewLine);

                        //Cafe Viet
                        if (txtDenDa.Text != "0")
                        {
                            rtfReceipt.AppendText("Cafe Đen Đá" + Environment.NewLine + txtDenDa.Text + "\t\t" + string.Format("{0:#,0}", denda) + "\t   " + string.Format("{0:#,0}", denDaCof * denda) + " đ" + Environment.NewLine);

                        }

                        if (txtSuaDa.Text != "0")
                        {
                            rtfReceipt.AppendText("Cafe Sữa Đá" + Environment.NewLine + txtSuaDa.Text + "\t\t" + string.Format("{0:#,0}", suada) + "\t   " + string.Format("{0:#,0}", suaDaCof * suada) + " đ" + Environment.NewLine);

                        }
                        if (txtBacSiu.Text != "0")
                        {
                            rtfReceipt.AppendText("Bạc Sỉu" + Environment.NewLine + txtBacSiu.Text + "\t\t" + string.Format("{0:#,0}", bacsiu) + "\t   " + string.Format("{0:#,0}", bacSiuCof * bacsiu) + " đ" + Environment.NewLine);

                        }
                        if (txtCafeSuaTuoi.Text != "0")
                        {
                            rtfReceipt.AppendText("Cafe Sữa Tươi" + Environment.NewLine + txtCafeSuaTuoi.Text + "\t\t" + string.Format("{0:#,0}", cafeSuaTuoi) + "\t   " + string.Format("{0:#,0}", cafeSuaTuoiCof * cafeSuaTuoi) + " đ" + Environment.NewLine);

                        }
                        //Da Xay
                        if (txtChocolate.Text != "0")
                        {
                            rtfReceipt.AppendText("Đá Xay Chocolate (Bạc Hà)" + Environment.NewLine + txtChocolate.Text + "\t\t" + string.Format("{0:#,0}", chocolate) + "\t   " + string.Format("{0:#,0}", chocolateCof * chocolate) + " đ" + Environment.NewLine);

                        }

                        if (txtOreo.Text != "0")
                        {
                            rtfReceipt.AppendText("Đá Xay Oreo" + Environment.NewLine + txtOreo.Text + "\t\t" + string.Format("{0:#,0}", oreo) + "\t   " + string.Format("{0:#,0}", oreoCof * oreo) + " đ" + Environment.NewLine);

                        }
                        if (txtCafeDaXay.Text != "0")
                        {
                            rtfReceipt.AppendText("Cafe Đá Xay" + Environment.NewLine + txtCafeDaXay.Text + "\t\t" + string.Format("{0:#,0}", cafeDaXay) + "\t   " + string.Format("{0:#,0}", cafeDaXayCof * cafeDaXay) + " đ" + Environment.NewLine);

                        }
                        if (txtMatcha.Text != "0")
                        {
                            rtfReceipt.AppendText("Đá Xay Matcha" + Environment.NewLine + txtMatcha.Text + "\t\t" + string.Format("{0:#,0}", matcha) + "\t   " + string.Format("{0:#,0}", matchaCof * matcha) + " đ" + Environment.NewLine);

                        }
                        //Sinh To
                        if (txtCamChanhDay.Text != "0")
                        {
                            rtfReceipt.AppendText("Sinh Tố Cam Chanh Dây" + Environment.NewLine + txtCamChanhDay.Text + "\t\t" + string.Format("{0:#,0}", camchanhday) + "\t   " + string.Format("{0:#,0}", camchanhdayCof * camchanhday) + " đ" + Environment.NewLine);

                        }
                        if (txtSinhToDau.Text != "0")
                        {
                            rtfReceipt.AppendText("Sinh Tố Dâu" + Environment.NewLine + txtSinhToDau.Text + "\t\t" + string.Format("{0:#,0}", sinhtodau) + "\t   " + string.Format("{0:#,0}", sinhtodauCof * sinhtodau) + " đ" + Environment.NewLine);

                        }
                        if (txtChanhTuyet.Text != "0")
                        {
                            rtfReceipt.AppendText("Chanh Tuyết" + Environment.NewLine + txtChanhTuyet.Text + "\t\t" + string.Format("{0:#,0}", chanhtuyet) + "\t   " + string.Format("{0:#,0}",chanhtuyetCof * chanhtuyet) + " đ" + Environment.NewLine);

                        }
                        if (txtSinhToBo.Text != "0")
                        {
                            rtfReceipt.AppendText("Sinh Tố Bơ" + Environment.NewLine + txtSinhToBo.Text + "\t\t" + string.Format("{0:#,0}", sinhtobo) + "\t   " + string.Format("{0:#,0}", sinhtoBoCof * sinhtobo) + " đ" + Environment.NewLine);

                        }
                        if (txtSinhToXoai.Text != "0")
                        {
                            rtfReceipt.AppendText("Sinh Tố Xoài" + Environment.NewLine + txtSinhToXoai.Text + "\t\t" + string.Format("{0:#,0}", sinhtoxoai) + "\t   " + string.Format("{0:#,0}", sinhtoXoaiCof * sinhtoxoai) + " đ" + Environment.NewLine);

                        }
                        if (txtDauXoaiCam.Text != "0")
                        {
                            rtfReceipt.AppendText("Sinh Tố Dâu Xoài Cam" + Environment.NewLine + txtDauXoaiCam.Text + "\t\t" + string.Format("{0:#,0}", dauxoaicam) + "\t   " + string.Format("{0:#,0}", dauxoaicamCof * dauxoaicam) + " đ" + Environment.NewLine);

                        }
                        //Nuoc Ep
                        if (txtNuocEpCam.Text != "0")
                        {
                            rtfReceipt.AppendText("Nước Ép Cam" + Environment.NewLine + txtNuocEpCam.Text + "\t\t" + string.Format("{0:#,0}", nuocepcam) + "\t   " + string.Format("{0:#,0}", nuocepcamCof * nuocepcam) + " đ" + Environment.NewLine);

                        }
                        if (txtNuocEpChanh.Text != "0")
                        {
                            rtfReceipt.AppendText("Nước Ép Chanh" + Environment.NewLine + txtNuocEpChanh.Text + "\t\t" + string.Format("{0:#,0}", nuocepchanh) + "\t   " + string.Format("{0:#,0}", nuocepchanhCof * nuocepchanh) + " đ" + Environment.NewLine);

                        }
                        if (txtNuocEpChanhDay.Text != "0")
                        {
                            rtfReceipt.AppendText("Nước Ép Chanh Dây" + Environment.NewLine + txtNuocEpChanhDay.Text + "\t\t" + string.Format("{0:#,0}", nuocepchanhday) + "\t   " + string.Format("{0:#,0}", nuocepchanhdayCof * nuocepchanhday) + " đ" + Environment.NewLine);

                        }
                        if (txtChanhOi.Text != "0")
                        {
                            rtfReceipt.AppendText("Nước Ép Chanh Ổi" + Environment.NewLine + txtChanhOi.Text + "\t\t" + string.Format("{0:#,0}", chanhoi) + "\t   " + string.Format("{0:#,0}", chanhoiCof * chanhoi) + " đ" + Environment.NewLine);

                        }
                        if (txtChanhDao.Text != "0")
                        {
                            rtfReceipt.AppendText("Nước Ép Chanh Đào" + Environment.NewLine + txtChanhDao.Text + "\t\t" + string.Format("{0:#,0}", chanhdao) + "\t   " + string.Format("{0:#,0}", chanhdaoCof * chanhdao) + " đ" + Environment.NewLine);

                        }
                        if (txtChanhMatOng.Text != "0")
                        {
                            rtfReceipt.AppendText("Nước Ép Chanh Mật Ong" + Environment.NewLine + txtChanhMatOng.Text + "\t\t" + string.Format("{0:#,0}", chanhmatong) + "\t   " + string.Format("{0:#,0}", chanhmatongCof * chanhmatong) + " đ" + Environment.NewLine);

                        }
                        //Sua Chua
                        if (txtSuaChuaDaXay.Text != "0")
                        {
                            rtfReceipt.AppendText("Sữa Chua Đá Xay" + Environment.NewLine + txtSuaChuaDaXay.Text + "\t\t" + string.Format("{0:#,0}", suachuadaxay) + "\t   " + string.Format("{0:#,0}", suachuadaxayCof * suachuadaxay) + " đ" + Environment.NewLine);

                        }
                        if (txtSuaChuaVietQuat.Text != "0")
                        {
                            rtfReceipt.AppendText("Sữa Chua Việt Quất" + Environment.NewLine + txtSuaChuaVietQuat.Text + "\t\t" + string.Format("{0:#,0}", suachuavietquat) + "\t   " + string.Format("{0:#,0}", suachuavietquatCof * suachuavietquat) + " đ" + Environment.NewLine);

                        }
                        if (txtSuaChuaDao.Text != "0")
                        {
                            rtfReceipt.AppendText("Sữa Chua Đào" + Environment.NewLine + txtSuaChuaDao.Text + "\t\t" + string.Format("{0:#,0}", suachuadao) + "\t   " + string.Format("{0:#,0}", suachuadaoCof * suachuadao) + " đ" + Environment.NewLine);

                        }
                        if (txtSuaChuaDau.Text != "0")
                        {
                            rtfReceipt.AppendText("Sữa Chua Dâu" + Environment.NewLine + txtSuaChuaDau.Text + "\t\t" + string.Format("{0:#,0}", suachuadau) + "\t   " + string.Format("{0:#,0}", suachuadauCof * suachuadau) + " đ" + Environment.NewLine);

                        }
                        if (txtSuaChuaChanhDay.Text != "0")
                        {
                            rtfReceipt.AppendText("Sữa Chua Chanh Dây" + Environment.NewLine + txtSuaChuaChanhDay.Text + "\t\t" + string.Format("{0:#,0}", suachuachanhday) + "\t   " + string.Format("{0:#,0}", suachuachanhdayCof * suachuachanhday) + " đ" + Environment.NewLine);

                        }
                        //Soda
                        if (txtSodaChanh.Text != "0")
                        {
                            rtfReceipt.AppendText("Soda Chanh" + Environment.NewLine + txtSodaChanh.Text + "\t\t" + string.Format("{0:#,0}", sodachanh) + "\t   " + string.Format("{0:#,0}", sodachanhCof * sodachanh) + " đ" + Environment.NewLine);

                        }
                        if (txtSodaCam.Text != "0")
                        {
                            rtfReceipt.AppendText("Soda Cam" + Environment.NewLine + txtSodaCam.Text + "\t\t" + string.Format("{0:#,0}", sodacam) + "\t   " + string.Format("{0:#,0}", sodacamCof * sodacam) + " đ" + Environment.NewLine);

                        }
                        if (txtSodaDao.Text != "0")
                            {
                                rtfReceipt.AppendText("Soda Đào " + Environment.NewLine + txtSodaDao.Text + "\t\t" + string.Format("{0:#,0}", sodadao) + "\t   " + string.Format("{0:#,0}", sodadaoCof * sodadao) + " đ" + Environment.NewLine);

                        }

                        //Trà
                        if (txtTraDenMacchiato.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Đen Macchiato" + Environment.NewLine + txtTraDenMacchiato.Text + "\t\t" + string.Format("{0:#,0}", tradenmacchiato) + "\t   " + string.Format("{0:#,0}", tradenmacchiatoCof * tradenmacchiato) + " đ" + Environment.NewLine);

                        }
                        if (txtMatchaMacchiato.Text != "0")
                        {
                            rtfReceipt.AppendText("Matcha Macchiato" + Environment.NewLine + txtMatchaMacchiato.Text + "\t\t" + string.Format("{0:#,0}", matchamacchiato) + "\t   " + string.Format("{0:#,0}", matchamacchiatoCof * matchamacchiato) + " đ" + Environment.NewLine);

                        }
                        if (txtTraOLongMacchiato.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Ô Long Macchiato" + Environment.NewLine + txtTraOLongMacchiato.Text + "\t\t" + string.Format("{0:#,0}", traolongmacchiato) + "\t   " + string.Format("{0:#,0}", traolongmacchiatoCof * traolongmacchiato) + " đ" + Environment.NewLine);

                        }
                        if (txtLucTraMacchiato.Text != "0")
                        {
                            rtfReceipt.AppendText("Lục Trà Macchiato" + Environment.NewLine + txtLucTraMacchiato.Text + "\t\t" + string.Format("{0:#,0}", luctramacchiato) + "\t   " + string.Format("{0:#,0}", luctramacchiatoCof * luctramacchiato) + " đ" + Environment.NewLine);

                        }
                        if (txtTraXoaiMacchiato.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Xoài Macchiato" + Environment.NewLine + txtTraXoaiMacchiato.Text + "\t\t" + string.Format("{0:#,0}", traxoaimacchiato) + "\t   " + string.Format("{0:#,0}", traxoaimacchiatoCof * traxoaimacchiato) + " đ" + Environment.NewLine);

                        }
                        if (txtHoaDauBiecMacchiato.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Hoa Đậu Biếc Macchiato" + Environment.NewLine + txtHoaDauBiecMacchiato.Text + "\t\t" + string.Format("{0:#,0}", trahoadaubiecmacchiato) + "\t   " + string.Format("{0:#,0}", trahoadaubiecmacchiatoCof * trahoadaubiecmacchiato) + " đ" + Environment.NewLine);

                        }

                        if (txtTraSuaThaiXanh.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Sữa Thái Xanh" + Environment.NewLine + txtTraSuaThaiXanh.Text + "\t\t" + string.Format("{0:#,0}", trasuathaixanh) + "\t   " + string.Format("{0:#,0}", trasuathaixanhCof * trasuathaixanh) + " đ" + Environment.NewLine);

                        }
                        if (txtTraHoaDauBiec.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Hoa Đậu Biếc" + Environment.NewLine + txtTraHoaDauBiec.Text + "\t\t" + string.Format("{0:#,0}", trahoadaubiec) + "\t   " + string.Format("{0:#,0}", trahoadaubiecCof * trahoadaubiec) + " đ" + Environment.NewLine);

                        }
                        if (txtTraHoaCuc.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Hoa Cúc" + Environment.NewLine + txtTraHoaCuc.Text + "\t\t" + string.Format("{0:#,0}", trahoacuc) + "\t   " + string.Format("{0:#,0}", trahoacucCof * trahoacuc) + " đ" + Environment.NewLine);

                        }
                        if (txtTraHoaCucHatChia.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Hoa Cúc Hạt Chia" + Environment.NewLine + txtTraHoaCucHatChia.Text + "\t\t" + string.Format("{0:#,0}", trahoacuchatchia) + "\t   " + string.Format("{0:#,0}", trahoacuchatchiaCof * trahoacuchatchia) + " đ" + Environment.NewLine);

                        }
                        if (txtTraHoaHongMatOng.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Hoa Hồng Mật Ong" + Environment.NewLine + txtTraHoaHongMatOng.Text + "\t\t" + string.Format("{0:#,0}", trahoahongmatong) + "\t   " + string.Format("{0:#,0}", trahoahongmatongCof * trahoahongmatong) + " đ" + Environment.NewLine);

                        }

                        if (txtTraDao.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Đào" + Environment.NewLine + txtTraDao.Text + "\t\t" + string.Format("{0:#,0}", tradao) + "\t   " + string.Format("{0:#,0}", tradaoCof * tradao) + " đ" + Environment.NewLine);

                        }
                        if (txtTraDaoCamSa.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Đào Cam Sả" + Environment.NewLine + txtTraDaoCamSa.Text + "\t\t" + string.Format("{0:#,0}", tradaocamsa) + "\t   " + string.Format("{0:#,0}", tradaocamsaCof * tradaocamsa) + " đ" + Environment.NewLine);

                        }
                        if (txtTraVaiHatChia.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Vải Hạt Chia" + Environment.NewLine + txtTraVaiHatChia.Text + "\t\t" + string.Format("{0:#,0}", travaihatchia) + "\t   " + string.Format("{0:#,0}", travaihatchiaCof * travaihatchia) + " đ" + Environment.NewLine);

                        }
                    
                        if (txtTraVaiDuaHau.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Vải Dưa Hấu" + Environment.NewLine + txtTraVaiDuaHau.Text + "\t\t" + string.Format("{0:#,0}", travaiduahau) + "\t   " + string.Format("{0:#,0}", travaiduahauCof * travaiduahau) + " đ" + Environment.NewLine);

                        }
                        if (txtTraLiptonChanh.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Lipton Chanh" + Environment.NewLine + txtTraLiptonChanh.Text + "\t\t" + string.Format("{0:#,0}", traliptonchanh) + "\t   " + string.Format("{0:#,0}", traliptonchanhCof * traliptonchanh) + " đ" + Environment.NewLine);

                        }
                        if (txtTraLiptonSua.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Lipton Sữa" + Environment.NewLine + txtTraLiptonSua.Text + "\t\t" + string.Format("{0:#,0}", traliptonsua) + "\t   " + string.Format("{0:#,0}", traliptonsuaCof * traliptonsua) + " đ" + Environment.NewLine);

                        }
                        if (txtTraVietQuat.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Việt Quất" + Environment.NewLine + txtTraVietQuat.Text + "\t\t" + string.Format("{0:#,0}", travietquat) + "\t   " + string.Format("{0:#,0}", travietquatCof * travietquat) + " đ" + Environment.NewLine);

                        }
                        if (txtTraCamMatOng.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Cam Mật Ong" + Environment.NewLine + txtTraCamMatOng.Text + "\t\t" + string.Format("{0:#,0}", tracammatong) + "\t   " + string.Format("{0:#,0}", tracammatongCof * tracammatong) + " đ" + Environment.NewLine);

                        }
                        if (txtTraGungMatOng.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Gừng Mật Ong" + Environment.NewLine + txtTraGungMatOng.Text + "\t\t" + string.Format("{0:#,0}", tragungmatong) + "\t   " + string.Format("{0:#,0}", tragungmatongCof * tragungmatong) + " đ" + Environment.NewLine);

                        }
                        if (txtTraLai.Text != "0")
                        {
                            rtfReceipt.AppendText("Trà Lài" + Environment.NewLine + txtTraLai.Text + "\t\t" + string.Format("{0:#,0}", tralai) + "\t   " + string.Format("{0:#,0}", tralaiCof * tralai) + " đ" + Environment.NewLine);

                        }

                        //Topingggggg
                        if (txtTranChauDuongDen.Text != "0")
                        {
                            rtfReceipt.AppendText("Trân Châu Đường Đen (Topping)" + Environment.NewLine + txtTranChauDuongDen.Text + "\t\t" + string.Format("{0:#,0}", tranchauduongden) + "\t   " + string.Format("{0:#,0}", tranchauduongdenCof * tranchauduongden) + " đ" + Environment.NewLine);

                        }
                        if (txtOreoTopping.Text != "0")
                        {
                            rtfReceipt.AppendText("Oreo (Topping)" + Environment.NewLine + txtOreoTopping.Text + "\t\t" + string.Format("{0:#,0}", oreoTopping) + "\t   " + string.Format("{0:#,0}", oreotoppingCof * oreoTopping) + " đ" + Environment.NewLine);

                        }
                        if (txtPlanTrung.Text != "0")
                        {
                            rtfReceipt.AppendText("Plan Trứng (Topping)" + Environment.NewLine + txtPlanTrung.Text + "\t\t" + string.Format("{0:#,0}", planTrung) + "\t   " + string.Format("{0:#,0}", plantrungCof * planTrung) + " đ" + Environment.NewLine);

                        }
                        if (txtPlanChocolate.Text != "0")
                        {
                            rtfReceipt.AppendText("Plan Chocolate (Topping)" + Environment.NewLine + txtPlanChocolate.Text + "\t\t" + string.Format("{0:#,0}", planchocolate) + "\t   " + string.Format("{0:#,0}", planchocolateCof * planchocolate) + " đ" + Environment.NewLine);

                        }
                        if (txtSuongSao.Text != "0")
                        {
                            rtfReceipt.AppendText("Sương Sáo (Topping)" + Environment.NewLine + txtSuongSao.Text + "\t\t" + string.Format("{0:#,0}", suongsao) + "\t   " + string.Format("{0:#,0}", suongsaoCof * suongsao) + " đ" + Environment.NewLine);

                        }
                        if (txtThachPhoMai.Text != "0")
                        {
                            rtfReceipt.AppendText("Thạch Phô Mai (Topping)" + Environment.NewLine + txtThachPhoMai.Text + "\t\t" + string.Format("{0:#,0}", thachphomai) + "\t   " + string.Format("{0:#,0}", thachphomaiCof * thachphomai) + " đ" + Environment.NewLine);

                        }
                        if (txtMacchiatoTopping.Text != "0")
                        {
                            rtfReceipt.AppendText("Macchiato (Topping)" + Environment.NewLine + txtMacchiatoTopping.Text + "\t\t" + string.Format("{0:#,0}", macchiatoTopping) + "\t   " + string.Format("{0:#,0}", machiatotoppingCof * macchiatoTopping) + " đ" + Environment.NewLine);

                        }
                        if (txtWhippinCream.Text != "0")
                        {
                            rtfReceipt.AppendText("Whippin Cream (Topping)" + Environment.NewLine + txtWhippinCream.Text + "\t\t" + string.Format("{0:#,0}", whippingCream) + "\t   " + string.Format("{0:#,0}", whippincreamCof * whippingCream) + " đ" + Environment.NewLine);

                        }
               



                                        rtfReceipt.AppendText("---------------------------------------------------------" + Environment.NewLine);
                        rtfReceipt.AppendText("Phí Dịch Vụ \t\t   " + String.Format("{0:#,0}", lblPhiDichVu.Text) + Environment.NewLine);

                        if (totalAftTax != 0)
                        {
                            rtfReceipt.AppendText("---------------------------------------------------------" + Environment.NewLine);
                            rtfReceipt.AppendText("Khuyến Mãi \t\t   " + lblKhuyenMai.Text + Environment.NewLine);
                            rtfReceipt.AppendText("Chiết Khấu \t\t   -" + String.Format("{0:#,0}", (cakeCosts + drinkCosts + svcCharge) * ((totalAftTax) / 100)) + " đ" + Environment.NewLine);
                        }

                        rtfReceipt.AppendText("---------------------------------------------------------" + Environment.NewLine);
                        rtfReceipt.AppendText("Tổng Tiền \t\t   " + String.Format("{0:#,0}", (cakeCosts + drinkCosts + svcCharge) * ((100 - totalAftTax) / 100)) + " đ" + Environment.NewLine);
                        rtfReceipt.AppendText("---------------------------------------------------------" + Environment.NewLine);
                        rtfReceipt.AppendText(lblTimer.Text + "\t" + lblDate.Text + Environment.NewLine + Environment.NewLine + Environment.NewLine);


                        rtfReceipt.AppendText("Wifi: Sweet Home" + Environment.NewLine);
                        rtfReceipt.AppendText("Pass: sweethometanquy" + Environment.NewLine);
                        rtfReceipt.AppendText("Địa chỉ: 206 Tân Quý, Phường Tân Quý,\nQuận Tân Phú" + Environment.NewLine);

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

            txtDenDa.Text = "0";
            txtSuaDa.Text = "0";
            txtBacSiu.Text = "0";
            txtCafeSuaTuoi.Text = "0";



            lblCakeCost.Text = "0";
            lblDrinkCost.Text = "0";
            lblPhiDichVu.Text = "0";
            lblChietKhau.Text = "0";
            lblKhuyenMai.Text = "0";
            lblTotal.Text = "0";

            txtDenDa.Enabled = false;
            txtSuaDa.Enabled = false; ;
            txtBacSiu.Enabled = false;
            txtCafeSuaTuoi.Enabled = false;




            chkDenDa.Checked = false;
            chkSuaDa.Checked = false;
            chkBacSiu.Checked = false;
            chkCafeSuaTuoi.Checked = false;



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
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("72 x 500 mm", 284, 1000);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
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
            if (label == "Đen Đá")
            {
                if (chkDenDa.Checked == true)
                {
                    txtDenDa.Enabled = true;
                    txtDenDa.Text = "1";

                }
                else
                {
                    txtDenDa.Enabled = false;
                    txtDenDa.Text = "0";
                }
            }
            else if (label == "Sữa Đá")
            {
                if (chkSuaDa.Checked == true)
                {
                    txtSuaDa.Enabled = true;
                    txtSuaDa.Text = "1";

                }
                else
                {
                    txtSuaDa.Enabled = false;
                    txtSuaDa.Text = "0";
                }
            }
            else if (label == "Bạc Xỉu")
            {
                if (chkBacSiu.Checked == true)
                {
                    txtBacSiu.Enabled = true;
                    txtBacSiu.Text = "1";

                }
                else
                {
                    txtBacSiu.Enabled = false;
                    txtBacSiu.Text = "0";
                }
            }
            else if (label == "Cafe Sữa Tươi")
            {
                if (chkCafeSuaTuoi.Checked == true)
                {
                    txtCafeSuaTuoi.Enabled = true;
                    txtCafeSuaTuoi.Text = "1";

                }
                else
                {
                    txtCafeSuaTuoi.Enabled = false;
                    txtCafeSuaTuoi.Text = "0";
                }
            }
            //Da Xay
            else if (label == "Chocolate (Bạc Hà)")
            {
                if (chkChocolate.Checked == true)
                {
                    txtChocolate.Enabled = true;
                    txtChocolate.Text = "1";

                }
                else
                {
                    txtChocolate.Enabled = false;
                    txtChocolate.Text = "0";
                }
            }
            else if (label == "Oreo (Bạc Hà)")
            {
                if (chkOreo.Checked == true)
                {
                    txtOreo.Enabled = true;
                    txtOreo.Text = "1";

                }
                else
                {
                    txtOreo.Enabled = false;
                    txtOreo.Text = "0";
                }
            }
            else if (label == "Cafe Đá Xay")
            {
                if (chkCafeDaXay.Checked == true)
                {
                    txtCafeDaXay.Enabled = true;
                    txtCafeDaXay.Text = "1";

                }
                else
                {
                    txtCafeDaXay.Enabled = false;
                    txtCafeDaXay.Text = "0";
                }
            }
            else if (label == "Matcha")
            {
                if (chkMatcha.Checked == true)
                {
                    txtMatcha.Enabled = true;
                    txtMatcha.Text = "1";

                }
                else
                {
                    txtMatcha.Enabled = false;
                    txtMatcha.Text = "0";
                }
            }
            //Sinh To
            else if (label == "Cam Chanh Dây")
            {
                if (chkCamChanhDay.Checked == true)
                {
                    txtCamChanhDay.Enabled = true;
                    txtCamChanhDay.Text = "1";

                }
                else
                {
                    txtCamChanhDay.Enabled = false;
                    txtCamChanhDay.Text = "0";
                }
            }
            else if (label == "Dâu" && name.Contains("SinhToDau"))
            {
                if (chkSinhToDau.Checked == true)
                {
                    txtSinhToDau.Enabled = true;
                    txtSinhToDau.Text = "1";

                }
                else
                {
                    txtSinhToDau.Enabled = false;
                    txtSinhToDau.Text = "0";
                }
            }
            else if (label == "Chanh Tuyết")
            {
                if (chkChanhTuyet.Checked == true)
                {
                    txtChanhTuyet.Enabled = true;
                    txtChanhTuyet.Text = "1";

                }
                else
                {
                    txtChanhTuyet.Enabled = false;
                    txtChanhTuyet.Text = "0";
                }
            }
            else if (label == "Bơ")
            {
                if (chkSinhToBo.Checked == true)
                {
                    txtSinhToBo.Enabled = true;
                    txtSinhToBo.Text = "1";

                }
                else
                {
                    txtSinhToBo.Enabled = false;
                    txtSinhToBo.Text = "0";
                }
            }
            else if (label == "Xoài")
            {
                if (chkSinhToXoai.Checked == true)
                {
                    txtSinhToXoai.Enabled = true;
                    txtSinhToXoai.Text = "1";

                }
                else
                {
                    txtSinhToXoai.Enabled = false;
                    txtSinhToXoai.Text = "0";
                }
            }
            else if (label == "Dâu Xoài Cam")
            {
                if (chkDauXoaiCam.Checked == true)
                {
                    txtDauXoaiCam.Enabled = true;
                    txtDauXoaiCam.Text = "1";

                }
                else
                {
                    txtDauXoaiCam.Enabled = false;
                    txtDauXoaiCam.Text = "0";
                }
            }
            //Nuoc Ep
            else if (label == "Cam" && name.Contains("NuocEpCam"))
            {
                if (chkNuocEpCam.Checked == true)
                {
                    txtNuocEpCam.Enabled = true;
                    txtNuocEpCam.Text = "1";

                }
                else
                {
                    txtNuocEpCam.Enabled = false;
                    txtNuocEpCam.Text = "0";
                }
            }
            else if (label == "Chanh" && name.Contains("NuocEpChanh"))
            {
                if (chkNuocEpChanh.Checked == true)
                {
                    txtNuocEpChanh.Enabled = true;
                    txtNuocEpChanh.Text = "1";

                }
                else
                {
                    txtNuocEpChanh.Enabled = false;
                    txtNuocEpChanh.Text = "0";
                }
            }
            else if (label == "Chanh Ổi")
            {
                if (chkChanhOi.Checked == true)
                {
                    txtChanhOi.Enabled = true;
                    txtChanhOi.Text = "1";

                }
                else
                {
                    txtChanhOi.Enabled = false;
                    txtChanhOi.Text = "0";
                }
            }
            else if (label == "Chanh Đào")
            {
                if (chkChanhDao.Checked == true)
                {
                    txtChanhDao.Enabled = true;
                    txtChanhDao.Text = "1";

                }
                else
                {
                    txtChanhDao.Enabled = false;
                    txtChanhDao.Text = "0";
                }
            }
            else if (label == "Chanh Mật Ong")
            {
                if (chkChanhMatOng.Checked == true)
                {
                    txtChanhMatOng.Enabled = true;
                    txtChanhMatOng.Text = "1";

                }
                else
                {
                    txtChanhMatOng.Enabled = false;
                    txtChanhMatOng.Text = "0";
                }
            }
            else if (label == "Chanh Dây" && name.Contains("NuocEpChanhDay"))
            {
                if (chkNuocEpChanhDay.Checked == true)
                {
                    txtNuocEpChanhDay.Enabled = true;
                    txtNuocEpChanhDay.Text = "1";

                }
                else
                {
                    txtNuocEpChanhDay.Enabled = false;
                    txtNuocEpChanhDay.Text = "0";
                }
            }
            //Sua Chua
            else if (label == "Đá Xay" && name.Contains("SuaChuaDaXay"))
            {
                if (chkSuaChuaDaXay.Checked == true)
                {
                    txtSuaChuaDaXay.Enabled = true;
                    txtSuaChuaDaXay.Text = "1";

                }
                else
                {
                    txtSuaChuaDaXay.Enabled = false;
                    txtSuaChuaDaXay.Text = "0";
                }
            }
            else if (label == "Việt Quất" && name.Contains("SuaChuaVietQuat"))
            {
                if (chkSuaChuaVietQuat.Checked == true)
                {
                    txtSuaChuaVietQuat.Enabled = true;
                    txtSuaChuaVietQuat.Text = "1";

                }
                else
                {
                    txtSuaChuaVietQuat.Enabled = false;
                    txtSuaChuaVietQuat.Text = "0";
                }
            }
            else if (label == "Đào" && name.Contains("SuaChuaDao"))
            {
                if (chkSuaChuaDao.Checked == true)
                {
                    txtSuaChuaDao.Enabled = true;
                    txtSuaChuaDao.Text = "1";

                }
                else
                {
                    txtSuaChuaDao.Enabled = false;
                    txtSuaChuaDao.Text = "0";
                }
            }
            else if (label == "Dâu" && name.Contains("SuaChuaDau"))
            {
                if (chkSuaChuaDau.Checked == true)
                {
                    txtSuaChuaDau.Enabled = true;
                    txtSuaChuaDau.Text = "1";

                }
                else
                {
                    txtSuaChuaDau.Enabled = false;
                    txtSuaChuaDau.Text = "0";
                }
            }
            else if (label == "Chanh Dây" && name.Contains("SuaChuaChanhDay"))
            {
                if (chkSuaChuaChanhDay.Checked == true)
                {
                    txtSuaChuaChanhDay.Enabled = true;
                    txtSuaChuaChanhDay.Text = "1";

                }
                else
                {
                    txtSuaChuaChanhDay.Enabled = false;
                    txtSuaChuaChanhDay.Text = "0";
                }
            }
            //Soda
            else if (label == "Chanh" && name.Contains("SodaChanh"))
            {
                if (chkSodaChanh.Checked == true)
                {
                    txtSodaChanh.Enabled = true;
                    txtSodaChanh.Text = "1";

                }
                else
                {
                    txtSodaChanh.Enabled = false;
                    txtSodaChanh.Text = "0";
                }
            }
            else if (label == "Blue Cucarao")
            {
                if (chkBlueCucarao.Checked == true)
                {
                    txtBlueCucarao.Enabled = true;
                    txtBlueCucarao.Text = "1";

                }
                else
                {
                    txtBlueCucarao.Enabled = false;
                    txtBlueCucarao.Text = "0";
                }
            }
            else if (label == "Đào" && name.Contains("SodaDao"))
            {
                if (chkSodaDao.Checked == true)
                {
                    txtSodaDao.Enabled = true;
                    txtSodaDao.Text = "1";

                }
                else
                {
                    txtSodaDao.Enabled = false;
                    txtSodaDao.Text = "0";
                }
            }
            else if (label == "Bạc Hà" && name.Contains("SodaBacHa"))
            {
                if (chkSodaBacHa.Checked == true)
                {
                    txtSodaBacHa.Enabled = true;
                    txtSodaBacHa.Text = "1";

                }
                else
                {
                    txtSodaBacHa.Enabled = false;
                    txtSodaBacHa.Text = "0";
                }
            }
            else if (label == "Cam" && name.Contains("SodaCam"))
            {
                if (chkSodaCam.Checked == true)
                {
                    txtSodaCam.Enabled = true;
                    txtSodaCam.Text = "1";

                }
                else
                {
                    txtSodaCam.Enabled = false;
                    txtSodaCam.Text = "0";
                }
            }
            //Trà
            else if (name == "chkTraDenMacchiato")
            {
                if (chkTraDenMacchiato.Checked == true)
                {
                    txtTraDenMacchiato.Enabled = true;
                    txtTraDenMacchiato.Text = "1";

                }
                else
                {
                    txtTraDenMacchiato.Enabled = false;
                    txtTraDenMacchiato.Text = "0";
                }
            }
            else if (label == "Matcha Macchiato")
            {
                if (chkMatchaMacchiato.Checked == true)
                {
                    txtMatchaMacchiato.Enabled = true;
                    txtMatchaMacchiato.Text = "1";

                }
                else
                {
                    txtMatchaMacchiato.Enabled = false;
                    txtMatchaMacchiato.Text = "0";
                }
            }
            else if (label == "Trà Ô Long Macchiato")
            {
                if (chkTraOLongMacchiato.Checked == true)
                {
                    txtTraOLongMacchiato.Enabled = true;
                    txtTraOLongMacchiato.Text = "1";

                }
                else
                {
                    txtTraOLongMacchiato.Enabled = false;
                    txtTraOLongMacchiato.Text = "0";
                }
            }
            else if (label == "Lục Trà Macchiato")
            {
                if (chkLucTraMacchiato.Checked == true)
                {
                    txtLucTraMacchiato.Enabled = true;
                    txtLucTraMacchiato.Text = "1";

                }
                else
                {
                    txtLucTraMacchiato.Enabled = false;
                    txtLucTraMacchiato.Text = "0";
                }
            }
            else if (label == "Trà Xoài Macchiato")
            {
                if (chkTraXoaiMacchiato.Checked == true)
                {
                    txtTraXoaiMacchiato.Enabled = true;
                    txtTraXoaiMacchiato.Text = "1";

                }
                else
                {
                    txtTraXoaiMacchiato.Enabled = false;
                    txtTraXoaiMacchiato.Text = "0";
                }
            }
            else if (name == "chkHoaDauBiecMacchiato")
            {
                if (chkHoaDauBiecMacchiato.Checked == true)
                {
                    txtHoaDauBiecMacchiato.Enabled = true;
                    txtHoaDauBiecMacchiato.Text = "1";

                }
                else
                {
                    txtHoaDauBiecMacchiato.Enabled = false;
                    txtHoaDauBiecMacchiato.Text = "0";
                }
            }
            else if (label == "Trà Sữa Thái Xanh")
            {
                if (chkTraSuaThaiXanh.Checked == true)
                {
                    txtTraSuaThaiXanh.Enabled = true;
                    txtTraSuaThaiXanh.Text = "1";

                }
                else
                {
                    txtTraSuaThaiXanh.Enabled = false;
                    txtTraSuaThaiXanh.Text = "0";
                }
            }
            else if (label == "Trà Hoa Đậu Biếc")
            {
                if (chkTraHoaDauBiec.Checked == true)
                {
                    txtTraHoaDauBiec.Enabled = true;
                    txtTraHoaDauBiec.Text = "1";

                }
                else
                {
                    txtTraHoaDauBiec.Enabled = false;
                    txtTraHoaDauBiec.Text = "0";
                }
            }
            else if (label == "Trà Hoa Cúc")
            {
                if (chkTraHoaCuc.Checked == true)
                {
                    txtTraHoaCuc.Enabled = true;
                    txtTraHoaCuc.Text = "1";

                }
                else
                {
                    txtTraHoaCuc.Enabled = false;
                    txtTraHoaCuc.Text = "0";
                }
            }
            else if (label == "Trà Hoa Cúc Hạt Chia")
            {
                if (chkTraHoaCucHatChia.Checked == true)
                {
                    txtTraHoaCucHatChia.Enabled = true;
                    txtTraHoaCucHatChia.Text = "1";

                }
                else
                {
                    txtTraHoaCucHatChia.Enabled = false;
                    txtTraHoaCucHatChia.Text = "0";
                }
            }
            else if (name == "chkTraHoaHongMatOng")
            {
                if (chkTraHoaHongMatOng.Checked == true)
                {
                    txtTraHoaHongMatOng.Enabled = true;
                    txtTraHoaHongMatOng.Text = "1";

                }
                else
                {
                    txtTraHoaHongMatOng.Enabled = false;
                    txtTraHoaHongMatOng.Text = "0";
                }
            }
            else if (label == "Trà Đào")
            {
                if (chkTraDao.Checked == true)
                {
                    txtTraDao.Enabled = true;
                    txtTraDao.Text = "1";

                }
                else
                {
                    txtTraDao.Enabled = false;
                    txtTraDao.Text = "0";
                }
            }
            else if (label == "Trà Đào Cam Sả")
            {
                if (chkTraDaoCamSa.Checked == true)
                {
                    txtTraDaoCamSa.Enabled = true;
                    txtTraDaoCamSa.Text = "1";

                }
                else
                {
                    txtTraDaoCamSa.Enabled = false;
                    txtTraDaoCamSa.Text = "0";
                }
            }
            else if (name == "chkTraVaiHatChia")
            {
                if (chkTraVaiHatChia.Checked == true)
                {
                    txtTraVaiHatChia.Enabled = true;
                    txtTraVaiHatChia.Text = "1";

                }
                else
                {
                    txtTraVaiHatChia.Enabled = false;
                    txtTraVaiHatChia.Text = "0";
                }
            }
            else if (label == "Trà Vải Dưa Hấu")
            {
                if (chkTraVaiDuaHau.Checked == true)
                {
                    txtTraVaiDuaHau.Enabled = true;
                    txtTraVaiDuaHau.Text = "1";

                }
                else
                {
                    txtTraVaiDuaHau.Enabled = false;
                    txtTraVaiDuaHau.Text = "0";
                }
            }

            else if (name == "chkTraLiptonSua")
            {
                if (chkTraLiptonSua.Checked == true)
                {
                    txtTraLiptonSua.Enabled = true;
                    txtTraLiptonSua.Text = "1";

                }
                else
                {
                    txtTraLiptonSua.Enabled = false;
                    txtTraLiptonSua.Text = "0";
                }
            }
            else if (label == "Trà Lipton Chanh")
            {
                if (chkTraLiptonChanh.Checked == true)
                {
                    txtTraLiptonChanh.Enabled = true;
                    txtTraLiptonChanh.Text = "1";

                }
                else
                {
                    txtTraLiptonChanh.Enabled = false;
                    txtTraLiptonChanh.Text = "0";
                }
            }
            else if (name == "chkTraVietQuat")
            {
                if (chkTraVietQuat.Checked == true)
                {
                    txtTraVietQuat.Enabled = true;
                    txtTraVietQuat.Text = "1";

                }
                else
                {
                    txtTraVietQuat.Enabled = false;
                    txtTraVietQuat.Text = "0";
                }
            }
            else if (label == "Trà Cam Mật Ong")
            {
                if (chkTraCamMatOng.Checked == true)
                {
                    txtTraCamMatOng.Enabled = true;
                    txtTraCamMatOng.Text = "1";

                }
                else
                {
                    txtTraCamMatOng.Enabled = false;
                    txtTraCamMatOng.Text = "0";
                }
            }
            else if (label == "Trà Gừng Mật Ong")
            {
                if (chkTraGungMatOng.Checked == true)
                {
                    txtTraGungMatOng.Enabled = true;
                    txtTraGungMatOng.Text = "1";

                }
                else
                {
                    txtTraGungMatOng.Enabled = false;
                    txtTraGungMatOng.Text = "0";
                }
            }
            else if (label == "Trà Lài")
            {
                if (chkTraLai.Checked == true)
                {
                    txtTraLai.Enabled = true;
                    txtTraLai.Text = "1";

                }
                else
                {
                    txtTraLai.Enabled = false;
                    txtTraLai.Text = "0";
                }
            }
            //Topping
            else if (label == "Trân Châu Đường Đen")
            {
                if (chkTranChauDuongDen.Checked == true)
                {
                    txtTranChauDuongDen.Enabled = true;
                    txtTranChauDuongDen.Text = "1";

                }
                else
                {
                    txtTranChauDuongDen.Enabled = false;
                    txtTranChauDuongDen.Text = "0";
                }
            }
            else if (name == "chkOreoTopping")
            {
                if (chkOreoTopping.Checked == true)
                {
                    txtOreoTopping.Enabled = true;
                    txtOreoTopping.Text = "1";

                }
                else
                {
                    txtOreoTopping.Enabled = false;
                    txtOreoTopping.Text = "0";
                }
            }
            else if (label == "Plan Trứng")
            {
                if (chkPlanTrung.Checked == true)
                {
                    txtPlanTrung.Enabled = true;
                    txtPlanTrung.Text = "1";

                }
                else
                {
                    txtPlanTrung.Enabled = false;
                    txtPlanTrung.Text = "0";
                }
            }
            else if (label == "Plan Chocolate")
            {
                if (chkPlanChocolate.Checked == true)
                {
                    txtPlanChocolate.Enabled = true;
                    txtPlanChocolate.Text = "1";

                }
                else
                {
                    txtPlanChocolate.Enabled = false;
                    txtPlanChocolate.Text = "0";
                }
            }
            else if (label == "Sương Sáo")
            {
                if (chkSuongSao.Checked == true)
                {
                    txtSuongSao.Enabled = true;
                    txtSuongSao.Text = "1";

                }
                else
                {
                    txtSuongSao.Enabled = false;
                    txtSuongSao.Text = "0";
                }
            }
            else if (name == "chkThachPhoMai")
            {
                if (chkThachPhoMai.Checked == true)
                {
                    txtThachPhoMai.Enabled = true;
                    txtThachPhoMai.Text = "1";

                }
                else
                {
                    txtThachPhoMai.Enabled = false;
                    txtThachPhoMai.Text = "0";
                }
            }
            else if (name == "chkMacchiatoTopping")
            {
                if (chkMacchiatoTopping.Checked == true)
                {
                    txtMacchiatoTopping.Enabled = true;
                    txtMacchiatoTopping.Text = "1";

                }
                else
                {
                    txtMacchiatoTopping.Enabled = false;
                    txtMacchiatoTopping.Text = "0";
                }
            }
            else if (label == "Whippin Cream")
            {
                if (chkWhippinCream.Checked == true)
                {
                    txtWhippinCream.Enabled = true;
                    txtWhippinCream.Text = "1";

                }
                else
                {
                    txtWhippinCream.Enabled = false;
                    txtWhippinCream.Text = "0";
                }
            }
            //End
        }



        private void plus_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Name;
            //Cafe Viet
            if (s.Contains("DenDa"))
            {
                if (!chkDenDa.Checked)
                {
                    chkDenDa.Checked = true;
                    txtDenDa.Enabled = true;
                    txtDenDa.Text = "1";

                }
                else
                    txtDenDa.Text = (Int32.Parse(txtDenDa.Text) + 1).ToString();

            }
            else if (s.Contains("SuaDa"))
            {
                if (!chkSuaDa.Checked)
                {
                    chkSuaDa.Checked = true;

                    txtSuaDa.Enabled = true;
                    txtSuaDa.Text = "1";

                }
                else
                    txtSuaDa.Text = (Int32.Parse(txtSuaDa.Text) + 1).ToString();

            }
            else if (s.Contains("BacSiu"))
            {
                if (!chkBacSiu.Checked)
                {
                    chkBacSiu.Checked = true;

                    txtBacSiu.Enabled = true;
                    txtBacSiu.Text = "1";

                }
                else
                    txtBacSiu.Text = (Int32.Parse(txtBacSiu.Text) + 1).ToString();

            }
            else if (s.Contains("CafeSuaTuoi"))
            {
                if (!chkCafeSuaTuoi.Checked)
                {
                    chkCafeSuaTuoi.Checked = true;

                    txtCafeSuaTuoi.Enabled = true;
                    txtCafeSuaTuoi.Text = "1";

                }
                else
                    txtCafeSuaTuoi.Text = (Int32.Parse(txtCafeSuaTuoi.Text) + 1).ToString();

            }
            //Da Xay
            else if (s == "plusChocolate")
            {
                if (!chkChocolate.Checked)
                {
                    chkChocolate.Checked = true;

                    txtChocolate.Enabled = true;
                    txtChocolate.Text = "1";

                }
                else
                    txtChocolate.Text = (Int32.Parse(txtChocolate.Text) + 1).ToString();

            }
            else if (s =="plusOreo")
            {
                if (!chkOreo.Checked)
                {
                    chkOreo.Checked = true;

                    txtOreo.Enabled = true;
                    txtOreo.Text = "1";

                }
                else
                    txtOreo.Text = (Int32.Parse(txtOreo.Text) + 1).ToString();

            }
            else if (s.Contains("CafeDaXay"))
            {
                if (!chkCafeDaXay.Checked)
                {
                    chkCafeDaXay.Checked = true;

                    txtCafeDaXay.Enabled = true;
                    txtCafeDaXay.Text = "1";

                }
                else
                    txtCafeDaXay.Text = (Int32.Parse(txtCafeDaXay.Text) + 1).ToString();

            }
            else if (s =="plusMatcha")
            {
                if (!chkMatcha.Checked)
                {
                    chkMatcha.Checked = true;

                    txtMatcha.Enabled = true;
                    txtMatcha.Text = "1";

                }
                else
                    txtMatcha.Text = (Int32.Parse(txtMatcha.Text) + 1).ToString();

            }

            //Sinh To
            else if (s.Contains("CamChanhDay"))
            {
                if (!chkCamChanhDay.Checked)
                {
                    chkCamChanhDay.Checked = true;

                    txtCamChanhDay.Enabled = true;
                    txtCamChanhDay.Text = "1";

                }
                else
                    txtCamChanhDay.Text = (Int32.Parse(txtCamChanhDay.Text) + 1).ToString();

            }
            else if (s.Contains("SinhToDau"))
            {
                if (!chkSinhToDau.Checked)
                {
                    chkSinhToDau.Checked = true;

                    txtSinhToDau.Enabled = true;
                    txtSinhToDau.Text = "1";

                }
                else
                    txtSinhToDau.Text = (Int32.Parse(txtSinhToDau.Text) + 1).ToString();

            }
            else if (s.Contains("ChanhTuyet"))
            {
                if (!chkChanhTuyet.Checked)
                {
                    chkChanhTuyet.Checked = true;

                    txtChanhTuyet.Enabled = true;
                    txtChanhTuyet.Text = "1";

                }
                else
                    txtChanhTuyet.Text = (Int32.Parse(txtChanhTuyet.Text) + 1).ToString();

            }
            else if (s.Contains("SinhToBo"))
            {
                if (!chkSinhToBo.Checked)
                {
                    chkSinhToBo.Checked = true;

                    txtSinhToBo.Enabled = true;
                    txtSinhToBo.Text = "1";

                }
                else
                    txtSinhToBo.Text = (Int32.Parse(txtSinhToBo.Text) + 1).ToString();

            }
            else if (s.Contains("SinhToXoai"))
            {
                if (!chkSinhToXoai.Checked)
                {
                    chkSinhToXoai.Checked = true;

                    txtSinhToXoai.Enabled = true;
                    txtSinhToXoai.Text = "1";

                }
                else
                    txtSinhToXoai.Text = (Int32.Parse(txtSinhToXoai.Text) + 1).ToString();

            }
            else if (s.Contains("DauXoaiCam"))
            {
                if (!chkDauXoaiCam.Checked)
                {
                    chkDauXoaiCam.Checked = true;

                    txtDauXoaiCam.Enabled = true;
                    txtDauXoaiCam.Text = "1";

                }
                else
                    txtDauXoaiCam.Text = (Int32.Parse(txtDauXoaiCam.Text) + 1).ToString();

            }
            //Nuoc Ep
            else if (s.Contains("NuocEpCam"))
            {
                if (!chkNuocEpCam.Checked)
                {
                    chkNuocEpCam.Checked = true;

                    txtNuocEpCam.Enabled = true;
                    txtNuocEpCam.Text = "1";

                }
                else
                    txtNuocEpCam.Text = (Int32.Parse(txtNuocEpCam.Text) + 1).ToString();

            }
            else if (s.Contains("NuocEpChanhDay"))
            {
                if (!chkNuocEpChanhDay.Checked)
                {
                    chkNuocEpChanhDay.Checked = true;

                    txtNuocEpChanhDay.Enabled = true;
                    txtNuocEpChanhDay.Text = "1";

                }
                else
                    txtNuocEpChanhDay.Text = (Int32.Parse(txtNuocEpChanhDay.Text) + 1).ToString();

            }
            else if (s.Contains("NuocEpChanh"))
            {
                if (!chkNuocEpChanh.Checked)
                {
                    chkNuocEpChanh.Checked = true;

                    txtNuocEpChanh.Enabled = true;
                    txtNuocEpChanh.Text = "1";

                }
                else
                    txtNuocEpChanh.Text = (Int32.Parse(txtNuocEpChanh.Text) + 1).ToString();

            }
            else if (s.Contains("ChanhOi"))
            {
                if (!chkChanhOi.Checked)
                {
                    chkChanhOi.Checked = true;

                    txtChanhOi.Enabled = true;
                    txtChanhOi.Text = "1";

                }
                else
                    txtChanhOi.Text = (Int32.Parse(txtChanhOi.Text) + 1).ToString();

            }
            else if (s.Contains("ChanhDao"))
            {
                if (!chkChanhDao.Checked)
                {
                    chkChanhDao.Checked = true;

                    txtChanhDao.Enabled = true;
                    txtChanhDao.Text = "1";

                }
                else
                    txtChanhDao.Text = (Int32.Parse(txtChanhDao.Text) + 1).ToString();

            }
            else if (s.Contains("ChanhMatOng"))
            {
                if (!chkChanhMatOng.Checked)
                {
                    chkChanhMatOng.Checked = true;

                    txtChanhMatOng.Enabled = true;
                    txtChanhMatOng.Text = "1";

                }
                else
                    txtChanhMatOng.Text = (Int32.Parse(txtChanhMatOng.Text) + 1).ToString();

            }

            //Sua Chua
            else if (s.Contains("SuaChuaDaXay"))
            {
                if (!chkSuaChuaDaXay.Checked)
                {
                    chkSuaChuaDaXay.Checked = true;

                    txtSuaChuaDaXay.Enabled = true;
                    txtSuaChuaDaXay.Text = "1";

                }
                else
                    txtSuaChuaDaXay.Text = (Int32.Parse(txtSuaChuaDaXay.Text) + 1).ToString();

            }
            else if (s.Contains("SuaChuaVietQuat"))
            {
                if (!chkSuaChuaVietQuat.Checked)
                {
                    chkSuaChuaVietQuat.Checked = true;

                    txtSuaChuaVietQuat.Enabled = true;
                    txtSuaChuaVietQuat.Text = "1";

                }
                else
                    txtSuaChuaVietQuat.Text = (Int32.Parse(txtSuaChuaVietQuat.Text) + 1).ToString();

            }
            else if (s.Contains("SuaChuaDao"))
            {
                if (!chkSuaChuaDao.Checked)
                {
                    chkSuaChuaDao.Checked = true;

                    txtSuaChuaDao.Enabled = true;
                    txtSuaChuaDao.Text = "1";

                }
                else
                    txtSuaChuaDao.Text = (Int32.Parse(txtSuaChuaDao.Text) + 1).ToString();

            }
            else if (s.Contains("SuaChuaDau"))
            {
                if (!chkSuaChuaDau.Checked)
                {
                    chkSuaChuaDau.Checked = true;

                    txtSuaChuaDau.Enabled = true;
                    txtSuaChuaDau.Text = "1";

                }
                else
                    txtSuaChuaDau.Text = (Int32.Parse(txtSuaChuaDau.Text) + 1).ToString();

            }
            else if (s.Contains("SuaChuaChanhDay"))
            {
                if (!chkSuaChuaChanhDay.Checked)
                {
                    chkSuaChuaChanhDay.Checked = true;

                    txtSuaChuaChanhDay.Enabled = true;
                    txtSuaChuaChanhDay.Text = "1";

                }
                else
                    txtSuaChuaChanhDay.Text = (Int32.Parse(txtSuaChuaChanhDay.Text) + 1).ToString();

            }
            //Soda
            else if (s.Contains("SodaChanh"))
            {
                if (!chkSodaChanh.Checked)
                {
                    chkSodaChanh.Checked = true;

                    txtSodaChanh.Enabled = true;
                    txtSodaChanh.Text = "1";

                }
                else
                    txtSodaChanh.Text = (Int32.Parse(txtSodaChanh.Text) + 1).ToString();

            }
            else if (s.Contains("BlueCucarao"))
            {
                if (!chkBlueCucarao.Checked)
                {
                    chkBlueCucarao.Checked = true;

                    txtBlueCucarao.Enabled = true;
                    txtBlueCucarao.Text = "1";

                }
                else
                    txtBlueCucarao.Text = (Int32.Parse(txtBlueCucarao.Text) + 1).ToString();

            }
            else if (s.Contains("SodaDao"))
            {
                if (!chkSodaDao.Checked)
                {
                    chkSodaDao.Checked = true;

                    txtSodaDao.Enabled = true;
                    txtSodaDao.Text = "1";

                }
                else
                    txtSodaDao.Text = (Int32.Parse(txtSodaDao.Text) + 1).ToString();

            }
            else if (s.Contains("SodaBacHa"))
            {
                if (!chkSodaBacHa.Checked)
                {
                    chkSodaBacHa.Checked = true;

                    txtSodaBacHa.Enabled = true;
                    txtSodaBacHa.Text = "1";

                }
                else
                    txtSodaBacHa.Text = (Int32.Parse(txtSodaBacHa.Text) + 1).ToString();

            }
            else if (s.Contains("SodaCam"))
            {
                if (!chkSodaCam.Checked)
                {
                    chkSodaCam.Checked = true;

                    txtSodaCam.Enabled = true;
                    txtSodaCam.Text = "1";

                }
                else
                    txtSodaCam.Text = (Int32.Parse(txtSodaCam.Text) + 1).ToString();

            }
            //TraAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            else if (s.Contains("TraDenMacchiato"))
            {
                if (!chkTraDenMacchiato.Checked)
                {
                    chkTraDenMacchiato.Checked = true;

                    txtTraDenMacchiato.Enabled = true;
                    txtTraDenMacchiato.Text = "1";

                }
                else
                    txtTraDenMacchiato.Text = (Int32.Parse(txtTraDenMacchiato.Text) + 1).ToString();

            }
            else if (s.Contains("MatchaMacchiato"))
            {
                if (!chkMatchaMacchiato.Checked)
                {
                    chkMatchaMacchiato.Checked = true;

                    txtMatchaMacchiato.Enabled = true;
                    txtMatchaMacchiato.Text = "1";

                }
                else
                    txtMatchaMacchiato.Text = (Int32.Parse(txtMatchaMacchiato.Text) + 1).ToString();

            }
            else if (s.Contains("TraOLongMacchiato"))
            {
                if (!chkTraOLongMacchiato.Checked)
                {
                    chkTraOLongMacchiato.Checked = true;

                    txtTraOLongMacchiato.Enabled = true;
                    txtTraOLongMacchiato.Text = "1";

                }
                else
                    txtTraOLongMacchiato.Text = (Int32.Parse(txtTraOLongMacchiato.Text) + 1).ToString();

            }
            else if (s.Contains("LucTraMacchiato"))
            {
                if (!chkLucTraMacchiato.Checked)
                {
                    chkLucTraMacchiato.Checked = true;

                    txtLucTraMacchiato.Enabled = true;
                    txtLucTraMacchiato.Text = "1";

                }
                else
                    txtLucTraMacchiato.Text = (Int32.Parse(txtLucTraMacchiato.Text) + 1).ToString();

            }
            else if (s.Contains("TraXoaiMacchiato"))
            {
                if (!chkTraXoaiMacchiato.Checked)
                {
                    chkTraXoaiMacchiato.Checked = true;

                    txtTraXoaiMacchiato.Enabled = true;
                    txtTraXoaiMacchiato.Text = "1";

                }
                else
                    txtTraXoaiMacchiato.Text = (Int32.Parse(txtTraXoaiMacchiato.Text) + 1).ToString();

            }
            else if (s.Contains("HoaDauBiecMacchiato"))
            {
                if (!chkHoaDauBiecMacchiato.Checked)
                {
                    chkHoaDauBiecMacchiato.Checked = true;

                    txtHoaDauBiecMacchiato.Enabled = true;
                    txtHoaDauBiecMacchiato.Text = "1";

                }
                else
                    txtHoaDauBiecMacchiato.Text = (Int32.Parse(txtHoaDauBiecMacchiato.Text) + 1).ToString();

            }
            else if (s.Contains("TraSuaThaiXanh"))
            {
                if (!chkTraSuaThaiXanh.Checked)
                {
                    chkTraSuaThaiXanh.Checked = true;

                    txtTraSuaThaiXanh.Enabled = true;
                    txtTraSuaThaiXanh.Text = "1";

                }
                else
                    txtTraSuaThaiXanh.Text = (Int32.Parse(txtTraSuaThaiXanh.Text) + 1).ToString();

            }
            else if (s.Contains("TraHoaDauBiec"))
            {
                if (!chkTraHoaDauBiec.Checked)
                {
                    chkTraHoaDauBiec.Checked = true;

                    txtTraHoaDauBiec.Enabled = true;
                    txtTraHoaDauBiec.Text = "1";

                }
                else
                    txtTraHoaDauBiec.Text = (Int32.Parse(txtTraHoaDauBiec.Text) + 1).ToString();

            }
            else if (s =="plusTraHoaCuc")
            {
                if (!chkTraHoaCuc.Checked)
                {
                    chkTraHoaCuc.Checked = true;

                    txtTraHoaCuc.Enabled = true;
                    txtTraHoaCuc.Text = "1";

                }
                else
                    txtTraHoaCuc.Text = (Int32.Parse(txtTraHoaCuc.Text) + 1).ToString();

            }
            else if (s.Contains("TraHoaCucHatChia"))
            {
                if (!chkTraHoaCucHatChia.Checked)
                {
                    chkTraHoaCucHatChia.Checked = true;

                    txtTraHoaCucHatChia.Enabled = true;
                    txtTraHoaCucHatChia.Text = "1";

                }
                else
                    txtTraHoaCucHatChia.Text = (Int32.Parse(txtTraHoaCucHatChia.Text) + 1).ToString();

            }
            else if (s.Contains("TraHoaHongMatOng"))
            {
                if (!chkTraHoaHongMatOng.Checked)
                {
                    chkTraHoaHongMatOng.Checked = true;

                    txtTraHoaHongMatOng.Enabled = true;
                    txtTraHoaHongMatOng.Text = "1";

                }
                else
                    txtTraHoaHongMatOng.Text = (Int32.Parse(txtTraHoaHongMatOng.Text) + 1).ToString();

            }
            else if (s =="plusTraDao")
            {
                if (!chkTraDao.Checked)
                {
                    chkTraDao.Checked = true;

                    txtTraDao.Enabled = true;
                    txtTraDao.Text = "1";

                }
                else
                    txtTraDao.Text = (Int32.Parse(txtTraDao.Text) + 1).ToString();

            }
            else if (s.Contains("TraDaoCamSa"))
            {
                if (!chkTraDaoCamSa.Checked)
                {
                    chkTraDaoCamSa.Checked = true;

                    txtTraDaoCamSa.Enabled = true;
                    txtTraDaoCamSa.Text = "1";

                }
                else
                    txtTraDaoCamSa.Text = (Int32.Parse(txtTraDaoCamSa.Text) + 1).ToString();

            }
            else if (s.Contains("TraVaiHatChia"))
            {
                if (!chkTraVaiHatChia.Checked)
                {
                    chkTraVaiHatChia.Checked = true;

                    txtTraVaiHatChia.Enabled = true;
                    txtTraVaiHatChia.Text = "1";

                }
                else
                    txtTraVaiHatChia.Text = (Int32.Parse(txtTraVaiHatChia.Text) + 1).ToString();

            }
            else if (s.Contains("TraVaiDuaHau"))
            {
                if (!chkTraVaiDuaHau.Checked)
                {
                    chkTraVaiDuaHau.Checked = true;

                    txtTraVaiDuaHau.Enabled = true;
                    txtTraVaiDuaHau.Text = "1";

                }
                else
                    txtTraVaiDuaHau.Text = (Int32.Parse(txtTraVaiDuaHau.Text) + 1).ToString();

            }
            else if (s.Contains("TraLiptonChanh"))
            {
                if (!chkTraLiptonChanh.Checked)
                {
                    chkTraLiptonChanh.Checked = true;

                    txtTraLiptonChanh.Enabled = true;
                    txtTraLiptonChanh.Text = "1";

                }
                else
                    txtTraLiptonChanh.Text = (Int32.Parse(txtTraLiptonChanh.Text) + 1).ToString();

            }
            else if (s.Contains("TraLiptonSua"))
            {
                if (!chkTraLiptonSua.Checked)
                {
                    chkTraLiptonSua.Checked = true;

                    txtTraLiptonSua.Enabled = true;
                    txtTraLiptonSua.Text = "1";

                }
                else
                    txtTraLiptonSua.Text = (Int32.Parse(txtTraLiptonSua.Text) + 1).ToString();

            }
            else if (s.Contains("TraVietQuat"))
            {
                if (!chkTraVietQuat.Checked)
                {
                    chkTraVietQuat.Checked = true;

                    txtTraVietQuat.Enabled = true;
                    txtTraVietQuat.Text = "1";

                }
                else
                    txtTraVietQuat.Text = (Int32.Parse(txtTraVietQuat.Text) + 1).ToString();

            }
            else if (s.Contains("TraCamMatOng"))
            {
                if (!chkTraCamMatOng.Checked)
                {
                    chkTraCamMatOng.Checked = true;

                    txtTraCamMatOng.Enabled = true;
                    txtTraCamMatOng.Text = "1";

                }
                else
                    txtTraCamMatOng.Text = (Int32.Parse(txtTraCamMatOng.Text) + 1).ToString();

            }
            else if (s.Contains("TraGungMatOng"))
            {
                if (!chkTraGungMatOng.Checked)
                {
                    chkTraGungMatOng.Checked = true;

                    txtTraGungMatOng.Enabled = true;
                    txtTraGungMatOng.Text = "1";

                }
                else
                    txtTraGungMatOng.Text = (Int32.Parse(txtTraGungMatOng.Text) + 1).ToString();

            }
            else if (s.Contains("TraLai"))
            {
                if (!chkTraLai.Checked)
                {
                    chkTraLai.Checked = true;

                    txtTraLai.Enabled = true;
                    txtTraLai.Text = "1";

                }
                else
                    txtTraLai.Text = (Int32.Parse(txtTraLai.Text) + 1).ToString();

            }

            //Topinggggggggggggggggggggg
            else if (s.Contains("TranChauDuongDen"))
            {
                if (!chkTranChauDuongDen.Checked)
                {
                    chkTranChauDuongDen.Checked = true;

                    txtTranChauDuongDen.Enabled = true;
                    txtTranChauDuongDen.Text = "1";

                }
                else
                    txtTranChauDuongDen.Text = (Int32.Parse(txtTranChauDuongDen.Text) + 1).ToString();

            }
            else if (s.Contains("OreoTopping"))
            {
                if (!chkOreoTopping.Checked)
                {
                    chkOreoTopping.Checked = true;

                    txtOreoTopping.Enabled = true;
                    txtOreoTopping.Text = "1";

                }
                else
                    txtOreoTopping.Text = (Int32.Parse(txtOreoTopping.Text) + 1).ToString();

            }
            else if (s.Contains("PlanTrung"))
            {
                if (!chkPlanTrung.Checked)
                {
                    chkPlanTrung.Checked = true;

                    txtPlanTrung.Enabled = true;
                    txtPlanTrung.Text = "1";

                }
                else
                    txtPlanTrung.Text = (Int32.Parse(txtPlanTrung.Text) + 1).ToString();

            }
            else if (s.Contains("PlanChocolate"))
            {
                if (!chkPlanChocolate.Checked)
                {
                    chkPlanChocolate.Checked = true;

                    txtPlanChocolate.Enabled = true;
                    txtPlanChocolate.Text = "1";

                }
                else
                    txtPlanChocolate.Text = (Int32.Parse(txtPlanChocolate.Text) + 1).ToString();

            }
            else if (s.Contains("SuongSao"))
            {
                if (!chkSuongSao.Checked)
                {
                    chkSuongSao.Checked = true;

                    txtSuongSao.Enabled = true;
                    txtSuongSao.Text = "1";

                }
                else
                    txtSuongSao.Text = (Int32.Parse(txtSuongSao.Text) + 1).ToString();

            }
            else if (s.Contains("ThachPhoMai"))
            {
                if (!chkThachPhoMai.Checked)
                {
                    chkThachPhoMai.Checked = true;

                    txtThachPhoMai.Enabled = true;
                    txtThachPhoMai.Text = "1";

                }
                else
                    txtThachPhoMai.Text = (Int32.Parse(txtThachPhoMai.Text) + 1).ToString();

            }
            else if (s.Contains("MacchiatoTopping"))
            {
                if (!chkMacchiatoTopping.Checked)
                {
                    chkMacchiatoTopping.Checked = true;

                    txtMacchiatoTopping.Enabled = true;
                    txtMacchiatoTopping.Text = "1";

                }
                else
                    txtMacchiatoTopping.Text = (Int32.Parse(txtMacchiatoTopping.Text) + 1).ToString();

            }
            else if (s.Contains("WhippinCream"))
            {
                if (!chkWhippinCream.Checked)
                {
                    chkWhippinCream.Checked = true;

                    txtWhippinCream.Enabled = true;
                    txtWhippinCream.Text = "1";

                }
                else
                    txtWhippinCream.Text = (Int32.Parse(txtWhippinCream.Text) + 1).ToString();

            }
            //Endddddddddddddd
            


        }
        private void minus_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Name;
            //Cafe Viet
            if (s.Contains("DenDa"))
            {

                if (Int32.Parse(txtDenDa.Text) > 1)
                {
                    txtDenDa.Text = (Int32.Parse(txtDenDa.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtDenDa.Text) == 1)
                {
                    chkDenDa.Checked = false;
                    txtDenDa.Enabled = false;
                    txtDenDa.Text = "0";
                }


            }
            else if (s.Contains("SuaDa"))
            {
                if (Int32.Parse(txtSuaDa.Text) > 1)
                {
                    txtSuaDa.Text = (Int32.Parse(txtSuaDa.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtSuaDa.Text) == 1)
                {
                    chkSuaDa.Checked = false;
                    txtSuaDa.Enabled = false;
                    txtSuaDa.Text = "0";
                }

            }
            else if (s.Contains("BacSiu"))
            {
                if (Int32.Parse(txtBacSiu.Text) > 1)
                {
                    txtBacSiu.Text = (Int32.Parse(txtBacSiu.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtBacSiu.Text) == 1)
                {
                    chkBacSiu.Checked = false;
                    txtBacSiu.Enabled = false;
                    txtBacSiu.Text = "0";
                }

            }
            else if (s.Contains("CafeSuaTuoi"))
            {
                if (Int32.Parse(txtCafeSuaTuoi.Text) > 1)
                {
                    txtCafeSuaTuoi.Text = (Int32.Parse(txtCafeSuaTuoi.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtCafeSuaTuoi.Text) == 1)
                {
                    chkCafeSuaTuoi.Checked = false;
                    txtCafeSuaTuoi.Enabled = false;
                    txtCafeSuaTuoi.Text = "0";
                }

            }
            //Da Xay
            else if (s =="minusChocolate")
            {
                if (Int32.Parse(txtChocolate.Text) > 1)
                {
                    txtChocolate.Text = (Int32.Parse(txtChocolate.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtChocolate.Text) == 1)
                {
                    chkChocolate.Checked = false;
                    txtChocolate.Enabled = false;
                    txtChocolate.Text = "0";
                }

            }
            else if (s =="minusOreo")
            {
                if (Int32.Parse(txtOreo.Text) > 1)
                {
                    txtOreo.Text = (Int32.Parse(txtOreo.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtOreo.Text) == 1)
                {
                    chkOreo.Checked = false;
                    txtOreo.Enabled = false;
                    txtOreo.Text = "0";
                }

            }
            else if (s.Contains("CafeDaXay"))
            {
                if (Int32.Parse(txtCafeDaXay.Text) > 1)
                {
                    txtCafeDaXay.Text = (Int32.Parse(txtCafeDaXay.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtCafeDaXay.Text) == 1)
                {
                    chkCafeDaXay.Checked = false;
                    txtCafeDaXay.Enabled = false;
                    txtCafeDaXay.Text = "0";
                }

            }
            else if (s == "minusMatcha")
            {
                if (Int32.Parse(txtMatcha.Text) > 1)
                {
                    txtMatcha.Text = (Int32.Parse(txtMatcha.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtMatcha.Text) == 1)
                {
                    chkMatcha.Checked = false;
                    txtMatcha.Enabled = false;
                    txtMatcha.Text = "0";
                }

            }
            //Sinh To
            else if (s.Contains("CamChanhDay"))
            {
                if (Int32.Parse(txtCamChanhDay.Text) > 1)
                {
                    txtCamChanhDay.Text = (Int32.Parse(txtCamChanhDay.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtCamChanhDay.Text) == 1)
                {
                    chkCamChanhDay.Checked = false;
                    txtCamChanhDay.Enabled = false;
                    txtCamChanhDay.Text = "0";
                }

            }
            else if (s.Contains("SinhToDau"))
            {
                if (Int32.Parse(txtSinhToDau.Text) > 1)
                {
                    txtSinhToDau.Text = (Int32.Parse(txtSinhToDau.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtSinhToDau.Text) == 1)
                {
                    chkSinhToDau.Checked = false;
                    txtSinhToDau.Enabled = false;
                    txtSinhToDau.Text = "0";
                }

            }
            else if (s.Contains("ChanhTuyet"))
            {
                if (Int32.Parse(txtChanhTuyet.Text) > 1)
                {
                    txtChanhTuyet.Text = (Int32.Parse(txtChanhTuyet.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtChanhTuyet.Text) == 1)
                {
                    chkChanhTuyet.Checked = false;
                    txtChanhTuyet.Enabled = false;
                    txtChanhTuyet.Text = "0";
                }

            }
            else if (s.Contains("SinhToBo"))
            {
                if (Int32.Parse(txtSinhToBo.Text) > 1)
                {
                    txtSinhToBo.Text = (Int32.Parse(txtSinhToBo.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtSinhToBo.Text) == 1)
                {
                    chkSinhToBo.Checked = false;
                    txtSinhToBo.Enabled = false;
                    txtSinhToBo.Text = "0";
                }

            }
            else if (s.Contains("SinhToXoai"))
            {
                if (Int32.Parse(txtSinhToXoai.Text) > 1)
                {
                    txtSinhToXoai.Text = (Int32.Parse(txtSinhToXoai.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtSinhToXoai.Text) == 1)
                {
                    chkSinhToXoai.Checked = false;
                    txtSinhToXoai.Enabled = false;
                    txtSinhToXoai.Text = "0";
                }

            }
            else if (s.Contains("DauXoaiCam"))
            {
                if (Int32.Parse(txtDauXoaiCam.Text) > 1)
                {
                    txtDauXoaiCam.Text = (Int32.Parse(txtDauXoaiCam.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtDauXoaiCam.Text) == 1)
                {
                    chkDauXoaiCam.Checked = false;
                    txtDauXoaiCam.Enabled = false;
                    txtDauXoaiCam.Text = "0";
                }

            }
            //Nuoc Ep
            else if (s.Contains("NuocEpCam"))
            {
                if (Int32.Parse(txtNuocEpCam.Text) > 1)
                {
                    txtNuocEpCam.Text = (Int32.Parse(txtNuocEpCam.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtNuocEpCam.Text) == 1)
                {
                    chkNuocEpCam.Checked = false;
                    txtNuocEpCam.Enabled = false;
                    txtNuocEpCam.Text = "0";
                }

            }
            else if (s == "minusNuocEpChanh")
            {
                if (Int32.Parse(txtNuocEpChanh.Text) > 1)
                {
                    txtNuocEpChanh.Text = (Int32.Parse(txtNuocEpChanh.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtNuocEpChanh.Text) == 1)
                {
                    chkNuocEpChanh.Checked = false;
                    txtNuocEpChanh.Enabled = false;
                    txtNuocEpChanh.Text = "0";
                }

            }
            else if (s.Contains("ChanhOi"))
            {
                if (Int32.Parse(txtChanhOi.Text) > 1)
                {
                    txtChanhOi.Text = (Int32.Parse(txtChanhOi.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtChanhOi.Text) == 1)
                {
                    chkChanhOi.Checked = false;
                    txtChanhOi.Enabled = false;
                    txtChanhOi.Text = "0";
                }

            }
            else if (s.Contains("ChanhDao"))
            {
                if (Int32.Parse(txtChanhDao.Text) > 1)
                {
                    txtChanhDao.Text = (Int32.Parse(txtChanhDao.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtChanhDao.Text) == 1)
                {
                    chkChanhDao.Checked = false;
                    txtChanhDao.Enabled = false;
                    txtChanhDao.Text = "0";
                }

            }
            else if (s.Contains("ChanhMatOng"))
            {
                if (Int32.Parse(txtChanhMatOng.Text) > 1)
                {
                    txtChanhMatOng.Text = (Int32.Parse(txtChanhMatOng.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtChanhMatOng.Text) == 1)
                {
                    chkChanhMatOng.Checked = false;
                    txtChanhMatOng.Enabled = false;
                    txtChanhMatOng.Text = "0";
                }

            }
            else if (s == "minusNuocEpChanhDay")
            {
                if (Int32.Parse(txtNuocEpChanhDay.Text) > 1)
                {
                    txtNuocEpChanhDay.Text = (Int32.Parse(txtNuocEpChanhDay.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtNuocEpChanhDay.Text) == 1)
                {
                    chkNuocEpChanhDay.Checked = false;
                    txtNuocEpChanhDay.Enabled = false;
                    txtNuocEpChanhDay.Text = "0";
                }

            }
            //Sua Chua
            else if (s.Contains("SuaChuaDaXay"))
            {
                if (Int32.Parse(txtSuaChuaDaXay.Text) > 1)
                {
                    txtSuaChuaDaXay.Text = (Int32.Parse(txtSuaChuaDaXay.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtSuaChuaDaXay.Text) == 1)
                {
                    chkSuaChuaDaXay.Checked = false;
                    txtSuaChuaDaXay.Enabled = false;
                    txtSuaChuaDaXay.Text = "0";
                }

            }
            else if (s.Contains("SuaChuaVietQuat"))
            {
                if (Int32.Parse(txtSuaChuaVietQuat.Text) > 1)
                {
                    txtSuaChuaVietQuat.Text = (Int32.Parse(txtSuaChuaVietQuat.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtSuaChuaVietQuat.Text) == 1)
                {
                    chkSuaChuaVietQuat.Checked = false;
                    txtSuaChuaVietQuat.Enabled = false;
                    txtSuaChuaVietQuat.Text = "0";
                }

            }
            else if (s.Contains("SuaChuaDao"))
            {
                if (Int32.Parse(txtSuaChuaDao.Text) > 1)
                {
                    txtSuaChuaDao.Text = (Int32.Parse(txtSuaChuaDao.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtSuaChuaDao.Text) == 1)
                {
                    chkSuaChuaDao.Checked = false;
                    txtSuaChuaDao.Enabled = false;
                    txtSuaChuaDao.Text = "0";
                }

            }
            else if (s.Contains("SuaChuaDau"))
            {
                if (Int32.Parse(txtSuaChuaDau.Text) > 1)
                {
                    txtSuaChuaDau.Text = (Int32.Parse(txtSuaChuaDau.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtSuaChuaDau.Text) == 1)
                {
                    chkSuaChuaDau.Checked = false;
                    txtSuaChuaDau.Enabled = false;
                    txtSuaChuaDau.Text = "0";
                }

            }
            else if (s.Contains("SuaChuaChanhDay"))
            {
                if (Int32.Parse(txtSuaChuaChanhDay.Text) > 1)
                {
                    txtSuaChuaChanhDay.Text = (Int32.Parse(txtSuaChuaChanhDay.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtSuaChuaChanhDay.Text) == 1)
                {
                    chkSuaChuaChanhDay.Checked = false;
                    txtSuaChuaChanhDay.Enabled = false;
                    txtSuaChuaChanhDay.Text = "0";
                }

            }
            else if (s.Contains("SodaChanh"))
            {
                if (Int32.Parse(txtSodaChanh.Text) > 1)
                {
                    txtSodaChanh.Text = (Int32.Parse(txtSodaChanh.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtSodaChanh.Text) == 1)
                {
                    chkSodaChanh.Checked = false;
                    txtSodaChanh.Enabled = false;
                    txtSodaChanh.Text = "0";
                }

            }
            else if (s.Contains("BlueCucarao"))
            {
                if (Int32.Parse(txtBlueCucarao.Text) > 1)
                {
                    txtBlueCucarao.Text = (Int32.Parse(txtBlueCucarao.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtBlueCucarao.Text) == 1)
                {
                    chkBlueCucarao.Checked = false;
                    txtBlueCucarao.Enabled = false;
                    txtBlueCucarao.Text = "0";
                }

            }
            else if (s.Contains("SodaDao"))
            {
                if (Int32.Parse(txtSodaDao.Text) > 1)
                {
                    txtSodaDao.Text = (Int32.Parse(txtSodaDao.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtSodaDao.Text) == 1)
                {
                    chkSodaDao.Checked = false;
                    txtSodaDao.Enabled = false;
                    txtSodaDao.Text = "0";
                }

            }
            else if (s.Contains("SodaBacHa"))
            {
                if (Int32.Parse(txtSodaBacHa.Text) > 1)
                {
                    txtSodaBacHa.Text = (Int32.Parse(txtSodaBacHa.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtSodaBacHa.Text) == 1)
                {
                    chkSodaBacHa.Checked = false;
                    txtSodaBacHa.Enabled = false;
                    txtSodaBacHa.Text = "0";
                }

            }
            else if (s.Contains("SodaCam"))
            {
                if (Int32.Parse(txtSodaCam.Text) > 1)
                {
                    txtSodaCam.Text = (Int32.Parse(txtSodaCam.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtSodaCam.Text) == 1)
                {
                    chkSodaCam.Checked = false;
                    txtSodaCam.Enabled = false;
                    txtSodaCam.Text = "0";
                }

            }
            //Tra
            else if (s.Contains("TraDenMacchiato"))
            {
                if (Int32.Parse(txtTraDenMacchiato.Text) > 1)
                {
                    txtTraDenMacchiato.Text = (Int32.Parse(txtTraDenMacchiato.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraDenMacchiato.Text) == 1)
                {
                    chkTraDenMacchiato.Checked = false;
                    txtTraDenMacchiato.Enabled = false;
                    txtTraDenMacchiato.Text = "0";
                }

            }
            else if (s.Contains("MatchaMacchiato"))
            {
                if (Int32.Parse(txtMatchaMacchiato.Text) > 1)
                {
                    txtMatchaMacchiato.Text = (Int32.Parse(txtMatchaMacchiato.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtMatchaMacchiato.Text) == 1)
                {
                    chkMatchaMacchiato.Checked = false;
                    txtMatchaMacchiato.Enabled = false;
                    txtMatchaMacchiato.Text = "0";
                }

            }
            else if (s.Contains("TraOLongMacchiato"))
            {
                if (Int32.Parse(txtTraOLongMacchiato.Text) > 1)
                {
                    txtTraOLongMacchiato.Text = (Int32.Parse(txtTraOLongMacchiato.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraOLongMacchiato.Text) == 1)
                {
                    chkTraOLongMacchiato.Checked = false;
                    txtTraOLongMacchiato.Enabled = false;
                    txtTraOLongMacchiato.Text = "0";
                }

            }
            else if (s.Contains("LucTraMacchiato"))
            {
                if (Int32.Parse(txtLucTraMacchiato.Text) > 1)
                {
                    txtLucTraMacchiato.Text = (Int32.Parse(txtLucTraMacchiato.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtLucTraMacchiato.Text) == 1)
                {
                    chkLucTraMacchiato.Checked = false;
                    txtLucTraMacchiato.Enabled = false;
                    txtLucTraMacchiato.Text = "0";
                }

            }
            else if (s.Contains("TraXoaiMacchiato"))
            {
                if (Int32.Parse(txtTraXoaiMacchiato.Text) > 1)
                {
                    txtTraXoaiMacchiato.Text = (Int32.Parse(txtTraXoaiMacchiato.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraXoaiMacchiato.Text) == 1)
                {
                    chkTraXoaiMacchiato.Checked = false;
                    txtTraXoaiMacchiato.Enabled = false;
                    txtTraXoaiMacchiato.Text = "0";
                }

            }
            else if (s.Contains("HoaDauBiecMacchiato"))
            {
                if (Int32.Parse(txtHoaDauBiecMacchiato.Text) > 1)
                {
                    txtHoaDauBiecMacchiato.Text = (Int32.Parse(txtHoaDauBiecMacchiato.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtHoaDauBiecMacchiato.Text) == 1)
                {
                    chkHoaDauBiecMacchiato.Checked = false;
                    txtHoaDauBiecMacchiato.Enabled = false;
                    txtHoaDauBiecMacchiato.Text = "0";
                }

            }
            else if (s.Contains("TraSuaThaiXanh"))
            {
                if (Int32.Parse(txtTraSuaThaiXanh.Text) > 1)
                {
                    txtTraSuaThaiXanh.Text = (Int32.Parse(txtTraSuaThaiXanh.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraSuaThaiXanh.Text) == 1)
                {
                    chkTraSuaThaiXanh.Checked = false;
                    txtTraSuaThaiXanh.Enabled = false;
                    txtTraSuaThaiXanh.Text = "0";
                }

            }
            else if (s.Contains("TraHoaDauBiec"))
            {
                if (Int32.Parse(txtTraHoaDauBiec.Text) > 1)
                {
                    txtTraHoaDauBiec.Text = (Int32.Parse(txtTraHoaDauBiec.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraHoaDauBiec.Text) == 1)
                {
                    chkTraHoaDauBiec.Checked = false;
                    txtTraHoaDauBiec.Enabled = false;
                    txtTraHoaDauBiec.Text = "0";
                }

               
                }
            else if (s == "minusTraHoaCuc")
            {
                if (Int32.Parse(txtTraHoaCuc.Text) > 1)
                {
                    txtTraHoaCuc.Text = (Int32.Parse(txtTraHoaCuc.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraHoaCuc.Text) == 1)
                {
                    chkTraHoaCuc.Checked = false;
                    txtTraHoaCuc.Enabled = false;
                    txtTraHoaCuc.Text = "0";
                }

            }
            else if (s.Contains("TraHoaCucHatChia"))
            {
                if (Int32.Parse(txtTraHoaCucHatChia.Text) > 1)
                {
                    txtTraHoaCucHatChia.Text = (Int32.Parse(txtTraHoaCucHatChia.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraHoaCucHatChia.Text) == 1)
                {
                    chkTraHoaCucHatChia.Checked = false;
                    txtTraHoaCucHatChia.Enabled = false;
                    txtTraHoaCucHatChia.Text = "0";
                }

            }
            else if (s.Contains("TraHoaHongMatOng"))
            {
                if (Int32.Parse(txtTraHoaHongMatOng.Text) > 1)
                {
                    txtTraHoaHongMatOng.Text = (Int32.Parse(txtTraHoaHongMatOng.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraHoaHongMatOng.Text) == 1)
                {
                    chkTraHoaHongMatOng.Checked = false;
                    txtTraHoaHongMatOng.Enabled = false;
                    txtTraHoaHongMatOng.Text = "0";
                }

            }
            else if (s == "minusTraDao")
            {
                if (Int32.Parse(txtTraDao.Text) > 1)
                {
                    txtTraDao.Text = (Int32.Parse(txtTraDao.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraDao.Text) == 1)
                {
                    chkTraDao.Checked = false;
                    txtTraDao.Enabled = false;
                    txtTraDao.Text = "0";
                }

            


            }
            else if (s == "minusTraDaoCamSa")
            {
                if (Int32.Parse(txtTraDaoCamSa.Text) > 1)
                {
                    txtTraDaoCamSa.Text = (Int32.Parse(txtTraDaoCamSa.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraDaoCamSa.Text) == 1)
                {
                    chkTraDaoCamSa.Checked = false;
                    txtTraDaoCamSa.Enabled = false;
                    txtTraDaoCamSa.Text = "0";
                }

            }
            else if (s == "minusTraVaiHatChia")
            {
                if (Int32.Parse(txtTraVaiHatChia.Text) > 1)
                {
                    txtTraVaiHatChia.Text = (Int32.Parse(txtTraVaiHatChia.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraVaiHatChia.Text) == 1)
                {
                    chkTraVaiHatChia.Checked = false;
                    txtTraVaiHatChia.Enabled = false;
                    txtTraVaiHatChia.Text = "0";
                }

            }
            else if (s == "minusTraVaiDuaHau")
            {
                if (Int32.Parse(txtTraVaiDuaHau.Text) > 1)
                {
                    txtTraVaiDuaHau.Text = (Int32.Parse(txtTraVaiDuaHau.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraVaiDuaHau.Text) == 1)
                {
                    chkTraVaiDuaHau.Checked = false;
                    txtTraVaiDuaHau.Enabled = false;
                    txtTraVaiDuaHau.Text = "0";
                }

            }
            else if (s.Contains("TraLiptonChanh"))
            {
                if (Int32.Parse(txtTraLiptonChanh.Text) > 1)
                {
                    txtTraLiptonChanh.Text = (Int32.Parse(txtTraLiptonChanh.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraLiptonChanh.Text) == 1)
                {
                    chkTraLiptonChanh.Checked = false;
                    txtTraLiptonChanh.Enabled = false;
                    txtTraLiptonChanh.Text = "0";
                }

            }
            else if (s.Contains("TraLiptonSua"))
            {
                if (Int32.Parse(txtTraLiptonSua.Text) > 1)
                {
                    txtTraLiptonSua.Text = (Int32.Parse(txtTraLiptonSua.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraLiptonSua.Text) == 1)
                {
                    chkTraLiptonSua.Checked = false;
                    txtTraLiptonSua.Enabled = false;
                    txtTraLiptonSua.Text = "0";
                }

            }
            else if (s.Contains("TraVietQuat"))
            {
                if (Int32.Parse(txtTraVietQuat.Text) > 1)
                {
                    txtTraVietQuat.Text = (Int32.Parse(txtTraVietQuat.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraVietQuat.Text) == 1)
                {
                    chkTraVietQuat.Checked = false;
                    txtTraVietQuat.Enabled = false;
                    txtTraVietQuat.Text = "0";
                }

            }
            else if (s.Contains("TraCamMatOng"))
            {
                if (Int32.Parse(txtTraCamMatOng.Text) > 1)
                {
                    txtTraCamMatOng.Text = (Int32.Parse(txtTraCamMatOng.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraCamMatOng.Text) == 1)
                {
                    chkTraCamMatOng.Checked = false;
                    txtTraCamMatOng.Enabled = false;
                    txtTraCamMatOng.Text = "0";
                }

            }
            else if (s.Contains("TraGungMatOng"))
            {
                if (Int32.Parse(txtTraGungMatOng.Text) > 1)
                {
                    txtTraGungMatOng.Text = (Int32.Parse(txtTraGungMatOng.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraGungMatOng.Text) == 1)
                {
                    chkTraGungMatOng.Checked = false;
                    txtTraGungMatOng.Enabled = false;
                    txtTraGungMatOng.Text = "0";
                }

            }
            else if (s.Contains("TraLai"))
            {
                if (Int32.Parse(txtTraLai.Text) > 1)
                {
                    txtTraLai.Text = (Int32.Parse(txtTraLai.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTraLai.Text) == 1)
                {
                    chkTraLai.Checked = false;
                    txtTraLai.Enabled = false;
                    txtTraLai.Text = "0";
                }

            }
            //Topping
            else if (s.Contains("TranChauDuongDen"))
            {
                if (Int32.Parse(txtTranChauDuongDen.Text) > 1)
                {
                    txtTranChauDuongDen.Text = (Int32.Parse(txtTranChauDuongDen.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtTranChauDuongDen.Text) == 1)
                {
                    chkTranChauDuongDen.Checked = false;
                    txtTranChauDuongDen.Enabled = false;
                    txtTranChauDuongDen.Text = "0";
                }

            }
            else if (s.Contains("OreoTopping"))
            {
                if (Int32.Parse(txtOreoTopping.Text) > 1)
                {
                    txtOreoTopping.Text = (Int32.Parse(txtOreoTopping.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtOreoTopping.Text) == 1)
                {
                    chkOreoTopping.Checked = false;
                    txtOreoTopping.Enabled = false;
                    txtOreoTopping.Text = "0";
                }

            }
            else if (s.Contains("PlanTrung"))
            {
                if (Int32.Parse(txtPlanTrung.Text) > 1)
                {
                    txtPlanTrung.Text = (Int32.Parse(txtPlanTrung.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtPlanTrung.Text) == 1)
                {
                    chkPlanTrung.Checked = false;
                    txtPlanTrung.Enabled = false;
                    txtPlanTrung.Text = "0";
                }

            }
            else if (s.Contains("PlanChocolate"))
            {
                if (Int32.Parse(txtPlanChocolate.Text) > 1)
                {
                    txtPlanChocolate.Text = (Int32.Parse(txtPlanChocolate.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtPlanChocolate.Text) == 1)
                {
                    chkPlanChocolate.Checked = false;
                    txtPlanChocolate.Enabled = false;
                    txtPlanChocolate.Text = "0";
                }

            }
            else if (s.Contains("SuongSao"))
            {
                if (Int32.Parse(txtSuongSao.Text) > 1)
                {
                    txtSuongSao.Text = (Int32.Parse(txtSuongSao.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtSuongSao.Text) == 1)
                {
                    chkSuongSao.Checked = false;
                    txtSuongSao.Enabled = false;
                    txtSuongSao.Text = "0";
                }

            }
            else if (s.Contains("ThachPhoMai"))
            {
                if (Int32.Parse(txtThachPhoMai.Text) > 1)
                {
                    txtThachPhoMai.Text = (Int32.Parse(txtThachPhoMai.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtThachPhoMai.Text) == 1)
                {
                    chkThachPhoMai.Checked = false;
                    txtThachPhoMai.Enabled = false;
                    txtThachPhoMai.Text = "0";
                }

            }
            else if (s.Contains("MacchiatoTopping"))
            {
                if (Int32.Parse(txtMacchiatoTopping.Text) > 1)
                {
                    txtMacchiatoTopping.Text = (Int32.Parse(txtMacchiatoTopping.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtMacchiatoTopping.Text) == 1)
                {
                    chkMacchiatoTopping.Checked = false;
                    txtMacchiatoTopping.Enabled = false;
                    txtMacchiatoTopping.Text = "0";
                }

            }
            else if (s.Contains("WhippinCream"))
            {
                if (Int32.Parse(txtWhippinCream.Text) > 1)
                {
                    txtWhippinCream.Text = (Int32.Parse(txtWhippinCream.Text) - 1).ToString();

                }
                else if (Int32.Parse(txtWhippinCream.Text) == 1)
                {
                    chkWhippinCream.Checked = false;
                    txtWhippinCream.Enabled = false;
                    txtWhippinCream.Text = "0";
                }

            }


        }

     

        private void reset(object sender, EventArgs e)
        {
            chkDenDa.Checked = false;
            chkSuaDa.Checked = false;
            chkBacSiu.Checked = false;
            chkCafeSuaTuoi.Checked = false;
            chkChocolate.Checked = false;
            chkOreo.Checked = false;
            chkCafeDaXay.Checked = false;
            chkCamChanhDay.Checked = false;
            chkSinhToDau.Checked = false;
            chkChanhTuyet.Checked = false;
            chkDauXoaiCam.Checked = false;
            chkNuocEpCam.Checked = false;
            chkNuocEpChanh.Checked = false;
            chkChanhOi.Checked = false;
            chkChanhDao.Checked = false;
            chkChanhMatOng.Checked = false;
            chkNuocEpChanhDay.Checked = false;
            chkSuaChuaDaXay.Checked = false;
            chkSuaChuaVietQuat.Checked = false;
            chkSuaChuaDao.Checked = false;
            chkSuaChuaDau.Checked = false;
            chkSuaChuaChanhDay.Checked = false;
            chkSodaChanh.Checked = false;
            chkBlueCucarao.Checked = false;
            chkSodaDao.Checked = false;
            chkSodaBacHa.Checked = false;
            chkSodaCam.Checked = false;
            //Trà
            chkTraDenMacchiato.Checked = false;
            chkMatchaMacchiato.Checked = false;
            chkTraOLongMacchiato.Checked = false;
            chkLucTraMacchiato.Checked = false;
            chkTraXoaiMacchiato.Checked = false;
            chkHoaDauBiecMacchiato.Checked = false;
            chkTraSuaThaiXanh.Checked = false;
            chkTraHoaDauBiec.Checked = false;
            chkTraHoaCuc.Checked = false;
            chkTraHoaCucHatChia.Checked = false;
            chkTraHoaHongMatOng.Checked = false;
            chkTraDao.Checked = false;
            chkTraDaoCamSa.Checked = false;
            chkTraVaiHatChia.Checked = false;
            chkTraVaiDuaHau.Checked = false;
            chkTraLiptonSua.Checked = false;
            chkTraLiptonChanh.Checked = false;
            chkTraVietQuat.Checked = false;
            chkTraCamMatOng.Checked = false;
            chkTraGungMatOng.Checked = false;
            chkTraLai.Checked = false;
            chkTranChauDuongDen.Checked = false;
            chkOreoTopping.Checked = false;
            chkPlanTrung.Checked = false;
            chkPlanChocolate.Checked = false;
            chkSuongSao.Checked = false;
            chkThachPhoMai.Checked = false;
            chkMacchiatoTopping.Checked = false;
            chkWhippinCream.Checked = false;
            chkSinhToBo.Checked = false;
            chkSinhToXoai.Checked = false;
            chkMatcha.Checked = false;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            reset(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}