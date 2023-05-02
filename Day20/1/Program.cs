byte[] data = new byte [1000];
// bytesRead will always end up at 1000, unless the stream is
// itself smaller in length:
int bytesRead = 0;
int chunkSize = 1;
while (bytesRead < data.Length && chunkSize > 0)
 bytesRead +=
 chunkSize = s.Read (data, bytesRead, data.Length - bytesRead);       