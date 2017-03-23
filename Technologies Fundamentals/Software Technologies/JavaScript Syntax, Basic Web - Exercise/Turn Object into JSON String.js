function objToJSON(pairs) {
    let result = '{';

    for (let i = 0; i < pairs.length; i++) {
        let input = pairs[i].split(' -> ')

        if (i == 2 || i == 3) {
            result += `"${input[0]}":`;
            result += `${Number(input[1])}`
        } else {
            result += `"${input[0]}":`;
            result += `"${input[1]}"`
        }

        if(i < pairs.length - 1){
            result+=',';
        }

    }

    result += '}'

    console.log(result)

}