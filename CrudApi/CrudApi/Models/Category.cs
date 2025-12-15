using System.ComponentModel.DataAnnotations;

namespace CrudApi.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
}
