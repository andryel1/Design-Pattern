using FacthoryMethod.Interfaces;
using FacthoryMethod.Forms;

namespace FacthoryMethod.Creators
{
    public class SmsCreator : Transformacao
    {
        public override INotificacao GetNotification()
        {
            return new Sms();
        }
    }
}