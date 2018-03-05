namespace SOLID.Math.Logging
{
    public interface ILogAppender
    {
        void Append(LogEntry entry);
    }
}