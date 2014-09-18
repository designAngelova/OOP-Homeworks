using System;

public class Extras
{
    private bool HDMIDisplayPort;
    private bool opticalDevice;
    private bool fullHD;
    private bool ssd;
    private bool blueTooth;
    private bool threeGModule;
    private bool kbdLighting;

    public Extras(bool hdmi = false, bool optical = false, bool hd = false, bool ssd = false,
        bool blueT = false, bool threeG = false, bool kbdLight = false)
    {
        this.HdmiDisplayPort = hdmi;
        this.OpticalDevice = optical;
        this.FullHd = hd;
        this.Ssd = ssd;
        this.BlueTooth = blueT;
        this.ThreeGModule = threeG;
        this.KbdLighting = kbdLight;
    }

    public bool HdmiDisplayPort
    {
        get { return HDMIDisplayPort; }
        set { HDMIDisplayPort = value; }
    }

    public bool OpticalDevice
    {
        get { return opticalDevice; }
        set { opticalDevice = value; }
    }

    public bool FullHd
    {
        get { return fullHD; }
        set { fullHD = value; }
    }

    public bool Ssd
    {
        get { return ssd; }
        set { ssd = value; }
    }

    public bool BlueTooth
    {
        get { return blueTooth; }
        set { blueTooth = value; }
    }

    public bool ThreeGModule
    {
        get { return threeGModule; }
        set { threeGModule = value; }
    }

    public bool KbdLighting
    {
        get { return kbdLighting; }
        set { kbdLighting = value; }
    }

    public override string ToString()
    {
        return string.Format("  - HDMI / Display Port: {0}\n" +
                             "  - Optical Device: {1}\n" +
                             "  - Full HD: {2}\n" +
                             "  - SSD: {3}\n" +
                             "  - Bluetooth: {4}\n" +
                             "  - 3G Module: {5}\n" +
                             "  - Keyboard Lighting: {6}",
                             HDMIDisplayPort ? "Yes" : "No",
                             opticalDevice ? "Yes" : "No",
                             fullHD ? "Yes" : "No",
                             ssd ? "Yes" : "No",
                             blueTooth ? "Yes" : "No",
                             threeGModule ? "Yes" : "No",
                             kbdLighting ? "Yes" : "No");
    }
}

