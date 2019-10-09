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
    /// The CreditNote class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class CreditNote : IDomainModelClass
    {
        #region CreditNote's Fields

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
        [DataMember(Name="CreditNoteNumber")]
        protected string creditNoteNumber;
        [DataMember(Name="Description")]
        protected string description;
        [DataMember(Name="DateIssued")]
        protected DateTime? dateIssued;
        [DataMember(Name="Amount")]
        protected decimal? amount;
        [DataMember(Name="TotalPrice")]
        protected decimal? totalPrice;
        [DataMember(Name="CreditNoteDocument")]
        protected string creditNoteDocument;
        [DataMember(Name="CNoteAttachment")]
        protected string cNoteAttachment;
        [DataMember(Name="Status")]
        protected DSS5_SupplyChainFinancialsOptimisation.BO.Status? status;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

#pragma warning disable 0649
        private bool disableInternalAdditions;
#pragma warning restore 0649
        #endregion
        #region CreditNote's Properties
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
/// The CreditNoteNumber property
///
/// </summary>
///
        public virtual string CreditNoteNumber
        {
            get
            {
                return creditNoteNumber;
            }
            set
            {
                creditNoteNumber = value;
            }
        }
/// <summary>
/// The Description property
///
/// </summary>
///
        public virtual string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
/// <summary>
/// The DateIssued property
///
/// </summary>
///
        public virtual DateTime? DateIssued
        {
            get
            {
                return dateIssued;
            }
            set
            {
                dateIssued = value;
            }
        }
/// <summary>
/// The Amount property
///
/// </summary>
///
        public virtual decimal? Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
/// <summary>
/// The TotalPrice property
///
/// </summary>
///
        public virtual decimal? TotalPrice
        {
            get
            {
                return totalPrice;
            }
            set
            {
                totalPrice = value;
            }
        }
/// <summary>
/// The CreditNoteDocument property
///
/// </summary>
///
        public virtual string CreditNoteDocument
        {
            get
            {
                return creditNoteDocument;
            }
            set
            {
                creditNoteDocument = value;
            }
        }
/// <summary>
/// The CNoteAttachment property
///
/// </summary>
///
        public virtual string CNoteAttachment
        {
            get
            {
                return cNoteAttachment;
            }
            set
            {
                cNoteAttachment = value;
            }
        }
/// <summary>
/// The Status property
///
/// </summary>
///
        public virtual DSS5_SupplyChainFinancialsOptimisation.BO.Status? Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
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
        #region CreditNote's Participant Properties
        [DataMember(Name="Orders")]
        protected IList<Order> orders = new List<Order>();
        public virtual List<Order> Orders
        {
            get
            {
                if (orders is Order[])
                {
                    orders = orders.ToList();
                }
                if (orders == null)
                {
                    orders = new List<Order>();
                }
                return orders.ToList();
            }
            set
            {
                if (orders is Order[])
                {
                    orders = orders.ToList();
                }
                if (orders != null)
                {
                    var __itemsToDelete = new List<Order>(orders);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveOrders(__item);
                    }
                }
                if(value == null)
                {
                    orders = new List<Order>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddOrders(__item);
                }
            }
        }
        public virtual void AddOrders(IList<Order> __items)
        {
            foreach (var __item in __items)
            {
                AddOrders(__item);
            }
        }

        public virtual void InternalAddOrders(Order __item)
        {
            if (__item == null || disableInternalAdditions) return;
            orders?.Add(__item);
        }

        public virtual void InternalRemoveOrders(Order __item)
        {
            if (__item == null) return;
            orders?.Remove(__item);
        }

        public virtual void AddOrders(Order __item)
        {
            if (__item == null) return;
            if (!orders.Contains(__item))
                InternalAddOrders(__item);
            if (!__item.CreditNotes.Contains(this))
                __item.AddCreditNotes(this);
        }

        public virtual void AddAtIndexOrders(int index, Order __item)
        {
            if (__item == null) return;
            if (!orders.Contains(__item))
                orders.Insert(index, __item);
            if (!__item.CreditNotes.Contains(this))
                __item.AddCreditNotes(this);
        }

        public virtual void RemoveOrders(Order __item)
        {
            if (__item != null)
            {
                if (orders.Contains(__item))
                    InternalRemoveOrders(__item);
                if(__item.CreditNotes.Contains(this))
                    __item.RemoveCreditNotes(this);
            }
        }
        public virtual void SetOrdersAt(Order __item, int __index)
        {
            if (__item == null)
            {
                orders[__index].RemoveCreditNotes(this);
            }
            else
            {
                orders[__index] = __item;
                if (!__item.CreditNotes.Contains(this))
                    __item.AddCreditNotes(this);
            }
        }

        public virtual void ClearOrders()
        {
            if (orders!=null)
            {
                var __itemsToRemove = orders.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveOrders(__item);
                }
            }
        }
        [DataMember(Name="CreditNoteProducts")]
        protected IList<CreditNoteProduct> creditNoteProducts = new List<CreditNoteProduct>();
        public virtual List<CreditNoteProduct> CreditNoteProducts
        {
            get
            {
                if (creditNoteProducts is CreditNoteProduct[])
                {
                    creditNoteProducts = creditNoteProducts.ToList();
                }
                if (creditNoteProducts == null)
                {
                    creditNoteProducts = new List<CreditNoteProduct>();
                }
                return creditNoteProducts.ToList();
            }
            set
            {
                if (creditNoteProducts is CreditNoteProduct[])
                {
                    creditNoteProducts = creditNoteProducts.ToList();
                }
                if (creditNoteProducts != null)
                {
                    var __itemsToDelete = new List<CreditNoteProduct>(creditNoteProducts);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveCreditNoteProducts(__item);
                    }
                }
                if(value == null)
                {
                    creditNoteProducts = new List<CreditNoteProduct>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddCreditNoteProducts(__item);
                }
            }
        }
        public virtual void AddCreditNoteProducts(IList<CreditNoteProduct> __items)
        {
            foreach (var __item in __items)
            {
                AddCreditNoteProducts(__item);
            }
        }

        public virtual void InternalAddCreditNoteProducts(CreditNoteProduct __item)
        {
            if (__item == null || disableInternalAdditions) return;
            creditNoteProducts?.Add(__item);
        }

        public virtual void InternalRemoveCreditNoteProducts(CreditNoteProduct __item)
        {
            if (__item == null) return;
            creditNoteProducts?.Remove(__item);
        }

        public virtual void AddCreditNoteProducts(CreditNoteProduct __item)
        {
            if (__item == null) return;
            if (__item.CreditNote != this)
                __item.CreditNote = this;
        }

        public virtual void AddAtIndexCreditNoteProducts(int index, CreditNoteProduct __item)
        {
            if (__item == null) return;
            creditNoteProducts?.Insert(index, __item);
            disableInternalAdditions = true;
            try
            {
                if (__item.CreditNote != this)
                    __item.CreditNote = this;
            }
            finally
            {
                disableInternalAdditions = false;
            }
        }

        public virtual void RemoveCreditNoteProducts(CreditNoteProduct __item)
        {
            if (__item != null)
            {
                __item.CreditNote = null;
            }
        }
        public virtual void SetCreditNoteProductsAt(CreditNoteProduct __item, int __index)
        {
            if (__item == null)
            {
                creditNoteProducts[__index].CreditNote = null;
            }
            else
            {
                creditNoteProducts[__index] = __item;
                if (__item.CreditNote != this)
                    __item.CreditNote = this;
            }
        }

        public virtual void ClearCreditNoteProducts()
        {
            if (creditNoteProducts!=null)
            {
                var __itemsToRemove = creditNoteProducts.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveCreditNoteProducts(__item);
                }
            }
        }
        [DataMember(Name="Transaction")]
        protected Transaction transaction;
        public virtual Transaction Transaction
        {
            get
            {
                return transaction;
            }
            set
            {
                if(Equals(transaction, value)) return;
                var __oldValue = transaction;
                transaction?.InternalRemoveCreditNotes(this);
                transaction = value;
                if (value != null)
                {
                    transaction.InternalAddCreditNotes(this);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the CreditNote class
/// </summary>
/// <returns>New CreditNote object</returns>
/// <remarks></remarks>
        public CreditNote() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (CreditNoteNumber != null && CreditNoteNumber.Length > 100)
            {
                __errors.Add("Length of property 'CreditNoteNumber' cannot be greater than 100.");
            }
            if (Description != null && Description.Length > 100)
            {
                __errors.Add("Length of property 'Description' cannot be greater than 100.");
            }
            if (CreditNoteDocument != null && CreditNoteDocument.Length > 2147483647)
            {
                __errors.Add("Length of property 'CreditNoteDocument' cannot be greater than 2147483647.");
            }
            if (CNoteAttachment != null && CNoteAttachment.Length > 100)
            {
                __errors.Add("Length of property 'CNoteAttachment' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'CreditNote' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (Id?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (CreditNoteNumber?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Description?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DateIssued?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Amount?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TotalPrice?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (CreditNoteDocument?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (CNoteAttachment?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Status?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [CreditNote] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual CreditNote Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, CreditNote copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (CreditNote)copiedObjects[this];
            copy = copy ?? new CreditNote();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.CreditNoteNumber = this.CreditNoteNumber;
            copy.Description = this.Description;
            copy.DateIssued = this.DateIssued;
            copy.Amount = this.Amount;
            copy.TotalPrice = this.TotalPrice;
            copy.CreditNoteDocument = this.CreditNoteDocument;
            copy.CNoteAttachment = this.CNoteAttachment;
            copy.Status = this.Status;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.orders = new List<Order>();
            if(deep && this.orders != null)
            {
                foreach (var __item in this.orders)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddOrders(__item);
                        else
                            copy.AddOrders(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddOrders((Order)copiedObjects[__item]);
                    }
                }
            }
            copy.creditNoteProducts = new List<CreditNoteProduct>();
            if(deep && this.creditNoteProducts != null)
            {
                foreach (var __item in this.creditNoteProducts)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddCreditNoteProducts(__item);
                        else
                            copy.AddCreditNoteProducts(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddCreditNoteProducts((CreditNoteProduct)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.transaction != null)
            {
                if (!copiedObjects.Contains(this.transaction))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Transaction = this.Transaction;
                    else if (asNew)
                        copy.Transaction = this.Transaction.Copy(deep, copiedObjects, true);
                    else
                        copy.transaction = this.transaction.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Transaction = (Transaction)copiedObjects[this.Transaction];
                    else
                        copy.transaction = (Transaction)copiedObjects[this.Transaction];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as CreditNote;
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
        public static bool operator ==(CreditNote x, CreditNote y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(CreditNote x, CreditNote y)
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
        protected bool HasSameNonDefaultIdAs(CreditNote compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion


    }
}