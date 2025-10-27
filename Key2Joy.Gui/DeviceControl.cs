using System.Windows.Forms;
using Key2Joy.LowLevelInput;

namespace Key2Joy.Gui;

public partial class DeviceControl : UserControl
{
    private DeviceControl()
    {
        this.InitializeComponent();
        this.Layout += this.DeviceControl_Layout;
    }

    public DeviceControl(IGamePadInfo device)
        : this()
    {
        this.lblIndex.Text = $"#{device.Index}";
        this.lblDevice.Text = device.Name;
    }

    private void DeviceControl_Layout(object sender, LayoutEventArgs e)
    {
        if (this.Height == this.Width)
        {
            return;
        }

        this.Height = this.Width;
    }
}
