function storingObjects(pairs) {
    let obj = {};

    for (let i = 0; i < pairs.length; i++) {
        let input = pairs[i].split(' -> ');

        let name = input[0];
        let age = input[1];
        let grade = input[2];

        obj[i] = new Array();
        obj[i].push(name);
        obj[i].push(age);
        obj[i].push(grade);
    }

    for (let i = 0; i < pairs.length; i++) {
        console.log(`Name: ${obj[i][0]}`);
        console.log(`Age: ${obj[i][1]}`);
        console.log(`Grade: ${obj[i][2]}`);
    }

}