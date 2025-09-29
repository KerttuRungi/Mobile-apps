using MauiPlanets.Views;
#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
#endif

namespace MauiPlanets
{
    public partial class App : Application
    {
        const int WindowWidth = 720;
        const int WindowHeight = 1000;

        public App()
        {
            InitializeComponent();
            MainPage = new StartPage();
        }

#if WINDOWS
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.HandlerChanged += (s, e) =>
            {
                var nativeWindow = window.Handler.PlatformView;
                IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
                WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
                AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);

                if (appWindow != null)
                {
                    appWindow.Resize(new SizeInt32(WindowWidth, WindowHeight));
                    appWindow.Show(); // Ensure the window is activated
                }
            };

            return window;
        }
#endif
    }
}