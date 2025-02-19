# Array Flattener in TypeScript

Flattens an arbitrarily nested array of strings into a flat array.

May be limited on depth due to method signature type:

```((string | string[])[] )|(string | string[])[][]```

## Build and Run

Must have NPM installed

```npm install```

Build:

```npm run build```

Run:

```npm run start```

Test:

```npm test```

## Running

Running the console script (npm run start) will run 2 examples through 
the `NestedFlattener` class:

    Example 1: [ [ 'one', 'two', [ 'three' ] ], [ 'four' ] ]
    finished:  [ 'one', 'two', 'three', 'four' ]
    Example 2:
    input:  [
    [ 'one', [ 'two', [Array] ], 'five' ],
    [ [ 'six', 'seven' ], 'eight' ],
    [ 'nine', [ 'ten', [Array] ] ]
    ]
    output: [
    'one',    'two',
    'three',  'four',
    'five',   'six',
    'seven',  'eight',
    'nine',   'ten',
    'eleven', 'twelve'
    ]

This class could be utilized in an app by itself.