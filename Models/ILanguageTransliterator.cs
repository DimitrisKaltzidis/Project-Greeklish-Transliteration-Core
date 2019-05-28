namespace Models
{
    public interface ILanguageTransliterator
    {
        string GuessGreekFromGreeklish(string text);

        string GenerateGreeklishFromGreek(string text);
    }
}
