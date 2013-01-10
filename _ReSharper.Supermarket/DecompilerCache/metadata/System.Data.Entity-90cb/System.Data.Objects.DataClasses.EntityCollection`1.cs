// Type: System.Data.Objects.DataClasses.EntityCollection`1
// Assembly: System.Data.Entity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\System.Data.Entity.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Objects;
using System.Data.Objects.Internal;
using System.Runtime;
using System.Runtime.Serialization;

namespace System.Data.Objects.DataClasses
{
    /// <summary>
    /// Represents a collection of objects on the "many" end of a relationship.
    /// </summary>
    /// <typeparam name="TEntity">The entity type of the collection.</typeparam>
    [Serializable]
    public sealed class EntityCollection<TEntity> : RelatedEnd, ICollection<TEntity>, IEnumerable<TEntity>, IEnumerable,
                                                    IListSource where TEntity : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Data.Objects.DataClasses.EntityCollection`1"/> class.
        /// </summary>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public EntityCollection();

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        internal EntityCollection(IEntityWrapper wrappedOwner, RelationshipNavigation navigation,
                                  IRelationshipFixer relationshipFixer);

        internal int CountInternal { get; }

        #region ICollection<TEntity> Members

        /// <summary>
        /// Adds an object to the collection.
        /// </summary>
        /// <param name="entity">An object to add to the collection. <paramref name="entity"/> must implement <see cref="T:System.Data.Objects.DataClasses.IEntityWithRelationships"/>.</param><exception cref="T:System.ArgumentNullException"><paramref name="entity "/>is null.</exception>
        public void Add(TEntity entity);

        /// <summary>
        /// Removes an object from the collection and marks the relationship for deletion.
        /// </summary>
        /// 
        /// <returns>
        /// true if item was successfully removed; otherwise, false.
        /// </returns>
        /// <param name="entity">The object to remove from the collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="entity"/> object is null.</exception><exception cref="T:System.InvalidOperationException">The<paramref name=" entity "/>object is not attached to the same object context.-or-The <paramref name="entity "/>object does not have a valid relationship manager.</exception>
        public bool Remove(TEntity entity);

        /// <summary>
        /// Returns an enumerator that is used to iterate through the objects in the collection.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator"/> that iterates through the set of values cached by <see cref="T:System.Data.Objects.DataClasses.EntityCollection`1"/>.
        /// </returns>
        public new IEnumerator<TEntity> GetEnumerator();

        /// <summary>
        /// Returns an enumerator that is used to iterate through the set of values cached by <see cref="T:System.Data.Objects.DataClasses.EntityCollection`1"/>.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator"/> that iterates through the set of values cached by <see cref="T:System.Data.Objects.DataClasses.EntityCollection`1"/>.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator();

        /// <summary>
        /// Removes all entities from the collection.
        /// </summary>
        public void Clear();

        /// <summary>
        /// Determines whether a specific object exists in the collection.
        /// </summary>
        /// 
        /// <returns>
        /// true if the object is found in the <see cref="T:System.Data.Objects.DataClasses.EntityCollection`1"/>; otherwise, false.
        /// </returns>
        /// <param name="entity">The object to locate in the <see cref="T:System.Data.Objects.DataClasses.EntityCollection`1"/>.</param>
        public bool Contains(TEntity entity);

        /// <summary>
        /// Copies all the contents of the collection to an array, starting at the specified index of the target array.
        /// </summary>
        /// <param name="array">The array to copy to.</param><param name="arrayIndex">The zero-based index in the array at which copying begins.</param>
        public void CopyTo(TEntity[] array, int arrayIndex);

        /// <summary>
        /// Gets the number of objects that are contained in the collection.
        /// </summary>
        /// 
        /// <returns>
        /// The number of elements that are contained in the <see cref="T:System.Data.Objects.DataClasses.EntityCollection`1"/>.
        /// </returns>
        public int Count { get; }

        /// <summary>
        /// Gets a value that indicates whether the <see cref="T:System.Data.Objects.DataClasses.EntityCollection`1"/> is read-only.
        /// </summary>
        /// 
        /// <returns>
        /// Always returns false.
        /// </returns>
        public bool IsReadOnly { get; }

        #endregion

        #region IListSource Members

        /// <summary>
        /// Returns the collection as an <see cref="T:System.Collections.IList"/> used for data binding.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Collections.IList"/> of entity objects.
        /// </returns>
        IList IListSource.GetList();

        /// <summary>
        /// Gets a value that indicates whether the related entity collection consists of collection objects.
        /// </summary>
        /// 
        /// <returns>
        /// This property always returns false because the <see cref="T:System.Data.Objects.DataClasses.EntityCollection`1"/> contains objects and not collections.
        /// </returns>
        bool IListSource.ContainsListCollection { get; }

        #endregion

        internal override void OnAssociationChanged(CollectionChangeAction collectionChangeAction, object entity);

