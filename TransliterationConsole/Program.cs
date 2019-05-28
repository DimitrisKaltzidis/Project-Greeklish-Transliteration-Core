namespace TransliterationConsole
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var yolo = "geia sou ti kaneis";

            var detector = new GreeklishHelper.LanguageDetector();

            var s = new GreeklishHelper.LanguageTransliterator();



            var res = s.GenerateGreeklishFromGreek("Καλησπέρα και καλή βραδιά");

            var language = detector.GetLanguage(yolo);
            Console.WriteLine($"{language.Language} - {language.Confidence}");
            Console.ReadKey();
        }
    }
}
