namespace SOLID.Math.Logging
{
    public interface ILog
    {
        void Append(string format, params object[] args);
    }
}