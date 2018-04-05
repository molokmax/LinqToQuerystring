﻿namespace LinqToQuerystring.TreeNodes.DataTypes
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;

    using Antlr.Runtime;

    using LinqToQuerystring.TreeNodes.Base;

    public class TimeNode : TreeNode {
        public TimeNode(Type inputType, IToken payload, TreeNodeFactory treeNodeFactory)
            : base(inputType, payload, treeNodeFactory) {
        }

        public override Expression BuildLinqExpression(IQueryable query, Expression expression, Expression item = null) {
            var timeText = this.Text
                .Replace("time'", string.Empty)
                .Replace("'", string.Empty);

            return Expression.Constant(TimeSpan.Parse(timeText));
        }
    }
}