
namespace Lecture.Tests
{
    public class Document : Thing, ISavable
    {
        public string Content;
        public string Name;

        public Document(string name)
        {
            Name = name;
        }

        //Using the interface method this way allows for only other ISavable interface
        //objects to be able to view this method
        string ISavable.ToText()
        {
            return $"{nameof(Name)}: {Name}";
        }
    }
}