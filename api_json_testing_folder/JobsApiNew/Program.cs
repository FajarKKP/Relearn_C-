using JobsApiNew;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<List<Job>>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// GET: /jobs
app.MapGet("/jobs", (List<Job> jobs) =>
{
    return Results.Ok(jobs);
});

// POST: /jobs
app.MapPost("/jobs", (Job newJob, List<Job> jobs) =>
{
    newJob.Id = jobs.Count > 0 ? jobs.Max(j => j.Id) + 1 : 1;
    jobs.Add(newJob);
    return Results.Created($"/jobs/{newJob.Id}", newJob);
});

app.Run();