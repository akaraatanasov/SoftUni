function printLines(lines) {
    for (let i = 0; i < lines.length; i++) {
        if (lines[i] !== 'Stop') {
            console.log(lines[i]);
        } else {
            break;
        }
    }
}