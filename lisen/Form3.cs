using NPOI.HSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Spire.Xls;
namespace lisen
{
    public partial class Form3 : Form
    {
        static FileStream file = new FileStream(@"性能表.xls", FileMode.Open, FileAccess.Read);
        static HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);
        HSSFSheet sheet1 = (HSSFSheet)hssfworkbook.GetSheet("Performance Table");
        PointF[] points=new PointF[7] ;
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
        Form2 calForm = new Form2();
        public Form3()
        {
            InitializeComponent();           
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            calForm.Show();
        }

        private void cal_btn_Click(object sender, EventArgs e)
        {

            int[] te = new int[7];
            int[] tc = new int[3];
            te[0] = Convert.ToInt16(textBox9.Text);
            te[1] = Convert.ToInt16(textBox10.Text);
            te[2] = Convert.ToInt16(textBox11.Text);
            te[3] = Convert.ToInt16(textBox12.Text);
            te[4] = Convert.ToInt16(textBox13.Text);
            te[5] = Convert.ToInt16(textBox14.Text);
            te[6] = Convert.ToInt16(textBox15.Text);
            tc[0] = Convert.ToInt16(textBox16.Text);
            tc[1] = Convert.ToInt16(textBox17.Text);
            tc[2] = Convert.ToInt16(textBox18.Text);
            for (int i = 2; i < 9; i++)
            {              
                dataGridView1.Columns[i].Name = te[i - 2].ToString();
                dataGridView1.Columns[i].HeaderText = te[i - 2].ToString();
                sheet1.GetRow(19 ).Cells[1+5*i].SetCellValue(te[i-2].ToString());
            }
            sheet1.GetRow(20).Cells[1].SetCellValue(tc[0].ToString());
            sheet1.GetRow(25).Cells[1].SetCellValue(tc[1].ToString());
            sheet1.GetRow(30).Cells[1].SetCellValue(tc[2].ToString());
            dataGridView1.Rows[0].Cells["tc"].Value = textBox16.Text;
            dataGridView1.Rows[5].Cells["tc"].Value = textBox17.Text;
            dataGridView1.Rows[10].Cells["tc"].Value = textBox18.Text;

            for (int i = 0; i < 7; i++) {
                for (int j = 0; j < 3; j++) {
                    string[] result = Cal.cal(te[i], tc[j]);
                    if (data_share.cool == "R134a" && data_share.nrjb == "Vr2.2")
                    {
                        vertx = Vr2_2R134arunRangeX;
                        verty = Vr2_2R134arunRangeY;
                    }
                    else if (data_share.cool == "R134a" && data_share.nrjb == "Vr3.0") {
                        vertx = Vr3_0R134arunRangeX;
                        verty = Vr3_0R134arunRangeY;
                    } else if (data_share.cool == "R22" || data_share.cool == "R407C" && data_share.nrjb == "Vr2.2") {
                        vertx = Vr2_2R22runrangeX;
                        verty = Vr2_2R22runRangeY;
                    } else if (data_share.cool == "R22" || data_share.cool == "R407C" && data_share.nrjb == "Vr3.0") {
                        vertx = Vr3_0R22runRangeX;
                        verty = Vr3_0R22runRangeY;
                    }


                    for (int h = 0; h < 7; h++) {
                        points[h] = new PointF(vertx[h], verty[h]);
                    }
                    PointF test = new PointF(te[i], tc[j]);
                    if (!PositionPnpoly(Vr2_2R134arunRangeX.Length, vertx, verty, te[i], tc[j]) && !OnRegion(points,test)) {
                        for (int m = 0; m < 5; m++) {
                            result[m] = "NaN";
                        }
                     }
                    dataGridView1.Rows[j * 5 + 0].Cells[te[i].ToString()].Value=result[1];
                    dataGridView1.Rows[j * 5 + 1].Cells[te[i].ToString()].Value = result[0];
                    dataGridView1.Rows[j * 5 + 2].Cells[te[i].ToString()].Value = result[2];
                    dataGridView1.Rows[j * 5 + 3].Cells[te[i].ToString()].Value = result[3];
                    dataGridView1.Rows[j * 5 + 4].Cells[te[i].ToString()].Value = result[4];
                    sheet1.GetRow(20+j*5).Cells[11+i*5].SetCellValue(result[1]);
                    sheet1.GetRow(21 + j * 5).Cells[11 + i * 5].SetCellValue(result[0]);
                    sheet1.GetRow(22 + j * 5).Cells[11 + i * 5].SetCellValue(result[2]);
                    sheet1.GetRow(23 + j * 5).Cells[11 + i * 5].SetCellValue(result[3]);
                    sheet1.GetRow(24 + j * 5).Cells[11 + i * 5].SetCellValue(result[4]);
                }
            }
            

        }
      
        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("tc", "tc[°C]");
            dataGridView1.Columns.Add("te", "te[°C]");
            sheet1.GetRow(19).Cells[1].SetCellValue("tc[°C]");
            sheet1.GetRow(19).Cells[6].SetCellValue("te[°C]");
            dataGridView1.Columns.Add(textBox9.Text, textBox9.Text);
            dataGridView1.Columns.Add(textBox10.Text, textBox10.Text);
            dataGridView1.Columns.Add(textBox11.Text, textBox11.Text);
            dataGridView1.Columns.Add(textBox12.Text, textBox12.Text);
            dataGridView1.Columns.Add(textBox13.Text, textBox13.Text);
            dataGridView1.Columns.Add(textBox14.Text, textBox14.Text);
            dataGridView1.Columns.Add(textBox15.Text, textBox15.Text);
            for (int i = 0; i < 15; i++) {
                dataGridView1.Rows.Add();
            }            
            dataGridView1.Rows[0].Cells["tc"].Value = 45;
            dataGridView1.Rows[5].Cells["tc"].Value = 40;
            dataGridView1.Rows[10].Cells["tc"].Value = 35;
          
