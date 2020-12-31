using NPOI.HSSF.UserModel;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lisen

{

    public partial class Form2 : Form
    {

        [global::System.Runtime.InteropServices.DllImport("CoolProp_cdecl", EntryPoint = "PropsSI", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern double PropsSI(string jarg1, string jarg2, double jarg3, string jarg4, double jarg5, string jarg6);
        static FileStream file = new FileStream(@"性能报表.xls", FileMode.Open, FileAccess.Read);
        static HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);
        HSSFSheet sheet1 = (HSSFSheet)hssfworkbook.GetSheet("Performance");
        Double Te, Tc;
        String cool;
        String nrjibi;
        int economyMode;
        Double n = 100;
        Double SH=5;
        Double SC=5;
        Double pqwdqiwang = 90;
        string xinghao;
        Double A1 = 0.226606, A2 = 0.414008, A3 = 0.36917;
        Double B1 = -0.2406, B2 = 0.4771, B3 = 0.6526;
        Double P0, Q0;
        PointF[] points = new PointF[7];
        string[] coolItems = { "R134a", "R22", "R407" };
        string[] nrjibiItems = { "Vr2.2", "Vr3.0" };
        string[] ysdianyuanItems = { "380V-3-50Hz" };
        string[] lqfangshiItems = { "A电机腔&压缩腔喷液冷却", "B电机腔喷液&外接油冷却", "C外接油冷却" };
        int[] Vr2_2R134arunRangeX = { -15, -15, 0, 15, 15, 2, -15 };
        int[] Vr2_2R134arunRangeY = { 22, 55, 70, 70, 35, 22, 22 };
        int[] Vr3_0R134arunRangeX = { -20, -20, 0, 15, 15, 2, -20 };
        int[] Vr3_0R134arunRangeY = { 22, 50, 70, 70, 35, 22, 22 };
        int[] Vr2_2R22runrangeX = { -20, -20, 0, 15, 15, -10, -20 };
        int[] Vr2_2R22runRangeY = { 10, 55, 70, 70, 35, 10, 10 };
        int[] Vr3_0R22runRangeX = { -30, -30, -10, 15, 15, -10, -30 };
        int[] Vr3_0R22runRangeY = { 10, 40, 70, 70, 35, 10, 10 };
        int[] vertx = new int[7];
        int[] verty = new int[7];
        int[] tempx = new int[7];
        int[] tempy = new int[7];
        readMDB mdbHelp;
        DataSet dataset;
        DataSet dataset2;
        public Form2()
        {
            
            var compressorList = new List<String>();
            InitializeComponent();
            set_chart(20,-20,75,10);
            ysrongtiao_TB.Text = Convert.ToString(n);
            pqwendu_TB.Text = Convert.ToString(pqwdqiwang);
            zfwendu_textBox1.Text= Convert.ToString(5);
            lnwendu_textBox1.Text = Convert.ToString(40);
            xqguore_TB.Text = Convert.ToString(5);
            ytguoleng_TB.Text = Convert.ToString(5);
            string str = System.IO.Directory.GetCurrentDirectory();
            String dir = str + "/Lisen.mdb";
            mdbHelp = new readMDB(dir);
            try
            {
                mdbHelp.Open();     // 打開數據庫
                System.Diagnostics.Debug.WriteLine(str);
                var ds = mdbHelp.GetDataSet("select  * from 压缩机基础数据");

                System.Diagnostics.Debug.WriteLine(ds.Tables[0].Rows[0]["压缩机型号"]);
                int row = ds.Tables[0].Rows.Count;
                for (int i = 0; i < row; i++) {
                    compressorList.Add((String)ds.Tables[0].Rows[i][1]);
                }

                // mdbHelp.Close();    // 關閉數據庫
            }
            finally
            {
                // mdbHelp = null;
            }
        
            cool_comboBox.DataSource = coolItems;
            compressor_comboBox.DataSource = compressorList;
            power_comboBox.DataSource = ysdianyuanItems;
            nrjibi_comboBox.DataSource = nrjibiItems;
            lqfangshi_combox.DataSource = lqfangshiItems;
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chart1.Series[0].Name = "Series1";
            this.chart1.Series[1].Points.AddXY(0, 0);
            this.chart1.Series[0].BorderWidth = 3;
            chartArea2.AxisX.Interval = 5D;
            chartArea2.AxisX.Maximum = 20D;
            chartArea2.AxisX.Minimum = -20D;
            chartArea2.AxisY.Interval = 10D;
            chartArea2.AxisY.Maximum = 75D;
            chartArea2.AxisY.Minimum = 10D;
            //cal();

        }

        private void back_button_Click(object sender, EventArgs e)
        {

            Form1 homeForm = new Form1();
            this.Hide();
            homeForm.Show();
        }

        private void jisuan_button_Click(object sender, EventArgs e)
        {
            xinghao = compressor_comboBox.Text;
            nrjibi = nrjibi_comboBox.Text;
            cool = cool_comboBox.Text;
            dataset = mdbHelp.GetDataSet("select  * from 压缩机基础数据 where 压缩机型号='" + xinghao + "'");
            dataset2 = mdbHelp.GetDataSet("select  * from 制冷剂参数 where 滑阀型号='" + nrjibi + "'" + " and " + "制冷剂='" + cool + "'");    
            Double minn = readParam("最小容调");
            if (zfwendu_textBox1.Text != "" && lnwendu_textBox1.Text != "" && xqguore_TB.Text != "" && ytguoleng_TB.Text != "" && pqwendu_TB.Text != ""&&cool!="R407")
            {
                Te = Convert.ToDouble(zfwendu_textBox1.Text);
                Tc = Convert.ToDouble(lnwendu_textBox1.Text);
                SH = Convert.ToDouble(xqguore_TB.Text);
                SC = Convert.ToDouble(ytguoleng_TB.Text);
                n = Convert.ToDouble(ysrongtiao_TB.Text);
                pqwdqiwang = Convert.ToDouble(pqwendu_TB.Text);
                economyMode = (int)economy_mode.CheckState;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                this.chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                this.chart1.Series[1].Points.AddXY(Te, Tc);
                this.chart1.Series[1].BorderWidth = 5;
                this.chart1.Series[1].Color = Color.Red;
                int minX = 0;
                int maxX = 0;
                int minY = 0;
                int maxY = 0;
                if (cool == "R134a" && nrjibi == "Vr2.2")
                {
                    vertx = Vr2_2R134arunRangeX;
                    verty = Vr2_2R134arunRangeY;
                    minX = -20;
                    maxX = 20;
                    minY = 15;
                    maxY = 75;
                }
                else if (cool == "R134a" && nrjibi == "Vr3.0")
                {
                    vertx = Vr3_0R134arunRangeX;
                    verty = Vr3_0R134arunRangeY;
                    minX = -25;
                    maxX = 20;
                    minY = 15;
                    maxY = 75;
                }
                else if (cool == "R22" || cool == "R407" && nrjibi == "Vr2.2")
                {
                    vertx = Vr2_2R22runrangeX;
                    verty = Vr2_2R22runRangeY;
                    minX = -25;
                    maxX = 20;
                    minY = 5;
                    maxY = 75;
                }
                else if (cool == "R22" || cool == "R407" && nrjibi == "Vr3.0")
                {
                    vertx = Vr3_0R22runRangeX;
                    verty = Vr3_0R22runRangeY;
                    minX = -35;
                    maxX = 20;
                    minY = 5;
                    maxY = 75;
                }
                set_chart(minX, maxX, minY, maxY);
                drawChart();
                for (int h = 0; h < 7; h++)
                {
                    points[h] = new PointF(vertx[h], verty[h]);
                }
                PointF test = new PointF((float)(Te), (float)Tc);

                if (!PositionPnpoly(Vr2_2R134arunRangeX.Length, vertx, verty, Te, Tc) && !OnRegion(points, test))
                {

                    showDialog();
                }
                else if (n > 100 || n < minn)
                {
                    showDialog("压缩机容调状态" + Convert.ToString(minn) + "至" + "100");
                }
                else if (pqwdqiwang < 75)
                {
                    showDialog("排气期望温度需要大于75");
                }
                else if (SH < 0.1)
                {
                    showDialog("过热度最小值为0.1");
                }
                else if (SC < 0.1)
                {
                    showDialog("过冷度最小值为0.1");
                }
                else
                {
                    drawChart();
                    cal();
                    set_table();
                }
            }
            else{
                    showNullDialog();
                }
        }

        private void zfwendu_textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != '.' && e.KeyChar != '-') {
                e.Handled = true;
            }
        }
        public Double readParam(String s) {
            Double param = Convert.ToDouble(dataset.Tables[0].Rows[0][s]);
            return param;
        }
        public Double read2Param(String s)
        {
            Double param = Convert.ToDouble(dataset2.Tables[0].Rows[0][s]);
            return param;
        }
        public void drawChart() {
            if (cool == "R134a" && nrjibi == "Vr2.2")
            {
                for (int i = 0; i < Vr2_2R134arunRangeX.Length; i++)
                {
                    this.chart1.Series[0].Points.AddXY(Vr2_2R134arunRangeX[i], Vr2_2R134arunRangeY[i]);
                }
            }
            else if (cool == "R134a" && nrjibi == "Vr3.0")
            {
                for (int i = 0; i < Vr3_0R134arunRangeX.Length; i++)
                {
                    this.chart1.Series[0].Points.AddXY(Vr3_0R134arunRangeX[i], Vr3_0R134arunRangeY[i]);
                }
            } else if (cool == "R22" || cool == "R407" && nrjibi == "Vr2.2") {
                for (int i = 0; i < Vr2_2R22runrangeX.Length; i++) {
                    this.chart1.Series[0].Points.AddXY(Vr2_2R22runrangeX[i], Vr2_2R22runRangeY[i]);
                }
            } else if (cool == "R22" || cool == "R407" && nrjibi == "Vr3.0") {
                for (int i = 0; i < Vr3_0R22runRangeX.Length; i++) {
                    this.chart1.Series[0].Points.AddXY(Vr3_0R22runRangeX[i], Vr3_0R22runRangeY[i]);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void xingnengbiao_button_Click(object sender, EventArgs e)
        {
            xinghao = compressor_comboBox.Text;
            nrjibi = nrjibi_comboBox.Text;
            cool = cool_comboBox.Text;
            dataset = mdbHelp.GetDataSet("select  * from 压缩机基础数据 where 压缩机型号='" + xinghao + "'");
            dataset2 = mdbHelp.GetDataSet("select  * from 制冷剂参数 where 滑阀型号='" + nrjibi + "'" + " and " + "制冷剂='" + cool + "'");
            Double[] a = calPQ(Te, Tc);
            Form3 homeForm = new Form3();
            data_share.cool = cool_comboBox.Text;
            data_share.ysjxh = compressor_comboBox.Text;
            data_share.gjdy = power_comboBox.Text;
            data_share.nrjb = nrjibi_comboBox.Text;
            data_share.SC = SC;
            data_share.SH = SH;
            data_share.n = Convert.ToDouble(ysrongtiao_TB.Text)/10;
            data_share.pqwendu = pqwendu_TB.Text;
            data_share.lqfangshi = lqfangshi_combox.Text;
            this.Hide();
            homeForm.Show();
        }

        public void showDialog() {
            MessageBox.Show("超出运行范围，请重新输入运行工况", "苏州利森压缩机选型软件", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        public void showNullDialog()
        {
            MessageBox.Show("输入不允许为空", "苏州利森压缩机选型软件", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void excel_button_Click(object sender, EventArgs e)
        {
            //Force excel to recalculate all the formula while open
            sheet1.ForceFormulaRecalculation = true;
            //生成新的excel 
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "*.xls|*.xls";
            sfd.FilterIndex = 0;
            sfd.RestoreDirectory = true;
            sfd.CreatePrompt = true;
            sfd.InitialDirectory = "c://";
            sfd.FileName = "性能报表";
            set_table();
            int flag = 0;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString(); //获得文件路径 

                try
                {
                    file = new FileStream(localFilePath, FileMode.Create);
                }
                catch (IOException)
                {
                    flag = 1;
                    showDialog("该表正在被其它进程占用，请先关闭");
                }
                if (flag == 0)
                    hssfworkbook.Write(file);

            }

            file.Close();
        }
        public void set_table() {
            sheet1.GetRow(8).Cells[4].SetCellValue(cool_comboBox.Text);
            sheet1.GetRow(9).Cells[4].SetCellValue(compressor_comboBox.Text);
            sheet1.GetRow(10).Cells[4].SetCellValue(power_comboBox.Text);
            sheet1.GetRow(11).Cells[4].SetCellValue(zfwendu_textBox1.Text);
            sheet1.GetRow(12).Cells[4].SetCellValue(lnwendu_textBox1.Text);
            sheet1.GetRow(13).Cells[4].SetCellValue(nrjibi_comboBox.Text);
            sheet1.GetRow(14).Cells[4].SetCellValue(ytguoleng_TB.Text);
            sheet1.GetRow(15).Cells[4].SetCellValue(xqguore_TB.Text);
            sheet1.GetRow(16).Cells[4].SetCellValue(ysrongtiao_TB.Text);
            sheet1.GetRow(17).Cells[4].SetCellValue(pqwendu_TB.Text);
            sheet1.GetRow(22).Cells[3].SetCellValue(yxmoshi_textBox.Text);
            sheet1.GetRow(23).Cells[3].SetCellValue(zlliang_textBox.Text);
            sheet1.GetRow(24).Cells[3].SetCellValue(srgonglv_textBox.Text);
            sheet1.GetRow(25).Cells[3].SetCellValue(yxdianliu_textBox.Text);
            sheet1.GetRow(26).Cells[3].SetCellValue(nxbi_textBox.Text);
            sheet1.GetRow(27).Cells[3].SetCellValue(xqzlliuliang_textBox.Text);
            sheet1.GetRow(28).Cells[3].SetCellValue(pqzlliuliang_textBox.Text);
            sheet1.GetRow(29).Cells[3].SetCellValue(zypyzl_textBox.Text);
            sheet1.GetRow(30).Cells[3].SetCellValue(dypyzl_textBox.Text);
            sheet1.GetRow(31).Cells[3].SetCellValue(wewlqpq_textBox.Text);

            sheet1.GetRow(22).Cells[5].SetCellValue(zljytwendu_textBox.Text);
            sheet1.GetRow(23).Cells[5].SetCellValue(jjqzlll_textBox.Text);
            sheet1.GetRow(24).Cells[5].SetCellValue(jjqhrl_textBox.Text);
            sheet1.GetRow(25).Cells[5].SetCellValue(jjqnbhwd_textBox.Text);
            sheet1.GetRow(26).Cells[5].SetCellValue(jjqnyl_textBox.Text);
            sheet1.GetRow(27).Cells[5].SetCellValue(ylqqnl_textBox.Text);
            sheet1.GetRow(28).Cells[5].SetCellValue(ylqldyll_textbox.Text);
            sheet1.GetRow(29).Cells[5].SetCellValue(ylqqckwd_textbox.Text);
            sheet1.GetRow(30).Cells[5].SetCellValue(zypylql_textBox.Text);
            sheet1.GetRow(31).Cells[5].SetCellValue(dypylql_textBox.Text);
            //sheet1.GetRow(32).Cells[5].SetCellValue(pyszjgl_textBox.Text);
        }

        private void dayin_button_Click(object sender, EventArgs e)
        {
            string str = System.IO.Directory.GetCurrentDirectory();

            file = new FileStream(System.IO.Directory.GetCurrentDirectory() + "/性能报表.xls", FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
            ChangeExcel2Image("性能报表.xls");
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        public void ChangeExcel2Image(string filename)
        {
            Spire.Xls.Workbook workbook = new Spire.Xls.Workbook();
            workbook.LoadFromFile(filename);
            Spire.Xls.Worksheet sheet = workbook.Worksheets[0];
            sheet.SaveToImage("性能报表.jpg"); //图片后缀.bmp ,imagepath自己设置
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            GC.Collect();
            Graphics g = e.Graphics;
            //imagepath是指 excel转成的图片的路径
            String imagepath = "性能报表.jpg";
            using (Bitmap bitmap = new Bitmap(imagepath))
            {
                //如何截取自己摸索
                //System.Drawing.Rectangle newarea = new System.Drawing.Rectangle();
                // newarea.X = 0;
                // newarea.Y = 50;
                // newarea.Width = bitmap.Width;
                // newarea.Height = bitmap.Height - 50;
                // using (Bitmap newbitmap = bitmap.Clone(newarea, bitmap.PixelFormat))
                //  {
                //g.DrawImage(newbitmap, 125, 125, newbitmap.Width - 200, newbitmap.Height - 150);
                //  }
                g.DrawImage(bitmap, 0, 0);
            }
        }

        public void showDialog(String s)
        {
            MessageBox.Show(s, "苏州利森压缩机选型软件", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        public void cal() {
            Double Tdm = Convert.ToDouble(pqwendu_TB.Text);
            Double[] a = calPQ(Te, Tc);
            Double P = a[0];
            Double Q = a[1];
            Double Qp, Pp;
            Double Ip;
            Double EER;
            Double Ts;
            n = n / 100;
            Qp = Q * n;
            Pp = P * (A1 * n * n + A2 * n + A3);
            Ip = P * 1000 / (3 * 220 * (B1 * n * n + B2 * n + B3));
            EER = Qp / Pp;
            Ts = Te + SH;
            Double Pe = PropsSI("P", "T", Te + 273.15, "Q", 1, cool);
            Double Pc = PropsSI("P", "T", Tc + 273.15, "Q", 1, cool);
            Double ttc = PropsSI("T", "P", Pc, "Q", 0, cool)-273.5;
            Double hs = PropsSI("H", "P", Pe, "T", Te + 273.15 + SH, cool);
            Double T1 = ttc - SC;
            Double hc = PropsSI("H", "P", Pc, "T", T1 + 273.15, cool);
            Double ms = Qp / (hs - hc) * 3600 * 1000 ;
            Double hd = Pp / ms * 3600 * 1000 + hs;
            Double Td1 = PropsSI("T", "H", hd, "P", Pc, cool)-273.15;
            Double hdm = PropsSI("H","P",Pc,"T",Tdm+273.5,cool);

           
            Double Qc1=0, Qc2=0, mc2=0, Pc2=0,Pc1=0,mc1=0, pi=Pp,moil=0,CPO=0,Qoil=0,Tob=0,A,B,Pm=0,TTm=0,Hmg=0,Hml=0,Qeco=0,meco=0,Tcc=0,Peco=0;
            A = readParam(cool + "A");
            B = readParam(cool + "B");
            data_share.A = A;
            data_share.B = B;
            if (Td1 > Tdm && Tc <= 60 && lqfangshi_combox.Text == "A电机腔&压缩腔喷液冷却")
            {
                Qc1 = 0;
                Pc1 = 0;
                mc1 = 0;
                Qc2 = ms/3600 * (hd - hdm)/1000;
                mc2 = Qc2 / (hdm - hc)*1000;
                Pc2 = mc2 * (hdm - hs)/1000;
                pi = Pp + Pc1 + Pc2;
                
            }
            else if (Td1 > Tdm && Tc > 60 && lqfangshi_combox.Text == "A电机腔&压缩腔喷液冷却")
            {
                Qc1 = P * 0.015;
                mc1 = Qc1 / (hs - hc)*1000;
                ms = ms - mc1*3600;
                Qp = Qp * (1 - mc1*3600 / (ms));
                Qc2 = (ms ) * (hd - hdm)/3600/1000;
                mc2 = Qc2 / (hdm - hc)*1000;
                Pc2 = (mc1 + mc2) * (hdm - hs)/1000;
                pi = pi + Pc1 + Pc2;
            }
            else if (Td1 > Tdm && Tc <= 60 && lqfangshi_combox.Text == "B电机腔喷液&外接油冷却")
            {
               
                moil = (A * Math.Sqrt((Tc - Te)) + B) * 950;
                CPO = 2.71;
                Qc2 = moil / 3600 * (hd - hdm) / 1000;
                Tob = Tdm - Qc2 / CPO / moil*3600;
            }
            else if (Td1 > Tdm && Tc > 60 && lqfangshi_combox.Text == "B电机腔喷液&外接油冷却")
            {
                moil = (A * Math.Sqrt((Tc - Te)) + B) * 950;
                CPO = 2.71;
                Tob = Tdm - Q / CPO / moil;
                Qc1 = P * 0.015;
                mc1 = Qc1 / (hs - hc)*1000;
                ms = ms - mc1*3600;
                Qp = Qp * (1 - mc1*3600 / ms );
                Qc2 = 0;
                mc2 = 0;
                Qc2=ms/3600*(hd-hdm)/ 1000;
                Tob = Tdm - Q / CPO / moil*3600;
                Pc2 = mc2 * (hdm - hs);
                pi = pi + Pc2;
            }
            else if (Td1 > Tdm && lqfangshi_combox.Text == "C外接油冷却") {
                moil = (A * Math.Sqrt(Tc - Te) + B) * 950;
                CPO = 2.71;
                Qoil = ms * (hd - hdm);
                Qc2 = ms / 3600 * (hd - hdm) / 1000;
                Tob = Tdm - Qc2 / CPO / moil*3600;
            }     
            if (economy_mode.CheckState == CheckState.Checked)
            {
                yxmoshi_textBox.Text = "经济模式";
                Pm = Math.Sqrt((Pe * Pc))/1000;
                TTm = PropsSI("T", "P", Pm * 1000, "Q", 1, cool)-273.5;
                Hmg = PropsSI("H","P",Pm*1000,"Q",1,cool)/1000;
                Hml = PropsSI("H","P",Pm*1000,"Q",0,cool)/1000;
                Qeco = ms * (hc / 1000 - Hml) / 3600;
                meco = Qeco / (Hmg-hc/1000)*3600;
                Tcc = PropsSI("T", "H", Hml * 1000, "P", Pc, cool) - 273.15;
 //               hd= pi / ms * 3600 * 1000 + hs;
                Peco = meco/3600*(hd/1000-Hmg);
                Qp = Qeco+Qp;
                pi = pi + Peco;
                T1 = TTm;
            }
            else
            {
                yxmoshi_textBox.Text = "普通模式";
            }
            yxdianliu_textBox.Text = Ip.ToString("0.00");
            nxbi_textBox.Text = EER.ToString("0.00");
            zlliang_textBox.Text = Qp.ToString("0.00");
            srgonglv_textBox.Text = pi.ToString("0.00");
            xqzlliuliang_textBox.Text = ms.ToString("0.00");
            pqzlliuliang_textBox.Text = (ms + mc1 + mc2).ToString("0.00");
            zypyzl_textBox.Text = mc1.ToString("0.00");
            dypyzl_textBox.Text = mc2.ToString("0.00");
            wewlqpq_textBox.Text = Td1.ToString("0.00");
            zljytwendu_textBox.Text =T1.ToString("0.00");
            jjqzlll_textBox.Text = meco.ToString("0.00");
            jjqhrl_textBox.Text = Qeco.ToString("0.00");
            jjqnbhwd_textBox.Text = TTm.ToString("0.00");
            jjqnyl_textBox.Text = Pm.ToString("0.00");
            ylqqnl_textBox.Text = Qoil.ToString("0.00");
            ylqldyll_textbox.Text = moil.ToString("0.00");
            ylqqckwd_textbox.Text = Tob.ToString("0.00");
            zypylql_textBox.Text = Qc1.ToString("0.00");
            dypylql_textBox.Text = Qc2.ToString("0.00");
            pyszjgl_textBox.Text = (Pc1 + Pc2).ToString("0.00");

        }
        public Double[] calPQ(Double Te, Double Tc) {
            Double M1, M2, M3, M4, M5, M6, M7, M8, M9, M10;
            Double V, n1, QR, PR;
            Double P1, P2, P3, P4, P5, P6, P7, P8, P9, P10;
            Double Qsh, Qsc, Psh;
            Double Q, P;
            V = readParam("排气量");
            n1 = readParam("排量系数");
            QR = readParam(cool + "Q");
            PR = readParam(cool + "P");
            M1 = read2Param("M1");
            M2 = read2Param("M2");
            M3 = read2Param("M3");
            M4 = read2Param("M4");
            M5 = read2Param("M5");
            M6 = read2Param("M6");
            M7 = read2Param("M7");
            M8 = read2Param("M8");
            M9 = read2Param("M9");
            M10 = read2Param("M10");
            P1 = read2Param("P1");
            P2 = read2Param("P2");
            P3 = read2Param("P3");
            P4 = read2Param("P4");
            P5 = read2Param("P5");
            P6 = read2Param("P6");
            P7 = read2Param("P7");
            P8 = read2Param("P8");
            P9 = read2Param("P9");
            P10 = read2Param("P10");
            Qsc = read2Param("QSC");
            Qsh = read2Param("QSH");
            Psh = read2Param("PSH");
            Constant.Qsc = Qsc;
            Constant.Qsh = Qsh;
            Constant.Psh = Psh;
            Constant.V = V;
            Constant.n1 = n1;
            Constant.QR = QR;
            Constant.PR = PR;
            Constant.M1 = M1;
            Constant.M2 = M2;
            Constant.M3 = M3;
            Constant.M4 = M4;
            Constant.M5 = M5;
            Constant.M6 = M6;
            Constant.M7 = M7;
            Constant.M8 = M8;
            Constant.M9 = M9;
            Constant.M10 = M10;
            Constant.P1 = P1;
            Constant.P2 = P2;
            Constant.P3 = P3;
            Constant.P4 = P4;
            Constant.P5 = P5;
            Constant.P6 = P6;
            Constant.P7 = P7;
            Constant.P8 = P8;
            Constant.P9 = P9;
            Constant.P10 = P10;
            Q = (M1 + M2 * Te + M3 * Tc + M4 * Te * Te + M5 * Te * Tc + M6 * Tc * Tc + M7 * Te * Te * Te +
                M8 * Tc * Te * Te + M9 * Te * Tc * Te + M10 * Tc * Tc * Tc + (SH - 5) * Qsh + Qsc * (SC - 5)) * V * n1 * QR;
            P = (P1 + P2 * Te + P3 * Tc + P4 * Te * Te + P5 * Te * Tc + P6 * Tc * Tc + P7 * Te * Te * Te +
                P8 * Tc * Te * Te + P9 * Te * Tc * Tc + P10 * Tc * Tc * Tc + (SH - 5) * Psh) * V * n1 * PR;
            return new Double[] { P, Q };

        }
        public static bool PositionPnpoly(int nvert, int[] vertx, int[] verty, double testx, double testy)
        {
            int i, j, c = 0;
  
            for (i = 0, j = nvert - 1; i < nvert; j = i++)
            {
                if (((verty[i] > testy) != (verty[j] > testy)) && (testx < (vertx[j] - vertx[i]) * (testy - verty[i]) / (verty[j] - verty[i]) + vertx[i]))
                {
                    c = 1 + c; ;
                }
            }
            if (c % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool OnRegion(PointF[] ps, PointF p)
        {
            if (ps == null || ps.Length < 2) return false;
            if (ps.Length == 2)
            {
                return OnLine(ps[0], ps[1], p, 0);
            }

            for (int i = 0; i < ps.Length; i++)
            {
                if (i < ps.Length - 1)
                {
                    if (OnLine(ps[i], ps[i + 1], p, 0))
                        return true;
                }
                else if (i == ps.Length - 1)
                {
                    if (OnLine(ps[0], ps[i], p, 0))
                        return true;
                }
            }
            return false;
        }
        public bool OnLine(PointF p1, PointF p2, PointF pf, double range)
        {
            //range 判断的的误差，不需要误差则赋值0
            //点在线段首尾两端之外则return false

            double cross = (p2.X - p1.X) * (pf.X - p1.X) + (p2.Y - p1.Y) * (pf.Y - p1.Y);
            if (cross < 0) return false;
            double d2 = (p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y);
            if (cross >d2) return false;

            double r = cross / d2;
            double px = p1.X + (p2.X - p1.X) * r;
            double py = p1.Y + (p2.Y - p1.Y) * r;

            //判断距离是否小于误差
            return Math.Sqrt((pf.X - px) * (pf.X - px) + (py - pf.Y) * (py - pf.Y)) <= range;
        }


    }
}
