using MyAzureApi.Controller;
using Xunit;

public class FirstTest
{
    [Fact]
    public void TestApiResponse()
    {
        var controller = new BaseController();
        var result = controller.Get();
        Assert.NotNull(result);
    }
}