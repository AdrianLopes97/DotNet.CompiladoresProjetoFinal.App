//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ./DotNet.CompiladoresProjetoFinal.App/ANTLR/VariableDeclaration.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IVariableDeclarationListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class VariableDeclarationBaseListener : IVariableDeclarationListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] VariableDeclarationParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] VariableDeclarationParser.ProgramContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclaration([NotNull] VariableDeclarationParser.DeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclaration([NotNull] VariableDeclarationParser.DeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.selectionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelectionStatement([NotNull] VariableDeclarationParser.SelectionStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.selectionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelectionStatement([NotNull] VariableDeclarationParser.SelectionStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.repetitionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRepetitionStatement([NotNull] VariableDeclarationParser.RepetitionStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.repetitionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRepetitionStatement([NotNull] VariableDeclarationParser.RepetitionStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileStatement([NotNull] VariableDeclarationParser.WhileStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileStatement([NotNull] VariableDeclarationParser.WhileStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.forStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForStatement([NotNull] VariableDeclarationParser.ForStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.forStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForStatement([NotNull] VariableDeclarationParser.ForStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.forInit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForInit([NotNull] VariableDeclarationParser.ForInitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.forInit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForInit([NotNull] VariableDeclarationParser.ForInitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.forUpdate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForUpdate([NotNull] VariableDeclarationParser.ForUpdateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.forUpdate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForUpdate([NotNull] VariableDeclarationParser.ForUpdateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.switchStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitchStatement([NotNull] VariableDeclarationParser.SwitchStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.switchStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitchStatement([NotNull] VariableDeclarationParser.SwitchStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.caseBlockList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCaseBlockList([NotNull] VariableDeclarationParser.CaseBlockListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.caseBlockList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCaseBlockList([NotNull] VariableDeclarationParser.CaseBlockListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.caseBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCaseBlock([NotNull] VariableDeclarationParser.CaseBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.caseBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCaseBlock([NotNull] VariableDeclarationParser.CaseBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.defaultBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefaultBlock([NotNull] VariableDeclarationParser.DefaultBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.defaultBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefaultBlock([NotNull] VariableDeclarationParser.DefaultBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.commandList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommandList([NotNull] VariableDeclarationParser.CommandListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.commandList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommandList([NotNull] VariableDeclarationParser.CommandListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.incrementDecrementStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIncrementDecrementStatement([NotNull] VariableDeclarationParser.IncrementDecrementStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.incrementDecrementStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIncrementDecrementStatement([NotNull] VariableDeclarationParser.IncrementDecrementStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.breakCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBreakCommand([NotNull] VariableDeclarationParser.BreakCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.breakCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBreakCommand([NotNull] VariableDeclarationParser.BreakCommandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.mathCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMathCommand([NotNull] VariableDeclarationParser.MathCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.mathCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMathCommand([NotNull] VariableDeclarationParser.MathCommandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.mathExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMathExpr([NotNull] VariableDeclarationParser.MathExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.mathExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMathExpr([NotNull] VariableDeclarationParser.MathExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondition([NotNull] VariableDeclarationParser.ConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondition([NotNull] VariableDeclarationParser.ConditionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.relOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelOp([NotNull] VariableDeclarationParser.RelOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.relOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelOp([NotNull] VariableDeclarationParser.RelOpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.typeSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeSpecifier([NotNull] VariableDeclarationParser.TypeSpecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.typeSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeSpecifier([NotNull] VariableDeclarationParser.TypeSpecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.declaratorList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclaratorList([NotNull] VariableDeclarationParser.DeclaratorListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.declaratorList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclaratorList([NotNull] VariableDeclarationParser.DeclaratorListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclarator([NotNull] VariableDeclarationParser.DeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclarator([NotNull] VariableDeclarationParser.DeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="VariableDeclarationParser.initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInitializer([NotNull] VariableDeclarationParser.InitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="VariableDeclarationParser.initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInitializer([NotNull] VariableDeclarationParser.InitializerContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
