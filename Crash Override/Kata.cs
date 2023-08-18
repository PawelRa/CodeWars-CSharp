using System;

namespace Crash_Override
{
    public partial class Kata
    {
        public static string AliasGen(string fName, string lName)
        {
            var FirstName = new Dictionary<string, string>() { { "A", "Alpha" }, { "B", "Beta" }, { "C", "Cache" },{ "D", "Data"},{"E", "Energy"},{"F", "Function"},{ "G", "Glitch"},
            { "H", "Half-life"}, { "I", "Ice"},{ "J", "Java"},{ "K", "Keystroke"},{"L", "Logic"},{ "M", "Malware"},{ "N", "Nagware"},{ "O", "OS"},{ "P", "Phishing"},{ "Q", "Quantum"},
            { "R", "RAD" },{ "S", "Strike"},{ "T", "Trojan"},{ "U", "Ultraviolet"},{ "V", "Vanilla"},{ "W", "WiFi"},{ "X", "Xerox"},{"Y", "Y"},{ "Z", "Zero"}};

            var Surname = new Dictionary<string, string>() { { "A", "Analogue" }, { "B", "Bomb" }, { "C", "Catalyst" },{ "D", "Discharge" },{ "E", "Electron" },{ "F", "Faraday"},
                {"G", "Gig"},{ "H", "Hacker"},{ "I", "IP"},{ "J", "Jabber"},{ "K", "Killer"},{ "L", "Lazer"},{ "M", "Mike"},{ "N", "n00b"},{ "O", "Overclock"},{ "P", "Payload"},
                { "Q", "Quark"},{ "R", "Roy"},{ "S", "Spy"},{ "T", "T-Rex"},{ "U", "Unit"},{ "V", "Virus"},{ "W", "Worm"},{ "X", "X"},{ "Y", "Yob"},{ "Z", "Zombie"}};

            if (!Char.IsLetter(fName[0]) || !Char.IsLetter(lName[0]))
            {
                return "Your name must start with a letter from A - Z.";
            }

            string first = Char.ToUpper(fName[0]).ToString();
            string second = Char.ToUpper(lName[0]).ToString();

             return $"{FirstName[first]} {Surname[second]}";
        }
    }
}
