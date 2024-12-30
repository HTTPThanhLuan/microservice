var builder = DistributedApplication.CreateBuilder(args);

var secondapi = builder.AddProject<Projects.Second_ApiService>("second");

var firstapi = builder.AddProject<Projects.First_ApiService>("firstapi")
    .WithReference(secondapi);


builder.AddProject<Projects.Yarp_Gateway>("yarp-gateway").WithReference(firstapi);

builder.Build().Run();
