namespace VpnHood.Tunneling
{
    public static class TunnelUtil
    {
        public const int SocketStackSize_Datagram = 65536 * 2;
        public const int SocketStackSize_Stream = 65536 * 2;
        public const int TlsHandshakeLength = 5000;
        public const int MtuWithFragmentation = 0xFFFF - 70;
        public const int MtuWithoutFragmentation = 1500 - 70;
    }
}
