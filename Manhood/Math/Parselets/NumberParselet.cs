﻿using System;

namespace Manhood.Parselets
{
    internal class NumberParselet : IPrefixParselet
    {
        public Expression Parse(Parser parser, Token token)
        {
            return new NumberExpression(Double.Parse(token.Text));
        }
    }
}