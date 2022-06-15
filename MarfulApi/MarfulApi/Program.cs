using Microsoft.EntityFrameworkCore;
using MarfulApi.Data;
using MarfulApi.Infrastructure;
using MarfulApi.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();
builder.Services.AddDbContext<MarfulDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("sqlServer")));
builder.Services.AddTransient<IContent,ContentRepo>();
builder.Services.AddTransient<IBasket, BasketRepo>();
builder.Services.AddTransient<IBrand, BrandRepo>();
builder.Services.AddTransient<ICompanyContent, CompanyContentRepo>();
builder.Services.AddTransient<IInfulonser, InfulonserRepo>();
builder.Services.AddTransient<IInfulonserContent, InfulonserContentRepo>();
builder.Services.AddTransient<IInfulonserUser, InfulonserUserRepo>();
builder.Services.AddTransient<IProduct, ProductRepo>();
builder.Services.AddTransient<ICompany, CompanyRepo>();
builder.Services.AddTransient<IPost, PostRepo>();
builder.Services.AddTransient<IJob, JobRepo>();
builder.Services.AddTransient<IMessage, MessageRepo>();
builder.Services.AddTransient<IConversation, ConversationRepo>();
builder.Services.AddTransient<IUserPost, UserPostRepo>();
builder.Services.AddTransient<IUser, UserRepo>();
builder.Services.AddTransient<IUserCompany, UserCompanyRepo>();
builder.Services.AddTransient<ICompany, CompanyRepo>();
builder.Services.AddTransient<IAuth, AuthRepo>();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseCors(builder =>
    builder
        .WithOrigins("https://localhost:7192")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed(_ => true)
        .AllowCredentials());
app.MapControllers();
app.UseEndpoints(endpoints => {
    endpoints.MapControllerRoute(
       name: "default",
       pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapHub<ManagementHub>("/management-hub");
});
app.Run();
