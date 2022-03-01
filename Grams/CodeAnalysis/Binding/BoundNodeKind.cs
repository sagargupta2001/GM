﻿namespace Grams.Code_Analysis.Binding
{
    internal enum BoundNodeKind
    {
        // Statements
        BlockStatement,
        VariableDeclaration,
        IfStatement,
        WhileStatement,
        DoWhileStatement,
        ForStatement,
        LabelStatement,
        GotoStatement,
        ConditionalGotoStatement,
        ExpressionStatement,

        // Expressions
        ErrorExpression,
        LiteralExpression,
        VariableExpression,
        AssignmentExpression,
        UnaryExpression,
        BinaryExpression,
        CallExpression,
        ConversionExpression,

    }

}
