using Microsoft.Azure.Management.AppService.Fluent;
using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using System;

namespace AzureDevOps01
{
    class Program
    {
        static void Main(string[] args)
        {
            IAzure azure = CreateAz();

            var resourceGroup = azure.ResourceGroups
            .Define("MY-RESOURCE-GROUP01")
            .WithRegion(Region.IndiaSouth)
            .Create();

            //var resourceGroup1 = azure.ResourceGroups
            //.Define("MY-RESOURCE-GROUP02")
            //.WithRegion(Region.IndiaSouth)
            //.Create();

            //var plan = azure.AppServices.AppServicePlans
            //    .Define("MY-PLAN")
            //    .WithRegion(Region.IndiaSouth)
            //    .WithExistingResourceGroup(resourceGroup)
            //    .WithPricingTier(PricingTier.StandardS1)
            //    .WithOperatingSystem(Microsoft.Azure.Management.AppService.Fluent.OperatingSystem.Windows)
            //    .Create();

            //azure.AppServices.WebApps
            //    .Define("my-app-xyz")
            //    .WithExistingWindowsPlan(plan)
            //    .WithExistingResourceGroup(resourceGroup)
            //    .Create();


            Console.WriteLine("Done!");
        }
        static IAzure CreateAz()
        {
            AzureCredentials credentials =
                SdkContext.AzureCredentialsFactory.FromServicePrincipal(
                    clientId: Environment.GetEnvironmentVariable("AzureClientId"),
                    clientSecret: Environment.GetEnvironmentVariable("AzureClientSecret"),
                    tenantId: Environment.GetEnvironmentVariable("AzureTenantID"),
                    AzureEnvironment.AzureGlobalCloud);

            IAzure azure = Azure.Configure()
                            .WithLogLevel(HttpLoggingDelegatingHandler.Level.Basic)
                            .Authenticate(credentials)
                            .WithSubscription("c7791184-ab41-458a-b044-f371730f1d84");
            return (IAzure)azure;

        }
    }
}
