using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Acme.BookStore.Blazor.WebAssembly;

[DependsOn(
    typeof(BookStoreBlazorModule),
    typeof(BookStoreHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class BookStoreBlazorWebAssemblyModule : AbpModule
{

}
