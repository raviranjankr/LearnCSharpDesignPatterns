namespace Decorator
{
    // interface defines operations that can be altered by decorators.
    public interface IGiftComponent
    {
        double GetCost();
        string PackGiftItem();
    }
}
