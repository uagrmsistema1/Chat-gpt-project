namespace ChatGPT.Integration.Services
{
    public interface IAnswerGeneratorService
    {
        Task<string> GenerateAnswer(string prompt);
    }
}
