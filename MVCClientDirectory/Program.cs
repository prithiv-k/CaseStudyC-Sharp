var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
endpoints.MapControllerRoute("default", "{controller=Client}/{action=ShowAllClientsDetails}/{id?}"); 
});
app.Run();
