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
  *******************************************************************************/

using System.Collections.Generic;

namespace AgGateway.ADAPT.ApplicationDataModel.Shapes
{
    /// <summary>
    /// An enclosed space, optionally with interior holes
    /// </summary>
    public class Polygon : Shape
    {
        public Polygon()
        {
            Type = ShapeTypeEnum.Polygon;
            InteriorRings = new List<LinearRing>();
        }

        /// <summary>
        /// The exterior ring that encloses and individual polygon.   A Polygon must have 1 exterior ring.
        /// </summary>
        public LinearRing ExteriorRing { get; set; }

        /// <summary>
        /// A collection of linear rings that define breaks in the polygon
        /// </summary>
        public List<LinearRing> InteriorRings { get; set; }
    }
}
