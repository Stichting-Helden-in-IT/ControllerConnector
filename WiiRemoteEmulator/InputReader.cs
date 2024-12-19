using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Timers;
using WiimoteLib;




namespace WiiRemoteEmulator;

public class InputReader
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
        
        
        Form1.wiiMote.GetStatus();
    }
}