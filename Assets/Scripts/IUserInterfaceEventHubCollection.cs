using System;

namespace AplosUserInterfaceEventHub
{

    public interface IUserInterfaceEventHubCollection
    {
        void RegisterEvent(string key, Action eventAction);
        void RegisterEvent(string key, Action<object> eventAction);
        void UnRegisterEvent(string key);
    }

}