using System;

namespace File_Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your language :");
            Console.WriteLine("ENG\nRUS\nAZE\n");
            string language = Console.ReadLine();
            switch (language)
            {
                case "ENG":
                    Console.WriteLine("Enter your file name (.pdf .jpg .docs) Example: book.pdf");
                    break;
                case "RUS":
                    Console.WriteLine("Введите имя файла (.pdf .jpg .docs) Например: book.pdf");
                    break;
                case "AZE":
                    Console.WriteLine("Fayl adını daxil edin (.pdf .jpg .docs) Məsələn: book.pdf");
                    break;
                default:
                    Console.WriteLine("Enter your file name (.pdf .jpg .docs) Example: book.pdf");
                    break;
            }

            FileValidator document = new FileValidator(Console.ReadLine(), ".pdf", ".jpg", ".docs");           
            Console.WriteLine("Enter file name and get extension :");
            Console.WriteLine(document.DefineExtension(Console.ReadLine()));
            Console.WriteLine("Available extensions : .pdf .jpg .docs");
            Console.WriteLine("Enter file name and extension or only extension :");
            Console.WriteLine(document.IsExtensionTrue(Console.ReadLine()));
        }
    }
    class FileValidator
    {
        private string[] _fileExtensions;
        private string _fileName;

        public FileValidator(params string[] extensions)
        {
            _fileExtensions = extensions;
        }
        public FileValidator(string fileName, params string[] extensions) : this(extensions)
        {
            _fileName = fileName;
        }

        public bool IsExtensionTrue(string name)
        {
            string newExtension = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == '.')
                {
                    for (int a = i; a < name.Length; a++)
                    {
                        newExtension += name[a];
                    }
                }
            }
            foreach (string sonluq in _fileExtensions)
            {
                if (sonluq == newExtension)
                {
                    return true;
                }
            }
            return false;
        }

        public string DefineExtension(string name)
        {
            string fullName = _fileName;
            string targetFileName = "";
            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == '.')
                {
                    for (int o = i; o > fullName.Length; o--)
                    {
                        targetFileName += fullName[o];
                    }
                }
            }
            return fullName;
        }
    }
}
