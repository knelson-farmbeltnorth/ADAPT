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
  *    Joseph Ross Making Properties
  *    Kathleen Oneal - changed Passable to IsPassable and Name to Description
  *    Kelly Nelson  - changed ShapeIdRef to Shape
  *    Kelly Nelson  - added ContextItems
  *******************************************************************************/

using AgGateway.ADAPT.ApplicationDataModel.Common;
using System.Collections.Generic;

namespace AgGateway.ADAPT.ApplicationDataModel.FieldBoundaries
{
    /// <summary>
    /// A spatial feature inside of a field boundary such as a waterway, rockpile, or grove of trees.
    /// </summary>
    public class InteriorBoundaryAttribute
    {
        public InteriorBoundaryAttribute()
        {
            ContextItems = new List<ContextItem>();
        }
        public Shapes.Shape Shape { get; set; }

        /// <summary>
        /// Whether the feature may be crossed with a vehicle, e.g., a shallow grass waterway (true) vs. a rock pile (false)
        /// </summary>
        public bool IsPassable { get; set; }

        public string Description { get; set; }

        public List<ContextItem> ContextItems { get; set; }
    }
}
