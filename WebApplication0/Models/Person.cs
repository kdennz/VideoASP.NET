using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication0.Models;

public partial class Person
{
 
    public int IdPeople { get; set; }

    public string NamePeople { get; set; } = null!;

    public int? Age { get; set; }
}