namespace ChainOfResponsability
{
    public interface IChainHandler
    {
        IChainHandler SetNext(IChainHandler handler);

        object Handle(object obj);
    }
}