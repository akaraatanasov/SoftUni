function keyValuePairs(pairs) {
    let obj = {};

    for (let i = 0; i < pairs.length; i++) {
        let temp = pairs[i].split(' ');

        let key = temp[0];
        let value = temp[1];

        if (value == undefined) {
            if (obj[key] == undefined) {
                console.log('None');
            } else {
                console.log(obj[key]);
            }
        } else {
            obj[key] = value;
        }
    }

}