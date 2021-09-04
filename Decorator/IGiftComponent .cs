namespace Decorator
{
    //The basic implementation of the component interface. Define operations that can be altered by decorators.
    public interface IGiftComponent
    {
        double GetCost();
        string PackGiftItem();
    }
}
