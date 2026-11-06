using System;
using Microsoft.AspNetCore.Identity.Data;

namespace RateCustomers.Models;

public class HomePageModel 
{
    public string? LoginName {get; set;}

    public string? Password{get; set;}

    public string? ConfirmPassword{get;set;}

}
