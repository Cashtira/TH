﻿using System;
using System.Collections.Generic;

namespace TH.Models;

public partial class Account
{
    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;
}