using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace Acme.BookStore.Samples;

public class SampleAppService : BookStoreAppService, ISampleAppService
{
    public Task<SampleDto> GetAsync()
    {
        return Task.FromResult(
            new SampleDto
            {
                Value = 42
            }
        );
    }

    [Authorize]
    public Task<SampleDto> GetAuthorizedAsync()
    {
        Logger.LogInformation($"tenant：{CurrentTenant.Id}");
        return Task.FromResult(
            new SampleDto
            {
                Value = 42,
                TenantId = CurrentTenant?.Id.ToString()
            }
        );
    }
}
