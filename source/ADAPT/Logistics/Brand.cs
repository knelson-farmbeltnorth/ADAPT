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
  *    Kelly Nelson - added definitions    
  *******************************************************************************/

using System;
using System.Collections.Generic;
using AgGateway.ADAPT.ApplicationDataModel.Common;

namespace AgGateway.ADAPT.ApplicationDataModel.Logistics
{
    /// <summary>
    /// A trade name under which a Manufacturer markets a good.
    /// </summary>
    public class Brand
    {
        public Brand()
        {
            Id = CompoundIdentifierFactory.Instance.Create();
            ContextItems = new List<ContextItem>();
        }

        public CompoundIdentifier Id { get; private set; }

        public String Description { get; set; }

        /// <summary>
        /// Optional mapping to Manufacturer
        /// </summary>
        public int ManufacturerId { get; set; }

        public List<ContextItem> ContextItems { get; set; }
    }
} 
