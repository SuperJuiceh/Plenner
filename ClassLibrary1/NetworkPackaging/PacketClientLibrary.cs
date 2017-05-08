using DataLab.Storage;
using Datalab.Server.Packets;
using DataLab.Data.Planning;
using DataLab.Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.NetworkPackaging
{
    public static class PacketClientLibrary
    {
        public static Tuple<bool, DynamicPlanningItemStorage> SyncUser(DynamicPlanningItemStorage localPlan)
        {
            // Send user and receive results
            
            QuestionPacket packje = PacketClient.SendAndReceive(QuestionPacket.SyncUserData(localPlan.CurrentUser)) as QuestionPacket;
            
            if (packje.A)
            {
                // Get content
                User user = (User)packje.Question_data[0];
                localPlan.plan = user.plan;

                localPlan = new DynamicPlanningItemStorage(localPlan, user);
            }

            return new Tuple<bool, DynamicPlanningItemStorage>(packje.A, localPlan);
        }
        
    }
}
