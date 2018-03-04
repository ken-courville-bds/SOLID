namespace SOLID.Math.Logging
{
    public interface ILogService
    {
        void Append(string format, params object[] args);
    }
}