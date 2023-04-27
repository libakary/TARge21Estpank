#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using TARge21Estpank.Views;
using Windows.Graphics;
#endif

namespace TARge21Estpank;


public partial class App : Application
{
	const int WindowWidth = 540;
	const int WindowHeight = 1400;
	const int kontojaak = 100;

	public App()
	{
		InitializeComponent();

#if WINDOWS
		Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
		{
			var mauiWindow = handler.VirtualView;
			var nativeWindow = handler.PlatformView;
			nativeWindow.Activate();
			IntPtr windowhandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
			WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowhandle);
			AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
			appWindow.Resize(new SizeInt32(WindowWidth, WindowHeight));
		});
#endif

		MainPage = new NavigationPage(new StartPage());
	}
}
