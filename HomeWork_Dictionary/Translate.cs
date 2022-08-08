using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace HomeWork_Dictionary
{
   public static class Translate
    {
       static Form2 form2 = new Form2();
        public static Dictionary<string, string> dictionaryRuEn { get; set; } = new Dictionary<string, string>();
        public static Dictionary<string, string> dictionaryRuDe { get; set; } = new Dictionary<string, string>();
        

        
       

        public static void LoadRuEn()
        {
            var jsonRuEn = File.ReadAllText("dictionaryRuEn.json");
            dictionaryRuEn = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonRuEn);
        }
        public static void LoadRuDe()
        {
            var jsonRuDe = File.ReadAllText("dictionaryRuDe.json");
            dictionaryRuDe = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonRuDe);
        }

        public static string TransRuEn(string line)
        {
           LoadRuEn();
            ListBox listBoxFrom = new ListBox();
            
            //if (listBoxFrom.Text == "Русский")
            //dictionaryRuEn.Add(form2.listBoxRu.Text, form2.listBoxEn.Text);
            //dictionaryRuEn.Add(form2.listBoxEn.Text, form2.listBoxRu.Text);
            return dictionaryRuEn[line];
        }
        public static string TransRuDe(string line)
        {
           LoadRuDe();
           
            return dictionaryRuDe[line];
        }

        
       
        //{
        //    ["привет"] = "hello",
        //    ["пока"] = "good Bye",
        //    ["мама"] = "mother",
        //    ["папа"] = "father",
        //    ["сын"] = "son",
        //    ["дочь"] = "daughter",
        //    ["дети"] = "children",
        //    ["привет"] = "hello",
        //    ["мир"] = "world",
        //    ["мне"] = "me",
        //    ["нравится"] = "like",
        //    ["программа"] = "program",
        //    ["создавать"] = "create",
        //    ["прекрасная"] = "beautiful",
        //    ["это"] = "this",
        //    ["родина"] = "motherland",
        //    ["здание"] = "house",
        //    ["дом"] = "home",
        //    ["мы"] = "we",
        //    ["пошли"] = "send",
        //    ["на"] = "in",
        //    ["hello"] = "Привет",
        //    ["good Bye"] = "Пока",
        //    ["mother"] = "мама",
        //    ["father"] = "папа",
        //    ["son"] = "сын",
        //    ["daughter"] = "дочь",
        //    ["children"] = "дети",
        //    ["hello"] = "привет",
        //    ["world"] = "мир",
        //    ["me"] = "мне",
        //    ["like"] = "нравится",
        //    ["program"] = "программа",
        //    ["create"] = "создавать",
        //    ["beautiful"] = "прекрасная",
        //    ["this"] = "это",
        //    ["motherland"] = "родина",
        //    ["house"] = "здание",
        //    ["home"] = "дом",
        //    ["we"] = "мы",
        //    ["send"] = "пошли",
        //    ["in"] = "на",
        //    ["square"] = "площадь"

        //};

        //public  Dictionary<string, string> dictionaryRuDe = new Dictionary<string, string>
        //{
        //    ["привет"] = "hallo",
        //    ["пока"] = "tschüss",
        //    ["мама"] = "mama",
        //    ["папа"] = "papa",
        //    ["сын"] = "sohn",
        //    ["дочь"] = "tochter",
        //    ["дети"] = "kinder",
        //    ["привет"] = "hallo",
        //    ["мир"] = "welt",
        //    ["мне"] = "mir",
        //    ["нравится"] = "gefällt",
        //    ["программа"] = "das Programm",
        //    ["создавать"] = "schaffen",
        //    ["прекрасная"] = "schoene",
        //    ["это"] = "es",
        //    ["родина"] = "die Heimat",
        //    ["здание"] = "die Aufgabe",
        //    ["дом"] = "die Haus",
        //    ["мы"] = "wir",
        //    ["пошли"] = "gehen",
        //    ["на"] = "auf",
        //    ["hallo"] = "Привет",
        //    ["tschüss"] = "Пока",
        //    ["mama"] = "Мама",
        //    ["papa"] = "Папа",
        //    ["sohn"] = "сын",
        //    ["tochter"] = "дочь",
        //    ["kinder"] = "дети",
        //    ["hallo"] = "привет",
        //    ["Welt"] = "мир",
        //    ["mir"] = "мне",
        //    ["gefällt"] = "нравится",
        //    ["das Programm"] = "программа",
        //    ["schaffen"] = "создавать",
        //    ["schoene"] = "пекрасная",
        //    ["es"] = "это",
        //    ["die Heimat"] = "родина",
        //    ["die Aufgabe"] = "здание",
        //    ["die Haus"] = "дом",
        //    ["wir"] = "мы",
        //    ["gehen"] = "пошли",
        //    ["auf"] = "на"
        //};

    }
   
}
