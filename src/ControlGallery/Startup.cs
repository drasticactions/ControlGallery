using Microsoft.Maui;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;

namespace ControlGallery
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
// 				.ConfigureMauiHandlers(handlers =>
// 				{
// #if WINDOWS10_0_17763_0_OR_GREATER
// 					handlers.AddCompatibilityRenderer<ImageButton,
// 						Microsoft.Maui.Controls.Compatibility.Platform.UWP.ImageButtonRenderer>();
// #elif ANDROID
// 					handlers.AddCompatibilityRenderer<ImageButton,
// 						Microsoft.Maui.Controls.Compatibility.Platform.Android.ImageButtonRenderer>();
// #elif IOS || MACCATALYST
// 					handlers.AddCompatibilityRenderer<ImageButton,
// 						Microsoft.Maui.Controls.Compatibility.Platform.iOS.ImageButtonRenderer>();
// #endif
// 				})
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("fa_solid.ttf", "FontAwesome");
					fonts.AddFont("opensans_regular.ttf", "OpenSansRegular");
					fonts.AddFont("opensans_semibold.ttf", "OpenSansSemiBold");
				})
				.UseMauiApp<App>();

			return builder.Build();
		}
	}
}
