using System.Text.Json;

namespace ArkTools.Data;

public class DinoColorService
{
    public async Task<List<DinoColor>> GetDinoColorsAsync()
    {
        JsonSerializerOptions options = new() 
        { 
            PropertyNameCaseInsensitive = true 
        };
        string json = await File.ReadAllTextAsync("colors.json");
        List<DinoColor> dinoColors = JsonSerializer.Deserialize<List<DinoColor>>(json, options)!;

        return dinoColors;
    }
}
