var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //mvc çalýþacaðýmýzý bildiriyoruz.

var app = builder.Build(); //build ettik.


app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=home}/{action=Index}/{id?}"
    );



app.Run();