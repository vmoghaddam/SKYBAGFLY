﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APTraining.Models
{
    public partial class RptDelayMonthlyCal
    {
        public int? Year { get; set; }
        public string MonthName { get; set; }
        public int? Month { get; set; }
        public int Delay { get; set; }
        public int PreDelay { get; set; }
        public decimal? DelayDiff { get; set; }
        public decimal? DelayPerLeg { get; set; }
        public decimal PreDelayPerLeg { get; set; }
        public decimal? DelayPerLegDiff { get; set; }
        public decimal? DelayPerBL { get; set; }
        public decimal PreDelayPerBL { get; set; }
        public decimal? DelayPerBLDiff { get; set; }
        public int? OnTimeFlightCount { get; set; }
        public int PreOnTimeFlightCount { get; set; }
        public decimal? OnTimeFlightCountDiff { get; set; }
        public decimal? OnTimeFlightsPerAll { get; set; }
        public decimal PreOnTimeFlightsPerAll { get; set; }
        public decimal? OnTimeFlightsPerAllDiff { get; set; }
        public decimal? DelayedFlightsPerAll { get; set; }
        public decimal PreDelayedFlightsPerAll { get; set; }
        public decimal? DelayedFlightsPerAllDiff { get; set; }
        public decimal? DelayedFlightsPerOnTime { get; set; }
        public decimal PreDelayedFlightsPerOnTime { get; set; }
        public decimal? DelayedFlightsPerOnTimeDiff { get; set; }
        public decimal? DelayedPaxPerAll { get; set; }
        public decimal PreDelayedPaxPerAll { get; set; }
        public decimal? DelayedPaxPerAllDiff { get; set; }
        public int PaxDelay120180 { get; set; }
        public int PrePaxDelay120180 { get; set; }
        public decimal? PaxDelay120180Diff { get; set; }
        public int PaxDelayOver180 { get; set; }
        public int PrePaxDelayOver180 { get; set; }
        public decimal? PaxDelayOver180Diff { get; set; }
        public int PaxDelayOver240 { get; set; }
        public int PrePaxDelayOver240 { get; set; }
        public decimal? PaxDelayOver240Diff { get; set; }
        public int DelayUnder30 { get; set; }
        public int PreDelayUnder30 { get; set; }
        public decimal? DelayUnder30Diff { get; set; }
        public int DelayOver30 { get; set; }
        public int PreDelayOver30 { get; set; }
        public decimal? DelayOver30Diff { get; set; }
        public int Delay3060 { get; set; }
        public int PreDelay3060 { get; set; }
        public decimal? Delay3060Diff { get; set; }
        public int Delay60120 { get; set; }
        public int PreDelay60120 { get; set; }
        public decimal? Delay60120Diff { get; set; }
        public int Delay120180 { get; set; }
        public int PreDelay120180 { get; set; }
        public decimal? Delay120180Diff { get; set; }
        public int DelayOver180 { get; set; }
        public int PreDelayOver180 { get; set; }
        public decimal? DelayOver180Diff { get; set; }
        public int DelayOver240 { get; set; }
        public int PreDelayOver240 { get; set; }
        public decimal? DelayOver240Diff { get; set; }
        public int DelayUnder30Time { get; set; }
        public int PreDelayUnder30Time { get; set; }
        public decimal? DelayUnder30TimeDiff { get; set; }
        public int DelayOver30Time { get; set; }
        public int PreDelayOver30Time { get; set; }
        public decimal? DelayOver30TimeDiff { get; set; }
        public int Delay3060Time { get; set; }
        public int PreDelay3060Time { get; set; }
        public decimal? Delay3060TimeDiff { get; set; }
        public int Delay60120Time { get; set; }
        public int PreDelay60120Time { get; set; }
        public decimal? Delay60120TimeDiff { get; set; }
        public int Delay120180Time { get; set; }
        public int PreDelay120180Time { get; set; }
        public decimal? Delay120180TimeDiff { get; set; }
        public int DelayOver180Time { get; set; }
        public int PreDelayOver180Time { get; set; }
        public decimal? DelayOver180TimeDiff { get; set; }
        public int DelayOver240Time { get; set; }
        public int PreDelayOver240Time { get; set; }
        public decimal? DelayOver240TimeDiff { get; set; }
        public int FltDelayUnder30 { get; set; }
        public int PreFltDelayUnder30 { get; set; }
        public decimal? FltDelayUnder30Diff { get; set; }
        public int FltDelayOver30 { get; set; }
        public int PreFltDelayOver30 { get; set; }
        public decimal? FltDelayOver30Diff { get; set; }
        public int FltDelay3060 { get; set; }
        public int PreFltDelay3060 { get; set; }
        public decimal? FltDelay3060Diff { get; set; }
        public int FltDelay60120 { get; set; }
        public int PreFltDelay60120 { get; set; }
        public decimal? FltDelay60120Diff { get; set; }
        public int FltDelay120180 { get; set; }
        public int PreFltDelay120180 { get; set; }
        public decimal? FltDelay120180Diff { get; set; }
        public int FltDelayOver180 { get; set; }
        public int PreFltDelayOver180 { get; set; }
        public decimal? FltDelayOver180Diff { get; set; }
        public int FltDelayOver240 { get; set; }
        public int PreFltDelayOver240 { get; set; }
        public decimal? FltDelayOver240Diff { get; set; }
        public decimal? FltDelayUnder30PerAll { get; set; }
        public decimal PreFltDelayUnder30PerAll { get; set; }
        public decimal? FltDelayUnder30PerAllDiff { get; set; }
        public decimal? FltDelayUnder30PerDelayed { get; set; }
        public decimal PreFltDelayUnder30PerDelayed { get; set; }
        public decimal? FltDelayOver30PerAll { get; set; }
        public decimal PreFltDelayOver30PerAll { get; set; }
        public decimal? FltDelayOver30PerAllDiff { get; set; }
        public decimal? FltDelayOver30PerDelayed { get; set; }
        public decimal PreFltDelayOver30PerDelayed { get; set; }
        public decimal? FltDelay3060PerAll { get; set; }
        public decimal PreFltDelay3060PerAll { get; set; }
        public decimal? FltDelay3060PerAllDiff { get; set; }
        public decimal? FltDelay3060PerDelayed { get; set; }
        public decimal PreFltDelay3060PerDelayed { get; set; }
        public decimal? FltDelay60120PerAll { get; set; }
        public decimal PreFltDelay60120PerAll { get; set; }
        public decimal? FltDelay60120PerAllDiff { get; set; }
        public decimal? FltDelay60120PerDelayed { get; set; }
        public decimal PreFltDelay60120PerDelayed { get; set; }
        public decimal? FltDelay120180PerAll { get; set; }
        public decimal PreFltDelay120180PerAll { get; set; }
        public decimal? FltDelay120180PerAllDiff { get; set; }
        public decimal? FltDelay120180PerDelayed { get; set; }
        public decimal PreFltDelay120180PerDelayed { get; set; }
        public decimal? FltDelayOver180PerAll { get; set; }
        public decimal PreFltDelayOver180PerAll { get; set; }
        public decimal? FltDelayOver180PerAllDiff { get; set; }
        public decimal? FltDelayOver180PerDelayed { get; set; }
        public decimal PreFltDelayOver180PerDelayed { get; set; }
        public decimal? FltDelayOver240PerAll { get; set; }
        public decimal PreFltDelayOver240PerAll { get; set; }
        public decimal? FltDelayOver240PerDelayed { get; set; }
        public decimal PaxDelayOver30 { get; set; }
        public int PrePaxDelayOver30 { get; set; }
        public decimal? PaxDelayOver30Diff { get; set; }
        public int PaxDelay3060 { get; set; }
        public int PrePaxDelay3060 { get; set; }
        public decimal? PaxDelay3060Diff { get; set; }
        public int PaxDelay60120 { get; set; }
        public int PrePaxDelay60120 { get; set; }
        public decimal? PaxDelay60120Diff { get; set; }
        public int FlightCount { get; set; }
        public int PreFlightCount { get; set; }
        public decimal? FlightCountDiff { get; set; }
        public int? AFlightCount { get; set; }
        public int PreAFlightCount { get; set; }
        public decimal? AFlightCountDiff { get; set; }
        public int BlockTime { get; set; }
        public int PreBlockTime { get; set; }
        public decimal? BlockTimeDiff { get; set; }
        public int? ABlockTime { get; set; }
        public int PreABlockTime { get; set; }
        public decimal? ABlockTimeDiff { get; set; }
        public int FlightTime { get; set; }
        public int PreFlightTime { get; set; }
        public decimal? FlightTimeDiff { get; set; }
        public int? AFlightTime { get; set; }
        public int PreAFlightTime { get; set; }
        public decimal? AFlightTimeDiff { get; set; }
        public int TotalPax { get; set; }
        public int PreTotalPax { get; set; }
        public decimal? TotalPaxDiff { get; set; }
        public int? ATotalPax { get; set; }
        public int PreATotalPax { get; set; }
        public decimal? ATotalPaxDiff { get; set; }
        public int TotalPaxAll { get; set; }
        public int PreTotalPaxAll { get; set; }
        public decimal? TotalPaxAllDiff { get; set; }
        public int? ATotalPaxAll { get; set; }
        public int PreATotalPaxAll { get; set; }
        public decimal? ATotalPaxAllDiff { get; set; }
    }
}
