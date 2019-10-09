// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using zAppDev.DotNet.Framework.Linq;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Workflow;
using zAppDev.DotNet.Framework.Identity.Model;

namespace DSS5_SupplyChainFinancialsOptimisation.BO
{
    /// <summary>
    /// The TurnoverStatistic class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class TurnoverStatistic : IDomainModelClass
    {
        #region TurnoverStatistic's Fields

        protected Guid _transientId= Guid.NewGuid();
        public virtual Guid TransientId
        {
            get
            {
                return _transientId;
            }
            set
            {
                _transientId = value;
            }
        }
        [DataMember(Name="Id")]
        protected int? id = 0;
        [DataMember(Name="TotalAmount")]
        protected decimal? totalAmount;
        [DataMember(Name="Year")]
        protected int? year;
        [DataMember(Name="Month")]
        protected int? month;
        [DataMember(Name="TotalAmountFunded")]
        protected decimal? totalAmountFunded;
        [DataMember(Name="TotalTransactions")]
        protected int? totalTransactions;
        [DataMember(Name="TotalCreditNotes")]
        protected int? totalCreditNotes;
        [DataMember(Name="CNAmount")]
        protected decimal? cNAmount;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region TurnoverStatistic's Properties
/// <summary>
/// The Id property
///
/// </summary>
///
        [Key]
        public virtual int? Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
/// <summary>
/// The TotalAmount property
///
/// </summary>
///
        public virtual decimal? TotalAmount
        {
            get
            {
                return totalAmount;
            }
            set
            {
                totalAmount = value;
            }
        }
/// <summary>
/// The Year property
///
/// </summary>
///
        public virtual int? Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
/// <summary>
/// The Month property
///
/// </summary>
///
        public virtual int? Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }
/// <summary>
/// The TotalAmountFunded property
///
/// </summary>
///
        public virtual decimal? TotalAmountFunded
        {
            get
            {
                return totalAmountFunded;
            }
            set
            {
                totalAmountFunded = value;
            }
        }
/// <summary>
/// The TotalTransactions property
///
/// </summary>
///
        public virtual int? TotalTransactions
        {
            get
            {
                return totalTransactions;
            }
            set
            {
                totalTransactions = value;
            }
        }
/// <summary>
/// The TotalCreditNotes property
///
/// </summary>
///
        public virtual int? TotalCreditNotes
        {
            get
            {
                return totalCreditNotes;
            }
            set
            {
                totalCreditNotes = value;
            }
        }
/// <summary>
/// The CNAmount property
///
/// </summary>
///
        public virtual decimal? CNAmount
        {
            get
            {
                return cNAmount;
            }
            set
            {
                cNAmount = value;
            }
        }
/// <summary>
/// The VersionTimestamp property
///Provides concurrency control for the class
/// </summary>
///
        public virtual byte[] VersionTimestamp
        {
            get
            {
                return versionTimestamp;
            }
            set
            {
                versionTimestamp = value;
            }
        }
        #endregion
        #region TurnoverStatistic's Participant Properties
        [DataMember(Name="Supplier")]
        protected Supplier supplier;
        public virtual Supplier Supplier
        {
            get
            {
                return supplier;
            }
            set
            {
                if(Equals(supplier, value)) return;
                var __oldValue = supplier;
                if (value != null)
                {
                    supplier = value;
                }
                else
                {
                    if (supplier != null)
                    {
                        supplier = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the TurnoverStatistic class
/// </summary>
/// <returns>New TurnoverStatistic object</returns>
/// <remarks></remarks>
        public TurnoverStatistic() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'TurnoverStatistic' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (Id?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TotalAmount?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Year?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Month?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TotalAmountFunded?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TotalTransactions?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TotalCreditNotes?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (CNAmount?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [TurnoverStatistic] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual TurnoverStatistic Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, TurnoverStatistic copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (TurnoverStatistic)copiedObjects[this];
            copy = copy ?? new TurnoverStatistic();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.TotalAmount = this.TotalAmount;
            copy.Year = this.Year;
            copy.Month = this.Month;
            copy.TotalAmountFunded = this.TotalAmountFunded;
            copy.TotalTransactions = this.TotalTransactions;
            copy.TotalCreditNotes = this.TotalCreditNotes;
            copy.CNAmount = this.CNAmount;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.supplier != null)
            {
                if (!copiedObjects.Contains(this.supplier))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Supplier = this.Supplier;
                    else if (asNew)
                        copy.Supplier = this.Supplier.Copy(deep, copiedObjects, true);
                    else
                        copy.supplier = this.supplier.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Supplier = (Supplier)copiedObjects[this.Supplier];
                    else
                        copy.supplier = (Supplier)copiedObjects[this.Supplier];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as TurnoverStatistic;
            if (ReferenceEquals(this, compareTo))
            {
                return true;
            }
            if (compareTo == null || !this.GetType().Equals(compareTo.GetTypeUnproxied()))
            {
                return false;
            }
            if (this.HasSameNonDefaultIdAs(compareTo))
            {
                return true;
            }
            // Since the Ids aren't the same, both of them must be transient to
            // compare domain signatures; because if one is transient and the
            // other is a persisted entity, then they cannot be the same object.
            return this.IsTransient() && compareTo.IsTransient() && (base.Equals(compareTo) || this.TransientId.Equals(compareTo.TransientId));
        }

// Maintain equality operator semantics for entities.
        public static bool operator ==(TurnoverStatistic x, TurnoverStatistic y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(TurnoverStatistic x, TurnoverStatistic y)
        {
            return !(x == y);
        }

        private PropertyInfo __propertyKeyCache;
        public virtual PropertyInfo GetPrimaryKey()
        {
            if (__propertyKeyCache == null)
            {
                __propertyKeyCache = this.GetType().GetProperty("Id");
            }
            return __propertyKeyCache;
        }


/// <summary>
///     To help ensure hashcode uniqueness, a carefully selected random number multiplier
///     is used within the calculation.  Goodrich and Tamassia's Data Structures and
///     Algorithms in Java asserts that 31, 33, 37, 39 and 41 will produce the fewest number
///     of collissions.  See http://computinglife.wordpress.com/2008/11/20/why-do-hash-functions-use-prime-numbers/
///     for more information.
/// </summary>
        private const int HashMultiplier = 31;
        private int? cachedHashcode;

        public override int GetHashCode()
        {
            if (this.cachedHashcode.HasValue)
            {
                return this.cachedHashcode.Value;
            }
            if (this.IsTransient())
            {
                //this.cachedHashcode = base.GetHashCode();
                return this.TransientId.GetHashCode(); //don't cache because this won't stay transient forever
            }
            else
            {
                unchecked
                {
                    // It's possible for two objects to return the same hash code based on
                    // identically valued properties, even if they're of two different types,
                    // so we include the object's type in the hash calculation
                    var hashCode = this.GetType().GetHashCode();
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.Id.GetHashCode();
                }
            }
            return this.cachedHashcode.Value;
        }

/// <summary>
///     Transient objects are not associated with an item already in storage.  For instance,
///     a Customer is transient if its Id is 0.  It's virtual to allow NHibernate-backed
///     objects to be lazily loaded.
/// </summary>
        public virtual bool IsTransient()
        {
            return this.Id == default(int) || this.Id.Equals(default(int));
        }

/// <summary>
///     When NHibernate proxies objects, it masks the type of the actual entity object.
///     This wrapper burrows into the proxied object to get its actual type.
///
///     Although this assumes NHibernate is being used, it doesn't require any NHibernate
///     related dependencies and has no bad side effects if NHibernate isn't being used.
///
///     Related discussion is at http://groups.google.com/group/sharp-architecture/browse_thread/thread/ddd05f9baede023a ...thanks Jay Oliver!
/// </summary>
        protected virtual System.Type GetTypeUnproxied()
        {
            return this.GetType();
        }

/// <summary>
///     Returns true if self and the provided entity have the same Id values
///     and the Ids are not of the default Id value
/// </summary>
        protected bool HasSameNonDefaultIdAs(TurnoverStatistic compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion


    }
}