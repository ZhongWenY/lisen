using System.Drawing;

namespace lisen
{
    partial class Form2
    {
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        int flag = 0;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
    
        public void set_chart(int minX,int maxX,int minY,int maxY)
        {
            if (flag == 0)
            {
                flag = 1;
                this.chart1.ChartAreas.Add(chartArea2);
            }
            chartArea2.AxisX.Interval = 5;
            chartArea2.AxisX.Maximum = maxX;
            chartArea2.AxisX.Minimum = minX;
            chartArea2.AxisY.Interval = 10;
            chartArea2.AxisY.Maximum = maxY;
            chartArea2.AxisY.Minimum = minY;
        }
        private void InitializeComponent()
        {
          //  System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.compressor_textBox = new System.Windows.Forms.TextBox();
            this.compressor_comboBox = new System.Windows.Forms.ComboBox();
            this.power_textBox = new System.Windows.Forms.TextBox();
            this.power_comboBox = new System.Windows.Forms.ComboBox();
            this.zf_wendu_textBox0 = new System.Windows.Forms.TextBox();
            this.lnwendu_textBox0 = new System.Windows.Forms.TextBox();
            this.nrjibi_textBox = new System.Windows.Forms.TextBox();
            this.lnwendu_textBox1 = new System.Windows.Forms.TextBox();
            this.nrjibi_comboBox = new System.Windows.Forms.ComboBox();
            this.zfwendu_textBox2 = new System.Windows.Forms.TextBox();
            this.lnwendu_textBox2 = new System.Windows.Forms.TextBox();
            this.zfwendu_textBox1 = new System.Windows.Forms.TextBox();
            this.cool_comboBox = new System.Windows.Forms.ComboBox();
            this.cool_textBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.economy_mode = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lqfangshi_combox = new System.Windows.Forms.ComboBox();
            this.ysrongtiao_textBox = new System.Windows.Forms.TextBox();
            this.yetiguolengdu_textBox = new System.Windows.Forms.TextBox();
            this.xqguore_textBox = new System.Windows.Forms.TextBox();
            this.pqwendu_textBox = new System.Windows.Forms.TextBox();
            this.ysrongtiao_TB = new System.Windows.Forms.TextBox();
            this.ytguoleng_TB = new System.Windows.Forms.TextBox();
            this.xqguore_TB = new System.Windows.Forms.TextBox();
            this.pqwendu_TB = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.yxmoshi_textBox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.zlliang_textBox = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.srgonglv_textBox = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.yxdianliu_textBox = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.nxbi_textBox = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.xqzlliuliang_textBox = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.pqzlliuliang_textBox = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.zypyzl_textBox = new System.Windows.Forms.TextBox();
            this.dypyzl_textBox = new System.Windows.Forms.TextBox();
            this.wewlqpq_textBox = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.zljjnbhwd_textBox1 = new System.Windows.Forms.TextBox();
            this.jjqnyl_textBox11 = new System.Windows.Forms.TextBox();
            this.ylqqnl_textBox33 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.zljytwendu_textBox = new System.Windows.Forms.TextBox();
            this.jjqzlll_textBox = new System.Windows.Forms.TextBox();
            this.jjqhrl_textBox = new System.Windows.Forms.TextBox();
            this.jjqnbhwd_textBox = new System.Windows.Forms.TextBox();
            this.jjqnyl_textBox = new System.Windows.Forms.TextBox();
            this.ylqqnl_textBox = new System.Windows.Forms.TextBox();
            this.ylqldyll_textbox = new System.Windows.Forms.TextBox();
            this.ylqqckwd_textbox = new System.Windows.Forms.TextBox();
            this.zypylql_textBox = new System.Windows.Forms.TextBox();
            this.dypylql_textBox = new System.Windows.Forms.TextBox();
            this.pyszjgl_textBox = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.jisuan_button = new System.Windows.Forms.Button();
            this.xingnengbiao_button = new System.Windows.Forms.Button();
            this.dayin_button = new System.Windows.Forms.Button();
            this.excel_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // compressor_textBox
            // 
            this.compressor_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.compressor_textBox.Font = new System.Drawing.Font("宋体", 9F);
            this.compressor_textBox.Location = new System.Drawing.Point(12, 53);
            this.compressor_textBox.Name = "compressor_textBox";
            this.compressor_textBox.ReadOnly = true;
            this.compressor_textBox.Size = new System.Drawing.Size(65, 14);
            this.compressor_textBox.TabIndex = 2;
            this.compressor_textBox.Text = "压缩机型号";
            // 
            // compressor_comboBox
            // 
            this.compressor_comboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.compressor_comboBox.CausesValidation = false;
            this.compressor_comboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.compressor_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compressor_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compressor_comboBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.compressor_comboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.compressor_comboBox.FormattingEnabled = true;
            this.compressor_comboBox.Location = new System.Drawing.Point(78, 48);
            this.compressor_comboBox.Name = "compressor_comboBox";
            this.compressor_comboBox.Size = new System.Drawing.Size(108, 22);
            this.compressor_comboBox.TabIndex = 3;
            // 
            // power_textBox
            // 
            this.power_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.power_textBox.Font = new System.Drawing.Font("宋体", 9F);
            this.power_textBox.Location = new System.Drawing.Point(12, 95);
            this.power_textBox.Name = "power_textBox";
            this.power_textBox.ReadOnly = true;
            this.power_textBox.Size = new System.Drawing.Size(78, 14);
            this.power_textBox.TabIndex = 4;
            this.power_textBox.Text = "供给电源";
            // 
            // power_comboBox
            // 
            this.power_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.power_comboBox.CausesValidation = false;
            this.power_comboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.power_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.power_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.power_comboBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.power_comboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.power_comboBox.FormattingEnabled = true;
            this.power_comboBox.Location = new System.Drawing.Point(78, 91);
            this.power_comboBox.Name = "power_comboBox";
            this.power_comboBox.Size = new System.Drawing.Size(108, 22);
            this.power_comboBox.TabIndex = 5;
            // 
            // zf_wendu_textBox0
            // 
            this.zf_wendu_textBox0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zf_wendu_textBox0.Font = new System.Drawing.Font("宋体", 9F);
            this.zf_wendu_textBox0.Location = new System.Drawing.Point(12, 143);
            this.zf_wendu_textBox0.Name = "zf_wendu_textBox0";
            this.zf_wendu_textBox0.ReadOnly = true;
            this.zf_wendu_textBox0.Size = new System.Drawing.Size(78, 14);
            this.zf_wendu_textBox0.TabIndex = 6;
            this.zf_wendu_textBox0.Text = "蒸发温度";
            // 
            // lnwendu_textBox0
            // 
            this.lnwendu_textBox0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnwendu_textBox0.Font = new System.Drawing.Font("宋体", 9F);
            this.lnwendu_textBox0.Location = new System.Drawing.Point(12, 183);
            this.lnwendu_textBox0.Name = "lnwendu_textBox0";
            this.lnwendu_textBox0.ReadOnly = true;
            this.lnwendu_textBox0.Size = new System.Drawing.Size(78, 14);
            this.lnwendu_textBox0.TabIndex = 7;
            this.lnwendu_textBox0.Text = "冷凝温度";
            // 
            // nrjibi_textBox
            // 
            this.nrjibi_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nrjibi_textBox.Font = new System.Drawing.Font("宋体", 9F);
            this.nrjibi_textBox.Location = new System.Drawing.Point(12, 227);
            this.nrjibi_textBox.Name = "nrjibi_textBox";
            this.nrjibi_textBox.ReadOnly = true;
            this.nrjibi_textBox.Size = new System.Drawing.Size(78, 14);
            this.nrjibi_textBox.TabIndex = 8;
            this.nrjibi_textBox.Text = "内容积比";
            // 
            // lnwendu_textBox1
            // 
            this.lnwendu_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnwendu_textBox1.Location = new System.Drawing.Point(78, 176);
            this.lnwendu_textBox1.MaxLength = 3;
            this.lnwendu_textBox1.Name = "lnwendu_textBox1";
            this.lnwendu_textBox1.Size = new System.Drawing.Size(63, 21);
            this.lnwendu_textBox1.TabIndex = 10;
            this.lnwendu_textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zfwendu_textBox1_KeyPress);
            // 
            // nrjibi_comboBox
            // 
            this.nrjibi_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.nrjibi_comboBox.CausesValidation = false;
            this.nrjibi_comboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.nrjibi_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nrjibi_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nrjibi_comboBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nrjibi_comboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nrjibi_comboBox.FormattingEnabled = true;
            this.nrjibi_comboBox.Location = new System.Drawing.Point(78, 219);
            this.nrjibi_comboBox.Name = "nrjibi_comboBox";
            this.nrjibi_comboBox.Size = new System.Drawing.Size(108, 22);
            this.nrjibi_comboBox.TabIndex = 11;
            // 
            // zfwendu_textBox2
            // 
            this.zfwendu_textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zfwendu_textBox2.Location = new System.Drawing.Point(149, 145);
            this.zfwendu_textBox2.Name = "zfwendu_textBox2";
            this.zfwendu_textBox2.ReadOnly = true;
            this.zfwendu_textBox2.Size = new System.Drawing.Size(37, 14);
            this.zfwendu_textBox2.TabIndex = 12;
            this.zfwendu_textBox2.Text = "Deg.C";
            // 
            // lnwendu_textBox2
            // 
            this.lnwendu_textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnwendu_textBox2.Location = new System.Drawing.Point(149, 183);
            this.lnwendu_textBox2.Name = "lnwendu_textBox2";
            this.lnwendu_textBox2.ReadOnly = true;
            this.lnwendu_textBox2.Size = new System.Drawing.Size(37, 14);
            this.lnwendu_textBox2.TabIndex = 13;
            this.lnwendu_textBox2.Text = "Deg.C";
            // 
            // zfwendu_textBox1
            // 
            this.zfwendu_textBox1.Location = new System.Drawing.Point(78, 136);
            this.zfwendu_textBox1.MaxLength = 3;
            this.zfwendu_textBox1.Name = "zfwendu_textBox1";
            this.zfwendu_textBox1.Size = new System.Drawing.Size(63, 21);
            this.zfwendu_textBox1.TabIndex = 14;
            this.zfwendu_textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zfwendu_textBox1_KeyPress);
            // 
            // cool_comboBox
            // 
            this.cool_comboBox.BackColor = System.Drawing.Color.White;
            this.cool_comboBox.CausesValidation = false;
            this.cool_comboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.cool_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cool_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cool_comboBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cool_comboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cool_comboBox.FormattingEnabled = true;
            this.cool_comboBox.Location = new System.Drawing.Point(78, 6);
            this.cool_comboBox.Name = "cool_comboBox";
            this.cool_comboBox.Size = new System.Drawing.Size(108, 22);
            this.cool_comboBox.TabIndex = 1;
            // 
            // cool_textBox
            // 
            this.cool_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cool_textBox.Font = new System.Drawing.Font("宋体", 9F);
            this.cool_textBox.Location = new System.Drawing.Point(12, 11);
            this.cool_textBox.Name = "cool_textBox";
            this.cool_textBox.ReadOnly = true;
            this.cool_textBox.Size = new System.Drawing.Size(60, 14);
            this.cool_textBox.TabIndex = 0;
            this.cool_textBox.Text = "制冷剂";
            // 
            // chart1
            // 
  

//            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(271, 30);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "Series2";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(367, 203);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // economy_mode
            // 
            this.economy_mode.AutoSize = true;
            this.economy_mode.Location = new System.Drawing.Point(736, 12);
            this.economy_mode.Name = "economy_mode";
            this.economy_mode.Size = new System.Drawing.Size(72, 16);
            this.economy_mode.TabIndex = 16;
            this.economy_mode.Text = "经济模式";
            this.economy_mode.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(736, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 14);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "冷却方式";
            // 
            // lqfangshi_combox
            // 
            this.lqfangshi_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lqfangshi_combox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lqfangshi_combox.FormattingEnabled = true;
            this.lqfangshi_combox.Location = new System.Drawing.Point(736, 58);
            this.lqfangshi_combox.Name = "lqfangshi_combox";
            this.lqfangshi_combox.Size = new System.Drawing.Size(177, 20);
            this.lqfangshi_combox.TabIndex = 18;
            // 
            // ysrongtiao_textBox
            // 
            this.ysrongtiao_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ysrongtiao_textBox.Location = new System.Drawing.Point(736, 95);
            this.ysrongtiao_textBox.Name = "ysrongtiao_textBox";
            this.ysrongtiao_textBox.ReadOnly = true;
            this.ysrongtiao_textBox.Size = new System.Drawing.Size(100, 14);
            this.ysrongtiao_textBox.TabIndex = 19;
            this.ysrongtiao_textBox.Text = "压缩机容调状态";
            // 
            // yetiguolengdu_textBox
            // 
            this.yetiguolengdu_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yetiguolengdu_textBox.Location = new System.Drawing.Point(736, 136);
            this.yetiguolengdu_textBox.Name = "yetiguolengdu_textBox";
            this.yetiguolengdu_textBox.ReadOnly = true;
            this.yetiguolengdu_textBox.Size = new System.Drawing.Size(100, 14);
            this.yetiguolengdu_textBox.TabIndex = 20;
            this.yetiguolengdu_textBox.Text = "液体过冷度";
            // 
            // xqguore_textBox
            // 
            this.xqguore_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xqguore_textBox.Location = new System.Drawing.Point(736, 176);
            this.xqguore_textBox.Name = "xqguore_textBox";
            this.xqguore_textBox.ReadOnly = true;
            this.xqguore_textBox.Size = new System.Drawing.Size(100, 14);
            this.xqguore_textBox.TabIndex = 21;
            this.xqguore_textBox.Text = "吸气过热度";
            // 
            // pqwendu_textBox
            // 
            this.pqwendu_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pqwendu_textBox.Location = new System.Drawing.Point(736, 219);
            this.pqwendu_textBox.Name = "pqwendu_textBox";
            this.pqwendu_textBox.ReadOnly = true;
            this.pqwendu_textBox.Size = new System.Drawing.Size(100, 14);
            this.pqwendu_textBox.TabIndex = 22;
            this.pqwendu_textBox.Text = "排气温度期望值";
            // 
            // ysrongtiao_TB
            // 
            this.ysrongtiao_TB.Location = new System.Drawing.Point(822, 91);
            this.ysrongtiao_TB.MaxLength = 3;
            this.ysrongtiao_TB.Name = "ysrongtiao_TB";
            this.ysrongtiao_TB.Size = new System.Drawing.Size(54, 21);
            this.ysrongtiao_TB.TabIndex = 23;
            this.ysrongtiao_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zfwendu_textBox1_KeyPress);
            // 
            // ytguoleng_TB
            // 
            this.ytguoleng_TB.Location = new System.Drawing.Point(822, 129);
            this.ytguoleng_TB.MaxLength = 3;
            this.ytguoleng_TB.Name = "ytguoleng_TB";
            this.ytguoleng_TB.Size = new System.Drawing.Size(54, 21);
            this.ytguoleng_TB.TabIndex = 24;
            this.ytguoleng_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zfwendu_textBox1_KeyPress);
            // 
            // xqguore_TB
            // 
            this.xqguore_TB.Location = new System.Drawing.Point(822, 169);
            this.xqguore_TB.MaxLength = 3;
            this.xqguore_TB.Name = "xqguore_TB";
            this.xqguore_TB.Size = new System.Drawing.Size(54, 21);
            this.xqguore_TB.TabIndex = 25;
            this.xqguore_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zfwendu_textBox1_KeyPress);
            // 
            // pqwendu_TB
            // 
            this.pqwendu_TB.Location = new System.Drawing.Point(822, 212);
            this.pqwendu_TB.MaxLength = 3;
            this.pqwendu_TB.Name = "pqwendu_TB";
            this.pqwendu_TB.Size = new System.Drawing.Size(54, 21);
            this.pqwendu_TB.TabIndex = 26;
            this.pqwendu_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zfwendu_textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox2.Location = new System.Drawing.Point(884, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(31, 19);
            this.textBox2.TabIndex = 27;
            this.textBox2.Text = "%";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(884, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(69, 14);
            this.textBox3.TabIndex = 28;
            this.textBox3.Text = "Deg.C";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(884, 178);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(69, 14);
            this.textBox4.TabIndex = 29;
            this.textBox4.Text = "Deg.C";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(884, 219);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(69, 14);
            this.textBox5.TabIndex = 30;
            this.textBox5.Text = "Deg.C";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox6.Location = new System.Drawing.Point(180, 279);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(50, 14);
            this.textBox6.TabIndex = 31;
            this.textBox6.Text = "运行模式";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yxmoshi_textBox
            // 
            this.yxmoshi_textBox.BackColor = System.Drawing.Color.White;
            this.yxmoshi_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yxmoshi_textBox.Location = new System.Drawing.Point(241, 276);
            this.yxmoshi_textBox.Name = "yxmoshi_textBox";
            this.yxmoshi_textBox.ReadOnly = true;
            this.yxmoshi_textBox.Size = new System.Drawing.Size(110, 21);
            this.yxmoshi_textBox.TabIndex = 32;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox7.Location = new System.Drawing.Point(194, 314);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(36, 14);
            this.textBox7.TabIndex = 33;
            this.textBox7.Text = "制冷量";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zlliang_textBox
            // 
            this.zlliang_textBox.BackColor = System.Drawing.Color.White;
            this.zlliang_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zlliang_textBox.Location = new System.Drawing.Point(241, 311);
            this.zlliang_textBox.Name = "zlliang_textBox";
            this.zlliang_textBox.ReadOnly = true;
            this.zlliang_textBox.Size = new System.Drawing.Size(110, 21);
            this.zlliang_textBox.TabIndex = 34;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox8.Location = new System.Drawing.Point(180, 349);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(50, 14);
            this.textBox8.TabIndex = 35;
            this.textBox8.Text = "输入功率";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // srgonglv_textBox
            // 
            this.srgonglv_textBox.BackColor = System.Drawing.Color.White;
            this.srgonglv_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srgonglv_textBox.Location = new System.Drawing.Point(241, 347);
            this.srgonglv_textBox.Name = "srgonglv_textBox";
            this.srgonglv_textBox.ReadOnly = true;
            this.srgonglv_textBox.Size = new System.Drawing.Size(110, 21);
            this.srgonglv_textBox.TabIndex = 36;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox9.Location = new System.Drawing.Point(180, 385);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(50, 14);
            this.textBox9.TabIndex = 37;
            this.textBox9.Text = "运行电流";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yxdianliu_textBox
            // 
            this.yxdianliu_textBox.BackColor = System.Drawing.Color.White;
            this.yxdianliu_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yxdianliu_textBox.Location = new System.Drawing.Point(241, 378);
            this.yxdianliu_textBox.Name = "yxdianliu_textBox";
            this.yxdianliu_textBox.ReadOnly = true;
            this.yxdianliu_textBox.Size = new System.Drawing.Size(110, 21);
            this.yxdianliu_textBox.TabIndex = 38;
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox10.Location = new System.Drawing.Point(188, 416);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(42, 14);
            this.textBox10.TabIndex = 39;
            this.textBox10.Text = "能效比";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nxbi_textBox
            // 
            this.nxbi_textBox.BackColor = System.Drawing.Color.White;
            this.nxbi_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nxbi_textBox.Location = new System.Drawing.Point(241, 413);
            this.nxbi_textBox.Name = "nxbi_textBox";
            this.nxbi_textBox.ReadOnly = true;
            this.nxbi_textBox.Size = new System.Drawing.Size(110, 21);
            this.nxbi_textBox.TabIndex = 40;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox11.Location = new System.Drawing.Point(152, 450);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(78, 14);
            this.textBox11.TabIndex = 41;
            this.textBox11.Text = "吸气质量流量";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // xqzlliuliang_textBox
            // 
            this.xqzlliuliang_textBox.BackColor = System.Drawing.Color.White;
            this.xqzlliuliang_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xqzlliuliang_textBox.Location = new System.Drawing.Point(241, 447);
            this.xqzlliuliang_textBox.Name = "xqzlliuliang_textBox";
            this.xqzlliuliang_textBox.ReadOnly = true;
            this.xqzlliuliang_textBox.Size = new System.Drawing.Size(110, 21);
            this.xqzlliuliang_textBox.TabIndex = 42;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox12.Location = new System.Drawing.Point(152, 484);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(78, 14);
            this.textBox12.TabIndex = 43;
            this.textBox12.Text = "排气质量流量";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pqzlliuliang_textBox
            // 
            this.pqzlliuliang_textBox.BackColor = System.Drawing.Color.White;
            this.pqzlliuliang_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pqzlliuliang_textBox.Location = new System.Drawing.Point(241, 481);
            this.pqzlliuliang_textBox.Name = "pqzlliuliang_textBox";
            this.pqzlliuliang_textBox.ReadOnly = true;
            this.pqzlliuliang_textBox.Size = new System.Drawing.Size(110, 21);
            this.pqzlliuliang_textBox.TabIndex = 44;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox13.Location = new System.Drawing.Point(129, 522);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(101, 14);
            this.textBox13.TabIndex = 45;
            this.textBox13.Text = "中压喷液质量流量";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox14.Location = new System.Drawing.Point(129, 553);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(101, 14);
            this.textBox14.TabIndex = 46;
            this.textBox14.Text = "低压喷液质量流量";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox15.Location = new System.Drawing.Point(117, 586);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(110, 14);
            this.textBox15.TabIndex = 47;
            this.textBox15.Text = "无额外冷却排气温度";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zypyzl_textBox
            // 
            this.zypyzl_textBox.BackColor = System.Drawing.Color.White;
            this.zypyzl_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zypyzl_textBox.Location = new System.Drawing.Point(241, 519);
            this.zypyzl_textBox.Name = "zypyzl_textBox";
            this.zypyzl_textBox.ReadOnly = true;
            this.zypyzl_textBox.Size = new System.Drawing.Size(110, 21);
            this.zypyzl_textBox.TabIndex = 48;
            // 
            // dypyzl_textBox
            // 
            this.dypyzl_textBox.BackColor = System.Drawing.Color.White;
            this.dypyzl_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dypyzl_textBox.Location = new System.Drawing.Point(241, 550);
            this.dypyzl_textBox.Name = "dypyzl_textBox";
            this.dypyzl_textBox.ReadOnly = true;
            this.dypyzl_textBox.Size = new System.Drawing.Size(110, 21);
            this.dypyzl_textBox.TabIndex = 49;
            // 
            // wewlqpq_textBox
            // 
            this.wewlqpq_textBox.BackColor = System.Drawing.Color.White;
            this.wewlqpq_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wewlqpq_textBox.Location = new System.Drawing.Point(241, 583);
            this.wewlqpq_textBox.Name = "wewlqpq_textBox";
            this.wewlqpq_textBox.ReadOnly = true;
            this.wewlqpq_textBox.Size = new System.Drawing.Size(110, 21);
            this.wewlqpq_textBox.TabIndex = 50;
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox16.Location = new System.Drawing.Point(502, 279);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(105, 14);
            this.textBox16.TabIndex = 51;
            this.textBox16.Text = "制冷剂液体温度";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox17.Location = new System.Drawing.Point(502, 313);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(105, 14);
            this.textBox17.TabIndex = 52;
            this.textBox17.Text = "经济器质量流量";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox18.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox18.Location = new System.Drawing.Point(514, 345);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(93, 14);
            this.textBox18.TabIndex = 53;
            this.textBox18.Text = "经济器换热量";
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zljjnbhwd_textBox1
            // 
            this.zljjnbhwd_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zljjnbhwd_textBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.zljjnbhwd_textBox1.Location = new System.Drawing.Point(482, 380);
            this.zljjnbhwd_textBox1.Name = "zljjnbhwd_textBox1";
            this.zljjnbhwd_textBox1.ReadOnly = true;
            this.zljjnbhwd_textBox1.Size = new System.Drawing.Size(125, 14);
            this.zljjnbhwd_textBox1.TabIndex = 54;
            this.zljjnbhwd_textBox1.Text = "制冷经济内饱和温度";
            this.zljjnbhwd_textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // jjqnyl_textBox11
            // 
            this.jjqnyl_textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jjqnyl_textBox11.Font = new System.Drawing.Font("宋体", 9F);
            this.jjqnyl_textBox11.Location = new System.Drawing.Point(502, 405);
            this.jjqnyl_textBox11.Name = "jjqnyl_textBox11";
            this.jjqnyl_textBox11.ReadOnly = true;
            this.jjqnyl_textBox11.Size = new System.Drawing.Size(105, 14);
            this.jjqnyl_textBox11.TabIndex = 55;
            this.jjqnyl_textBox11.Text = "经济器内压力";
            this.jjqnyl_textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ylqqnl_textBox33
            // 
            this.ylqqnl_textBox33.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ylqqnl_textBox33.Font = new System.Drawing.Font("宋体", 9F);
            this.ylqqnl_textBox33.Location = new System.Drawing.Point(482, 433);
            this.ylqqnl_textBox33.Name = "ylqqnl_textBox33";
            this.ylqqnl_textBox33.ReadOnly = true;
            this.ylqqnl_textBox33.Size = new System.Drawing.Size(125, 14);
            this.ylqqnl_textBox33.TabIndex = 56;
            this.ylqqnl_textBox33.Text = "油冷却器能力";
            this.ylqqnl_textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox22
            // 
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox22.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox22.Location = new System.Drawing.Point(482, 463);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(125, 14);
            this.textBox22.TabIndex = 57;
            this.textBox22.Text = "油冷器冷冻油流量";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox23.Location = new System.Drawing.Point(494, 493);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(113, 14);
            this.textBox23.TabIndex = 58;
            this.textBox23.Text = "油冷却器出口温度";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox24
            // 
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox24.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox24.Location = new System.Drawing.Point(494, 523);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(113, 14);
            this.textBox24.TabIndex = 59;
            this.textBox24.Text = "中压喷液冷却量";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox25
            // 
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox25.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox25.Location = new System.Drawing.Point(494, 557);
            this.textBox25.Name = "textBox25";
            this.textBox25.ReadOnly = true;
            this.textBox25.Size = new System.Drawing.Size(113, 14);
            this.textBox25.TabIndex = 60;
            this.textBox25.Text = "低压喷液冷却量";
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox26
            // 
            this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox26.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox26.Location = new System.Drawing.Point(494, 590);
            this.textBox26.Name = "textBox26";
            this.textBox26.ReadOnly = true;
            this.textBox26.Size = new System.Drawing.Size(113, 14);
            this.textBox26.TabIndex = 61;
            this.textBox26.Text = "喷液时增加功率";
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zljytwendu_textBox
            // 
            this.zljytwendu_textBox.BackColor = System.Drawing.Color.White;
            this.zljytwendu_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zljytwendu_textBox.Location = new System.Drawing.Point(622, 272);
            this.zljytwendu_textBox.Name = "zljytwendu_textBox";
            this.zljytwendu_textBox.ReadOnly = true;
            this.zljytwendu_textBox.Size = new System.Drawing.Size(110, 21);
            this.zljytwendu_textBox.TabIndex = 62;
            // 
            // jjqzlll_textBox
            // 
            this.jjqzlll_textBox.BackColor = System.Drawing.Color.White;
            this.jjqzlll_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jjqzlll_textBox.Location = new System.Drawing.Point(622, 306);
            this.jjqzlll_textBox.Name = "jjqzlll_textBox";
            this.jjqzlll_textBox.ReadOnly = true;
            this.jjqzlll_textBox.Size = new System.Drawing.Size(110, 21);
            this.jjqzlll_textBox.TabIndex = 63;
            // 
            // jjqhrl_textBox
            // 
            this.jjqhrl_textBox.BackColor = System.Drawing.Color.White;
            this.jjqhrl_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jjqhrl_textBox.Location = new System.Drawing.Point(622, 342);
            this.jjqhrl_textBox.Name = "jjqhrl_textBox";
            this.jjqhrl_textBox.ReadOnly = true;
            this.jjqhrl_textBox.Size = new System.Drawing.Size(110, 21);
            this.jjqhrl_textBox.TabIndex = 64;
            // 
            // jjqnbhwd_textBox
            // 
            this.jjqnbhwd_textBox.BackColor = System.Drawing.Color.White;
            this.jjqnbhwd_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jjqnbhwd_textBox.Location = new System.Drawing.Point(622, 373);
            this.jjqnbhwd_textBox.Name = "jjqnbhwd_textBox";
            this.jjqnbhwd_textBox.ReadOnly = true;
            this.jjqnbhwd_textBox.Size = new System.Drawing.Size(110, 21);
            this.jjqnbhwd_textBox.TabIndex = 65;
            // 
            // jjqnyl_textBox
            // 
            this.jjqnyl_textBox.BackColor = System.Drawing.Color.White;
            this.jjqnyl_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jjqnyl_textBox.Location = new System.Drawing.Point(622, 402);
            this.jjqnyl_textBox.Name = "jjqnyl_textBox";
            this.jjqnyl_textBox.ReadOnly = true;
            this.jjqnyl_textBox.Size = new System.Drawing.Size(110, 21);
            this.jjqnyl_textBox.TabIndex = 66;
            // 
            // ylqqnl_textBox
            // 
            this.ylqqnl_textBox.BackColor = System.Drawing.Color.White;
            this.ylqqnl_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ylqqnl_textBox.Location = new System.Drawing.Point(622, 430);
            this.ylqqnl_textBox.Name = "ylqqnl_textBox";
            this.ylqqnl_textBox.ReadOnly = true;
            this.ylqqnl_textBox.Size = new System.Drawing.Size(110, 21);
            this.ylqqnl_textBox.TabIndex = 67;
            // 
            // ylqldyll_textbox
            // 
            this.ylqldyll_textbox.BackColor = System.Drawing.Color.White;
            this.ylqldyll_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ylqldyll_textbox.Location = new System.Drawing.Point(622, 460);
            this.ylqldyll_textbox.Name = "ylqldyll_textbox";
            this.ylqldyll_textbox.ReadOnly = true;
            this.ylqldyll_textbox.Size = new System.Drawing.Size(110, 21);
            this.ylqldyll_textbox.TabIndex = 68;
            // 
            // ylqqckwd_textbox
            // 
            this.ylqqckwd_textbox.BackColor = System.Drawing.Color.White;
            this.ylqqckwd_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ylqqckwd_textbox.Location = new System.Drawing.Point(622, 490);
            this.ylqqckwd_textbox.Name = "ylqqckwd_textbox";
            this.ylqqckwd_textbox.ReadOnly = true;
            this.ylqqckwd_textbox.Size = new System.Drawing.Size(110, 21);
            this.ylqqckwd_textbox.TabIndex = 69;
            // 
            // zypylql_textBox
            // 
            this.zypylql_textBox.BackColor = System.Drawing.Color.White;
            this.zypylql_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zypylql_textBox.Location = new System.Drawing.Point(622, 520);
            this.zypylql_textBox.Name = "zypylql_textBox";
            this.zypylql_textBox.ReadOnly = true;
            this.zypylql_textBox.Size = new System.Drawing.Size(110, 21);
            this.zypylql_textBox.TabIndex = 70;
            // 
            // dypylql_textBox
            // 
            this.dypylql_textBox.BackColor = System.Drawing.Color.White;
            this.dypylql_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dypylql_textBox.Location = new System.Drawing.Point(622, 554);
            this.dypylql_textBox.Name = "dypylql_textBox";
            this.dypylql_textBox.ReadOnly = true;
            this.dypylql_textBox.Size = new System.Drawing.Size(110, 21);
            this.dypylql_textBox.TabIndex = 71;
            // 
            // pyszjgl_textBox
            // 
            this.pyszjgl_textBox.BackColor = System.Drawing.Color.White;
            this.pyszjgl_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pyszjgl_textBox.Location = new System.Drawing.Point(622, 587);
            this.pyszjgl_textBox.Name = "pyszjgl_textBox";
            this.pyszjgl_textBox.ReadOnly = true;
            this.pyszjgl_textBox.Size = new System.Drawing.Size(110, 21);
            this.pyszjgl_textBox.TabIndex = 72;
            // 
            // textBox19
            // 
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox19.Location = new System.Drawing.Point(738, 276);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(69, 14);
            this.textBox19.TabIndex = 73;
            this.textBox19.Text = "Deg.C";
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox20.Location = new System.Drawing.Point(738, 378);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(69, 14);
            this.textBox20.TabIndex = 74;
            this.textBox20.Text = "Deg.C";
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox21.Location = new System.Drawing.Point(738, 493);
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(69, 14);
            this.textBox21.TabIndex = 75;
            this.textBox21.Text = "Deg.C";
            // 
            // textBox27
            // 
            this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox27.Location = new System.Drawing.Point(738, 557);
            this.textBox27.Name = "textBox27";
            this.textBox27.ReadOnly = true;
            this.textBox27.Size = new System.Drawing.Size(69, 14);
            this.textBox27.TabIndex = 76;
            this.textBox27.Text = "kW";
            // 
            // textBox28
            // 
            this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox28.Location = new System.Drawing.Point(738, 526);
            this.textBox28.Name = "textBox28";
            this.textBox28.ReadOnly = true;
            this.textBox28.Size = new System.Drawing.Size(69, 14);
            this.textBox28.TabIndex = 77;
            this.textBox28.Text = "kW";
            // 
            // textBox29
            // 
            this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox29.Location = new System.Drawing.Point(738, 590);
            this.textBox29.Name = "textBox29";
            this.textBox29.ReadOnly = true;
            this.textBox29.Size = new System.Drawing.Size(69, 14);
            this.textBox29.TabIndex = 78;
            this.textBox29.Text = "kW";
            // 
            // textBox30
            // 
            this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox30.Location = new System.Drawing.Point(738, 433);
            this.textBox30.Name = "textBox30";
            this.textBox30.ReadOnly = true;
            this.textBox30.Size = new System.Drawing.Size(69, 14);
            this.textBox30.TabIndex = 79;
            this.textBox30.Text = "kW";
            // 
            // textBox31
            // 
            this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox31.Location = new System.Drawing.Point(738, 345);
            this.textBox31.Name = "textBox31";
            this.textBox31.ReadOnly = true;
            this.textBox31.Size = new System.Drawing.Size(69, 14);
            this.textBox31.TabIndex = 80;
            this.textBox31.Text = "kW";
            // 
            // textBox32
            // 
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox32.Location = new System.Drawing.Point(738, 311);
            this.textBox32.Name = "textBox32";
            this.textBox32.ReadOnly = true;
            this.textBox32.Size = new System.Drawing.Size(69, 14);
            this.textBox32.TabIndex = 81;
            this.textBox32.Text = "kg/h";
            // 
            // textBox33
            // 
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox33.Location = new System.Drawing.Point(738, 463);
            this.textBox33.Name = "textBox33";
            this.textBox33.ReadOnly = true;
            this.textBox33.Size = new System.Drawing.Size(69, 14);
            this.textBox33.TabIndex = 82;
            this.textBox33.Text = "kW/h";
            // 
            // textBox34
            // 
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox34.Location = new System.Drawing.Point(738, 405);
            this.textBox34.Name = "textBox34";
            this.textBox34.ReadOnly = true;
            this.textBox34.Size = new System.Drawing.Size(69, 14);
            this.textBox34.TabIndex = 83;
            this.textBox34.Text = "kpa";
            // 
            // jisuan_button
            // 
            this.jisuan_button.Location = new System.Drawing.Point(66, 638);
            this.jisuan_button.Name = "jisuan_button";
            this.jisuan_button.Size = new System.Drawing.Size(75, 23);
            this.jisuan_button.TabIndex = 84;
            this.jisuan_button.Text = "计算";
            this.jisuan_button.UseVisualStyleBackColor = true;
            this.jisuan_button.Click += new System.EventHandler(this.jisuan_button_Click);
            // 
            // xingnengbiao_button
            // 
            this.xingnengbiao_button.Location = new System.Drawing.Point(241, 638);
            this.xingnengbiao_button.Name = "xingnengbiao_button";
            this.xingnengbiao_button.Size = new System.Drawing.Size(75, 23);
            this.xingnengbiao_button.TabIndex = 85;
            this.xingnengbiao_button.Text = "性能表";
            this.xingnengbiao_button.UseVisualStyleBackColor = true;
            this.xingnengbiao_button.Click += new System.EventHandler(this.xingnengbiao_button_Click);
            // 
            // dayin_button
            // 
            this.dayin_button.Location = new System.Drawing.Point(413, 638);
            this.dayin_button.Name = "dayin_button";
            this.dayin_button.Size = new System.Drawing.Size(75, 23);
            this.dayin_button.TabIndex = 86;
            this.dayin_button.Text = "打印";
            this.dayin_button.UseVisualStyleBackColor = true;
            this.dayin_button.Click += new System.EventHandler(this.dayin_button_Click);
            // 
            // excel_button
            // 
            this.excel_button.Location = new System.Drawing.Point(563, 638);
            this.excel_button.Name = "excel_button";
            this.excel_button.Size = new System.Drawing.Size(75, 23);
            this.excel_button.TabIndex = 87;
            this.excel_button.Text = "输出EXCEL";
            this.excel_button.UseVisualStyleBackColor = true;
            this.excel_button.Click += new System.EventHandler(this.excel_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(738, 638);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 88;
            this.back_button.Text = "返回";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // textBox35
            // 
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox35.Location = new System.Drawing.Point(357, 318);
            this.textBox35.Name = "textBox35";
            this.textBox35.ReadOnly = true;
            this.textBox35.Size = new System.Drawing.Size(69, 14);
            this.textBox35.TabIndex = 89;
            this.textBox35.Text = "kW";
            // 
            // textBox36
            // 
            this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox36.Location = new System.Drawing.Point(357, 354);
            this.textBox36.Name = "textBox36";
            this.textBox36.ReadOnly = true;
            this.textBox36.Size = new System.Drawing.Size(69, 14);
            this.textBox36.TabIndex = 90;
            this.textBox36.Text = "kW";
            // 
            // textBox37
            // 
            this.textBox37.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox37.Location = new System.Drawing.Point(357, 385);
            this.textBox37.Name = "textBox37";
            this.textBox37.ReadOnly = true;
            this.textBox37.Size = new System.Drawing.Size(69, 14);
            this.textBox37.TabIndex = 91;
            this.textBox37.Text = "A";
            // 
            // textBox38
            // 
            this.textBox38.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox38.Location = new System.Drawing.Point(357, 454);
            this.textBox38.Name = "textBox38";
            this.textBox38.ReadOnly = true;
            this.textBox38.Size = new System.Drawing.Size(69, 14);
            this.textBox38.TabIndex = 92;
            this.textBox38.Text = "kg/h";
            // 
            // textBox39
            // 
            this.textBox39.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox39.Location = new System.Drawing.Point(357, 483);
            this.textBox39.Name = "textBox39";
            this.textBox39.ReadOnly = true;
            this.textBox39.Size = new System.Drawing.Size(69, 14);
            this.textBox39.TabIndex = 93;
            this.textBox39.Text = "kg/h";
            // 
            // textBox40
            // 
            this.textBox40.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox40.Location = new System.Drawing.Point(357, 526);
            this.textBox40.Name = "textBox40";
            this.textBox40.ReadOnly = true;
            this.textBox40.Size = new System.Drawing.Size(69, 14);
            this.textBox40.TabIndex = 94;
            this.textBox40.Text = "kg/h";
            // 
            // textBox41
            // 
            this.textBox41.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox41.Location = new System.Drawing.Point(357, 556);
            this.textBox41.Name = "textBox41";
            this.textBox41.ReadOnly = true;
            this.textBox41.Size = new System.Drawing.Size(69, 14);
            this.textBox41.TabIndex = 95;
            this.textBox41.Text = "kg/h";
            // 
            // textBox42
            // 
            this.textBox42.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox42.Location = new System.Drawing.Point(357, 589);
            this.textBox42.Name = "textBox42";
            this.textBox42.ReadOnly = true;
            this.textBox42.Size = new System.Drawing.Size(69, 14);
            this.textBox42.TabIndex = 96;
            this.textBox42.Text = "Deg.C";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(954, 673);
            this.Controls.Add(this.textBox42);
            this.Controls.Add(this.textBox41);
            this.Controls.Add(this.textBox40);
            this.Controls.Add(this.textBox39);
            this.Controls.Add(this.textBox38);
            this.Controls.Add(this.textBox37);
            this.Controls.Add(this.textBox36);
            this.Controls.Add(this.textBox35);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.excel_button);
            this.Controls.Add(this.dayin_button);
            this.Controls.Add(this.xingnengbiao_button);
            this.Controls.Add(this.jisuan_button);
            this.Controls.Add(this.textBox34);
            this.Controls.Add(this.textBox33);
            this.Controls.Add(this.textBox32);
            this.Controls.Add(this.textBox31);
            this.Controls.Add(this.textBox30);
            this.Controls.Add(this.textBox29);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.textBox27);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.pyszjgl_textBox);
            this.Controls.Add(this.dypylql_textBox);
            this.Controls.Add(this.zypylql_textBox);
            this.Controls.Add(this.ylqqckwd_textbox);
            this.Controls.Add(this.ylqldyll_textbox);
            this.Controls.Add(this.ylqqnl_textBox);
            this.Controls.Add(this.jjqnyl_textBox);
            this.Controls.Add(this.jjqnbhwd_textBox);
            this.Controls.Add(this.jjqhrl_textBox);
            this.Controls.Add(this.jjqzlll_textBox);
            this.Controls.Add(this.zljytwendu_textBox);
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.textBox25);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.ylqqnl_textBox33);
            this.Controls.Add(this.jjqnyl_textBox11);
            this.Controls.Add(this.zljjnbhwd_textBox1);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.wewlqpq_textBox);
            this.Controls.Add(this.dypyzl_textBox);
            this.Controls.Add(this.zypyzl_textBox);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.pqzlliuliang_textBox);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.xqzlliuliang_textBox);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.nxbi_textBox);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.yxdianliu_textBox);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.srgonglv_textBox);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.zlliang_textBox);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.yxmoshi_textBox);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pqwendu_TB);
            this.Controls.Add(this.xqguore_TB);
            this.Controls.Add(this.ytguoleng_TB);
            this.Controls.Add(this.ysrongtiao_TB);
            this.Controls.Add(this.pqwendu_textBox);
            this.Controls.Add(this.xqguore_textBox);
            this.Controls.Add(this.yetiguolengdu_textBox);
            this.Controls.Add(this.ysrongtiao_textBox);
            this.Controls.Add(this.lqfangshi_combox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.economy_mode);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.nrjibi_comboBox);
            this.Controls.Add(this.nrjibi_textBox);
            this.Controls.Add(this.zfwendu_textBox2);
            this.Controls.Add(this.zfwendu_textBox1);
            this.Controls.Add(this.zf_wendu_textBox0);
            this.Controls.Add(this.compressor_comboBox);
            this.Controls.Add(this.compressor_textBox);
            this.Controls.Add(this.power_comboBox);
            this.Controls.Add(this.power_textBox);
            this.Controls.Add(this.lnwendu_textBox2);
            this.Controls.Add(this.lnwendu_textBox1);
            this.Controls.Add(this.lnwendu_textBox0);
            this.Controls.Add(this.cool_comboBox);
            this.Controls.Add(this.cool_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "性能计算";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox compressor_textBox;
        private System.Windows.Forms.ComboBox compressor_comboBox;
        private System.Windows.Forms.TextBox power_textBox;
        private System.Windows.Forms.ComboBox power_comboBox;
        private System.Windows.Forms.TextBox zf_wendu_textBox0;
        private System.Windows.Forms.TextBox lnwendu_textBox0;
        private System.Windows.Forms.TextBox nrjibi_textBox;
        private System.Windows.Forms.TextBox lnwendu_textBox1;
        private System.Windows.Forms.ComboBox nrjibi_comboBox;
        private System.Windows.Forms.TextBox zfwendu_textBox2;
        private System.Windows.Forms.TextBox lnwendu_textBox2;
        private System.Windows.Forms.TextBox zfwendu_textBox1;
        private System.Windows.Forms.ComboBox cool_comboBox;
        private System.Windows.Forms.TextBox cool_textBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox economy_mode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox lqfangshi_combox;
        private System.Windows.Forms.TextBox ysrongtiao_textBox;
        private System.Windows.Forms.TextBox yetiguolengdu_textBox;
        private System.Windows.Forms.TextBox xqguore_textBox;
        private System.Windows.Forms.TextBox pqwendu_textBox;
        private System.Windows.Forms.TextBox ysrongtiao_TB;
        private System.Windows.Forms.TextBox ytguoleng_TB;
        private System.Windows.Forms.TextBox xqguore_TB;
        private System.Windows.Forms.TextBox pqwendu_TB;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox yxmoshi_textBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox zlliang_textBox;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox srgonglv_textBox;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox yxdianliu_textBox;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox nxbi_textBox;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox xqzlliuliang_textBox;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox pqzlliuliang_textBox;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox zypyzl_textBox;
        private System.Windows.Forms.TextBox dypyzl_textBox;
        private System.Windows.Forms.TextBox wewlqpq_textBox;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox zljjnbhwd_textBox1;
        private System.Windows.Forms.TextBox jjqnyl_textBox11;
        private System.Windows.Forms.TextBox ylqqnl_textBox33;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox zljytwendu_textBox;
        private System.Windows.Forms.TextBox jjqzlll_textBox;
        private System.Windows.Forms.TextBox jjqhrl_textBox;
        private System.Windows.Forms.TextBox jjqnbhwd_textBox;
        private System.Windows.Forms.TextBox jjqnyl_textBox;
        private System.Windows.Forms.TextBox ylqqnl_textBox;
        private System.Windows.Forms.TextBox ylqldyll_textbox;
        private System.Windows.Forms.TextBox ylqqckwd_textbox;
        private System.Windows.Forms.TextBox zypylql_textBox;
        private System.Windows.Forms.TextBox dypylql_textBox;
        private System.Windows.Forms.TextBox pyszjgl_textBox;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.Button jisuan_button;
        private System.Windows.Forms.Button xingnengbiao_button;
        private System.Windows.Forms.Button dayin_button;
        private System.Windows.Forms.Button excel_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox textBox42;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}