        /// <summary>
        /// Loads related objects into the collection, using the specified merge option.
        /// </summary>
        /// <param name="mergeOption">Specifies how the objects in this collection should be merged with the objects that might have been returned from previous queries against the same <see cref="T:System.Data.Objects.ObjectContext"/>.</param>
        public override void Load(MergeOption mergeOption);

        /// <summary>
        /// Defines relationships between an object and a collection of related objects in an object context.
        /// </summary>
        /// <param name="entities">Collection of objects in the object context that are related to the source object.</param><exception cref="T:System.ArgumentNullException"><paramref name="entities"/> collection is null.</exception><exception cref="T:System.InvalidOperationException">The source object or an object in the <paramref name="entities"/> collection is null or is not in an <see cref="F:System.Data.EntityState.Unchanged"/> or <see cref="F:System.Data.EntityState.Modified"/> state.-or-The relationship cannot be defined based on the EDM metadata. This can occur when the association in the conceptual schema does not support a relationship between the two types.</exception>
        public void Attach(IEnumerable<TEntity> entities);

        /// <summary>
        /// Defines a relationship between two attached objects in an object context.
        /// </summary>
        /// <param name="entity">The object being attached.</param><exception cref="T:System.ArgumentNullException">When the <paramref name="entity"/> is null.</exception><exception cref="T:System.InvalidOperationException">When the <paramref name="entity"/> cannot be related to the source object. This can occur when the association in the conceptual schema does not support a relationship between the two types.-or-When either object is null or is not in an <see cref="F:System.Data.EntityState.Unchanged"/> or <see cref="F:System.Data.EntityState.Modified"/> state.</exception>
        public void Attach(TEntity entity);

        internal void Load(List<IEntityWrapper> collection, MergeOption mergeOption);

        internal override void DisconnectedAdd(IEntityWrapper wrappedEntity);
        internal override bool DisconnectedRemove(IEntityWrapper wrappedEntity);

        internal bool RemoveInternal(TEntity entity);
        internal override void Include(bool addRelationshipAsUnchanged, bool doAttach);
        internal override void Exclude();

        internal override void ClearCollectionOrRef(IEntityWrapper wrappedEntity, RelationshipNavigation navigation,
                                                    bool doCascadeDelete);

        internal override void ClearWrappedValues();
        internal override bool VerifyEntityForAdd(IEntityWrapper wrappedEntity, bool relationshipAlreadyExists);
        internal override bool CanSetEntityType(IEntityWrapper wrappedEntity);
        internal override void VerifyType(IEntityWrapper wrappedEntity);

        internal override bool RemoveFromLocalCache(IEntityWrapper wrappedEntity, bool resetIsLoaded,
                                                    bool preserveForeignKey);

        internal override bool RemoveFromObjectCache(IEntityWrapper wrappedEntity);

        internal override void RetrieveReferentialConstraintProperties(
            Dictionary<string, KeyValuePair<object, IntBox>> properties, HashSet<object> visited);

        internal override bool IsEmpty();
        internal override void VerifyMultiplicityConstraintsForAdd(bool applyConstraints);
        internal override void OnRelatedEndClear();
        internal override bool ContainsEntity(IEntityWrapper wrappedEntity);

        internal override IEnumerable GetInternalEnumerable();
        internal override IEnumerable<IEntityWrapper> GetWrappedEntities();

        internal override void BulkDeleteAll(List<object> list);
        internal override bool CheckIfNavigationPropertyContainsEntity(IEntityWrapper wrapper);
        internal override void VerifyNavigationPropertyForAdd(IEntityWrapper wrapper);

        /// <summary>
        /// Used internally to serialize entity objects.
        /// </summary>
        /// <param name="context">The streaming context.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [OnSerializing]
        [Browsable(false)]
        public void OnSerializing(StreamingContext context);

        /// <summary>
        /// Used internally to deserialize entity objects.
        /// </summary>
        /// <param name="context">The streaming context.</param>
        [Browsable(false)]
        [OnDeserialized]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void OnCollectionDeserialized(StreamingContext context);

        /// <summary>
        /// Returns an object query that, when it is executed, returns the same set of objects that exists in the current collection.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Data.Objects.ObjectQuery`1"/> that represents the entity collection.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">When the object is in an <see cref="F:System.Data.EntityState.Added"/> state.-or-When the object is in a <see cref="F:System.Data.EntityState.Detached"/> state with a <see cref="T:System.Data.Objects.MergeOption"/> other than <see cref="F:System.Data.Objects.MergeOption.NoTracking"/>.</exception>
        public ObjectQuery<TEntity> CreateSourceQuery();

        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        internal override IEnumerable CreateSourceQueryInternal();

        internal override void AddToLocalCache(IEntityWrapper wrappedEntity, bool applyConstraints);
        internal override void AddToObjectCache(IEntityWrapper wrappedEntity);

        internal override event CollectionChangeEventHandler AssociationChangedForObjectView;
    }
}
