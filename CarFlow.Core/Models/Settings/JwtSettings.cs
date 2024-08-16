﻿#nullable disable

namespace CarFlow.Core.Models.Settings;

public class JwtSettings
{
    public string Key { get; init; }

    public string Issuer { get; init; }

    public string Audience { get; init; }

    public int ExpiryMinutes { get; init; }
}