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
 *  The website to help send confirmation emails.
 */
using Assignment2;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class EmailSender : IEmailSender
    {
        //https://docs.microsoft.com/en-us/aspnet/core/security/authentication/accconfirm?view=aspnetcore-2.2&tabs=visual-studio

        public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor)
            {
                Options = optionsAccessor.Value;
            }

            public AuthMessageSenderOptions Options { get; } //set only via Secret Manager

            public Task SendEmailAsync(string email, string subject, string message)
            {
                return Execute(Options.SendGridKey, subject, message, email);
            }

            public Task Execute(string apiKey, string subject, string message, string email)
            {
                apiKey = "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";
                var client = new SendGridClient(apiKey);
                var msg = new SendGridMessage()
                {
                    From = new EmailAddress("Joe@contoso.com", "This is a Confirmation Email"),
                    Subject = subject,
                    PlainTextContent = message,
                    HtmlContent = message
                };
                msg.AddTo(new EmailAddress(email));

                // Disable click tracking.
                // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
                msg.SetClickTracking(false, false);

                return client.SendEmailAsync(msg);
            }
        
    }
}
