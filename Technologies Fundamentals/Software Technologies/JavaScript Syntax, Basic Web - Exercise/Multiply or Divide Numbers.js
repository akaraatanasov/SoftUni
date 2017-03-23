function multiplyOrDivideNumbers(nums) {
    let num1 = Number(nums[0]);
    let num2 = Number(nums[1]);
    let result = 0;

    if (num1 > num2) {
        result = num1 / num2;
    } else {
        result = num1 * num2;
    }

    return result;
}