class NestedFlattener {

    // [['one', 'two', ['three']], ['four']]
    public static flatten (nestedArray: ((string | string[])[] )|(string | string[])[][]): string[]
    {

        let flat: string[] = [];
        nestedArray.forEach((item) => {
            if (typeof item === 'string') {
                flat.push(item);
            } else if (Array.isArray(item) && item.length < 2 && typeof item[0] === 'string') {
                flat.push(item[0]);
            } else {
                flat = flat.concat(this.flatten(item));
            }
        });

        return flat;
    }

}

export default NestedFlattener;