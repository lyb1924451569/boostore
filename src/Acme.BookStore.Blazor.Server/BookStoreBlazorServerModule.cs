using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Acme.BookStore.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(BookStoreBlazorModule)
    )]
public class BookStoreBlazorServerModule : AbpModule
{

}
