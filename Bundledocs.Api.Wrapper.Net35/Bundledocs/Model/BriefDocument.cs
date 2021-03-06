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
    /// BriefDocument
    /// </summary>
    [DataContract]
    public partial class BriefDocument :  IEquatable<BriefDocument>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BriefDocument" /> class.
        /// </summary>
        /// <param name="DateRegenerated">DateRegenerated.</param>
        /// <param name="LastDownloadTimeStamp">LastDownloadTimeStamp.</param>
        /// <param name="IsDateEnabled">IsDateEnabled.</param>
        /// <param name="IsExpanded">IsExpanded.</param>
        /// <param name="IsDocumentDateEnabled">IsDocumentDateEnabled.</param>
        /// <param name="IsContinuation">IsContinuation.</param>
        /// <param name="IsCoverPage">IsCoverPage.</param>
        /// <param name="IsIncluded">IsIncluded.</param>
        /// <param name="IsLateInsert">IsLateInsert.</param>
        /// <param name="LateInsertPageNumber">LateInsertPageNumber.</param>
        /// <param name="IsUsingSourceFileDimensions">IsUsingSourceFileDimensions.</param>
        /// <param name="SourceFilePath">SourceFilePath.</param>
        /// <param name="PdfFilePath">PdfFilePath.</param>
        /// <param name="FileName">FileName.</param>
        /// <param name="FileExtension">FileExtension.</param>
        /// <param name="FileSize">FileSize.</param>
        /// <param name="ParentRowKey">ParentRowKey.</param>
        /// <param name="NumberOfPages">NumberOfPages.</param>
        /// <param name="BriefPageNumber">BriefPageNumber.</param>
        /// <param name="BriefPageNumberPrinted">BriefPageNumberPrinted.</param>
        /// <param name="DisplayOrder">DisplayOrder.</param>
        /// <param name="DisplayOrderPrinted">DisplayOrderPrinted.</param>
        /// <param name="DisplayDate">DisplayDate.</param>
        /// <param name="DisplayDateFormat">DisplayDateFormat.</param>
        /// <param name="DisplayDatePrinted">DisplayDatePrinted.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Description">Description.</param>
        /// <param name="BorderColor">BorderColor.</param>
        /// <param name="PageRange">PageRange.</param>
        /// <param name="FileUploadKey">FileUploadKey.</param>
        /// <param name="Children">Children.</param>
        /// <param name="Annotations">Annotations.</param>
        /// <param name="ForeignKey">ForeignKey.</param>
        /// <param name="Created">Created.</param>
        /// <param name="LastAccessedTimeStamp">LastAccessedTimeStamp.</param>
        /// <param name="PartitionKey">PartitionKey.</param>
        /// <param name="RowKey">RowKey.</param>
        /// <param name="Timestamp">Timestamp.</param>
        /// <param name="ETag">ETag.</param>
        public BriefDocument(DateTime? DateRegenerated = null, DateTime? LastDownloadTimeStamp = null, bool? IsDateEnabled = null, bool? IsExpanded = null, bool? IsDocumentDateEnabled = null, bool? IsContinuation = null, bool? IsCoverPage = null, bool? IsIncluded = null, bool? IsLateInsert = null, int? LateInsertPageNumber = null, bool? IsUsingSourceFileDimensions = null, string SourceFilePath = null, string PdfFilePath = null, string FileName = null, string FileExtension = null, string FileSize = null, string ParentRowKey = null, int? NumberOfPages = null, int? BriefPageNumber = null, int? BriefPageNumberPrinted = null, string DisplayOrder = null, string DisplayOrderPrinted = null, DateTime? DisplayDate = null, string DisplayDateFormat = null, string DisplayDatePrinted = null, string Type = null, string Description = null, string BorderColor = null, string PageRange = null, string FileUploadKey = null, List<BriefDocument> Children = null, List<BriefDocumentAnnotation> Annotations = null, string ForeignKey = null, DateTime? Created = null, DateTime? LastAccessedTimeStamp = null, string PartitionKey = null, string RowKey = null, DateTime? Timestamp = null, string ETag = null)
        {
            this.DateRegenerated = DateRegenerated;
            this.LastDownloadTimeStamp = LastDownloadTimeStamp;
            this.IsDateEnabled = IsDateEnabled;
            this.IsExpanded = IsExpanded;
            this.IsDocumentDateEnabled = IsDocumentDateEnabled;
            this.IsContinuation = IsContinuation;
            this.IsCoverPage = IsCoverPage;
            this.IsIncluded = IsIncluded;
            this.IsLateInsert = IsLateInsert;
            this.LateInsertPageNumber = LateInsertPageNumber;
            this.IsUsingSourceFileDimensions = IsUsingSourceFileDimensions;
            this.SourceFilePath = SourceFilePath;
            this.PdfFilePath = PdfFilePath;
            this.FileName = FileName;
            this.FileExtension = FileExtension;
            this.FileSize = FileSize;
            this.ParentRowKey = ParentRowKey;
            this.NumberOfPages = NumberOfPages;
            this.BriefPageNumber = BriefPageNumber;
            this.BriefPageNumberPrinted = BriefPageNumberPrinted;
            this.DisplayOrder = DisplayOrder;
            this.DisplayOrderPrinted = DisplayOrderPrinted;
            this.DisplayDate = DisplayDate;
            this.DisplayDateFormat = DisplayDateFormat;
            this.DisplayDatePrinted = DisplayDatePrinted;
            this.Type = Type;
            this.Description = Description;
            this.BorderColor = BorderColor;
            this.PageRange = PageRange;
            this.FileUploadKey = FileUploadKey;
            this.Children = Children;
            this.Annotations = Annotations;
            this.ForeignKey = ForeignKey;
            this.Created = Created;
            this.LastAccessedTimeStamp = LastAccessedTimeStamp;
            this.PartitionKey = PartitionKey;
            this.RowKey = RowKey;
            this.Timestamp = Timestamp;
            this.ETag = ETag;
        }
        
        /// <summary>
        /// Gets or Sets DateRegenerated
        /// </summary>
        [DataMember(Name="DateRegenerated", EmitDefaultValue=false)]
        public DateTime? DateRegenerated { get; set; }
        /// <summary>
        /// Gets or Sets LastDownloadTimeStamp
        /// </summary>
        [DataMember(Name="LastDownloadTimeStamp", EmitDefaultValue=false)]
        public DateTime? LastDownloadTimeStamp { get; set; }
        /// <summary>
        /// Gets or Sets IsDateEnabled
        /// </summary>
        [DataMember(Name="IsDateEnabled", EmitDefaultValue=false)]
        public bool? IsDateEnabled { get; set; }
        /// <summary>
        /// Gets or Sets IsExpanded
        /// </summary>
        [DataMember(Name="IsExpanded", EmitDefaultValue=false)]
        public bool? IsExpanded { get; set; }
        /// <summary>
        /// Gets or Sets IsDocumentDateEnabled
        /// </summary>
        [DataMember(Name="IsDocumentDateEnabled", EmitDefaultValue=false)]
        public bool? IsDocumentDateEnabled { get; set; }
        /// <summary>
        /// Gets or Sets IsContinuation
        /// </summary>
        [DataMember(Name="IsContinuation", EmitDefaultValue=false)]
        public bool? IsContinuation { get; set; }
        /// <summary>
        /// Gets or Sets IsCoverPage
        /// </summary>
        [DataMember(Name="IsCoverPage", EmitDefaultValue=false)]
        public bool? IsCoverPage { get; set; }
        /// <summary>
        /// Gets or Sets IsIncluded
        /// </summary>
        [DataMember(Name="IsIncluded", EmitDefaultValue=false)]
        public bool? IsIncluded { get; set; }
        /// <summary>
        /// Gets or Sets IsLateInsert
        /// </summary>
        [DataMember(Name="IsLateInsert", EmitDefaultValue=false)]
        public bool? IsLateInsert { get; set; }
        /// <summary>
        /// Gets or Sets LateInsertPageNumber
        /// </summary>
        [DataMember(Name="LateInsertPageNumber", EmitDefaultValue=false)]
        public int? LateInsertPageNumber { get; set; }
        /// <summary>
        /// Gets or Sets IsUsingSourceFileDimensions
        /// </summary>
        [DataMember(Name="IsUsingSourceFileDimensions", EmitDefaultValue=false)]
        public bool? IsUsingSourceFileDimensions { get; set; }
        /// <summary>
        /// Gets or Sets SourceFilePath
        /// </summary>
        [DataMember(Name="SourceFilePath", EmitDefaultValue=false)]
        public string SourceFilePath { get; set; }
        /// <summary>
        /// Gets or Sets PdfFilePath
        /// </summary>
        [DataMember(Name="PdfFilePath", EmitDefaultValue=false)]
        public string PdfFilePath { get; set; }
        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name="FileName", EmitDefaultValue=false)]
        public string FileName { get; set; }
        /// <summary>
        /// Gets or Sets FileExtension
        /// </summary>
        [DataMember(Name="FileExtension", EmitDefaultValue=false)]
        public string FileExtension { get; set; }
        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [DataMember(Name="FileSize", EmitDefaultValue=false)]
        public string FileSize { get; set; }
        /// <summary>
        /// Gets or Sets ParentRowKey
        /// </summary>
        [DataMember(Name="ParentRowKey", EmitDefaultValue=false)]
        public string ParentRowKey { get; set; }
        /// <summary>
        /// Gets or Sets NumberOfPages
        /// </summary>
        [DataMember(Name="NumberOfPages", EmitDefaultValue=false)]
        public int? NumberOfPages { get; set; }
        /// <summary>
        /// Gets or Sets BriefPageNumber
        /// </summary>
        [DataMember(Name="BriefPageNumber", EmitDefaultValue=false)]
        public int? BriefPageNumber { get; set; }
        /// <summary>
        /// Gets or Sets BriefPageNumberPrinted
        /// </summary>
        [DataMember(Name="BriefPageNumberPrinted", EmitDefaultValue=false)]
        public int? BriefPageNumberPrinted { get; set; }
        /// <summary>
        /// Gets or Sets DisplayOrder
        /// </summary>
        [DataMember(Name="DisplayOrder", EmitDefaultValue=false)]
        public string DisplayOrder { get; set; }
        /// <summary>
        /// Gets or Sets DisplayOrderPrinted
        /// </summary>
        [DataMember(Name="DisplayOrderPrinted", EmitDefaultValue=false)]
        public string DisplayOrderPrinted { get; set; }
        /// <summary>
        /// Gets or Sets DisplayDate
        /// </summary>
        [DataMember(Name="DisplayDate", EmitDefaultValue=false)]
        public DateTime? DisplayDate { get; set; }
        /// <summary>
        /// Gets or Sets DisplayDateFormat
        /// </summary>
        [DataMember(Name="DisplayDateFormat", EmitDefaultValue=false)]
        public string DisplayDateFormat { get; set; }
        /// <summary>
        /// Gets or Sets DisplayDatePrinted
        /// </summary>
        [DataMember(Name="DisplayDatePrinted", EmitDefaultValue=false)]
        public string DisplayDatePrinted { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets BorderColor
        /// </summary>
        [DataMember(Name="BorderColor", EmitDefaultValue=false)]
        public string BorderColor { get; set; }
        /// <summary>
        /// Gets or Sets PageRange
        /// </summary>
        [DataMember(Name="PageRange", EmitDefaultValue=false)]
        public string PageRange { get; set; }
        /// <summary>
        /// Gets or Sets FileUploadKey
        /// </summary>
        [DataMember(Name="FileUploadKey", EmitDefaultValue=false)]
        public string FileUploadKey { get; set; }
        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [DataMember(Name="Children", EmitDefaultValue=false)]
        public List<BriefDocument> Children { get; set; }
        /// <summary>
        /// Gets or Sets Annotations
        /// </summary>
        [DataMember(Name="Annotations", EmitDefaultValue=false)]
        public List<BriefDocumentAnnotation> Annotations { get; set; }
        /// <summary>
        /// Gets or Sets ForeignKey
        /// </summary>
        [DataMember(Name="ForeignKey", EmitDefaultValue=false)]
        public string ForeignKey { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="Created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }
        /// <summary>
        /// Gets or Sets LastAccessedTimeStamp
        /// </summary>
        [DataMember(Name="LastAccessedTimeStamp", EmitDefaultValue=false)]
        public DateTime? LastAccessedTimeStamp { get; set; }
        /// <summary>
        /// Gets or Sets PartitionKey
        /// </summary>
        [DataMember(Name="PartitionKey", EmitDefaultValue=false)]
        public string PartitionKey { get; set; }
        /// <summary>
        /// Gets or Sets RowKey
        /// </summary>
        [DataMember(Name="RowKey", EmitDefaultValue=false)]
        public string RowKey { get; set; }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="Timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Gets or Sets ETag
        /// </summary>
        [DataMember(Name="ETag", EmitDefaultValue=false)]
        public string ETag { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BriefDocument {\n");
            sb.Append("  DateRegenerated: ").Append(DateRegenerated).Append("\n");
            sb.Append("  LastDownloadTimeStamp: ").Append(LastDownloadTimeStamp).Append("\n");
            sb.Append("  IsDateEnabled: ").Append(IsDateEnabled).Append("\n");
            sb.Append("  IsExpanded: ").Append(IsExpanded).Append("\n");
            sb.Append("  IsDocumentDateEnabled: ").Append(IsDocumentDateEnabled).Append("\n");
            sb.Append("  IsContinuation: ").Append(IsContinuation).Append("\n");
            sb.Append("  IsCoverPage: ").Append(IsCoverPage).Append("\n");
            sb.Append("  IsIncluded: ").Append(IsIncluded).Append("\n");
            sb.Append("  IsLateInsert: ").Append(IsLateInsert).Append("\n");
            sb.Append("  LateInsertPageNumber: ").Append(LateInsertPageNumber).Append("\n");
            sb.Append("  IsUsingSourceFileDimensions: ").Append(IsUsingSourceFileDimensions).Append("\n");
            sb.Append("  SourceFilePath: ").Append(SourceFilePath).Append("\n");
            sb.Append("  PdfFilePath: ").Append(PdfFilePath).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  FileExtension: ").Append(FileExtension).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  ParentRowKey: ").Append(ParentRowKey).Append("\n");
            sb.Append("  NumberOfPages: ").Append(NumberOfPages).Append("\n");
            sb.Append("  BriefPageNumber: ").Append(BriefPageNumber).Append("\n");
            sb.Append("  BriefPageNumberPrinted: ").Append(BriefPageNumberPrinted).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  DisplayOrderPrinted: ").Append(DisplayOrderPrinted).Append("\n");
            sb.Append("  DisplayDate: ").Append(DisplayDate).Append("\n");
            sb.Append("  DisplayDateFormat: ").Append(DisplayDateFormat).Append("\n");
            sb.Append("  DisplayDatePrinted: ").Append(DisplayDatePrinted).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  BorderColor: ").Append(BorderColor).Append("\n");
            sb.Append("  PageRange: ").Append(PageRange).Append("\n");
            sb.Append("  FileUploadKey: ").Append(FileUploadKey).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  ForeignKey: ").Append(ForeignKey).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  LastAccessedTimeStamp: ").Append(LastAccessedTimeStamp).Append("\n");
            sb.Append("  PartitionKey: ").Append(PartitionKey).Append("\n");
            sb.Append("  RowKey: ").Append(RowKey).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  ETag: ").Append(ETag).Append("\n");
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
            return this.Equals(obj as BriefDocument);
        }

        /// <summary>
        /// Returns true if BriefDocument instances are equal
        /// </summary>
        /// <param name="other">Instance of BriefDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BriefDocument other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DateRegenerated == other.DateRegenerated ||
                    this.DateRegenerated != null &&
                    this.DateRegenerated.Equals(other.DateRegenerated)
                ) && 
                (
                    this.LastDownloadTimeStamp == other.LastDownloadTimeStamp ||
                    this.LastDownloadTimeStamp != null &&
                    this.LastDownloadTimeStamp.Equals(other.LastDownloadTimeStamp)
                ) && 
                (
                    this.IsDateEnabled == other.IsDateEnabled ||
                    this.IsDateEnabled != null &&
                    this.IsDateEnabled.Equals(other.IsDateEnabled)
                ) && 
                (
                    this.IsExpanded == other.IsExpanded ||
                    this.IsExpanded != null &&
                    this.IsExpanded.Equals(other.IsExpanded)
                ) && 
                (
                    this.IsDocumentDateEnabled == other.IsDocumentDateEnabled ||
                    this.IsDocumentDateEnabled != null &&
                    this.IsDocumentDateEnabled.Equals(other.IsDocumentDateEnabled)
                ) && 
                (
                    this.IsContinuation == other.IsContinuation ||
                    this.IsContinuation != null &&
                    this.IsContinuation.Equals(other.IsContinuation)
                ) && 
                (
                    this.IsCoverPage == other.IsCoverPage ||
                    this.IsCoverPage != null &&
                    this.IsCoverPage.Equals(other.IsCoverPage)
                ) && 
                (
                    this.IsIncluded == other.IsIncluded ||
                    this.IsIncluded != null &&
                    this.IsIncluded.Equals(other.IsIncluded)
                ) && 
                (
                    this.IsLateInsert == other.IsLateInsert ||
                    this.IsLateInsert != null &&
                    this.IsLateInsert.Equals(other.IsLateInsert)
                ) && 
                (
                    this.LateInsertPageNumber == other.LateInsertPageNumber ||
                    this.LateInsertPageNumber != null &&
                    this.LateInsertPageNumber.Equals(other.LateInsertPageNumber)
                ) && 
                (
                    this.IsUsingSourceFileDimensions == other.IsUsingSourceFileDimensions ||
                    this.IsUsingSourceFileDimensions != null &&
                    this.IsUsingSourceFileDimensions.Equals(other.IsUsingSourceFileDimensions)
                ) && 
                (
                    this.SourceFilePath == other.SourceFilePath ||
                    this.SourceFilePath != null &&
                    this.SourceFilePath.Equals(other.SourceFilePath)
                ) && 
                (
                    this.PdfFilePath == other.PdfFilePath ||
                    this.PdfFilePath != null &&
                    this.PdfFilePath.Equals(other.PdfFilePath)
                ) && 
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) && 
                (
                    this.FileExtension == other.FileExtension ||
                    this.FileExtension != null &&
                    this.FileExtension.Equals(other.FileExtension)
                ) && 
                (
                    this.FileSize == other.FileSize ||
                    this.FileSize != null &&
                    this.FileSize.Equals(other.FileSize)
                ) && 
                (
                    this.ParentRowKey == other.ParentRowKey ||
                    this.ParentRowKey != null &&
                    this.ParentRowKey.Equals(other.ParentRowKey)
                ) && 
                (
                    this.NumberOfPages == other.NumberOfPages ||
                    this.NumberOfPages != null &&
                    this.NumberOfPages.Equals(other.NumberOfPages)
                ) && 
                (
                    this.BriefPageNumber == other.BriefPageNumber ||
                    this.BriefPageNumber != null &&
                    this.BriefPageNumber.Equals(other.BriefPageNumber)
                ) && 
                (
                    this.BriefPageNumberPrinted == other.BriefPageNumberPrinted ||
                    this.BriefPageNumberPrinted != null &&
                    this.BriefPageNumberPrinted.Equals(other.BriefPageNumberPrinted)
                ) && 
                (
                    this.DisplayOrder == other.DisplayOrder ||
                    this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(other.DisplayOrder)
                ) && 
                (
                    this.DisplayOrderPrinted == other.DisplayOrderPrinted ||
                    this.DisplayOrderPrinted != null &&
                    this.DisplayOrderPrinted.Equals(other.DisplayOrderPrinted)
                ) && 
                (
                    this.DisplayDate == other.DisplayDate ||
                    this.DisplayDate != null &&
                    this.DisplayDate.Equals(other.DisplayDate)
                ) && 
                (
                    this.DisplayDateFormat == other.DisplayDateFormat ||
                    this.DisplayDateFormat != null &&
                    this.DisplayDateFormat.Equals(other.DisplayDateFormat)
                ) && 
                (
                    this.DisplayDatePrinted == other.DisplayDatePrinted ||
                    this.DisplayDatePrinted != null &&
                    this.DisplayDatePrinted.Equals(other.DisplayDatePrinted)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.BorderColor == other.BorderColor ||
                    this.BorderColor != null &&
                    this.BorderColor.Equals(other.BorderColor)
                ) && 
                (
                    this.PageRange == other.PageRange ||
                    this.PageRange != null &&
                    this.PageRange.Equals(other.PageRange)
                ) && 
                (
                    this.FileUploadKey == other.FileUploadKey ||
                    this.FileUploadKey != null &&
                    this.FileUploadKey.Equals(other.FileUploadKey)
                ) && 
                (
                    this.Children == other.Children ||
                    this.Children != null &&
                    this.Children.SequenceEqual(other.Children)
                ) && 
                (
                    this.Annotations == other.Annotations ||
                    this.Annotations != null &&
                    this.Annotations.SequenceEqual(other.Annotations)
                ) && 
                (
                    this.ForeignKey == other.ForeignKey ||
                    this.ForeignKey != null &&
                    this.ForeignKey.Equals(other.ForeignKey)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.LastAccessedTimeStamp == other.LastAccessedTimeStamp ||
                    this.LastAccessedTimeStamp != null &&
                    this.LastAccessedTimeStamp.Equals(other.LastAccessedTimeStamp)
                ) && 
                (
                    this.PartitionKey == other.PartitionKey ||
                    this.PartitionKey != null &&
                    this.PartitionKey.Equals(other.PartitionKey)
                ) && 
                (
                    this.RowKey == other.RowKey ||
                    this.RowKey != null &&
                    this.RowKey.Equals(other.RowKey)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.ETag == other.ETag ||
                    this.ETag != null &&
                    this.ETag.Equals(other.ETag)
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
                if (this.DateRegenerated != null)
                    hash = hash * 59 + this.DateRegenerated.GetHashCode();
                if (this.LastDownloadTimeStamp != null)
                    hash = hash * 59 + this.LastDownloadTimeStamp.GetHashCode();
                if (this.IsDateEnabled != null)
                    hash = hash * 59 + this.IsDateEnabled.GetHashCode();
                if (this.IsExpanded != null)
                    hash = hash * 59 + this.IsExpanded.GetHashCode();
                if (this.IsDocumentDateEnabled != null)
                    hash = hash * 59 + this.IsDocumentDateEnabled.GetHashCode();
                if (this.IsContinuation != null)
                    hash = hash * 59 + this.IsContinuation.GetHashCode();
                if (this.IsCoverPage != null)
                    hash = hash * 59 + this.IsCoverPage.GetHashCode();
                if (this.IsIncluded != null)
                    hash = hash * 59 + this.IsIncluded.GetHashCode();
                if (this.IsLateInsert != null)
                    hash = hash * 59 + this.IsLateInsert.GetHashCode();
                if (this.LateInsertPageNumber != null)
                    hash = hash * 59 + this.LateInsertPageNumber.GetHashCode();
                if (this.IsUsingSourceFileDimensions != null)
                    hash = hash * 59 + this.IsUsingSourceFileDimensions.GetHashCode();
                if (this.SourceFilePath != null)
                    hash = hash * 59 + this.SourceFilePath.GetHashCode();
                if (this.PdfFilePath != null)
                    hash = hash * 59 + this.PdfFilePath.GetHashCode();
                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();
                if (this.FileExtension != null)
                    hash = hash * 59 + this.FileExtension.GetHashCode();
                if (this.FileSize != null)
                    hash = hash * 59 + this.FileSize.GetHashCode();
                if (this.ParentRowKey != null)
                    hash = hash * 59 + this.ParentRowKey.GetHashCode();
                if (this.NumberOfPages != null)
                    hash = hash * 59 + this.NumberOfPages.GetHashCode();
                if (this.BriefPageNumber != null)
                    hash = hash * 59 + this.BriefPageNumber.GetHashCode();
                if (this.BriefPageNumberPrinted != null)
                    hash = hash * 59 + this.BriefPageNumberPrinted.GetHashCode();
                if (this.DisplayOrder != null)
                    hash = hash * 59 + this.DisplayOrder.GetHashCode();
                if (this.DisplayOrderPrinted != null)
                    hash = hash * 59 + this.DisplayOrderPrinted.GetHashCode();
                if (this.DisplayDate != null)
                    hash = hash * 59 + this.DisplayDate.GetHashCode();
                if (this.DisplayDateFormat != null)
                    hash = hash * 59 + this.DisplayDateFormat.GetHashCode();
                if (this.DisplayDatePrinted != null)
                    hash = hash * 59 + this.DisplayDatePrinted.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.BorderColor != null)
                    hash = hash * 59 + this.BorderColor.GetHashCode();
                if (this.PageRange != null)
                    hash = hash * 59 + this.PageRange.GetHashCode();
                if (this.FileUploadKey != null)
                    hash = hash * 59 + this.FileUploadKey.GetHashCode();
                if (this.Children != null)
                    hash = hash * 59 + this.Children.GetHashCode();
                if (this.Annotations != null)
                    hash = hash * 59 + this.Annotations.GetHashCode();
                if (this.ForeignKey != null)
                    hash = hash * 59 + this.ForeignKey.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.LastAccessedTimeStamp != null)
                    hash = hash * 59 + this.LastAccessedTimeStamp.GetHashCode();
                if (this.PartitionKey != null)
                    hash = hash * 59 + this.PartitionKey.GetHashCode();
                if (this.RowKey != null)
                    hash = hash * 59 + this.RowKey.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.ETag != null)
                    hash = hash * 59 + this.ETag.GetHashCode();
                return hash;
            }
        }
    }

}
