using SoapCore;
using CurrencyConverter;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddSingleton<ICurrencyConverterService, CurrencyConverterService>();
//builder.Services.AddControllers();
var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseSoapEndpoint<ICurrencyConverterService>("/CurrencyConverterService.asmx", new SoapEncoderOptions());
//app.UseAuthorization();
//app.MapControllers();
app.Run();