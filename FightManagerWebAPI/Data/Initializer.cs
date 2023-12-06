﻿using FightManagerWebAPI.Entities;
using Microsoft.AspNetCore.Identity;

namespace FightManagerWebAPI.Data
{
    public class Initializer
    {
        public static async Task SeedAsync(DndFightManagerContext context)
        {
            try
            {
                context.Database.EnsureCreated();

                if (!context.Abilities.Any())
                {
                    var abilities = new Ability[]
                    {
                        new Ability {Title = "Сила"},
                        new Ability {Title = "Ловкость"},
                        new Ability {Title = "Телосложение"},
                        new Ability {Title = "Интеллект"},
                        new Ability {Title = "Мудрость"},
                        new Ability {Title = "Харизма"}
                    };

                    foreach (var ability in abilities)
                    {
                        context.Abilities.Add(ability);
                    }
                    await context.SaveChangesAsync();
                }

            }
            catch
            {
                throw;
            }
        }

        public static async Task CreateUserRoles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

            // Создание ролей администратора и пользователя
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }

            // Создание Администратора
            string adminEmail = "admin@mail.com";
            string adminPassword = "Aa123456!";
            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                User admin = new User { Email = adminEmail, UserName = adminEmail };
                IdentityResult result = await userManager.CreateAsync(admin, adminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }

            // Создание Пользователя
            string userEmail = "user@mail.com";
            string userPassword = "Aa123456!";
            if (await userManager.FindByNameAsync(userEmail) == null)
            {
                User user = new User { Email = userEmail, UserName = userEmail };
                IdentityResult result = await userManager.CreateAsync(user, userPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "user");
                }
            }
        }
    }
}
