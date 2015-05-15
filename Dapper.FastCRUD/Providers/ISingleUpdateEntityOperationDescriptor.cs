﻿namespace Dapper.FastCrud.Providers
{
    using System;
    using System.Data;

    internal interface ISingleUpdateEntityOperationDescriptor<TEntity>:IOperationDescriptor<TEntity>
    {
        bool Execute(IDbConnection connection, TEntity keyEntity, IDbTransaction transaction = null, TimeSpan? commandTimeout = null);
    }
}