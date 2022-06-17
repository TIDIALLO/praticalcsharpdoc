// This is the interface we are going to focus on.
// It is an interface for something that would be able
// to read and write data to something that is ready
// to be used this way
public interface IReaderWriter<TData> where TData: Data
{
    void Initialize();
    TData Read(int dataId);
    void Write(TData data);
}