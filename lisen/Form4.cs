using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using NPOI.HSSF.UserModel;
using Microsoft.Office.Interop.Excel;
using Spire.Xls;
namespace lisen
{
    public partial class Form4 : Form
    {
        string[] coolItems = { "R134a", "R22", "R407" };
        string[] nrjibiItems = { "Vr2.2", "Vr3.0" };
        string[] ysdianyuanItems = { "380V-3-50Hz" };
        [global::System.Runtime.InteropServices.DllImport("CoolProp_cdecl", EntryPoint = "PropsSI", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern double PropsSI(string jarg1, string jarg2, double jarg3, string jarg4, double jarg5, string jarg6);
        static FileStream file = new FileStream(@"选型结果.xls", FileMode.Open, FileAccess.Read);
        static HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);
        HSSFSheet sheet1 = (HSSFSheet)hssfworkbook.GetSheet("Selection");
        readMDB mdbHelp;
        DataSet dataset;
        DataSet dataset2;
        String cool,nrjibi;
        Double A1 = 0.226606, A2 = 0.414008, A3 = 0.36917;
        Double B1 = -0.2406, B2 = 0.4771, B3 = 0.6526;
        Double n = 100 / 100;
        public Form4()
        {
            InitializeComponent();
            lnwd_textBox.Text = "40";
            zfwd_textBox.Text = "5";
            ytgld_textBox.Text = "5";
            xqgrd_textBox.Text = "5";
            zlj_comboBox.DataSource = coolItems;
            gjdy_comboBox.DataSource = ysdianyuanItems;
            nrjb_comboBox.DataSource = nrjibiItems;
            cool = zlj_comboBox.Text;
            nrjibi = nrjb_comboBox.Text;
            string str = System.IO.Directory.GetCurrentDirectory();
            String dir = str + "/Lisen.mdb";
            mdbHelp = new readMDB(dir);
            try
            {
                mdbHelp.Open();     // 打開數據庫
                System.Diagnostics.Debug.WriteLine(str);
               


                // mdbHelp.Close();    // 關閉數據庫
            }
            finally
            {
                // mdbHelp = null;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        public Double readParam(String s)
        {
            Double param = Convert.ToDouble(dataset.Tables[0].Rows[0][s]);
            return param;
        }

        private void output_button_Click(object sender, EventArgs e)
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
            sfd.FileName = "选型结果";
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
        public void PrintPriviewExcelFile(string filePath)

        {
            ApplicationClass xlApp = new ApplicationClass();
            xlApp.Visible = true;
            object oMissing = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath, 0, true, 5, oMissing, oMissing, true, 1, oMissing, false, false, oMissing, false, oMissing, oMissing);
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkbook.Worksheets[1];
            xlWorksheet.PrintPreview(null);
            xlApp.Visible = false;
            xlWorksheet = null;
        }

        public Double read2Param(String s)
        {
            Double param = Convert.ToDouble(dataset2.Tables[0].Rows[0][s]);
            return param;
        }
        public void ChangeExcel2Image(string filename)
        {
            Spire.Xls.Workbook workbook = new Spire.Xls.Workbook();
            workbook.LoadFromFile(filename);
            Spire.Xls.Worksheet sheet = workbook.Worksheets[0];
            sheet.SaveToImage("选型结果.jpg"); //图片后缀.bmp ,imagepath自己设置
        }


        private void print_button_Click(object sender, EventArgs e)
        {
            string str = System.IO.Directory.GetCurrentDirectory();
            file = new FileStream(System.IO.Directory.GetCurrentDirectory() + "/选型结果.xls", FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
            ChangeExcel2Image("选型结果.xls");
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            //if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                //printDocument1.Print();   //打印
            }
            //  string str = System.IO.Directory.GetCurrentDirectory();
            //  file = new FileStream(System.IO.Directory.GetCurrentDirectory() + "/选型结果.xls", FileMode.Create);
            //  hssfworkbook.Write(file);
            //  file.Close();
            //  PrintPriviewExcelFile(str + "/选型结果.xls");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            GC.Collect();
            Graphics g = e.Graphics;
            //imagepath是指 excel转成的图片的路径
            String imagepath = "选型结果.jpg";
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
                g.DrawImage(bitmap,0, 0);
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        public void showDialog(String s)
        {
            MessageBox.Show(s, "苏州利森压缩机选型软件", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        public void showNullDialog()
        {
            MessageBox.Show("输入不允许为空", "苏州利森压缩机选型软件", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void cal_button_Click(object sender, EventArgs e)
        {
            Double Te=0;
            Double Tc=0;
            Double SC=0;
            Double SH=0;
            Double Q1=long.MaxValue,Q2=long.MaxValue,Q,P1=0,P2=0;
            String xinghao1="", xinghao2="";
            Double Qin=0;
            Double I1=0, I2 = 0;
            if (zfwd_textBox.Text == "" || lnwd_textBox.Text == "" || ytgld_textBox.Text == "" || xqgrd_textBox.Text == ""||zll_textBox.Text=="")
            {
                showNullDialog();
            }
            else {                
                Te = Convert.ToDouble(zfwd_textBox.Text);
                Tc = Convert.ToDouble(lnwd_textBox.Text);
                SC = Convert.ToDouble(ytgld_textBox.Text);
                SH = Convert.ToDouble(xqgrd_textBox.Text);
                Qin = Convert.ToDouble(zll_textBox.Text);
            
            cool = zlj_comboBox.Text;
            nrjibi = nrjb_comboBox.Text;
            List<String> ysjxh_list = new List<String>();
            dataset = mdbHelp.GetDataSet("select  * from 压缩机基础数据");
            dataset2 = mdbHelp.GetDataSet("select  * from 制冷剂参数 where 滑阀型号='" + nrjibi + "'" + " and " + "制冷剂='" + cool + "'");
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++) {
               
                ysjxh_list.Add(dataset.Tables[0].Rows[i]["压缩机型号"].ToString());
            }
                foreach (String xinghao in ysjxh_list)
                {
                    dataset = mdbHelp.GetDataSet("select  * from 压缩机基础数据 where 压缩机型号=" + "'" + xinghao + "'");

                    Double[] res = calQ(Te, Tc, SC, SH);
                    Q = res[0];
                    if (Math.Abs(Q - Qin) < Math.Abs(Q1 - Qin))
                    {
                        Q1 = Q;
                        P1 = res[1];
                        xinghao1 = xinghao;
                    }
                    else if (Math.Abs(Q - Qin) < Math.Abs(Q2 - Qin))
                    {
                        Q2 = Q;
                        P2 = res[1];
                        xinghao2 = xinghao;
                    }

                    I1 = P1 * 1000 / (3 * 220 * (B1 * n * n + B2 * n + B3));
                    I2 = P2 * 1000 / (3 * 220 * (B1 * n * n + B2 * n + B3));
                    Double Pe = PropsSI("P", "T", Te + 273.15, "Q", 1, cool);
                    Double Pc = PropsSI("P", "T", Tc + 273.15, "Q", 1, cool);
                    Double hs = PropsSI("H", "P", Pe, "T", Te + 273.15 + SH, cool);
                    Double T1 = Tc - SC;
                    Double hc = PropsSI("H", "P", Pc, "T", T1 + 273.15, cool);
                    Double ms1 = Q1 / (hs - hc) * 3600 * 1000;
                    Double ms2 = Q2 / (hs - hc) * 3600 * 1000;
                    ysjxh1_textBox.Text = xinghao1;
                    ysjxh2_textBox.Text = xinghao2;
                    zll1_textBox.Text = Q1.ToString("0.0");
                    zll2_textBox.Text = Q2.ToString("0.0");
                    srgl1_textBox.Text = P1.ToString("0.0");
                    srgl2_textBox.Text = P2.ToString("0.0");
                    yxdl1_textBox.Text = I1.ToString("0.0");
                    yxdl2_textBox.Text = I2.ToString("0.0");
                    nxb1_textBox.Text = (Q1 / P1).ToString("0.0");
                    nxb2_textBox.Text = (Q2 / P2).ToString("0.0");
                    xqzlll1_textBox.Text = ms1.ToString("0.0");
                    xqzlll2_textBox.Text = ms2.ToString("0.0");
                    sheet1.GetRow(8).Cells[4].SetCellValue(Qin.ToString("0.0"));
                    sheet1.GetRow(9).Cells[4].SetCellValue(cool);
                    sheet1.GetRow(10).Cells[4].SetCellValue(gjdy_comboBox.Text);
                    sheet1.GetRow(11).Cells[4].SetCellValue(zfwd_textBox.Text);
                    sheet1.GetRow(12).Cells[4].SetCellValue(lnwd_textBox.Text);
                    sheet1.GetRow(13).Cells[4].SetCellValue(nrjb_comboBox.Text);
                    sheet1.GetRow(14).Cells[4].SetCellValue(ytgld_textBox.Text);
                    sheet1.GetRow(15).Cells[4].SetCellValue(xqgrd_textBox.Text);

                    sheet1.GetRow(22).Cells[3].SetCellValue(xinghao1);
                    sheet1.GetRow(22).Cells[5].SetCellValue(xinghao2);
                    sheet1.GetRow(23).Cells[3].SetCellValue(Q1.ToString("0.0"));
                    sheet1.GetRow(23).Cells[5].SetCellValue(Q2.ToString("0.0"));
                    sheet1.GetRow(24).Cells[3].SetCellValue(P1.ToString("0.0"));
                    sheet1.GetRow(24).Cells[5].SetCellValue(P2.ToString("0.0"));
                    sheet1.GetRow(25).Cells[3].SetCellValue(I1.ToString("0.0"));
                    sheet1.GetRow(25).Cells[5].SetCellValue(I1.ToString("0.0"));
                    sheet1.GetRow(26).Cells[3].SetCellValue((Q1 / P1).ToString("0.0"));
                    sheet1.GetRow(26).Cells[5].SetCellValue((Q2 / P2).ToString("0.0"));
                    sheet1.GetRow(27).Cells[3].SetCellValue(ms1.ToString("0.0"));
                    sheet1.GetRow(27).Cells[5].SetCellValue(ms2.ToString("0.0"));
                }

            }
           

        }
        public double[] calQ(Double Te,Double Tc,Double SC,Double SH) {
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
            Q = (M1 + M2 * Te + M3 * Tc + M4 * Te * Te + M5 * Te * Tc + M6 * Tc * Tc + M7 * Te * Te * Te +
             M8 * Tc * Te * Te + M9 * Te * Tc * Te + M10 * Tc * Tc * Tc + (SH - 5) * Qsh + Qsc * (SC - 5)) * V * n1 * QR;
            P = (P1 + P2 * Te + P3 * Tc + P4 * Te * Te + P5 * Te * Tc + P6 * Tc * Tc + P7 * Te * Te * Te +
                P8 * Tc * Te * Te + P9 * Te * Tc * Tc + P10 * Tc * Tc * Tc + (SH - 5) * Psh) * V * n1 * PR;
            return new Double[] { Q ,P};

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1();
            this.Hide();
            homeForm.Show();
        }

    }
}
