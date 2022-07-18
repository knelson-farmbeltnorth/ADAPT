/*******************************************************************************
 * Copyright (C) 2015 AgGateway and ADAPT Contributors
 * Copyright (C) 2015 Deere and Company
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
 *
 * Contributors:
 *    Tarak Reddy, Tim Shearouse - initial API and implementation
 *    Tarak Reddy - Renamed Guidance to GuidancePattern to match ISO
 *    Kathleen Oneal - renamed property Name to Description
  *******************************************************************************/

using AgGateway.ADAPT.ApplicationDataModel.Common;
using AgGateway.ADAPT.ApplicationDataModel.Logistics;
using AgGateway.ADAPT.ApplicationDataModel.Representations;
using AgGateway.ADAPT.ApplicationDataModel.Shapes;

namespace AgGateway.ADAPT.ApplicationDataModel.Guidance
{
    /// <summary>
    /// A geospatial definition used to guide a vehicle in a field
    /// </summary>
    public abstract class GuidancePattern
    {
        public GuidancePattern()
        {
            Id = CompoundIdentifierFactory.Instance.Create();
        }

        public CompoundIdentifier Id { get; private set; }

        /// <summary>
        /// The type of guidance pattern:  AB line, AB curve, APlus line, Spiral or Pivot.
        /// </summary>
        public GuidancePatternTypeEnum GuidancePatternType { get; set; }

        public GpsSource GpsSource { get; set; }

        public string OriginalEpsgCode { get; set; }

        public string Description { get; set; }

        public NumericRepresentationValue SwathWidth { get; set; }

        /// <summary>
        /// The propagation direction of a guidance pattern:  Both directions (default), left only, right only, or no propagation.
        /// </summary>
        public PropagationDirectionEnum PropagationDirection { get; set; }

        /// <summary>
        /// The extension of a guidance line outward from either end point.  From both points (default), from A only, from B only, or no extension
        /// </summary>
        public GuidanceExtensionEnum Extension { get; set; }

        public int? NumbersOfSwathsLeft { get; set; }

        public int? NumbersOfSwathsRight { get; set; }

        public MultiPolygon BoundingPolygon { get; set; }
    }
}
