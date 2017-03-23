function addRemoveElements(pairs) {
    let newArray = [];

    for (let i = 0; i < pairs.length; i++) {
        let temp = pairs[i].split(' ');

        let command = temp[0];
        let value = Number(temp[1]);

        if (command == 'add') {
            newArray.push(value);
        } else if (command == 'remove') {
            newArray.splice(value, 1);
        }
    }

    for (let i = 0; i < newArray.length; i++) {
        console.log(newArray[i]);
    }

}