using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace lisen
{
    class Cal
    {
        [global::System.Runtime.InteropServices.DllImport("CoolProp_cdecl", EntryPoint = "PropsSI", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern double PropsSI(string jarg1, string jarg2, double jarg3, string jarg4, double jarg5, string jarg6);       
        public static string[] cal(Double Te, Double Tc)
        {
            Double M1, M2, M3, M4, M5, M6, M7, M8, M9, M10;
            Double V, n1, QR, PR;
            Double P1, P2, P3, P4, P5, P6, P7, P8, P9, P10;
            Double Qsh, Qsc, Psh;
            Double Q, P,COP,I,mLp;
            Double B1 = -0.2406, B2 = 0.4771, B3 = 0.6526;
            Double A1 = 0.226606, A2 = 0.414008, A3 = 0.36917;
            Double A=data_share.A, B=data_share.B;
            V = Constant.V;
            n1 = Constant.n1;
            QR = Constant.QR;
            PR = Constant.PR;
            M1 = Constant.M1;
            M2 = Constant.M2;
            M3 = Constant.M3;
            M4 = Constant.M4;
            M5 = Constant.M5;
            M6 = Constant.M6;
            M7 = Constant.M7;
            M8 = Constant.M8;
            M9 = Constant.M9;
            M10 = Constant.M10;
            P1 = Constant.P1;
            P2 = Constant.P2;
            P3 = Constant.P3;
            P4 = Constant.P4;
            P5 = Constant.P5;
            P6 = Constant.P6;
            P7 = Constant.P7;
            P8 = Constant.P8;
            P9 = Constant.P9;
            P10 = Constant.P10;
            Qsc = Constant.Qsc;
            Qsh = Constant.Qsh;
            Psh = Constant.Psh;
            Double n = 100/100;
            Double SH = 5;
            Double SC = 5;
            String cool = data_share.cool;
            Q = (M1 + M2 * Te + M3 * Tc + M4 * Te * Te + M5 * Te * Tc + M6 * Tc * Tc + M7 * Te * Te * Te +
                M8 * Tc * Te * Te + M9 * Te * Tc * Te + M10 * Tc * Tc * Tc + (SH - 5) * Qsh + Qsc * (SC - 5)) * V * n1 * QR;
            P = (P1 + P2 * Te + P3 * Tc + P4 * Te * Te + P5 * Te * Tc + P6 * Tc * Tc + P7 * Te * Te * Te +
                P8 * Tc * Te * Te + P9 * Te * Tc * Tc + P10 * Tc * Tc * Tc + (SH - 5) * Psh) * V * n1 * PR;
            I = P * 1000 / (3 * 220 * (B1 * n * n + B2 * n + B3));
            Double Tdm = Convert.ToDouble(data_share.pqwendu);
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
            Double ttc = PropsSI("T", "P", Pc, "Q", 0, cool) - 273.5;
            Double hs = PropsSI("H", "P", Pe, "T", Te + 273.15 + SH, cool);
            Double T1 = Tc - SC;
            Double hc = PropsSI("H", "P", Pc, "T", T1 + 273.15, cool);
            Double ms = Qp / (hs - hc) * 3600 * 1000;
            Double hd = Pp / ms * 3600 * 1000 + hs;
            Double Td1 = PropsSI("T", "H", hd, "P", Pc, cool) - 273.15;
            Double hdm = PropsSI("H", "P", Pc, "T", Tdm + 273.5, cool);
            Double Qc1 = 0, Qc2 = 0, mc2 = 0, Pc2 = 0, Pc1 = 0, mc1 = 0, pi = Pp, moil = 0, CPO = 0, Qoil = 0, Tob = 0, Pm = 0, TTm = 0, Hmg = 0, Hml = 0, Qeco = 0, meco = 0, Tcc = 0, Peco = 0;         
            if (Td1 > Tdm && Tc <= 60 && data_share.lqfangshi == "A电机腔&压缩腔喷液冷却")
            {
                Qc2 = ms * (hd - hdm);
                mc2 = Qc2 / (hdm - hc);
                Pc2 = mc2 * (hdm - hs);
                pi = Pp + Pc1 + Pc2;

            }
            else if (Td1 > Tdm && Tc > 60 && data_share.lqfangshi == "A电机腔&压缩腔喷液冷却")
            {
                Qc1 = P * 0.015;
                mc1 = Qc1 / (hs - hc) * 1000;
                ms = ms - mc1 * 3600;
                Qp = Qp * (1 - mc1 * 3600 / (ms));
                Qc2 = (ms) * (hd - hdm) / 3600 / 1000;
                mc2 = Qc2 / (hdm - hc) * 1000;
                Pc2 = (mc1 + mc2) * (hdm - hs) / 1000;
                pi = pi + Pc1 + Pc2;
            }
            else if (Td1 > Tdm && Tc <= 60 && data_share.lqfangshi == "B电机腔喷液&外接油冷却")
            {

                moil = (A * Math.Sqrt((Tc - Te)) + B) * 950;
                CPO = 2.71;
                Qoil = ms * (hd - hdm);
                Tob = Tdm - Q / CPO / moil;
            }
            else if (Td1 > Tdm && Tc > 60 && data_share.lqfangshi == "B电机腔喷液&外接油冷却")
            {
                Qc1 = P * 0.015;
                mc1 = Qc2 / (hs - hc);
                ms = ms - mc2;
                Qp = Q * (1 - mc1 / (ms - mc1));
                Qoil = (ms - mc1) * (hd - hdm);
                Tob = Tdm - Q / CPO / moil;
                Pc2 = mc2 * (hdm - hs);
                pi = pi + Pc2;
            }
            else if (Td1 > Tdm && data_share.lqfangshi == "C外接油冷却")
            {
                moil = (A * Math.Sqrt(Tc - Te) + B) * 950;
                CPO = 2.71;
                Qoil = ms * (hd - hdm);
                Tob = Tdm - Q / CPO / moil;
            }
            mLp = mc2;
            return new string[] { P.ToString("0.00"), Q.ToString("0.00"),(Q/P).ToString("0.00"),I.ToString("0.00"),mLp.ToString("0.00") };

        }
    }
}
