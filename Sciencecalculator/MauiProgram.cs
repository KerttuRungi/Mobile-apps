using Microsoft.Extensions.Logging;

namespace Sciencecalculator
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
                    fonts.AddFont("Clairo-Light.ttf", "RegularFont");
                    fonts.AddFont("Clairo-ExtraLight.ttf", "LightFont");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
