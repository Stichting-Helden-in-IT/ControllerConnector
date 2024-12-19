using System.Timers;
using WiimoteLib;
using static WiiRemoteEmulator.InputReader;
using System;

using SharpDX.DirectInput;

namespace WiiRemoteEmulator;

public partial class Form1 : Form
{
    // Static instance of a System.Timers.Timer
    // This timer is set up to execute with an interval of 50 milliseconds
    static System.Timers.Timer updateTimer = new System.Timers.Timer()
    {
        Interval = 50,  // Interval between timer events in milliseconds
        Enabled = false // Timer starts disabled
    };

    internal static Wiimote wiiMote = new Wiimote();

    private float[] zeroPoint = new float[4];

    public Form1()
    {
        InitializeComponent();
    }

    // Event handler for the Connect Wii Mote button click
    private void ConnectWiiMote_Click(object sender, EventArgs e)
    {
        ConnectWiiMote();
    }
    
    // Event handler for the Start Update Timer button click
    private void StartUpdateTimer_Click(object sender, EventArgs e)
    {
        // Attach the event handler to be executed when the timer elapses
        updateTimer.Elapsed += UpdateTimer_Elapsed;
        
        // Enable the timer to start periodic execution
        updateTimer.Enabled = true;
    }

    //TODO: Fix this so it actually works properly
    //Maybe make it display 0 while having a margin of 0 to 10 so it doesnt go below the 0
    private void CalibrateBoard_Click(object sender, EventArgs e)
    {
        RecalibrateBoard();
    }
    
    // Connect Wii Mote logic
    private void ConnectWiiMote()
    {
        // Set deviceCollection to be a new instance of the Wii remote collected in WiimoteCollection
        var deviceCollection = new WiimoteCollection();
        
        deviceCollection.FindAllWiimotes();
       
        for (int i = 0; i < deviceCollection.Count; i++)
        {
            
            wiiMote = deviceCollection[i];
            wiiMote.Connect();
            
        }
        
        InitializeWiiMoteEvents();
        wiiMote.WiimoteState.BalanceBoardState.SensorValuesRaw = new BalanceBoardSensors();
    }
    
    // Calls when timer is elapsed is used to display information
    void UpdateTimer_Elapsed(object sender, ElapsedEventArgs e)
    {
        // Call InfoUpdate() every time the timer is finished
        InfoUpdate();
    }
    
    // Initializes the Wii remotes events
    public void InitializeWiiMoteEvents()
    {
        // Set the events to execute their respective Methods
        wiiMote.WiimoteChanged += WiimoteChangedEvent;
        wiiMote.WiimoteExtensionChanged += WiimoteExtensionChanged;
    }
    
    // Calls when a value changes on the Wii remote
    private static void WiimoteChangedEvent(object sender, WiimoteChangedEventArgs e)
    {
        
    }
    
    private static void WiimoteExtensionChanged(object sender, WiimoteExtensionChangedEventArgs e)
    {
        
    }

    // Set the zeropoint to where the idle balanceboard values are when the button is pressed
    private void RecalibrateBoard()
    {
        // TODO: Either change this to make it actually work or use a different value
        zeroPoint[1] = wiiMote.WiimoteState.BalanceBoardState.SensorValuesRaw.TopLeft;
        zeroPoint[2] = wiiMote.WiimoteState.BalanceBoardState.SensorValuesRaw.TopRight;
        zeroPoint[3] = wiiMote.WiimoteState.BalanceBoardState.SensorValuesRaw.BottomLeft;
        zeroPoint[4] = wiiMote.WiimoteState.BalanceBoardState.SensorValuesRaw.BottomRight;
    }

    private void InfoUpdate()
    {
        // Set the raw value floats
        var rwTopLeft     = wiiMote.WiimoteState.BalanceBoardState.SensorValuesRaw.TopLeft - zeroPoint[1];
        TopLeftValue.Text = rwTopLeft.ToString();
        var rwTopRight    = wiiMote.WiimoteState.BalanceBoardState.SensorValuesRaw.TopRight - zeroPoint[2];
        TopRightValue.Text = rwTopRight.ToString();
        var rwBottomLeft  = wiiMote.WiimoteState.BalanceBoardState.SensorValuesRaw.BottomLeft - zeroPoint[3];
        BottomLeftValue.Text = rwBottomLeft.ToString();
        var rwBottomRight = wiiMote.WiimoteState.BalanceBoardState.SensorValuesRaw.BottomRight - zeroPoint[4];
        BottomRightValue.Text = rwBottomRight.ToString();
    }
    
    // Simple print function
    public static void Print(object message)
    {
        Console.WriteLine(message);
    }
}