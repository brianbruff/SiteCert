﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SiteCert.Models
{
    // Modify the User class to add extra user information
    //public class User : IUser
    //{
    //    public User()
    //        : this(String.Empty)
    //    {
    //    }

    //    public User(string userName)
    //    {
    //        UserName = userName;
    //        Id = Guid.NewGuid().ToString();
    //    }

    //    [Key]
    //    public string Id { get; set; }

    //    public string UserName { get; set; }

    //    //[DataType(DataType.PhoneNumber)]
    //    //public string PhoneNumber { get; set; }

    //    //[DataType(DataType.EmailAddress)]
    //    //public string Email { get; set; }
    //}

    //public class UserLogin : IUserLogin
    //{
    //    [Key, Column(Order = 0)]
    //    public string LoginProvider { get; set; }
    //    [Key, Column(Order = 1)]
    //    public string ProviderKey { get; set; }

    //    public string UserId { get; set; }

    //    public UserLogin() { }

    //    public UserLogin(string userId, string loginProvider, string providerKey)
    //    {
    //        LoginProvider = loginProvider;
    //        ProviderKey = providerKey;
    //        UserId = userId;
    //    }
    //}

    //public class UserSecret : IUserSecret
    //{
    //    public UserSecret()
    //    {
    //    }

    //    public UserSecret(string userName, string secret)
    //    {
    //        UserName = userName;
    //        Secret = secret;
    //    }

    //    [Key]
    //    public string UserName { get; set; }
    //    public string Secret { get; set; }
    //}

    //public class UserRole : IUserRole
    //{
    //    [Key, Column(Order = 0)]
    //    public string RoleId { get; set; }
    //    [Key, Column(Order = 1)]
    //    public string UserId { get; set; }
    //}

    //public class Role : IRole
    //{
    //    public Role()
    //        : this(String.Empty)
    //    {
    //    }

    //    public Role(string roleName)
    //    {
    //        Id = roleName;
    //    }

    //    [Key]
    //    public string Id { get; set; }
    //}
}
