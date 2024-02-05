using System.ComponentModel.DataAnnotations;

namespace TechTrain.ReusableModules.WebApi.Models;

public record Cart {
    public required int CartId {get; set;}
    public int NumberOfItemsInCart { get; set; }
    public required decimal SumTotal {get; set;}
    public required string Currency {get; set;}
}