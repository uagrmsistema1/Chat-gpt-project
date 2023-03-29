using OpenAI_API;
using OpenAI_API.Completions;

namespace ChatGPT.Integration.Services
{
    public class AnswerGeneratorService : IAnswerGeneratorService
    {
        public async Task<string> GenerateAnswer(string prompt)
        {
            string apikey = "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";
            string answer = string.Empty;
            var openai = new OpenAIAPI(apikey);
            CompletionRequest completion= new CompletionRequest();
            completion.Prompt= prompt;
            completion.MaxTokens = 4000;
            var result= await openai.Completions.CreateCompletionAsync(completion);
            if (result!=null)
            {
                foreach (var item in result.Completions)
                {
                    answer = item.Text;
                }
            }
            return answer;


        }
    }
}
