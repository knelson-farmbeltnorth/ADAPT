/*******************************************************************************
  * Copyright (C) 2015 AgGateway and ADAPT Contributors
  * Copyright (C) 2015 Deere and Company
  * All rights reserved. This program and the accompanying materials
  * are made available under the terms of the Eclipse Public License v1.0
  * which accompanies this distribution, and is available at
  * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
  *
  * Contributors:
  *    Kathleen Oneal - initial API and implementation
  *    Stuart Rhea - #112 CropNutritionIngredientCodeEnum needs to be changed into an EnumeratedRepresentation and have the oxides added to the list
  *    Kelly Nelson - added XML Comments
  *******************************************************************************/

using AgGateway.ADAPT.ApplicationDataModel.Representations;

namespace AgGateway.ADAPT.ApplicationDataModel.Products
{
    /// <summary>
    /// An crop nutrition element of a Product, mapped via ProductComponent
    /// </summary>
    public class CropNutritionIngredient : Ingredient
    {
        /// <summary>
        /// A reference to the element, using for example dtCropNutritionIngredient
        /// </summary>
        public EnumeratedValue IngredientCode { get; set; }
    }
}
