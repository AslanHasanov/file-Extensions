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
                    Console.WriteLine("Enter your file name :");
                    break;
                case "RUS":
                    Console.WriteLine("Введите имя файла :");
                    break;
                case "AZE":
                    Console.WriteLine("Fayl adını daxil edin :");
                    break;
                default:
                    Console.WriteLine("Enter your file name :");
                    break;

            }
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
        public FileValidator(string fileName, params string[] extensions) :this(extensions)
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
