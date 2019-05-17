using Autofac.Extras.Moq;
using CalculationsLibrary;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace CalculationsLibraryTest
{
    public class TextDataAccessLibraryTest
    {
        [Fact]
        private void TextDataAccess_SaveText_ThrowsPathTooLongException()
        {
            // Arrange
            string outputPathFiller = 1.ToString().PadLeft(260, '0');

            string filePath = string.Concat(@"C:\Temp\", outputPathFiller, @"\Save.txt");

            // Assert
            Assert.Throws<PathTooLongException>(() =>
            {
                new TextDataAccess().SaveText(filePath, null);
            });
        }

        [Fact]
        private void TextDataAccess_SaveText_Validated()
        {
            // Arrange
            string filePath = @"E:\Temp\Save.txt";
            List<string> lines = new List<string>() { "This is a line" };

            // Act
            using (var moc = AutoMock.GetLoose())
            {
                moc.Mock<ITextDataAccess>()
                    .Setup(x => x.SaveText(filePath, lines));
            }

            // Assert
            //???
        }
    }
}
