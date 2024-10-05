using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace dataModel;

public partial class City
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(10)]
    public string Name { get; set; } = null!;

    [Column("capital")]
    public bool? Capital { get; set; }

    [Column("population")]
    public long Population { get; set; }

    [Column("longitude")]
    public double Longitude { get; set; }

    [Column("latitude")]
    public double Latitude { get; set; }

    [Column("countryId")]
    public int CountryId { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("Cities")]
    public virtual Country Country { get; set; } = null!;
}