            for (int i = 0; i < 3; i++) {
                dataGridView1.Rows[0+i*5].Cells["te"].Value = "Q[KW]";
                dataGridView1.Rows[1 + i * 5].Cells["te"].Value = "P[KW]";
                dataGridView1.Rows[2 + i * 5].Cells["te"].Value = "COP";
                dataGridView1.Rows[3 + i * 5].Cells["te"].Value = "I[A]";
                dataGridView1.Rows[4 + i * 5].Cells["te"].Value = "mLp[Kg/h]";
                sheet1.GetRow(20+i*5).Cells[6].SetCellValue("Q[KW]");
                sheet1.GetRow(21+i*5).Cells[6].SetCellValue("P[KW]");
                sheet1.GetRow(22+i*5).Cells[6].SetCellValue("COP");
                sheet1.GetRow(23+i*5).Cells[6].SetCellValue("I[A]");
                sheet1.GetRow(24+i*5).Cells[6].SetCellValue("mLp[Kg/h]");
            }
            zlj_textBox.Text = data_share.cool;
            ysjxh_textBox.Text = data_share.ysjxh;
            gjdy_textBox.Text = data_share.gjdy;
            nrjb_textBox.Text = data_share.nrjb;
            System.Diagnostics.Debug.WriteLine(data_share.cool);
            sheet1.GetRow(7).Cells[24].SetCellValue(data_share.ysjxh);
            sheet1.GetRow(8).Cells[24].SetCellValue(data_share.cool);
            sheet1.GetRow(9).Cells[24].SetCellValue(data_share.gjdy);
            sheet1.GetRow(10).Cells[24].SetCellValue(data_share.nrjb);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox9.Text = (Convert.ToDouble(textBox9.Text)+5).ToString("0");
            textBox10.Text = (Convert.ToDouble(textBox10.Text) + 5).ToString("0");
            textBox11.Text = (Convert.ToDouble(textBox11.Text) + 5).ToString("0");
            textBox12.Text = (Convert.ToDouble(textBox12.Text) + 5).ToString("0");
            textBox13.Text = (Convert.ToDouble(textBox13.Text) + 5).ToString("0");
            textBox14.Text = (Convert.ToDouble(textBox14.Text) + 5).ToString("0");
            textBox15.Text = (Convert.ToDouble(textBox15.Text) + 5).ToString("0");
            textBox16.Text = (Convert.ToDouble(textBox16.Text) + 5).ToString("0");
            textBox17.Text = (Convert.ToDouble(textBox17.Text) + 5).ToString("0");
            textBox18.Text = (Convert.ToDouble(textBox18.Text) + 5).ToString("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox9.Text = (Convert.ToDouble(textBox9.Text) - 5).ToString("0");
            textBox10.Text = (Convert.ToDouble(textBox10.Text) - 5).ToString("0");
            textBox11.Text = (Convert.ToDouble(textBox11.Text) - 5).ToString("0");
            textBox12.Text = (Convert.ToDouble(textBox12.Text) - 5).ToString("0");
            textBox13.Text = (Convert.ToDouble(textBox13.Text) - 5).ToString("0");
            textBox14.Text = (Convert.ToDouble(textBox14.Text) - 5).ToString("0");
            textBox15.Text = (Convert.ToDouble(textBox15.Text) - 5).ToString("0");
            textBox16.Text = (Convert.ToDouble(textBox16.Text) - 5).ToString("0");
            textBox17.Text = (Convert.ToDouble(textBox17.Text) - 5).ToString("0");
            textBox18.Text = (Convert.ToDouble(textBox18.Text) - 5).ToString("0");
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
            if (cross <0) return false;
            double d2 = (p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y);
            if (cross >d2) return false;

            double r = cross / d2;
            double px = p1.X + (p2.X - p1.X) * r;
            double py = p1.Y + (p2.Y - p1.Y) * r;

            //判断距离是否小于误差
            return Math.Sqrt((pf.X - px) * (pf.X - px) + (py - pf.Y) * (py - pf.Y)) <= range;
        }

        private void output_btn_Click(object sender, EventArgs e)
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
            sfd.FileName = "性能表";
            sfd.DefaultExt = "xls";
            int flag = 0;
            if (sfd.ShowDialog() == DialogResult.OK) {
                string localFilePath = sfd.FileName.ToString(); //获得文件路径 
                
               
                try
                {
                    file = new FileStream(localFilePath, FileMode.Create);
                }
                catch (IOException) {
                    flag = 1;
                    showDialog("该表正在被其它进程占用，请先关闭");
                }
                if (flag == 0)
                    hssfworkbook.Write(file);

            }
         
            file.Close();
            
        }
        public void showDialog(String s)
        {
            MessageBox.Show(s, "苏州利森压缩机选型软件", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        public void ChangeExcel2Image(string filename)
        {
            Spire.Xls.Workbook workbook = new Spire.Xls.Workbook();
            workbook.LoadFromFile(filename);
            Spire.Xls.Worksheet sheet = workbook.Worksheets[0];
            sheet.SaveToImage("性能表.jpg"); //图片后缀.bmp ,imagepath自己设置
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            string str = System.IO.Directory.GetCurrentDirectory();
            file = new FileStream(System.IO.Directory.GetCurrentDirectory() + "/性能表.xls", FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
            // PrintPriviewExcelFile(str+"/性能表.xls");
            ChangeExcel2Image("性能表.xls");
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            GC.Collect();
            Graphics g = e.Graphics;
            //imagepath是指 excel转成的图片的路径
            String imagepath = "性能表.jpg";
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

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

    }
}
