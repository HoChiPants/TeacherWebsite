/**
 * Author:    Austin Stephens
 * Date:      September/10/2019
 * Course:    CS 4540, University of Utah, School of Computing
 * Copyright: CS 4540 and Austin Stephens - This work may not be copied for use in Academic Coursework.
 *
 * I, Austin Stephens, certify that I wrote this code from scratch and did not copy it in part or whole from 
 * another source.  Any references used in the completion of the assignment are cited in my README file.
 *
 * File Contents
 *
 *  Automatically Generated for use
 */
using System;
using Assignment4.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Assignment4.Areas.Identity.IdentityHostingStartup))]
namespace Assignment4.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<UserRolesContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("UserRolesContextConnection")));

                services
                .AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<UserRolesContext>();
            });
        }
    }
}