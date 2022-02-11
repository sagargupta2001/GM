namespace Grams.Code_Analysis.Binding
{
    internal enum BoundNodeKind
    {
        // Statements
        BlockStatement,
        VariableDeclaration,
        IfStatement,
        WhileStatement,
        ForStatement,
        LabelStatement,
        GotoStatement,
        ConditionalGotoStatement,
        ExpressionStatement,

        // Expressions
        LiteralExpression,
        VariableExpression,
        AssignmentExpression,
        UnaryExpression,
        BinaryExpression,

    }

}
