function multipleValueKey(pairs) {
    let obj = {};

    for (let i = 0; i < pairs.length; i++) {
        let temp = pairs[i].split(' ');

        let key = temp[0];
        let value = temp[1];

        if (value == undefined) {
            if (obj[key] == undefined) {
                console.log('None');
            } else {
                for (let j = 0; j < obj[key].length; j++) {
                    console.log(obj[key][j]);
                }
            }
        } else {
            if (obj[key] === undefined) {
                obj[key] = new Array();
                obj[key].push(value);
            } else {
                obj[key].push(value);
            }
        }
    }

}