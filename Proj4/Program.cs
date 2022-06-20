using System;

namespace proj4
{
    class Program
    {
        interface IElectronic_Device
        {
            void Reload() { }
        }

        abstract class Computer : IElectronic_Device
        {
            private string _model;
            private int _memory = 0;
            private string _keypad_Colour;

            public int Memory
            {
                get => _memory;
                set { if (value > 0) _memory = value; }
            }

            public string Model
            {
                get => _model;
                init => _model = value;
            }

            public string Keypad_Colour { get; set; }

            protected Computer(int memory, string model, string keypad_Colour)
            {
                Memory = memory;
                Model = model;
                Keypad_Colour = keypad_Colour;
            }

            public void Reload()
            {
                Console.Clear();
                Console.WriteLine(Keypad_Colour);
            }
        }

        class Notebook : Computer
        {
            private string _processor;

            public int Processor { get; }

            public Notebook(int memory, string model, string keypad_Colour, string processor) : base(memory, model, keypad_Colour)
            {
                _processor = processor;
            }

            public void Info() { Console.WriteLine(Processor); }
        }
        class PC : Computer
        {
            private bool _has_Video_Card;

            public bool Has_Video_Card { get; set; }

            public PC(int memory, string model, string keypad_Colour, bool has_Video_Card) : base(memory, model, keypad_Colour)
            {
                _has_Video_Card = has_Video_Card;
            }

            public void Video_Card() { Console.WriteLine(Has_Video_Card); }
        }
        class Mobile_Phone : Computer
        {
            private bool _has_Camera;

            public bool Has_Camera { get; }

            public Mobile_Phone(int memory, string model, string keypad_Colour, bool has_Camera) : base(memory, model, keypad_Colour)
            {
                _has_Camera = has_Camera;
            }

            public int[] Snap_Photo() { int[] photo = new int[10]; return photo; }
        }

        static void Main(string[] args)
        {
            Mobile_Phone Samsung = new Mobile_Phone(100, "lxljdnv", "ksjvs", true);
            Samsung.Snap_Photo();
            Samsung.Reload();
        }
    }
}
