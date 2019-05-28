namespace GreeklishHelper
{
    using Models;

    // TODO I should souloupwsw this a bit
    public class LanguageTransliterator : ILanguageTransliterator
    {
        public string GuessGreekFromGreeklish(string input)
        {
            return LinguisticTools.GreeklishHelper.GuessSentense(input);
        }

        public string GenerateGreeklishFromGreek(string text)
        {
            return LinguisticTools.GreeklishHelper.ToGreeklish(text);
        }
    }
}