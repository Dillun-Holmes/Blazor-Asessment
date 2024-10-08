namespace DillunHolmesBlazorServerApp.Models
{
    public partial class DeviceType
    {
        public DeviceType()
        {
            Devices = new HashSet<Device>();
        }

        public string TypeName { get; set; } = null!;

        public virtual ICollection<Device> Devices { get; set; }
    }
}
