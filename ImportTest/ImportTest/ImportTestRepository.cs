﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace ImportTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the ImportTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    [RepositoryFolder("b7ed5c1b-bdb1-44dd-addc-67d843b7bbd4")]
    public partial class ImportTestRepository : RepoGenBaseFolder
    {
        static ImportTestRepository instance = new ImportTestRepository();

        /// <summary>
        /// Gets the singleton class instance representing the ImportTestRepository element repository.
        /// </summary>
        [RepositoryFolder("b7ed5c1b-bdb1-44dd-addc-67d843b7bbd4")]
        public static ImportTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public ImportTestRepository() 
            : base("ImportTestRepository", "/", null, 0, false, "b7ed5c1b-bdb1-44dd-addc-67d843b7bbd4", ".\\RepositoryImages\\ImportTestRepositoryb7ed5c1b.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("b7ed5c1b-bdb1-44dd-addc-67d843b7bbd4")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    public partial class ImportTestRepositoryFolders
    {
    }
#pragma warning restore 0436
}