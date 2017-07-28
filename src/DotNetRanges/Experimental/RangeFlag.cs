﻿using System;

namespace DotNetRanges.Experimental
{
    [Flags]
    enum RangeFlag : byte
    {
        LowerInfiniteBound = 1, /* LowerBelowAll in Guava */
        LowerClosedBound = 2, /* LowerBelowValue in Guava */
        LowerOpenBound = 4, /* LowerAboveValue in Guava */
        
        UpperOpenBound = 8, /* UpperBelowValue in Guava */
        UpperClosedBound = 16, /* UpperAboveValue in Guava */
        UpperInfiniteBound = 32, /* UpperAboveAll in Guava */

        HasLowerBound = LowerClosedBound | LowerOpenBound,
        HasUpperBound = UpperOpenBound | UpperClosedBound,

        AllLowerBits = LowerClosedBound | LowerOpenBound | LowerInfiniteBound,
        AllUpperBits = UpperOpenBound | UpperClosedBound | UpperInfiniteBound,

        /* Ranges */
        Open = LowerOpenBound | UpperOpenBound,
        Closed = LowerClosedBound | UpperClosedBound,
        ClosedOpen = LowerClosedBound | UpperOpenBound,
        OpenClosed = LowerOpenBound | UpperClosedBound,
        GreaterThan = LowerOpenBound | UpperInfiniteBound,
        AtLeast = LowerClosedBound | UpperInfiniteBound,
        LessThan = LowerInfiniteBound | UpperOpenBound,
        AtMost = LowerInfiniteBound | UpperClosedBound,
        All = LowerInfiniteBound | UpperInfiniteBound
    }
}
