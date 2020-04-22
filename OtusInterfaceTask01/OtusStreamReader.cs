using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace OtusInterfaceTask01
{
    public class OtusStreamReader<T>: IEnumerable<T>, IDisposable
    {
        private Stream _stream;
        private ISerializer<T> serializer;
        
        public OtusStreamReader(Stream stream, ISerializer<T> serializer)
        {
            _stream = stream;
            this.serializer = serializer;

        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in serializer.Deserialize<T[]>(_stream))
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            _stream.Close();
            _stream = null;
            serializer = null;
        }
    }
}