using System.IO;

namespace OtusInterfaceTask01
{
    public interface ISerializer<T>
    {
        string Serialize<T>(T item);
        T Deserialize<T>(Stream stream);
    }
}