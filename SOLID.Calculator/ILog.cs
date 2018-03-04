namespace SOLID.Math
{
    public interface ILog
    {
        void Append(string format, params object[] args);
    }
}