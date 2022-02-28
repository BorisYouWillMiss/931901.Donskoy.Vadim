var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ICalculateService, CalculateService>();

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

app.Run();

public interface ICalculateService
{
    public int Sum();
    public int Mul();
    public int Div();
    public int Sub();
    public int GetValueOne();
    public int GetValueTwo();
    public bool GetError();
}
public class CalculateService : ICalculateService
{
    public CalculateService()
    {
        var Rand = new Random();
        ValueOne = Rand.Next(10);
        ValueTwo = Rand.Next(10);
        if (ValueTwo == 0)
            Error = true;
        else Error = false;
    }
    public int ValueOne = 0;
    public int ValueTwo = 0;
    public bool Error = false;
    public int Sum()
    {
        return ValueOne + ValueTwo;
    }
    public int Mul()
    {
        return ValueOne * ValueTwo;
    }
    public int Div()
    {
        if (Error) return 0;
        return ValueOne / ValueTwo;
    }
    public int Sub()
    {
        return ValueOne - ValueTwo;
    }
    public int GetValueOne()
    {
        return (int)ValueOne;
    }
    public int GetValueTwo()
    {
        return (int)ValueTwo;
    }
    public bool GetError()
    {
        return Error;
    }
}