using System.ComponentModel.DataAnnotations;

namespace CornerStore.Models;

public class CategoryDTO
{
    public int Id { get; set; }
    [Required]
    public string CategoryName { get; set; }
}