using System.IO;
using System.IO.Compression;
using Microsoft.AspNetCore.ResponseCompression;

namespace Microservice.Application.Providers
{
    /// <summary>
    /// Provider para compressão de informações
    /// </summary>
    public class BrotliCompressionProvider : ICompressionProvider
    {
        public string EncodingName => "br";
        public bool SupportsFlush => true;

        public Stream CreateStream(Stream outputStream) => new BrotliStream(outputStream, CompressionLevel.Optimal, true);
    }
}