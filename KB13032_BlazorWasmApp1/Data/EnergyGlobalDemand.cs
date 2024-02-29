﻿namespace KB13032_BlazorWasmApp1.Data;

public class EnergyGlobalDemand : List<EnergyGlobalDemandItem>
{
    public EnergyGlobalDemand()
    {
        this.Add(new EnergyGlobalDemandItem()
        {
            Value = 37,
            Category = @"Cooling",
            Summary = @"Cooling 37%"
        });
        this.Add(new EnergyGlobalDemandItem()
        {
            Value = 25,
            Category = @"Residential",
            Summary = @"Residential 25%"
        });
        this.Add(new EnergyGlobalDemandItem()
        {
            Value = 12,
            Category = @"Heating",
            Summary = @"Heating 12%"
        });
        this.Add(new EnergyGlobalDemandItem()
        {
            Value = 11,
            Category = @"Lighting",
            Summary = @"Lighting 11%"
        });
        this.Add(new EnergyGlobalDemandItem()
        {
            Value = 15,
            Category = @"Other",
            Summary = @"Other 15%"
        });
    }
}
