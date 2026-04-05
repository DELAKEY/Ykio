
namespace Ykio.Services
{
    public class ParserService : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            var t = new Thread(Worker);
            t.Start();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        void Worker()
        {
            while (true)
            {
                Parser();
                Thread.Sleep(60 * 60 * 1000);
            }
        }
        void Parser()
        {

        }
    }
}
