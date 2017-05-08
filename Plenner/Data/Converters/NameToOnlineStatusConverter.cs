using Datalab.Server.Packets;
using DataLab.NetworkPackaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;

namespace Plenner.Data.Converters
{
    public class NameToOnlineStatusConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, string language)
        {
            string name = value as string;

            if (name != "")
            {
                // Send packet
                QuestionPacket qPack = QuestionPacket.Is_Online(name);
                PacketClient.sendPacket(qPack);
                QuestionPacket packet = PacketClient.receivePacket() as QuestionPacket;
                
                if (packet.A)
                    return Colors.Green;

            }

            return Colors.Red;

        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
