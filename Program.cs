using Microsoft.EntityFrameworkCore;
using React_Ecommerce_BE;
using React_Ecommerce_BE.BusinessLogic;
using React_Ecommerce_BE.BusinessRepository;

var builder = WebApplication.CreateBuilder(args);





// Add services to the container.


builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DB")));

///

builder.Services.AddTransient<IProductBusinessLogic, ProductBusinessLogic>();
builder.Services.AddTransient<IProductsBusinessRepository, ProductsBusinessRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//cors

builder.Services.AddCors(policy => policy.AddPolicy("corspolicy", 
                                                    build =>
                                                        {
                                                            build.WithOrigins("http://localhost:3000")
                                                            .AllowAnyMethod()
                                                            .AllowAnyHeader();
                                                        }));



/*var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

var app = builder.Build();

// Use the CORS policy
app.UseCors("AllowAllOrigins");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
*/

/*builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder
            .WithOrigins("http://localhost:3000") // Replace with your client app's URL
            .AllowAnyHeader()
            .AllowAnyMethod());
});
*/

var app = builder.Build();
/*
app.UseCors("AllowAllOrigins");*/



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
      // app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("corspolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
