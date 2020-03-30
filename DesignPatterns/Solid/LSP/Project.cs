using System.Collections.ObjectModel;

/// <summary>
/// Liskov Substitution Principle (LSP) =>  "Code that uses a base class must be able to substitute a subclass without knowing it".
/// http://www.blackwasp.co.uk/lsp_2.aspx
/// </summary>
namespace Solid.LSP
{
    public class Project
    {
        public Collection<ProjectFile> AllFiles { get; set; }
        public Collection<WriteableFile> WriteableFiles { get; set; }

        public void LoadAllFiles()
        {
            foreach (ProjectFile file in AllFiles)
            {
                file.LoadFileData();
            }
        }

        public void SaveAllWriteableFiles()
        {
            foreach (WriteableFile file in WriteableFiles)
            {
                file.SaveFileData();
            }
        }
    }
}
