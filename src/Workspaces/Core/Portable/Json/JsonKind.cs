﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis.Json
{
    internal enum JsonKind
    {
        None,
        Sequence,
        CompilationUnit,
        Text,
        Object,
        Array,
        Literal,
        NegativeLiteral,
        Property,
        EmptyValue,

        // Tokens
        EndOfFile,
        OpenBraceToken,
        CloseBraceToken,
        OpenBracketToken,
        CloseBracketToken,
        StringToken,
        NumberToken,
        TextToken,
        ColonToken,
        CommaToken,
        TrueLiteralToken,
        FalseLiteralToken,
        NullLiteralToken,
        UndefinedLiteralToken,
        NaNLiteralToken,
        InfinityLiteralToken,
        NegativeInfinityLiteralToken,
        MinusToken,

        // Trivia
        SingleLineCommentTrivia,
        MultiLineCommentTrivia,
        WhitespaceTrivia,
        EndOfLineTrivia,
    }
}
