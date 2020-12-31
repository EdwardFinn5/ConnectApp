using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AppUserSeed
    {
        public static async Task SeedAppUsers(DataContext context)
        {

            if (await context.ColUsers.AnyAsync()) return;
            {
                var colUserData = await System.IO.File.ReadAllTextAsync("Data/ColUserSeedData.json");
                var colUsers = JsonSerializer.Deserialize<List<ColUser>>(colUserData);
                foreach (var user in colUsers)
                {
                    using var hmac = new HMACSHA512();

                    user.ColUserName = user.ColUserName.ToLower();
                    user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pa$$w0rd"));
                    user.PasswordSalt = hmac.Key;

                    context.ColUsers.Add(user);
                }

                await context.SaveChangesAsync();
            }

            if (await context.Users.AnyAsync()) return;
            {
                var userData = await System.IO.File.ReadAllTextAsync("Data/UserSeedData.json");
                var users = JsonSerializer.Deserialize<List<AppUser>>(userData);
                foreach (var user in users)
                {
                    using var hmac = new HMACSHA512();

                    user.UserName = user.UserName.ToLower();
                    user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pa$$w0rd"));
                    user.PasswordSalt = hmac.Key;

                    context.Users.Add(user);
                }

                await context.SaveChangesAsync();
            }

            if (!context.FactFeatures.Any())
            {
                var factFeatureData =
                        File.ReadAllText("Data/FactFeature.json");

                var factFeatures = JsonSerializer.Deserialize<List<FactFeature>>(factFeatureData);

                foreach (var factFeature in factFeatures)
                {
                    context.FactFeatures.Add(factFeature);
                }

                await context.SaveChangesAsync();
            }

            if (!context.MajorCats.Any())
            {
                var majorCatData =
                    File.ReadAllText("Data/MajorCat.json");

                var majorCats = JsonSerializer.Deserialize<List<MajorCat>>(majorCatData);

                foreach (var majorCat in majorCats)
                {
                    context.MajorCats.Add(majorCat);
                }

                await context.SaveChangesAsync();
            }

            if (!context.Majors.Any())
            {
                var majorData =
                        File.ReadAllText("Data/Major.json");

                var majors = JsonSerializer.Deserialize<List<Major>>(majorData);

                foreach (var major in majors)
                {
                    context.Majors.Add(major);
                }

                await context.SaveChangesAsync();
            }

            if (!context.CollegeMajors.Any())
            {
                var collegeMajorData =
                    File.ReadAllText("Data/CollegeMajor.json");

                var collegeMajors = JsonSerializer.Deserialize<List<CollegeMajor>>(collegeMajorData);

                foreach (var collegeMajor in collegeMajors)
                {
                    context.CollegeMajors.Add(collegeMajor);
                }

                await context.SaveChangesAsync();
            }
        }
    }
}