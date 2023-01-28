using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Template;

namespace Routing
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.MapControllerRoute(
				name: "CowMoo",
				pattern: "{id}",
				constraints: new { id = @"\d+" },
				defaults: new {controller = "Home", action = "CowMoo" });

			app.MapControllerRoute(
				name: "Chic-Fil-A",
				pattern: "EatMoreChicken",
				defaults: new { controller = "Home", action = "ChicFilA" });

			app.MapControllerRoute(
				name: "CowMoo",
				pattern: "{id}/{name}",
				constraints: new { id = @"\d+" },
				defaults: new { controller = "Home", action = "BetsyMoo" });

			app.MapControllerRoute(
				name: "GalleryImage",
				pattern: "AllCows/Gallery/{id}",
				constraints: new { id = @"\d+" },
				defaults: new { controller = "Home", action = "GalImage" });

			app.MapControllerRoute(
				name: "GalleryPage1",
				pattern: "AllCows/Gallery/{id}/page" + "{pId}",
				constraints: new { id = @"\d+", pId = @"\d+" },
				//not possible because you can't use a required word and a variable in the same section of a url pattern
				defaults: new { controller = "Home", action = "GalPage1" });

			app.MapControllerRoute(
				name: "GalleryImage",
				pattern: "AllCows/Gallery/{id}/{pId}",
				constraints: new{id = @"\d+", pId = @"\d+"},
				defaults: new { controller = "Home", action = "GalPage2" });

			app.MapControllerRoute(
				name: "All",
				pattern: "{category}",
				defaults: new { category = "all", controller = "Home", action = "Index" });

			app.Run();
		}
	}
}