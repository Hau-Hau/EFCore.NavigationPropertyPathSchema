﻿using System.Diagnostics.CodeAnalysis;

namespace EFCore.QueryIncludeSchema.Interfaces
{
    public interface ISchemaExecutable<TEntity>
        where TEntity : class
    {
        IQueryable<TEntity> Execute(IncludePropertyPath<TEntity>? includePropertyPath = null);
    }
}
