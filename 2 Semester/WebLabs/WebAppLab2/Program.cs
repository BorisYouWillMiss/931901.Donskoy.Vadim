var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


app.MapGet("/api/calc/{numberone:int}/{numbertwo:int}/{opertype}", (int numberone, int numbertwo, string opertype) =>
{
    string solution = "";
    if (opertype == "+")
        solution = numberone.ToString() + " " + opertype + " " + numbertwo.ToString() + " = " + (numberone + numbertwo).ToString();
    else if (opertype == "-")
        solution = numberone.ToString() + " " + opertype + " " + numbertwo.ToString() + " = " + (numberone - numbertwo).ToString();
    else if (opertype == "*")
        solution = numberone.ToString() + " " + opertype + " " + numbertwo.ToString() + " = " + (numberone * numbertwo).ToString();
    else if (opertype == "%")
        solution = numberone.ToString() + " / " + numbertwo.ToString() + " = " + (numberone / numbertwo).ToString();

    return solution;
});

app.MapGet("/api/calcSum/{numberone:int}/{numbertwo:int}", (int numberone, int numbertwo) =>
{
    string solution = numberone.ToString() + " + " + numbertwo.ToString() + " = " + (numberone+numbertwo).ToString();

    return solution;
});

app.MapGet("/api/calcSub/{numberone:int}/{numbertwo:int}", (int numberone, int numbertwo) =>
{
    string solution = numberone.ToString() + " - " + numbertwo.ToString() + " = " + (numberone - numbertwo).ToString();

    return solution;
});

app.MapGet("/api/calcMul/{numberone:int}/{numbertwo:int}", (int numberone, int numbertwo) =>
{
    string solution = numberone.ToString() + " * " + numbertwo.ToString() + " = " + (numberone * numbertwo).ToString();

    return solution;
});

app.MapGet("/api/calcDiv/{numberone:int}/{numbertwo:int}", (int numberone, int numbertwo) =>
{
    string solution = numberone.ToString() + " / " + numbertwo.ToString() + " = " + (numberone / numbertwo).ToString();

    return solution;
});

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
