namespace VpnHood.Server
{
    public class AddUsageParams
    {
        public ClientIdentity ClientIdentity { get; set; }
        public long SentTrafficByteCount { get; set; }
        public long ReceivedTrafficByteCount { get; set; }
    }
}
