﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class state_alpha_code
{
    public state_alpha_code()
    {
        this.state_city = new HashSet<state_city>();
        this.state_region = new HashSet<state_region>();
    }

    public string alpha_code { get; set; }
    public string description { get; set; }
    public string country { get; set; }

    public virtual ICollection<state_city> state_city { get; set; }
    public virtual ICollection<state_region> state_region { get; set; }
}

public partial class state_city
{
    public string alpha_code { get; set; }
    public string city { get; set; }

    public virtual state_alpha_code state_alpha_code { get; set; }
}

public partial class state_region
{
    public string alpha_code { get; set; }
    public string region { get; set; }

    public virtual state_alpha_code state_alpha_code { get; set; }
}