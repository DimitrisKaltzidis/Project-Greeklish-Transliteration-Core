namespace Models
{
    using System.Threading.Tasks;

    public interface ILanguageDetector
    {
        LanguageDetectionResult GetLanguage(string text);

        Task<LanguageDetectionResult> GetLanguageAsync(string text);
    }
}