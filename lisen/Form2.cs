using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lisen
{
    public partial class Form2 : Form
    {
        Double Te, Tc;
        String cool;
        String nrjibi;
        int economyMode;
        Double n=100;
        Double SH;
        Double SC;
        Double pqwdqiwang=90;
 
        string[] coolItems = { "R134a","R22","R407"};
        string[] nrjibiItems = { "Vr2.2", "Vr3.0" };
        string[] ysdianyuanItems = { "380V-3-50Hz" };
        string[] lqfangshiItems = { "A电机腔&压缩腔喷液冷却","B电机腔喷液&外接油冷却","C外接油冷却" };
        string[] compressorItems = { "LSS18H279"  };
        int[] Vr2_2R134arunRangeX = { -15, -15, 0, 15, 15, 2, -15 };
        int[] Vr2_2R134arunRangeY = { 22, 55, 70, 70, 35, 22, 22 };
        int[] Vr3_0R134arunRangeX = { -20, -20, 0, 15, 15, 2, -20 };
        int[] Vr3_0R134arunRangeY = { 22, 50, 70, 70, 35, 22, 22 };
        int[] Vr2_2R22runrangeX = { -20, -20, 0, 15, 15, -10, -20 };
        int[] Vr2_2R22runRangeY = { 10, 55, 70, 70, 35, 10, 10 };
        int[] Vr3_0R22runRangeX = { -30, -30, -10, 15, 15, -10, -30 };
        int[] Vr3_0R22runRangeY = { 10, 40, 70, 70, 35, 10, 10 };
        readMDB mdbHelp;
        DataSet dataset;
        DataSet dataset2;
        public Form2()
        {
            var compressorList = new List<String>();
            InitializeComponent();
            ysrongtiao_TB.Text =Convert.ToString(n);
            pqwendu_TB.Text = Convert.ToString(pqwdqiwang);
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

        }

        private void back_button_Click(object sender, EventArgs e)
        {

            Form1 homeForm = new Form1();
            this.Hide();
            homeForm.Show();
        }

        private void jisuan_button_Click(object sender, EventArgs e)
        {
            string xinghao = compressor_comboBox.Text;
            nrjibi = nrjibi_comboBox.Text;
            cool = cool_comboBox.Text;
            dataset = mdbHelp.GetDataSet("select  * from 压缩机基础数据 where 压缩机型号='"+xinghao+"'");
            dataset2 = mdbHelp.GetDataSet("select  * from 制冷剂参数 where 滑阀型号='" + nrjibi + "'"+" and "+"制冷剂='"+cool+"'");
            Double minn = readParam("最小容调");
            System.Diagnostics.Debug.Write(minn);
            if (zfwendu_textBox1.Text != "" && lnwendu_textBox1.Text != null&&xqguore_TB.Text!=null&&ytguoleng_TB.Text!=null&&pqwendu_TB.Text!=null)
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
                drawChart();
            }
            else {
                showNullDialog();
            }
            if (!PositionPnpoly(Vr3_0R134arunRangeX.Length, Vr3_0R134arunRangeX, Vr3_0R134arunRangeY, Te, Tc))
            {

                showDialog();
            }
            else if (n > 100 || n < minn) {
                showDialog("压缩机容调状态"+Convert.ToString(minn)+"至"+"100");
            }
            else
            {
                cal();
            }
         
        }

        private void zfwendu_textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8&&e.KeyChar!='.'&&e.KeyChar!='-') {
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
            } else if (cool=="R22"||cool=="R407"&&nrjibi=="Vr3.0") {
                for (int i = 0; i < Vr3_0R22runRangeX.Length; i++) {
                    this.chart1.Series[0].Points.AddXY(Vr3_0R22runRangeX[i], Vr3_0R22runRangeY[i]);
                }
            }
        }
        public void showDialog() {
            MessageBox.Show("超出运行范围，请重新输入运行工况", "苏州利森压缩机选型软件", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        public void showNullDialog()
        {
            MessageBox.Show("输入不允许为空", "苏州利森压缩机选型软件", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        public void showDialog(String s)
        {
            MessageBox.Show(s, "苏州利森压缩机选型软件", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        public void cal() {
            Double M1, M2, M3, M4, M5, M6, M7, M8, M9, M10;
            Double V, n1, QR,PR;
            Double P1, P2, P3, P4, P5, P6, P7, P8, P9, P10;
            Double Qsh,Qsc,Psh;
            Double Q,P;
            V = readParam("排气量");
            n1 = readParam("排量系数");
            QR = readParam(cool+"Q");
            PR = readParam(cool+"P");
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
            Q = (M1 + M2 * Te + M3 * Tc + M4 * Te*Te + M5 * Te * Tc + M6 * Tc * Tc + M7 * Te *Te*Te +
                M8 * Tc * Te * Te + M9 * Te * Tc * Te + M10 * Tc *Tc*Tc + (SH - 5) * Qsh + Qsc * (SC - 5)) * V * n1 * QR;
            P = (P1 + P2 * Te + P3 * Tc + P4 * Te * Te + P5 * Te * Tc + P6 * Tc * Tc + P7 * Te * Te * Te +
                P8 * Tc * Te * Te + P9 * Te * Tc * Tc + P10 * Tc * Tc * Tc + (SH - 5) * Psh) * V * n1 * PR;
            zlliang_textBox.Text = Q.ToString("0.00");
            srgonglv_textBox.Text = P.ToString("0.00");
            if (economy_mode.CheckState == CheckState.Checked)
            {
                yxmoshi_textBox.Text = "经济模式";
            }
            else
            {
                yxmoshi_textBox.Text = "普通模式";
            }
            
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
    }
}
