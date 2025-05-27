grammar VariableDeclaration;

declaration
    : typeSpecifier declaratorList SEMI
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

SEMI       : ';';
COMMA      : ',';
ASSIGN     : '=';

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

fragment EscapeSequence
    : '\\' [btnr"\\']
    ;

WS
    : [ \t\r\n]+ -> skip
    ;
