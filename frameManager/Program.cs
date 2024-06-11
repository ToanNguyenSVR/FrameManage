using frameManager.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<FrameDbContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));
//} );
   var app = builder.Build();
//using (var scope = app.Services.CreateScope())
//{
//    var dbConntext = scope.ServiceProvider.GetRequiredService<FrameDbContext>();
//    if (!dbConntext.Database.CanConnect())
//    {
//        throw new NotImplementedException("");
//    }
//}

    // Configure the HTTP request pipeline.
    
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

