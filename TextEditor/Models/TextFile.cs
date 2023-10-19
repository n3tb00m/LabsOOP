using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Markup;
using TextEditor.Services;

namespace TextEditor.Models
{
    internal class TextFile
    {
        public string FilePath { get; set; } = null!;

        [JsonIgnore]
        public string FileName
        {
            get
            {
                string fileName = Path.GetFileName(FilePath);
                return string.IsNullOrEmpty(fileName) ? "New File*" : fileName;
            }
        }

        [JsonIgnore]
        public string FileExtension => Path.GetExtension(FilePath)[1..].ToUpper();

        [JsonIgnore]
        public FlowDocument Text { get; set; } = null;

        public DateTime LastChange { get; set; } = DateTime.Now;

        public TextFile() { }

        internal TextFile(string path)
        {
            FilePath = path;

            if (!string.IsNullOrEmpty(FilePath))
            {
                try
                {
                    Text = XamlReader.Parse(File.ReadAllText(FilePath)) as FlowDocument;
                }
                catch (XamlParseException)
                {
                    Text = TextService.TxtToXaml(File.ReadAllLines(FilePath));
                }
            }
        }
    }
}
