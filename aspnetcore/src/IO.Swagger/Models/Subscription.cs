/*
 * UTM DSS/USS API
 *
 * Interface to Discovery and Synchronization Service (DSS) and UAS Service Suppliers (USS) used by participating clients to discover and interoperate.  Unless otherwise specified, fields specified in a message but not declared in the API shall be ignored.
 *
 * OpenAPI spec version: 1.0.0-oas3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// Specification of a geographic area that a client is interested in on an ongoing basis (e.g., “planning area”).  Internal to the DSS.
    /// </summary>
    [DataContract]
    public partial class Subscription : IEquatable<Subscription>
    { 
        /// <summary>
        /// Unique identifier for this subscription.
        /// </summary>
        /// <value>Unique identifier for this subscription.</value>
        [Required]
        [DataMember(Name="id")]
        public AnyOfSubscriptionId Id { get; set; }

        /// <summary>
        /// Gets or Sets Callbacks
        /// </summary>
        [Required]
        [DataMember(Name="callbacks")]
        public SubscriptionCallbacks Callbacks { get; set; }

        /// <summary>
        /// Created by the DSS and based on creating client’s ID (via access token).  Used for restricting mutation and deletion operations to owner.
        /// </summary>
        /// <value>Created by the DSS and based on creating client’s ID (via access token).  Used for restricting mutation and deletion operations to owner.</value>
        [Required]
        [DataMember(Name="owner")]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or Sets NotificationIndex
        /// </summary>
        [Required]
        [DataMember(Name="notification_index")]
        public SubscriptionNotificationIndex NotificationIndex { get; set; }

        /// <summary>
        /// If set, this Subscription will not generate any notifications before this time.  RFC 3339 format, per OpenAPI specification.
        /// </summary>
        /// <value>If set, this Subscription will not generate any notifications before this time.  RFC 3339 format, per OpenAPI specification.</value>
        [DataMember(Name="time_start")]
        public  TimeStart { get; set; }

        /// <summary>
        /// If set, this subscription will be automatically removed after this time.  RFC 3339 format, per OpenAPI specification.
        /// </summary>
        /// <value>If set, this subscription will be automatically removed after this time.  RFC 3339 format, per OpenAPI specification.</value>
        [DataMember(Name="time_end")]
        public  TimeEnd { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [Required]
        [DataMember(Name="version")]
        public Version Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subscription {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Callbacks: ").Append(Callbacks).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  NotificationIndex: ").Append(NotificationIndex).Append("\n");
            sb.Append("  TimeStart: ").Append(TimeStart).Append("\n");
            sb.Append("  TimeEnd: ").Append(TimeEnd).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Subscription)obj);
        }

        /// <summary>
        /// Returns true if Subscription instances are equal
        /// </summary>
        /// <param name="other">Instance of Subscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subscription other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.SequenceEqual(other.Id)
                ) && 
                (
                    Callbacks == other.Callbacks ||
                    Callbacks != null &&
                    Callbacks.Equals(other.Callbacks)
                ) && 
                (
                    Owner == other.Owner ||
                    Owner != null &&
                    Owner.Equals(other.Owner)
                ) && 
                (
                    NotificationIndex == other.NotificationIndex ||
                    NotificationIndex != null &&
                    NotificationIndex.Equals(other.NotificationIndex)
                ) && 
                (
                    TimeStart == other.TimeStart ||
                    TimeStart != null &&
                    TimeStart.SequenceEqual(other.TimeStart)
                ) && 
                (
                    TimeEnd == other.TimeEnd ||
                    TimeEnd != null &&
                    TimeEnd.SequenceEqual(other.TimeEnd)
                ) && 
                (
                    Version == other.Version ||
                    Version != null &&
                    Version.Equals(other.Version)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Callbacks != null)
                    hashCode = hashCode * 59 + Callbacks.GetHashCode();
                    if (Owner != null)
                    hashCode = hashCode * 59 + Owner.GetHashCode();
                    if (NotificationIndex != null)
                    hashCode = hashCode * 59 + NotificationIndex.GetHashCode();
                    if (TimeStart != null)
                    hashCode = hashCode * 59 + TimeStart.GetHashCode();
                    if (TimeEnd != null)
                    hashCode = hashCode * 59 + TimeEnd.GetHashCode();
                    if (Version != null)
                    hashCode = hashCode * 59 + Version.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Subscription left, Subscription right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Subscription left, Subscription right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
