﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using HomeCareObjects.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace ProjectWebApp.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly IUserEmailStore<IdentityUser> _emailStore;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;
        HomeCareDBContext homeCareDBContext;
        public RegisterModel(
            UserManager<IdentityUser> userManager,
            IUserStore<IdentityUser> userStore,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
            homeCareDBContext = new HomeCareDBContext();
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            public string Role { get; set; }
            
            [ValidateNever]
            public IEnumerable<SelectListItem> RoleList { get; set; }   
        }


        public async Task OnGetAsync(string returnUrl = null)
        {
            if(!_roleManager.RoleExistsAsync("Admin").GetAwaiter().GetResult())
            {
                //seed roles if they do not exist
                _roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole("Manager")).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole("Technician")).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole("User")).GetAwaiter().GetResult();
            }
            if (_userManager.FindByEmailAsync("admin@test.com").GetAwaiter().GetResult() == null)
            {
                //seed admin, manager, tech, and users if they do not exist
                var admin = new IdentityUser
                {
                    UserName = "admin@test.com",
                    Email = "admin@test.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };
                await _userManager.CreateAsync(admin, "Test@123");
                await _userManager.AddToRoleAsync(admin, "Admin");
            
           

                var manager1 = new IdentityUser
                {
                    UserName = "manager1@test.com",
                    Email = "manager1@test.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };
                await _userManager.CreateAsync(manager1, "Test@123");
                await _userManager.AddToRoleAsync(manager1, "Manager");
                var manager2 = new IdentityUser
                {
                    UserName = "manager2@test.com",
                    Email = "manager2@test.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };
                await _userManager.CreateAsync(manager2, "Test@123");
                await _userManager.AddToRoleAsync(manager2, "Manager");
                var manager3 = new IdentityUser
                {
                    UserName = "manager3@test.com",
                    Email = "manager3@test.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };
                await _userManager.CreateAsync(manager3, "Test@123");
                await _userManager.AddToRoleAsync(manager3, "Manager");
                var manager4 = new IdentityUser
                {
                    UserName = "manager4@test.com",
                    Email = "manager4@test.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };
                await _userManager.CreateAsync(manager4, "Test@123");
                await _userManager.AddToRoleAsync(manager4, "Manager");

            
                var tech1 = new IdentityUser
                {
                    UserName = "tech1@test.com",
                    Email = "tech1@test.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };
                await _userManager.CreateAsync(tech1, "Test@123");
                await _userManager.AddToRoleAsync(tech1, "Technician");
            
                var tech2 = new IdentityUser
                {
                    UserName = "tech2@test.com",
                    Email = "tech2@test.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };
                await _userManager.CreateAsync(tech2, "Test@123");
                await _userManager.AddToRoleAsync(tech2, "Technician");
                
                var tech3 = new IdentityUser
                {
                    UserName = "tech3@test.com",
                    Email = "tech3@test.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };
                await _userManager.CreateAsync(tech3, "Test@123");
                await _userManager.AddToRoleAsync(tech3, "Technician");
                var tech4 = new IdentityUser
                {
                    UserName = "tech4@test.com",
                    Email = "tech4@test.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };
                await _userManager.CreateAsync(tech4, "Test@123");
                await _userManager.AddToRoleAsync(tech4, "Technician");
                var tech5 = new IdentityUser
                {
                    UserName = "tech5@test.com",
                    Email = "tech5@test.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };
                await _userManager.CreateAsync(tech5, "Test@123");
                await _userManager.AddToRoleAsync(tech5, "Technician");
            
                var user1 = new IdentityUser
                {
                    UserName = "user1@test.com",
                    Email = "user1@test.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };
                await _userManager.CreateAsync(user1, "Test@123");
                await _userManager.AddToRoleAsync(user1, "User");

            
                var user2 = new IdentityUser
                {
                    UserName = "user2@test.com",
                    Email = "user2@test.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };
                await _userManager.CreateAsync(user2, "Test@123");
                await _userManager.AddToRoleAsync(user2, "User");

            }


            ReturnUrl = returnUrl;

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            Input = new InputModel()
            {
                RoleList = _roleManager.Roles.Select(x => x.Name).Select(i => new SelectListItem { Text = i, Value = i })
            };
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = CreateUser();

                await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");


                    if(Input.Role == null || Input.Role == "0") {
                        await _userManager.AddToRoleAsync(user, "User"); //if no role selected, add him as user
                    }
                    else
                    {
                        await _userManager.AddToRoleAsync(user, Input.Role); //if role was selected, add him to that role
                    }

                    var userId = await _userManager.GetUserIdAsync(user);
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);

                    var Input = new InputModel()
                    {
                        RoleList = _roleManager.Roles.Select(x => x.Name).Select(i => new SelectListItem { Text = i, Value = i })
                    };

                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private IdentityUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<IdentityUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(IdentityUser)}'. " +
                    $"Ensure that '{nameof(IdentityUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<IdentityUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<IdentityUser>)_userStore;
        }
    }
}
