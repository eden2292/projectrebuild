using System.Net.Sockets;
using BlazorApp3.Data;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using BlazorApp3.Data;

#region Instatiation of blazor page
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Error");
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

#endregion

namespace SyslogAssignment
{

  
  public class UDPListeningSocket
  {
    public UDPListeningSocket()
    {
      //ListeningSocketInitialise();
    }

    private void ListeningSocketInitialisation()
    {
      
    }
    private static void Main()
    {
      SyslogMessage msg = new SyslogMessage("192.168.1.3", DateTime.Now, "<124>1 2023-10-26T09:55:01.582Z Park Air Systems LTD test app ABCDEFGHIJKLMNOP");
      msg.ParseMessage();
    }
  }
}