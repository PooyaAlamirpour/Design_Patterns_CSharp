using System.Collections.Generic;
using System.Security.Cryptography;
using MediatorPattern.Colleagues;
using MediatorPattern.ConcreteColleagues;

namespace MediatorPattern.ConcreteMediators
{
    public class Chatroom : AbstractChatroom
    {
        private readonly Dictionary<string, Participant> _participantList = new();

        public override void Register(Participant participant)
        {
            if (!_participantList.ContainsValue(participant))
            {
                _participantList[participant.Name] = participant;
            }

            participant.Chatroom = this;
        } 

        public override void Send(string from, string to, string message)
        {
            var participant = _participantList[to];
            if (participant is not null)
            {
                participant.Receive(from, message);
            }
        }
    }
}