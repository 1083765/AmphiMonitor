using System;
using Corpuls.Bluetooth.Connection;
using Corpuls.Bluetooth;

namespace AmphiSys.Monitor.Corpuls3.MonitorAccess
{

    public class Corpuls3Connection
    {
        private BluetoothConnection _btConn;
        public ConnectedC3Device _connectedC3Device;
        private string mac = "00:18:da:04:b3:11";
        private int port = 2;
        private string pin = "6673";
        private static Corpuls3Connection _instance;
        private bool _connected = false;

        // Constuct a Corpuls3Connection object
        /// <summary>
        /// Constuct a Corpuls3Connection object
        /// </summary>
        public Corpuls3Connection()
        {
        }

        //  Connect to Corpuls3
        /// <summary>
        /// Attempts to connect to Corpuls3 with bt
        /// </summary>
        public bool Connect()
        {
            try
            {
                _btConn = new BluetoothConnection(mac, port, pin);
                _connectedC3Device = new ConnectedC3Device(_btConn, (warning) => { Console.WriteLine(warning); });
                _connected = true;
            }
            catch(Exception)
            {
                throw;
            }
            return _connected;
        }

        //  Disconnect to Corpuls3
        /// <summary>
        /// Attempts to disconnect from Corpuls3
        /// </summary>
        internal void Disconnect()
        {
            try
            {
                if(_connectedC3Device != null)
                {
                    _connectedC3Device.Dispose();
                }
                if(_btConn != null)
                {
                    _btConn.Dispose();
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        // Returns an instance of Corpuls3Connection
        /// <summary>
        /// Returns an instance of Corpuls3Connection after checking if an instance already exists
        /// </summary>
        /// <returns>
        /// An instance of Corpuls3Connection.
        /// </returns>
        public static Corpuls3Connection GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Corpuls3Connection();
            }
            return _instance;
        }
    }
}