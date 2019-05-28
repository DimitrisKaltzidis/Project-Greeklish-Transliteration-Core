namespace Models
{
    using System.Threading.Tasks;

    public interface ILanguageTranslator
    {
        Task<string> TranslateTextAsync(
            string text,
            string sourceLanguage,
            string destinationLanguage);

        string TranslateText(
            string text,
            string sourceLanguage,
            string destinationLanguage);
    }
}