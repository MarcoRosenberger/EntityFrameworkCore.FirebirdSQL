/*                 
 *     EntityFrameworkCore.FirebirdSqlSQL  - Congratulations EFCore Team
 *              https://www.FirebirdSqlsql.org/en/net-provider/ 
 *     Permission to use, copy, modify, and distribute this software and its
 *     documentation for any purpose, without fee, and without a written
 *     agreement is hereby granted, provided that the above copyright notice
 *     and this paragraph and the following two paragraphs appear in all copies. 
 * 
 *     The contents of this file are subject to the Initial
 *     Developer's Public License Version 1.0 (the "License");
 *     you may not use this file except in compliance with the
 *     License. You may obtain a copy of the License at
 *     http://www.FirebirdSqlsql.org/index.php?op=doc&id=idpl
 *
 *     Software distributed under the License is distributed on
 *     an "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, either
 *     express or implied.  See the License for the specific
 *     language governing rights and limitations under the License.
 *
 *              Copyright (c) 2017 Rafael Almeida
 *         Made In Sergipe-Brasil - ralms@ralms.net 
 *                  All Rights Reserved.
 */


using System;
using System.Data;
using System.Data.Common;
using JetBrains.Annotations;
using System.Collections.Concurrent;
using FirebirdSql.Data.FirebirdClient;

namespace Microsoft.EntityFrameworkCore.Storage.Internal
{
    public class FirebirdSqlStringTypeMapping : StringTypeMapping
    {
        readonly FbDbType _fbDbType;

        public FirebirdSqlStringTypeMapping(string storeType, FbDbType fbDbType)
            : base(storeType)
        {
            _fbDbType = fbDbType;
        }

        protected override void ConfigureParameter([NotNull] DbParameter parameter)
            => ((FbParameter)parameter).FbDbType = _fbDbType;
    }
 
}
