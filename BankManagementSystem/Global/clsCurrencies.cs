
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Threading.Tasks;

namespace clsCurrencies
{
    internal class clsCurrencies
    {

        private const string AccessKey = "eb3f8368aae154ab28d2ba95d7e51c05";
        private const string BaseUrl = "http://api.currencylayer.com/";
        private const string Endpoint = "live";
        
        static public  async Task<Dictionary<string,double>> CurrenciesForEGP()
        {
            HttpClient client = new HttpClient();
            string url = $"{BaseUrl}{Endpoint}?access_key={AccessKey}&source=EGP";
            Dictionary<string, double> egpRates=new Dictionary<string, double> { };

            try
            {

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();

                JsonDocument doc = JsonDocument.Parse(jsonResponse);
                JsonElement root = doc.RootElement;

                if (root.TryGetProperty("timestamp", out JsonElement timestampElement) &&
                    root.TryGetProperty("source", out JsonElement sourceElement) &&
                    root.TryGetProperty("quotes", out JsonElement quotesElement) &&
                    quotesElement.TryGetProperty("EGPUSD", out JsonElement egpUsdElement) &&
                      quotesElement.TryGetProperty("EGPEUR", out JsonElement egpEurElement) &&
                    quotesElement.TryGetProperty("EGPJPY", out JsonElement egpJpyElement) &&
                    quotesElement.TryGetProperty("EGPGBP", out JsonElement egpGbpElement) &&
                    quotesElement.TryGetProperty("EGPSAR", out JsonElement egpSarElement) &&
                    quotesElement.TryGetProperty("EGPJOD", out JsonElement egpJodElement) &&
                    quotesElement.TryGetProperty("EGPCAD", out JsonElement egpCadElement) &&
                    quotesElement.TryGetProperty("EGPAUD", out JsonElement egpAudElement) &&
                    quotesElement.TryGetProperty("EGPCHF", out JsonElement egpChfElement) &&
                    quotesElement.TryGetProperty("EGPINR", out JsonElement egpInrElement) &&
                    quotesElement.TryGetProperty("EGPCNY", out JsonElement egpCnyElement) &&
                    quotesElement.TryGetProperty("EGPAED", out JsonElement egpAedElement) &&
                    quotesElement.TryGetProperty("EGPZAR", out JsonElement egpZarElement) &&
                    quotesElement.TryGetProperty("EGPKRW", out JsonElement egpKrwElement) &&
                    quotesElement.TryGetProperty("EGPMXN", out JsonElement egpMxnElement) &&
                    quotesElement.TryGetProperty("EGPRUB", out JsonElement egpRubElement) &&
                    quotesElement.TryGetProperty("EGPTRY", out JsonElement egpTryElement) &&
                    quotesElement.TryGetProperty("EGPSEK", out JsonElement egpSekElement) &&
                    quotesElement.TryGetProperty("EGPNOK", out JsonElement egpNokElement) &&
                    quotesElement.TryGetProperty("EGPTHB", out JsonElement egpThbElement) &&
                    quotesElement.TryGetProperty("EGPHKD", out JsonElement egpHkdElement) &&
                    quotesElement.TryGetProperty("EGPNZD", out JsonElement egpNzdElement))
                {
                    long timestamp = timestampElement.GetInt64();
                    string source = sourceElement.GetString();

                    egpRates = new Dictionary<string, double>
{
                        { "USD", egpUsdElement.GetDouble() },
                        { "EUR", egpEurElement.GetDouble() },
                        { "JPY", egpJpyElement.GetDouble() },
                        { "GBP", egpGbpElement.GetDouble() },
                        { "SAR", egpSarElement.GetDouble() },
                        { "JOD", egpJodElement.GetDouble() },
                        { "CAD", egpCadElement.GetDouble() },
                        { "AUD", egpAudElement.GetDouble() },
                        { "CHF", egpChfElement.GetDouble() },
                        { "INR", egpInrElement.GetDouble() },
                        { "CNY", egpCnyElement.GetDouble() },
                        { "AED", egpAedElement.GetDouble() },
                        { "ZAR", egpZarElement.GetDouble() },
                        { "KRW", egpKrwElement.GetDouble() },
                        { "MXN", egpMxnElement.GetDouble() },
                        { "RUB", egpRubElement.GetDouble() },
                        { "TRY", egpTryElement.GetDouble() },
                        { "SEK", egpSekElement.GetDouble() },
                        { "NOK", egpNokElement.GetDouble() },
                        { "THB", egpThbElement.GetDouble() },
                        { "HKD", egpHkdElement.GetDouble() },
                        { "NZD", egpNzdElement.GetDouble() }
};


                }
                return egpRates;
            }
                
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            
            }
            catch (JsonException e)
            {
                Console.WriteLine($"JSON parsing error: {e.Message}");
             
            }

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
            return egpRates;
        }

       


    }
}