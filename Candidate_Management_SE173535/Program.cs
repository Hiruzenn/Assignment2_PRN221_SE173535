using Candidate_Repository;
using Candidate_Service;


namespace CandidateManagement_GUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddScoped<ICandidateProfileService, CandidateProfileService>();
            builder.Services.AddScoped<ICandidateProfileRepo, CandidateProfileRepo>();
            builder.Services.AddScoped<IJobPostRepo, JobPostRepo>();
            builder.Services.AddScoped<IJobPostService, JobPostService>();
            builder.Services.AddScoped<IHRAccountRepo, HRAccountRepo>();
            builder.Services.AddScoped<IHRAccountService, HRAccountService>();
            builder.Services.AddSession();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
