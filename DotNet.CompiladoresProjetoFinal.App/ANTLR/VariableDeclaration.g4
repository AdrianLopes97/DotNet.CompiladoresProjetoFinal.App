grammar VariableDeclaration;

program
    : (declaration | selectionStatement | repetitionStatement)* EOF
    ;

declaration
    : typeSpecifier declaratorList SEMI
    ;

// Comando if-else
selectionStatement
    : IF LPAREN condition RPAREN LBRACE commandList RBRACE (ELSE LBRACE commandList RBRACE)?
    | switchStatement
    ;

// Comandos de Repetição
repetitionStatement
    : whileStatement
    | forStatement
    ;

whileStatement
    : WHILE LPAREN condition RPAREN LBRACE commandList RBRACE
    ;

forStatement
    : FOR LPAREN forInit SEMI condition SEMI forUpdate RPAREN LBRACE commandList RBRACE
    ;

forInit
    : Identifier ASSIGN mathExpr // i = 0
    ;

forUpdate
    : Identifier (ASSIGN mathExpr | PLUSPLUS | MINUSMINUS) // i = i + 1 OR i++ OR i--
    ;

// Comando switch-case
switchStatement
    : SWITCH LPAREN Identifier RPAREN LBRACE caseBlockList (defaultBlock)? RBRACE
    ;

caseBlockList
    : caseBlock+
    ;

caseBlock
    : (CASE Identifier COLON)+ LBRACE commandList RBRACE
    ;

defaultBlock
    : DEFAULT COLON LBRACE commandList RBRACE
    ;

// Lista de comandos matemáticos simples
commandList
    : (mathCommand | breakCommand | incrementDecrementStatement)*
    ;

incrementDecrementStatement // New rule
    : Identifier (PLUSPLUS | MINUSMINUS) SEMI
    ;

breakCommand
    : BREAK SEMI
    ;

mathCommand
    : Identifier ASSIGN mathExpr SEMI
    ;

// Expressão matemática simples
mathExpr
    : mathExpr op=('*'|'/') mathExpr
    | mathExpr op=('+'|'-') mathExpr
    | IntegerLiteral
    | FloatingLiteral
    | Identifier
    | LPAREN mathExpr RPAREN
    ;

// Condição relacional
condition
    : mathExpr relOp mathExpr
    ;

relOp
    : EQ
    | NEQ
    | LT
    | LTEQ
    | GT
    | GTEQ
    ;

typeSpecifier
    : CHAR
    | INT
    | FLOAT
    ;

declaratorList
    : declarator (COMMA declarator)*
    ;

declarator
    : Identifier (ASSIGN initializer)?
    ;

initializer
    : CHAR_LITERAL
    | STRING_LITERAL
    | IntegerLiteral
    | FloatingLiteral
    ;

CHAR       : 'char';
INT        : 'int';
FLOAT      : 'float';

IF         : 'if';
ELSE       : 'else';
SWITCH     : 'switch';
CASE       : 'case';
DEFAULT    : 'default';
BREAK      : 'break';
WHILE      : 'while';
FOR        : 'for';  

EQ         : '==';
NEQ        : '!=';
LTEQ       : '<=';
GTEQ       : '>=';
LT         : '<';
GT         : '>';

LPAREN     : '(';
RPAREN     : ')';
LBRACE     : '{';
RBRACE     : '}';
COLON      : ':';

SEMI       : ';';
COMMA      : ',';
ASSIGN     : '=';
PLUSPLUS   : '++'; 
MINUSMINUS : '--'; 

Identifier
    : [a-zA-Z_] [a-zA-Z_0-9]*
    ;

CHAR_LITERAL
    : '\'' (~['\\\r\n] | EscapeSequence) '\''
    ;

STRING_LITERAL
    : '"' (~["\\\r\n] | EscapeSequence)* '"'
    ;

IntegerLiteral
    : [0-9]+
    ;

FloatingLiteral
    : [0-9]+ '.' [0-9]* | '.' [0-9]+
    ;

// Operadores matemáticos
// (Os tokens para +, -, *, /)
PLUS       : '+';
MINUS      : '-';
STAR       : '*';
DIV        : '/';

fragment EscapeSequence
    : '\\' [btnr"\\']
    ;

WS
    : [ \t\r\n]+ -> skip
    ;
