namespace DillunHolmesBlazorServerApp.Models
{
    public partial class Device
    {
        public Device()
        {
            Operations = new HashSet<Operation>();
        }

        public int DeviceId { get; set; }
        public string Name { get; set; } = null!;
        public string DeviceType { get; set; } = null!;

        public virtual DeviceType DeviceTypeNavigation { get; set; } = null!;
        public virtual ICollection<Operation> Operations { get; set; }
    }
}
