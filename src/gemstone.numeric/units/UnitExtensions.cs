﻿//******************************************************************************************************
//  UnitExtensions.cs - Gbtc
//
//  Copyright © 2016, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may not use this
//  file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  12/12/2016 - J. Ritchie Carroll
//       Generated original version of source code.
//
//******************************************************************************************************

using System.Collections.Generic;

namespace gemstone.numeric.units
{
    /// <summary>
    /// Defines extension functions related to unit structures.
    /// </summary>
    public static class UnitExtensions
    {
        /// <summary>
        /// Unwraps a set of <see cref="Angle"/> values so a comparable mathematical operation can be applied.
        /// </summary>
        /// <param name="source">Sequence of <see cref="Angle"/> values to unwrap.</param>
        /// <returns>Unwrapped set of <see cref="Angle"/> values.</returns>
        /// <remarks>
        /// For Angles that wrap, e.g., between -180 and +180, this algorithm unwraps the values to make the values mathematically comparable.
        /// </remarks>
        public static IEnumerable<Angle> Unwrap(this IEnumerable<Angle> source) => Angle.Unwrap(source);

        /// <summary>
        /// Calculates an average of the specified sequence of <see cref="Angle"/> values.
        /// </summary>
        /// <param name="source">Sequence of <see cref="Angle"/> values over which to calculate average.</param>
        /// <returns>Average of the specified sequence of <see cref="Angle"/> values.</returns>
        /// <remarks>
        /// For Angles that wrap, e.g., between -180 and +180, this algorithm takes the wrapping into account when calculating the average.
        /// </remarks>
        public static Angle Average(this IEnumerable<Angle> source) => Angle.Average(source);
    }
}
