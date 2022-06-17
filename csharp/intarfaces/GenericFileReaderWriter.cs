// This is the class implementing our IReaderWriter<TData>
// but now we know that it is going to save and retrieve
// data to and from a file. We would not care about the
// implementation so don't give it too much thought.
public class FileReaderWriter<TData> : IReaderWriter<TData> where TData : Data
{
    public void Initialize() { throw new NotImplementedException(); }

    public TData Read(int dataId) { throw new NotImplementedException(); }

    public void Write(TData data) { throw new NotImplementedException(); }
}