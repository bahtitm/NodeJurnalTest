using Application.Features.Journals.Commands.CreateJournal;
using DSEU.Application.Common.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

public class CustomExceptionHandler : IExceptionHandler
{
    private readonly ILogger<CustomExceptionHandler> logger;
    private readonly IServiceProvider serviceProvider;
    

    public CustomExceptionHandler(ILogger<CustomExceptionHandler> logger, IServiceProvider serviceProvider)
    {
        this.logger = logger;
        this.serviceProvider = serviceProvider;
        
    }
    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        var exceptionMessage = exception.Message;
        logger.LogError(
            "Error Message: {exceptionMessage}, Time of occurrence {time}",
            exceptionMessage, DateTime.UtcNow);
        if (exception is not null)
        {
            using var scope = serviceProvider.CreateAsyncScope();
            var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();
            await mediator.Send(new CreateJournalCommand());
            throw new SecureException();
        }
        // Return false to continue with the default behavior
        // - or - return true to signal that this exception is handled
        return await ValueTask.FromResult(false);
    }
}