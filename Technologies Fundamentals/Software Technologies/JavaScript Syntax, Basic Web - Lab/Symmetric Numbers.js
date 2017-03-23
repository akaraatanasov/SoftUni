function symmetricNums(args) {
	let number = Number(args[0]);
	let result = '';

	for (let i = 1; i <= number; i++) {
		if (isSymmetric(i)) {
			result += i + ' ';
		}
	}

	console.log(result);

	function isSymmetric(number) {
		number = number.toString();

		for (let i = 0; i < number.length / 2; i++) {
			if (number[i] !== number[number.length - i - 1]) {
				return false;
			}			
		}

		return true;
	}
}