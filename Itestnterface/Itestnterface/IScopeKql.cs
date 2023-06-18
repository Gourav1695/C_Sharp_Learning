// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IScopeKql.cs" company="Microsoft">
// Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------------------------------------------

namespace Microsoft.SubstrateSearch.Context
{
    /// <summary>
    /// Represents a scope-based KQL query.
    /// </summary>
    public interface IScopeKql
    {
        /// <summary>
        /// Gets the entity types requested by the user based on query understanding.
        /// </summary>
        /// <returns>A list of entity types.</returns>
        List<EntityTypes> GetEntityTypesRequested();

        /// <summary>
        /// Gets the scoped query annotations in the query.
        /// </summary>
        /// <returns>A dictionary where the keys are keyword types and the values are query annotations.</returns>
        Dictionary<KeywordType, QueryAnnotation> GetScopesInQuery();

        /// <summary>
        /// Gets the query keyword extracted from the query.
        /// </summary>
        /// <returns>The query keyword.</returns>
        string GetQueryKeyword();

        /// <summary>
        /// Determines whether a scope-based KQL query was recognized in the query.
        /// </summary>
        /// <returns><c>true</c> if a scope-based KQL query was recognized; otherwise, <c>false</c>.</returns>
        bool GetIsScopeKqlQuery();
    }
}


