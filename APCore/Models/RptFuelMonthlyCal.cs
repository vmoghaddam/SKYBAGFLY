﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class RptFuelMonthlyCal
    {
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string MonthName { get; set; }
        public string ArgStr { get; set; }
        public int? ArgNum { get; set; }
        public int? Legs { get; set; }
        public int PreLegs { get; set; }
        public decimal? LegsDiff { get; set; }
        public decimal Uplift { get; set; }
        public decimal Used { get; set; }
        public decimal FPFuel { get; set; }
        public decimal PreUsed { get; set; }
        public decimal? UsedKiloDiff { get; set; }
        public decimal? UsedPerUpLift { get; set; }
        public decimal PreUsedPerUpLift { get; set; }
        public decimal? UsedPerUpLiftDiff { get; set; }
        public decimal? UsedPerFPFuel { get; set; }
        public decimal PreUsedPerFPFuel { get; set; }
        public decimal? UsedPerFPFuelDiff { get; set; }
        public decimal? UpliftKilo { get; set; }
        public decimal? UsedKilo { get; set; }
        public decimal PreUsedKilo { get; set; }
        public decimal? FPFuelKilo { get; set; }
        public decimal? UpliftPerLeg { get; set; }
        public decimal? UsedPerLeg { get; set; }
        public decimal PreUsedPerLeg { get; set; }
        public decimal? UsedDiffPerLeg { get; set; }
        public decimal? FPFuelPerLeg { get; set; }
        public decimal? UpliftKiloPerLeg { get; set; }
        public decimal? UsedKiloPerLeg { get; set; }
        public int TotalPax { get; set; }
        public int PreTotalPax { get; set; }
        public decimal? TotalPaxDiff { get; set; }
        public int TotalPaxAll { get; set; }
        public double Distance { get; set; }
        public double PreDistance { get; set; }
        public double? DistanceDiff { get; set; }
        public double DistanceKM { get; set; }
        public int Weight { get; set; }
        public decimal WeightTone { get; set; }
        public decimal PreWeightTone { get; set; }
        public decimal? WeightToneDiff { get; set; }
        public int PaxWeight { get; set; }
        public decimal PaxWeightTone { get; set; }
        public double WeightDistance { get; set; }
        public double WeightDistanceToneKM { get; set; }
        public decimal? UpliftPerPax { get; set; }
        public decimal? UpliftPerWeight { get; set; }
        public double? UpliftPerDistance { get; set; }
        public double? UpliftPerDistanceKM { get; set; }
        public double? FPFuelPerDistance { get; set; }
        public decimal? FPFuelPerWeight { get; set; }
        public double? UpliftPerWeightDistance { get; set; }
        public double? UpliftPerWeightDistanceKM { get; set; }
        public decimal? UsedPerPax { get; set; }
        public decimal PreUsedPerPax { get; set; }
        public decimal? UsedPerPaxDiff { get; set; }
        public decimal? FPFuelPerPax { get; set; }
        public decimal? UsedPerWeight { get; set; }
        public double? UsedPerDistance { get; set; }
        public double? UsedPerDistanceKM { get; set; }
        public double? UsedPerWeightDistance { get; set; }
        public double? UsedPerWeightDistanceKM { get; set; }
        public double PreUsedPerWeightDistanceKM { get; set; }
        public double? UsedPerWeightDistanceDiff { get; set; }
        public decimal? UsedDiff { get; set; }
        public decimal? UsedDiffPerPax { get; set; }
        public decimal? UsedDiffPerWeight { get; set; }
        public double? UsedDiffPerDistance { get; set; }
        public double? UsedDiffPerWeightDistance { get; set; }
        public decimal? UsedDiffPercent { get; set; }
        public decimal? UsedDiffPerPaxPercent { get; set; }
        public decimal? UsedDiffPerWeightPercent { get; set; }
        public double? UsedDiffPerDistancePercent { get; set; }
        public double? UsedDiffPerWeightDistancePercent { get; set; }
        public double? UsedPerWeightDistanceToneKM { get; set; }
        public double? FPFuelPerWeightDistanceToneKM { get; set; }
        public decimal? UsedPerWeightTone { get; set; }
        public decimal? FPFuelPerWeightTone { get; set; }
        public int FlightTime { get; set; }
        public int BlockTime { get; set; }
        public int PreBlockTime { get; set; }
        public decimal? BlockTimeDiff { get; set; }
        public decimal? UsedPerFlightTime { get; set; }
        public decimal? UsedPerBlockTime { get; set; }
        public decimal PreUsedPerBlockTime { get; set; }
        public decimal? UsedPerBlockTimeDiff { get; set; }
        public decimal? FPFuelPerFlightTime { get; set; }
        public decimal? FPFuelPerBlockTime { get; set; }
        public decimal? MaxUsed { get; set; }
        public decimal? MinUsed { get; set; }
        public decimal? AvgUsed { get; set; }
        public double SeatDistanceKM { get; set; }
        public double SeatKiloDistanceKM { get; set; }
        public double? UsedPerSeatDistanceKM { get; set; }
        public double? UsedPerSeatKiloDistanceKM { get; set; }
        public double PaxDistanceKM { get; set; }
        public double PaxKiloDistanceKM { get; set; }
        public double? UsedPerPaxDistanceKM { get; set; }
        public double? UsedPerPaxKiloDistanceKM { get; set; }
        public double PreUsedPerPaxKiloDistanceKM { get; set; }
        public double? UsedPerPaxKiloDistanceKMAvg { get; set; }
        public double? UsedPerPaxKiloDistanceKMDiff { get; set; }
        public int? TotalSeat { get; set; }
        public decimal? UsedPerPaxBlockTime { get; set; }
        public decimal PreUsedPerPaxBlockTime { get; set; }
        public decimal? UsedPerSeatBlockTime { get; set; }
        public decimal? UsedPerPaxBlockTimeAvg { get; set; }
        public decimal? UsedPerSeatBlockTimeAvg { get; set; }
        public decimal? UsedPerPaxBlockTimeDiff { get; set; }
    }
}
