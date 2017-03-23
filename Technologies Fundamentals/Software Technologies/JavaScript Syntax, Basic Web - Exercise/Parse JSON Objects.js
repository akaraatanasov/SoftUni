function parseJSON(pairs) {
    for (let i = 0; i < pairs.length; i++) {
        let result = JSON.parse(pairs[i]);

        console.log(`Name: ${result.name}`);
        console.log(`Age: ${result.age}`);
        console.log(`Date: ${result.date}`);
    }

}