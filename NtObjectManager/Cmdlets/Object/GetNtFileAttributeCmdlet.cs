﻿//  Copyright 2020 Google Inc. All Rights Reserved.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

using NtApiDotNet;
using System.Management.Automation;

namespace NtObjectManager.Cmdlets.Object
{
    /// <summary>
    /// <para type="synopsis">Get the file attributes for a file.</para>
    /// <para type="description">This cmdlet gets the file attributes for a file.</para>
    /// </summary>
    /// <example>
    ///   <code>Get-NtFileAttribute -File $f</code>
    ///   <para>Get the file attributes for the file.</para>
    /// </example>
    [Cmdlet(VerbsCommon.Set, "NtFileReparsePoint", DefaultParameterSetName = "Default")]
    public class GetNtFileAttributeCmdlet : BaseNtFilePropertyCmdlet
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public GetNtFileAttributeCmdlet() 
            : base(FileAccessRights.ReadAttributes, FileShareMode.None, FileOpenOptions.None)
        {
        }

        private protected override void HandleFile(NtFile file)
        {
            WriteObject(file.FileAttributes);
        }
    }
}
