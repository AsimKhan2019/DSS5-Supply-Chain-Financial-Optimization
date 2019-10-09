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
    /// The CommercialAgreement class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class CommercialAgreement : IDomainModelClass
    {
        #region CommercialAgreement's Fields

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
        [DataMember(Name="ProductCategory")]
        protected string productCategory;
        [DataMember(Name="PaymentTerms")]
        protected string paymentTerms;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

#pragma warning disable 0649
        private bool disableInternalAdditions;
#pragma warning restore 0649
        #endregion
        #region CommercialAgreement's Properties
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
/// The ProductCategory property
///
/// </summary>
///
        public virtual string ProductCategory
        {
            get
            {
                return productCategory;
            }
            set
            {
                productCategory = value;
            }
        }
/// <summary>
/// The PaymentTerms property
///
/// </summary>
///
        public virtual string PaymentTerms
        {
            get
            {
                return paymentTerms;
            }
            set
            {
                paymentTerms = value;
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
        #region CommercialAgreement's Participant Properties
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
                supplier?.InternalRemoveCommercialAgreements(this);
                supplier = value;
                if (value != null)
                {
                    supplier.InternalAddCommercialAgreements(this);
                }
            }
        }
        [DataMember(Name="Buyer")]
        protected Buyer buyer;
        public virtual Buyer Buyer
        {
            get
            {
                return buyer;
            }
            set
            {
                if(Equals(buyer, value)) return;
                var __oldValue = buyer;
                buyer?.InternalRemoveCommercialAgreements(this);
                buyer = value;
                if (value != null)
                {
                    buyer.InternalAddCommercialAgreements(this);
                }
            }
        }
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
            if (__item.CommercialAgreement != this)
                __item.CommercialAgreement = this;
        }

        public virtual void AddAtIndexOrders(int index, Order __item)
        {
            if (__item == null) return;
            orders?.Insert(index, __item);
            disableInternalAdditions = true;
            try
            {
                if (__item.CommercialAgreement != this)
                    __item.CommercialAgreement = this;
            }
            finally
            {
                disableInternalAdditions = false;
            }
        }

        public virtual void RemoveOrders(Order __item)
        {
            if (__item != null)
            {
                __item.CommercialAgreement = null;
            }
        }
        public virtual void SetOrdersAt(Order __item, int __index)
        {
            if (__item == null)
            {
                orders[__index].CommercialAgreement = null;
            }
            else
            {
                orders[__index] = __item;
                if (__item.CommercialAgreement != this)
                    __item.CommercialAgreement = this;
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
        [DataMember(Name="ImportedBuyer")]
        protected ImportedBuyer importedBuyer;
        public virtual ImportedBuyer ImportedBuyer
        {
            get
            {
                return importedBuyer;
            }
            set
            {
                if(Equals(importedBuyer, value)) return;
                var __oldValue = importedBuyer;
                importedBuyer?.InternalRemoveCommercialAgreement(this);
                importedBuyer = value;
                if (value != null)
                {
                    importedBuyer.InternalAddCommercialAgreement(this);
                }
            }
        }
        [DataMember(Name="Transactions")]
        protected IList<Transaction> transactions = new List<Transaction>();
        public virtual List<Transaction> Transactions
        {
            get
            {
                if (transactions is Transaction[])
                {
                    transactions = transactions.ToList();
                }
                if (transactions == null)
                {
                    transactions = new List<Transaction>();
                }
                return transactions.ToList();
            }
            set
            {
                if (transactions is Transaction[])
                {
                    transactions = transactions.ToList();
                }
                if (transactions != null)
                {
                    var __itemsToDelete = new List<Transaction>(transactions);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveTransactions(__item);
                    }
                }
                if(value == null)
                {
                    transactions = new List<Transaction>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddTransactions(__item);
                }
            }
        }
        public virtual void AddTransactions(IList<Transaction> __items)
        {
            foreach (var __item in __items)
            {
                AddTransactions(__item);
            }
        }

        public virtual void InternalAddTransactions(Transaction __item)
        {
            if (__item == null || disableInternalAdditions) return;
            transactions?.Add(__item);
        }

        public virtual void InternalRemoveTransactions(Transaction __item)
        {
            if (__item == null) return;
            transactions?.Remove(__item);
        }

        public virtual void AddTransactions(Transaction __item)
        {
            if (__item == null) return;
            if (__item.CommercialAgreement != this)
                __item.CommercialAgreement = this;
        }

        public virtual void AddAtIndexTransactions(int index, Transaction __item)
        {
            if (__item == null) return;
            transactions?.Insert(index, __item);
            disableInternalAdditions = true;
            try
            {
                if (__item.CommercialAgreement != this)
                    __item.CommercialAgreement = this;
            }
            finally
            {
                disableInternalAdditions = false;
            }
        }

        public virtual void RemoveTransactions(Transaction __item)
        {
            if (__item != null)
            {
                __item.CommercialAgreement = null;
            }
        }
        public virtual void SetTransactionsAt(Transaction __item, int __index)
        {
            if (__item == null)
            {
                transactions[__index].CommercialAgreement = null;
            }
            else
            {
                transactions[__index] = __item;
                if (__item.CommercialAgreement != this)
                    __item.CommercialAgreement = this;
            }
        }

        public virtual void ClearTransactions()
        {
            if (transactions!=null)
            {
                var __itemsToRemove = transactions.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveTransactions(__item);
                }
            }
        }
        [DataMember(Name="Agreement")]
        protected Agreement agreement;
        public virtual Agreement Agreement
        {
            get
            {
                return agreement;
            }
            set
            {
                if(Equals(agreement, value)) return;
                var __oldValue = agreement;
                agreement?.InternalRemoveCommercialAgreements(this);
                agreement = value;
                if (value != null)
                {
                    agreement.InternalAddCommercialAgreements(this);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the CommercialAgreement class
/// </summary>
/// <returns>New CommercialAgreement object</returns>
/// <remarks></remarks>
        public CommercialAgreement() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (ProductCategory != null && ProductCategory.Length > 100)
            {
                __errors.Add("Length of property 'ProductCategory' cannot be greater than 100.");
            }
            if (PaymentTerms != null && PaymentTerms.Length > 100)
            {
                __errors.Add("Length of property 'PaymentTerms' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'CommercialAgreement' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (Id?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (ProductCategory?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (PaymentTerms?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [CommercialAgreement] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual CommercialAgreement Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, CommercialAgreement copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (CommercialAgreement)copiedObjects[this];
            copy = copy ?? new CommercialAgreement();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.ProductCategory = this.ProductCategory;
            copy.PaymentTerms = this.PaymentTerms;
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
            if(deep && this.buyer != null)
            {
                if (!copiedObjects.Contains(this.buyer))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Buyer = this.Buyer;
                    else if (asNew)
                        copy.Buyer = this.Buyer.Copy(deep, copiedObjects, true);
                    else
                        copy.buyer = this.buyer.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Buyer = (Buyer)copiedObjects[this.Buyer];
                    else
                        copy.buyer = (Buyer)copiedObjects[this.Buyer];
                }
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
            if(deep && this.importedBuyer != null)
            {
                if (!copiedObjects.Contains(this.importedBuyer))
                {
                    if (asNew && reuseNestedObjects)
                        copy.ImportedBuyer = this.ImportedBuyer;
                    else if (asNew)
                        copy.ImportedBuyer = this.ImportedBuyer.Copy(deep, copiedObjects, true);
                    else
                        copy.importedBuyer = this.importedBuyer.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.ImportedBuyer = (ImportedBuyer)copiedObjects[this.ImportedBuyer];
                    else
                        copy.importedBuyer = (ImportedBuyer)copiedObjects[this.ImportedBuyer];
                }
            }
            copy.transactions = new List<Transaction>();
            if(deep && this.transactions != null)
            {
                foreach (var __item in this.transactions)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddTransactions(__item);
                        else
                            copy.AddTransactions(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddTransactions((Transaction)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.agreement != null)
            {
                if (!copiedObjects.Contains(this.agreement))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Agreement = this.Agreement;
                    else if (asNew)
                        copy.Agreement = this.Agreement.Copy(deep, copiedObjects, true);
                    else
                        copy.agreement = this.agreement.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Agreement = (Agreement)copiedObjects[this.Agreement];
                    else
                        copy.agreement = (Agreement)copiedObjects[this.Agreement];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as CommercialAgreement;
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
        public static bool operator ==(CommercialAgreement x, CommercialAgreement y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(CommercialAgreement x, CommercialAgreement y)
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
        protected bool HasSameNonDefaultIdAs(CommercialAgreement compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion


    }
}