function productOf3Numbers(nums) {
    let negatives = 0;
    let zero = false;

    for (let i = 0; i < nums.length; i++) {
        if (Number(nums[i]) < 0) {
            negatives++;
        } else if (Number(nums[i]) === 0) {
            zero = true;
        }
    }

    let result = 'Positive';

    if (zero === false && negatives % 2 === 1) {
        result = 'Negative';
    }

    return result;
}