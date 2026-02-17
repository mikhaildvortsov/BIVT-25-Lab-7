using System.ComponentModel;

namespace Characters;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public struct Character
    {
        private string _name;
        private int _age;
        private int _height;
        private string _gender;
        private string _hairstyle;
        private string _eyeColor;
        private int _weight;

        public string Name => _name;
        public int Age => _age;
        public int Height => _height;
        public string Gender => _gender;
        public string Hairstyle => _hairstyle;
        public string EyeColor => _eyeColor;
        public int Weight => _weight;

        public Character(string  name, int age, int height, string gender, string hairstyle, string eyeColor, int weight)
            {
            _name = name;
            _age = age;
            _height = height;
            _gender = gender;
            _hairstyle = hairstyle;
            _eyeColor = eyeColor;
            _weight = weight;
            }

        public struct Village
        {
            private Character[] _characters;
            private int _characterID;
            public Character[] Characters
            {
                get
                {
                    Character[] copy =  new Character[_characters.Length];
                    Array.Copy(_characters, copy, _characters.Length);
                    return copy;
                    
                }
            }

            public Village(Character[] characters)
            {
                _characters = new Character[]
                {
                    new Character("Borin",
                        45,
                        168,
                        "Male",
                        "Short beard",
                        "Brown",
                        78),
                    new Character("Tomas",
                        32,
                        175,
                        "Male",
                        "Messy short hair",
                        "Green",
                        70),
                    new Character("Elina",
                        19,
                        162,
                        "Female",
                        "Long wavy hair",
                        "Blue",
                        54),
                    new Character("Gregor",
                        50,
                        180,
                        "Male",
                        "Long curly hair",
                        "Gray",
                        85),
                    new Character("Hilda",
                        41,
                        170,
                        "Female",
                        "Braided hair",
                        "Brown",
                        68),
                    new Character("Marek",
                        28,
                        178,
                        "Male",
                        "Shoulder-length hair",
                        "Hazel",
                        73),
                    new Character("Lina",
                        23,
                        165,
                        "Female",
                        "Curly short hair",
                        "Green",
                        58),
                    new Character("Sven",
                        36,
                        182,
                        "Male",
                        "Long straight hair",
                        "Blue",
                        80)
                };
            }
            public void Add(Character[] characters, Character character)
            {
                Array.Resize(ref characters, _characters.Length + 1);
                characters[_characters.Length - 1] = character;
            }
        }
    }
}