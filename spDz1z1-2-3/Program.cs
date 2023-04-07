//задание 1
//using System;
//using System.Runtime.InteropServices;

//class Program
//{
//    [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
//    static extern int MessageBox(IntPtr hwnd, String text, String caption, uint type);

//    static void Main()
//    {
//        // Отобразить информацию о себе в нескольких MessageBox
//        MessageBox(IntPtr.Zero, "Меня зовут Никита.", "Информация о мне", 0);
//        MessageBox(IntPtr.Zero, "Я студент академии шаг", "Информация о мне", 0);
//        MessageBox(IntPtr.Zero, "Мне 18 лет", "Информация о мне", 0);
//    }
//}
//-----------------------------------------------------------------------------------------------



//задание 2
//using System.Runtime.InteropServices;
//namespace ConsoleApp2
//{
//    static class Program
//    {
//        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
//        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

//        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
//        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);
//        //static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type); 
//        static void Main(string[] args)
//        {
//            Console.WriteLine("choose: 1 - change name, 2 - close window");
//            uint choose = Convert.ToUInt16(Console.ReadLine());
//            var a = Console.ReadLine();

//            switch (choose)
//            {
//                case 1:
//                    string b = Console.ReadLine();
//                    SendMessage(FindWindow(a, null), 12, IntPtr.Zero, b);
//                    break;
//                case 2:
//                    SendMessage(FindWindow(a, null), 16, IntPtr.Zero, null);
//                    break;
//            }
//            Console.ReadLine();
//        }
//    }
//}




//----------------------------------------------------------------------------------
//задание 3
//using System;
//using System.Runtime.InteropServices;

//class Program
//{
//    [DllImport("kernel32.dll")]
//    public static extern bool Beep(int frequency, int duration);

//    [DllImport("user32.dll")]
//    public static extern bool MessageBeep(uint type);

//    static void Main(string[] args)
//    {
//        int[] frequencies = { 500, 600, 700, 800, 900 };
//        int duration = 500; // in milliseconds

//        foreach (int frequency in frequencies)
//        {
//            Beep(frequency, duration);
//            MessageBeep(0xFFFFFFFF); // play system default sound
//            System.Threading.Thread.Sleep(1000); // wait for 1 second
//        }
//    }
//}