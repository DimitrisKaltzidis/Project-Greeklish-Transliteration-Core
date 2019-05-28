namespace Models.ExternalServices
{
    using System.Collections.Generic;

    public class Data
    {
        public List<List<GoogleDetectLanguageModels.DetectionResult>> detections { get; set; }
    }
}