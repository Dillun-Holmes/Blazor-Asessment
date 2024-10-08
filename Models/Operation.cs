namespace DillunHolmesBlazorServerApp.Models
{
    public partial class Operation
    {
        public int OperationId { get; set; }
        public string Name { get; set; } = null!;
        public int OrderInWhichToPerform { get; set; }
        public byte[]? ImageData { get; set; }
        public int? DeviceId { get; set; }

        public virtual Device? Device { get; set; }
    }
}
