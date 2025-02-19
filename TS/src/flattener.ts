import NestedFlattener from "./NestedFlattener";

let nested1: (string | string[])[][] = [['one', 'two', ['three']], ['four']];
let nested2: any = [
    ['one', ['two', ['three', 'four']], 'five'],
    [['six', 'seven'], 'eight'],
    ['nine', ['ten', ['eleven', ['twelve']]]]
];

console.log("Example 1:", nested1);
console.log("finished: ", NestedFlattener.flatten(nested1));

console.log("Example 2: ");
console.log("input: ",nested2);
console.log("output:", NestedFlattener.flatten(nested2));