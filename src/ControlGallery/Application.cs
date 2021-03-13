﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using ControlGallery.Pages;

namespace ControlGallery
{
	public class Application : MauiApp
	{
		public override IAppHostBuilder CreateBuilder() =>
			base.CreateBuilder()
				.RegisterCompatibilityRenderers()
				.ConfigureServices((ctx, services) =>
				{
					services.AddTransient<LabelPage>();
					services.AddTransient<IWindow, MainWindow>();
				})
				.ConfigureFonts((hostingContext, fonts) =>
				{
					fonts.AddFont("fa_solid.ttf", "FontAwesome");
					fonts.AddFont("opensans_regular.ttf", "OpenSansRegular");
					fonts.AddFont("opensans_semibold.ttf", "OpenSansSemiBold");
				});

		public override IWindow CreateWindow(IActivationState state)
		{
			Microsoft.Maui.Controls.Compatibility.Forms.Init(state);
			return Services.GetService<IWindow>();
		}
	}
}