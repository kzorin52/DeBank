using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DeBank;
public class DeBankAPI
{
    private HttpClient client;
    public DeBankAPI()
    {
        client = new HttpClient();
    }
    public async Task<List<Models.Datum>> ScanAddress(string address)
    {
        var wReq = await client.GetAsync($"https://api.debank.com/token/balance_list?is_all=true&user_addr={address}");
        return JsonConvert.DeserializeObject<Models.Root>(await wReq.Content.ReadAsStringAsync())?.Data ?? new();
    }
    public double GetDouble(object? _int, int decimals) => double.Parse((_int ?? 0d).ToString() ?? "0") / Math.Pow(10, decimals);
    public double Round(double? toRound) => Math.Round(toRound ?? 0d, 2);
}