namespace TransliterationConsole
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var phraseToDetectAndTransliterate = "pou eisai re tsifth";

            var phraseToConvertToGreeklish = "Καλησπέρα και καλή βραδιά";

            var detector = new GreeklishHelper.LanguageDetector();

            var transliterator = new GreeklishHelper.LanguageTransliterator();

            var greekFromGreeklish = transliterator.GuessGreekFromGreeklish(phraseToDetectAndTransliterate);

            var greeklishFromGreek = transliterator.GenerateGreeklishFromGreek(phraseToConvertToGreeklish);

            var language = detector.GetLanguage(phraseToDetectAndTransliterate);

            Console.WriteLine($"Original phrase to detect and transliterate: {phraseToDetectAndTransliterate}");
            Console.WriteLine($"Original phrase to convert to Greeklish: {phraseToConvertToGreeklish}");
            Console.WriteLine($"Detected language: {language.Language} - {language.Confidence}");
            Console.WriteLine($"Greek from Greeklish: {greekFromGreeklish}");
            Console.WriteLine($"Greeklish from Greek: {greeklishFromGreek}");
            Console.WriteLine($"Press any key to exit.");
            Console.ReadKey();
        }
    }
}
