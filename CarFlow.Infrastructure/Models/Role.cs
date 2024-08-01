﻿namespace CarFlow.Infrastructure.Models;

public class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<Account> AccountsNavigation { get; set; } = new List<Account>();
}