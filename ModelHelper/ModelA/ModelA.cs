using System.ComponentModel.DataAnnotations;

namespace ModelHelper;

public class ModelA 
    : Model
    , IModelA
{
	public int Id { get; set; }

    [Required]
	[MaxLength(NameMax)]
	public string? Name { get; set; }

    [MaxLength(DescriptionMax)]
	public string? Description { get; set; }
}