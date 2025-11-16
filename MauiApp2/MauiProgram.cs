using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace MauiApp2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            // Optional: register page + viewmodel (helps if you use DI later)
            builder.Services.AddTransient<ViewModels.Pages.MainPageViewModel>();
            builder.Services.AddTransient<MainPage>();
            return builder.Build();
        }
    }
}
