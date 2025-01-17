﻿using Antlr4.Runtime;
using Rubberduck.Parsing.Symbols;

namespace Rubberduck.Parsing.Binding
{
    public interface IBindingContext
    {
        IBoundExpression Resolve(
            Declaration module, 
            Declaration parent, 
            ParserRuleContext expression,
            IBoundExpression withBlockVariable, 
            StatementResolutionContext statementContext,
            bool requiresLetCoercion = false, 
            bool isLetAssignment = false);
        IExpressionBinding BuildTree(
            Declaration module, 
            Declaration parent, 
            ParserRuleContext expression,
            IBoundExpression withBlockVariable, 
            StatementResolutionContext statementContext,
            bool requiresLetCoercion = false, 
            bool isLetAssignment = false);
    }
}
