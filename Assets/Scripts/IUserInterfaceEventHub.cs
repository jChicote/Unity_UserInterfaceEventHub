namespace AplosUserInterfaceEventHub
{

    public interface IUserInterfaceEventHub
    {
        void TriggerEvent(string key);
        void TriggerEvent(string key, object param);
    }

}