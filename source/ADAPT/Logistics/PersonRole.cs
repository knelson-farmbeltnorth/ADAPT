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
  *    Kathleen Oneal - changed Role from string to PersonRolesEnum
  *    Justin Sliekers - changed EmployerId to CompanyId, changed to list of Timescope for ActiveScopes
  *    Kelly Nelson - added definitions
  *******************************************************************************/

using System.Collections.Generic;
using AgGateway.ADAPT.ApplicationDataModel.Common;
using AgGateway.ADAPT.ApplicationDataModel.Representations;

namespace AgGateway.ADAPT.ApplicationDataModel.Logistics
{
    /// <summary>
    /// The function assumed by an individual for a specific time and purpose
    /// </summary>
    public class PersonRole
    {
        public PersonRole()
        {
            Id = CompoundIdentifierFactory.Instance.Create();
            TimeScopes = new List<TimeScope>();
        }

        public CompoundIdentifier Id { get; private set; }

        /// <summary>
        /// Mapping to the Person.  Required.
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// The function assumed
        /// </summary>
        public EnumeratedValue Role { get; set; }

        /// <summary>
        /// Optional mapping to a Grower
        /// </summary>
        public int? GrowerId { get; set; }

        public List<TimeScope> TimeScopes { get; set; }

        /// <summary>
        /// Optional mapping to a Company
        /// </summary>
        public int? CompanyId { get; set; }
    }
}
