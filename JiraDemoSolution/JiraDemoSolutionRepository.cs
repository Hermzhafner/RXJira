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

namespace JiraDemoSolution
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the JiraDemoSolutionRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    [RepositoryFolder("07da7171-552f-4cfd-b435-69a3811e3e39")]
    public partial class JiraDemoSolutionRepository : RepoGenBaseFolder
    {
        static JiraDemoSolutionRepository instance = new JiraDemoSolutionRepository();

        /// <summary>
        /// Gets the singleton class instance representing the JiraDemoSolutionRepository element repository.
        /// </summary>
        [RepositoryFolder("07da7171-552f-4cfd-b435-69a3811e3e39")]
        public static JiraDemoSolutionRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public JiraDemoSolutionRepository() 
            : base("JiraDemoSolutionRepository", "/", null, 0, false, "07da7171-552f-4cfd-b435-69a3811e3e39", ".\\RepositoryImages\\JiraDemoSolutionRepository07da7171.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("07da7171-552f-4cfd-b435-69a3811e3e39")]
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
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    public partial class JiraDemoSolutionRepositoryFolders
    {
    }
#pragma warning restore 0436
}