using FacthoryMethod.Interfaces;
using FacthoryMethod.Forms;

namespace FacthoryMethod.Creators
{
    public class EmailCreator : Transformacao
    {
        public override INotificacao GetNotification()
        {
            return new Email();
        }
    }
}