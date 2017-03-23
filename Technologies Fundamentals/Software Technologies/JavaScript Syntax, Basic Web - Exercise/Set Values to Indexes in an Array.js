function setValues(pairs) {
    let length = Number(pairs[0]);
    let newArray = [];

    for (let i = 1; i < pairs.length; i++) {
        let temp = pairs[i].split(' - ');
        let index = temp[0];
        let value = temp[1];

        newArray[index] = value;
    }

    for (let i = 0; i < length; i++) {
        if (newArray[i] == undefined) {
            console.log(0);
        } else {
            console.log(newArray[i]);
        }
    }

}