using Datalab.Server.Packets;
using DataLab.Server.Packets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.NetworkPackaging
{
    public class PacketClientNotifier: BackgroundWorker
    {

        public event EventHandler SignalPost;

        public TimeSpan Delay = TimeSpan.FromSeconds(10);
        
        public PacketClientNotifier()
        {
            // Set worker options
            this.WorkerSupportsCancellation =   true;
            this.WorkerReportsProgress      =   true;
        }

        // Start the notifier
        public void Start()
        {
            this.DoWork += PacketClientNotifier_DoWork;
            this.RunWorkerAsync();
            this.RunWorkerCompleted += PacketClientNotifier_RunWorkerCompleted;
        }

        private void PacketClientNotifier_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Stop();
        }

        public void Stop()
        {
            this.CancelAsync();
            this.DoWork -= PacketClientNotifier_DoWork;
            
        }
        
        private async void PacketClientNotifier_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!e.Cancel)
            {
                // Wait a timespan before asking again
                await Task.Delay(Delay.Seconds * 1000);
                if (PacketClient.DataAvailable)
                {
                    if (!PacketClient.Locked)
                        SignalPost(PacketClient.receivePacket(), new EventArgs());
                }

            }
        }

        public void setChanged(Packet p) {

            if (SignalPost != null)
            {
                SignalPost(p, new EventArgs());
            }
        }
        
    }
}
