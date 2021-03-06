﻿//-----------------------------------------------------------------------
// <copyright file="NotInitializedException.cs" company="Segment">
//     Copyright (c) Segment. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Segment.Exception
{
    public class NotInitializedException : System.Exception
    {
        public NotInitializedException() : base("Please initialize Segment.io first before using.")
        {
        }
    }
}
