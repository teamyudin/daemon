using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NServiceBus;
using Messages;
public class StartImportHandler: IHandleMessages<StartImport>{
        readonly ILogger logger;
        public StartImportHandler(ILogger<StartImportHandler> logger)
        {
            this.logger = logger;
        }

        public Task Handle(StartImport message, IMessageHandlerContext context)
        {
            logger.LogInformation($"Import Started for Session Id: {message.SessionId}");

            return Task.CompletedTask;
        } 
}