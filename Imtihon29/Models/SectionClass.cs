namespace Imtihon29.Models
{
    internal class SectionClass
    {
        public string Name { get; set; } = string.Empty;

        public string ImagePath { get; set; } = string.Empty;

        public SectionClass(string name, string imagePath)
        {
            Name = name;
            ImagePath = imagePath;
        }
    }
}
