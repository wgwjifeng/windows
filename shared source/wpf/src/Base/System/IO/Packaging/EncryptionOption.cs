//-----------------------------------------------------------------------------
//
// <copyright file="EncryptionOption.cs" company="Microsoft">
//    Copyright (C) Microsoft Corporation.  All rights reserved.
// </copyright>
//
// Description:
//  EncryptionOption enumeration is used as an aggregate mechanism to give users controls 
//  over Encryption features within MMCF container. 
//
//-----------------------------------------------------------------------------

namespace System.IO.Packaging
{
    /// <summary>
    /// This class is used to control Encryption RM for package parts.  
    /// </summary>
    public enum EncryptionOption : int
    {
            /// <summary>
            /// Encryption is turned off in this mode. This is not supported.
            /// </summary>
            None = 0,

            /// <summary>
            /// RightsManagement is the only supported option right now.
            /// </summary>
            RightsManagement = 1,
    }
}
