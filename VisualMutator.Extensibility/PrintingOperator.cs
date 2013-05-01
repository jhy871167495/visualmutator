﻿namespace VisualMutator.Extensibility
{
    public class PrintingOperator : IMutationOperator
    {
        public OperatorInfo Info { get {return new OperatorInfo("P", "Printing Operator", "");} }

        private readonly DebugOperatorCodeVisitor visitor = new DebugOperatorCodeVisitor();

        public IOperatorCodeVisitor FindTargets()
        {
            return visitor;
        }

        public IOperatorCodeRewriter Mutate()
        {
            return new OperatorCodeRewriter();
        }

        public string GetInfo()
        {
            return visitor.ToString();
        }

    }
}