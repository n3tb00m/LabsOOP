using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Media.TextFormatting;
using TextEditor.Models;

namespace TextEditor.Services
{
    internal class TextService
    {
        public IEnumerable<TextFile>? LoadRecentFiles(string path)
        {
            return JsonSerializer.Deserialize<IEnumerable<TextFile>>(File.ReadAllText(path));
        }

        public void SaveFile(TextFile file)
        {
            using (StreamWriter writer = new StreamWriter(file.FilePath))
            {
                string text;

                if(Path.GetExtension(file.FilePath).ToLower() == ".txt")
                {
                    text = XamlToTxt(file.Text);
                }
                else
                {
                    text = XamlWriter.Save(file.Text);
                }

                writer.Write(text);
            }
        }

        public static FlowDocument TxtToXaml(string[] lines)
        {
            Paragraph paragraph = new Paragraph();

            foreach (string line in lines)
            {
                paragraph.Inlines.Add(new Run(line));
                paragraph.Inlines.Add(new LineBreak());
            }

            FlowDocument flowDocument = new(paragraph);

            return flowDocument;
        }

        public static string XamlToTxt(FlowDocument doc)
        {
            TextRange docSelection = new TextRange(doc.ContentStart, doc.ContentEnd);

            return docSelection.Text;
        }
    }
}
