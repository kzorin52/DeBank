using Newtonsoft.Json;
using System.Collections.Generic;
using System.Numerics;

namespace DeBank.Models;
public class Datum
{
    [JsonProperty("balance")]
    public object? Balance;

    [JsonProperty("chain")]
    public string? Chain;

    [JsonProperty("decimals")]
    public int Decimals;

    [JsonProperty("display_symbol")]
    public object? DisplaySymbol;

    [JsonProperty("id")]
    public string? Id;

    [JsonProperty("is_core")]
    public bool? IsCore;

    [JsonProperty("is_verified")]
    public bool? IsVerified;

    [JsonProperty("is_wallet")]
    public bool IsWallet;

    [JsonProperty("logo_url")]
    public string? LogoUrl;

    [JsonProperty("name")]
    public string? Name;

    [JsonProperty("optimized_symbol")]
    public string? OptimizedSymbol;

    [JsonProperty("price")]
    public double? Price;

    [JsonProperty("protocol_id")]
    public string? ProtocolId;

    [JsonProperty("symbol")]
    public string? Symbol;

    [JsonProperty("time_at", NullValueHandling = NullValueHandling.Ignore)]
    public double TimeAt;
}

public class Root
{
    [JsonProperty("_cache_seconds")]
    public int CacheSeconds;

    [JsonProperty("_seconds")]
    public double Seconds;

    [JsonProperty("data")]
    public List<Datum>? Data;

    [JsonProperty("error_code")]
    public int ErrorCode;
}