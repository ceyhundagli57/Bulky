using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bulky.Models;

public class ProductImage
{
    public int  ID { get; set; }
    [Required] 
    public string ImageURL { get; set; }

    public int ProductId { get; set; }
    [ForeignKey("ProductId")] 
    public Product Pro { get; set; }
}