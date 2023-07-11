namespace NETDemo.Services;

public class UsersService
{
    private readonly ILogger<UsersService> logger;

    public UsersService(ILogger<UsersService> logger)
    {
        this.logger = logger;
    }

    public int GetNumberOfUsers()
    {
        //http call
        try
        {
            Random rand = new Random();
            var number = rand.Next();

            if(number %2 == 0)
            {
                throw new Exception("Service unavailable");
            }
            throw new NotImplementedException();
        }
        catch ( Exception ex)
        {
            logger.LogError(ex, "Could not reach endpoint");
            return -1;
        }
    }
}
