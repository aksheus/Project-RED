﻿// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AzureServicesForUnity.QueryHelpers.OData
{
    internal enum QueryTokenKind
    {
        Unknown,
        End,
        Identifier,
        StringLiteral,
        IntegerLiteral,
        RealLiteral,
        Not,
        Modulo,
        OpenParen,
        CloseParen,
        Multiply,
        Add,
        Sub,
        Comma,
        Minus,
        Dot,
        Divide,
        LessThan,
        Equal,
        GreaterThan,
        NotEqual,
        And,
        LessThanEqual,
        GreaterThanEqual,
        Or
    }
}
