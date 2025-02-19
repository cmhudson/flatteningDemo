import NestedFlattener from "../src/NestedFlattener";

describe('NestedFlattener', () => {
    test('flattens a simple nested array', () => {
        const nestedArray: (string | string[])[][] = [['one', 'two', ['three']], ['four']];
        const result = NestedFlattener.flatten(nestedArray);
        expect(result).toEqual(['one', 'two', 'three', 'four']);
    });

    test('flattens a more complex nested array', () => {
        const nestedArray: (string | string[])[][] = [
            ['one', ['two', 'three', 'four'], 'five'],
            [['six', 'seven'], 'eight'],
            ['nine', ['ten', 'eleven', 'twelve']]
        ];
        const result = NestedFlattener.flatten(nestedArray);
        expect(result).toEqual(['one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine', 'ten', 'eleven', 'twelve']);
    });

    test('returns empty array with empty input', () => {
        const array: (string | string[])[][] = [];
        const result = NestedFlattener.flatten(array);
        expect(result).toEqual([]);
    })
});