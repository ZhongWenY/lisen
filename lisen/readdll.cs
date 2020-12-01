using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace lisen
{
    class readdll
    {
       // [DllImport("CoolProp_cdecl.dll", EntryPoint = "PropsSI", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        [global::System.Runtime.InteropServices.DllImport("CoolProp_cdecl", EntryPoint = "PropsSI", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern double PropsSI(string jarg1, string jarg2, double jarg3, string jarg4, double jarg5, string jarg6);
        //  public static extern Double PropsSI(IntPtr Output, IntPtr Name1, IntPtr Prop1, IntPtr Name2, IntPtr Prop2, IntPtr FluidName);
        public void read_dll()
        {

            // int hModule = NativeMethod.LoadLibrary(@"CoolProp_cdecl.dll");
            // System.Diagnostics.Debug.WriteLine(hModule);

            //if (hModule == 0) return;

            //2. 读取函数指针
            //    IntPtr intPtr = NativeMethod.GetProcAddress(hModule, "PropsSI");

            //3. 将函数指针封装成委托
            //    PropsSI addFunction = (PropsSI)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(PropsSI));

            //4. 测试
            // addFunction('P','T',Te+273.5,'Q',1,'A');


            Double a = PropsSI("P", "T", 5+273.15, "Q", 1, "R134a");
            System.Diagnostics.Debug.WriteLine(a);

           // IntPtr ptrIn0 = Marshal.StringToHGlobalAnsi("P");
       //     IntPtr ptrIn1 = Marshal.StringToHGlobalAnsi("T");
        //    IntPtr ptrIn2 = Marshal.StringToHGlobalAnsi("101325");
        //    IntPtr ptrIn3 = Marshal.StringToHGlobalAnsi("Q");
        //    IntPtr ptrIn4 = Marshal.StringToHGlobalAnsi("300");
        //    IntPtr ptrIn5 = Marshal.StringToHGlobalAnsi("Water");
         //   IntPtr ptrRet = PropsSI(ptrIn0, ptrIn1, ptrIn2, ptrIn3, ptrIn4, ptrIn5);
            
            

        }
    }
   

}
