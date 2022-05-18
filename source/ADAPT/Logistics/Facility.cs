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
  *    Kathleen Oneal - made companyId nullable, renamed property name from FactilityTypeEnum to FacilityType
  *    R. Andres Ferreyra - added nullable ParentFacilityId for PAIL compatibility.
  *    Kelly Nelson - added definitions
  *******************************************************************************/

using System.Collections.Generic;
using AgGateway.ADAPT.ApplicationDataModel.Common;
using AgGateway.ADAPT.ApplicationDataModel.Representations;

namespace AgGateway.ADAPT.ApplicationDataModel.Logistics
{
    /// <summary>
    /// A physical place at which a business entity operates
    /// </summary>
    public class Facility
    {
        public Facility()
        {
            Id = CompoundIdentifierFactory.Instance.Create();
            ContextItems = new List<ContextItem>();
        }

        public CompoundIdentifier Id { get; private set; }

        /// <summary>
        /// Optional mapping to a company
        /// </summary>
        public int? CompanyId { get; set; }

        public string Description { get; set; }

        public ContactInfo ContactInfo { get; set; }

        public EnumeratedValue FacilityType { get; set; }

        public List<ContextItem> ContextItems { get; set; }

        /// <summary>
        /// Enables a hierarchical structure for facilities. 
        /// </summary>
        public int? ParentFacilityId { get; set; } 
    }
}
