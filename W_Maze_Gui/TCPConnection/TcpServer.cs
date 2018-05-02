using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Reciever;

namespace W_Maze_Gui.TCPConnection
{
    internal class TcpServer
    {
        public const string ACQUIRE = "acquire";
        public const string RECORD = "record";

        private volatile bool _hasStarted;
        private NetworkStream _networkStream;
        private StreamWriter _networkWriter;
        private StreamReader _networkReader;


        public TcpServer(string ipAddress = "192.168.0.50", int port = 20000)
        {
            _tcpListener = new TcpListener(IPAddress.Parse(ipAddress), port);
        }

        private TcpListener _tcpListener { get; }
        private Socket _clientConnection { get; set; }

        public bool IsConnected { get; set; }

        public async Task<bool> StartServerAndWaitForClient()
        {
            if (!_hasStarted)
            {
                _tcpListener.Start();
                _hasStarted = true;
            }

            Logger.Instance.WriteMessage("Trying to connect");
            _clientConnection = await _tcpListener.AcceptSocketAsync();

            if (_clientConnection != null && _clientConnection.Connected)
            {
                Logger.Instance.WriteMessage("Successfully started and connected!");
                _networkStream = new NetworkStream(_clientConnection);
                _networkWriter = new StreamWriter(_networkStream) {AutoFlush = true};
                _networkReader = new StreamReader(_networkStream);

                IsConnected = true;
            }

            return _clientConnection != null && _clientConnection.Connected;
        }

        public void SendMessage(string message)
        {
            _networkWriter.WriteLine(message);
            _networkWriter.Flush();
            var response = _networkReader.ReadLine();
            Logger.Instance.WriteMessage($"Sent message {message} to {_clientConnection.Handle.ToInt64()}, got response {response}");
        }

        public void StopSender()
        {
            _tcpListener?.Stop();
            _clientConnection?.Disconnect(false);
            _clientConnection?.Dispose();
            _networkStream?.Dispose();
        }
    }
}