/* 
 * Bundledocs.Web.Api
 *
 * Bundledocs Web Api (v1)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Bundledocs.Model
{
    /// <summary>
    /// BriefDocumentDisplayOrderUpdateBean
    /// </summary>
    [DataContract]
    public partial class BriefDocumentDisplayOrderUpdateBean :  IEquatable<BriefDocumentDisplayOrderUpdateBean>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BriefDocumentDisplayOrderUpdateBean" /> class.
        /// </summary>
        /// <param name="RowKey">RowKey.</param>
        /// <param name="ParentRowKey">ParentRowKey.</param>
        /// <param name="DisplayOrder">DisplayOrder.</param>
        public BriefDocumentDisplayOrderUpdateBean(string RowKey = null, string ParentRowKey = null, string DisplayOrder = null)
        {
            this.RowKey = RowKey;
            this.ParentRowKey = ParentRowKey;
            this.DisplayOrder = DisplayOrder;
        }
        
        /// <summary>
        /// Gets or Sets RowKey
        /// </summary>
        [DataMember(Name="RowKey", EmitDefaultValue=false)]
        public string RowKey { get; set; }
        /// <summary>
        /// Gets or Sets ParentRowKey
        /// </summary>
        [DataMember(Name="ParentRowKey", EmitDefaultValue=false)]
        public string ParentRowKey { get; set; }
        /// <summary>
        /// Gets or Sets DisplayOrder
        /// </summary>
        [DataMember(Name="DisplayOrder", EmitDefaultValue=false)]
        public string DisplayOrder { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BriefDocumentDisplayOrderUpdateBean {\n");
            sb.Append("  RowKey: ").Append(RowKey).Append("\n");
            sb.Append("  ParentRowKey: ").Append(ParentRowKey).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BriefDocumentDisplayOrderUpdateBean);
        }

        /// <summary>
        /// Returns true if BriefDocumentDisplayOrderUpdateBean instances are equal
        /// </summary>
        /// <param name="other">Instance of BriefDocumentDisplayOrderUpdateBean to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BriefDocumentDisplayOrderUpdateBean other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RowKey == other.RowKey ||
                    this.RowKey != null &&
                    this.RowKey.Equals(other.RowKey)
                ) && 
                (
                    this.ParentRowKey == other.ParentRowKey ||
                    this.ParentRowKey != null &&
                    this.ParentRowKey.Equals(other.ParentRowKey)
                ) && 
                (
                    this.DisplayOrder == other.DisplayOrder ||
                    this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(other.DisplayOrder)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.RowKey != null)
                    hash = hash * 59 + this.RowKey.GetHashCode();
                if (this.ParentRowKey != null)
                    hash = hash * 59 + this.ParentRowKey.GetHashCode();
                if (this.DisplayOrder != null)
                    hash = hash * 59 + this.DisplayOrder.GetHashCode();
                return hash;
            }
        }
    }

}
