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

namespace CSharp2CPP {
  public partial class Form1 : Form {
    //[DllImport(@"D:\MyGIT\CPP_DLL\x64\Debug\CPP_DLL.dll", EntryPoint = "mixed_mode_multiply", CallingConvention = CallingConvention.StdCall)]
    [DllImport(@"D:\MyGIT\CSharp2CPP\x64\Debug\CPP_DLL.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int Multiply(int x, int y);
    [DllImport(@"D:\MyGIT\CSharp2CPP\x64\Debug\CPP_DLL.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int Addition(int x, int y);
    [DllImport(@"D:\MyGIT\CSharp2CPP\x64\Debug\CPP_DLL.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern void Set1(int index, int data);
    [DllImport(@"D:\MyGIT\CSharp2CPP\x64\Debug\CPP_DLL.dll", CallingConvention = CallingConvention.StdCall)]
    public static extern int Get1(int index);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void YourCallback(int x, int y);
        
    [DllImport(@"D:\MyGIT\CSharp2CPP\x64\Debug\CPP_DLL.dll")]
    public static extern int TakesInCallbackAndDoesStuff([MarshalAs(UnmanagedType.FunctionPtr)] YourCallback callbackPointer);


    public Form1() {
      InitializeComponent();
    }

    YourCallback callback =
      (intParam1, intParam2) => {
        Console.WriteLine("The result of the C++ function is {0} and {1}", intParam1, intParam2);
      };

    private void button1_Click(object sender, EventArgs e) {
      int result = Multiply(7, 7);
      Console.WriteLine("The Multiply answer is {0}", result);
      result = Addition(7, 7);
      Console.WriteLine("The add answer is {0}", result);
      Set1(0, 123);
      result = Get1(0);
      Console.WriteLine("The Get1 answer is {0}", result);
      //Console.ReadKey();

      int x = TakesInCallbackAndDoesStuff(callback);
    }



    
  }
}
