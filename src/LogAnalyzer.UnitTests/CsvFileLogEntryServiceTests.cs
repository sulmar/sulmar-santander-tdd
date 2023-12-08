
using System.Text;

namespace LogAnalyzer.UnitTests
{
    public class FakeValidFileStreamReader : IFileStreamReader
    {
        public StreamReader Get(string path)
        {
            var header = "Timestamp,Source_IP,Destination_IP,Protocol,Port,Bytes_Transferred";
            var line = "2023-11-22 08:00:00,203.0.113.10,8.8.8.8,TCP,80,1200";

            MemoryStream stream = new MemoryStream();
            var headerBytes = Encoding.UTF8.GetBytes(header);
            var lineBytes = Encoding.UTF8.GetBytes(line);

            stream.Write(headerBytes, 0, headerBytes.Length);
            stream.Write(lineBytes, 0, lineBytes.Length);

            StreamReader streamReader = new StreamReader(stream);

            return streamReader;
        }
    }

    public class FakeInvalidFileStreamReader : IFileStreamReader
    {
        public StreamReader Get(string path)
        {
            var header = "a";
            MemoryStream stream = new MemoryStream();
            var headerBytes = Encoding.UTF8.GetBytes(header);
            StreamReader streamReader = new StreamReader(stream);

            return streamReader;
        }
    }

    public class CsvFileLogEntryServiceTests
    {
        [Fact]
        public void GetLogEntries_EmptyFile_ShouldThrowInvalidOperation()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void GetLogEntries_InvalidFile_ShouldThrowFormatException()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void GetLogEntries_ValidFile_ShouldReturnsLogEntries()
        {
            // Arrange
            IFileStreamReader streamReader = new FakeValidFileStreamReader();

            CsvFileLogEntryService logEntryService = new CsvFileLogEntryService(streamReader);

            // Act
            var result = logEntryService.GetLogEntries("a.csv");

            // Assert
            Assert.Single(result);
        }
    }
}