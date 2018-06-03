using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;

namespace Fiap.CopaMundo.UWP.Services
{
    public static class NotificationService
    {
        public static void SelecaoNewsNotification(string selecao)
        {
            XmlDocument toastXml = new XmlDocument();

            string toastXmlString =
                $@"<toast scenario='alarm'>
                <visual>
                    <binding template='ToastGeneric'>
                    <text>Uhuuul!! A partir de agora você passa a receber todas as sobre a seleção do(a) {selecao}!!</text>
                    </binding>
                </visual>
            </toast>";

            toastXml.LoadXml(toastXmlString);

            var toast = new ScheduledToastNotification(toastXml, DateTime.Now.AddSeconds(10));

            ToastNotificationManager.CreateToastNotifier().AddToSchedule(toast);
        }
    }
}
