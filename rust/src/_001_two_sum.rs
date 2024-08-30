use std::collections::HashMap;

// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
pub fn two_sum(nums: Vec<i32>, target: i32) -> Vec<i32> {
    let mut scores: HashMap<i32, usize> = HashMap::new();
    
    for (i, num) in nums.into_iter().enumerate() {
        let diff = target - num;
        let value = scores.get(&diff);

        match value {
            Some(x) => {
                return vec![i.try_into().unwrap(), (*x).try_into().unwrap()];
            }
            None => {
                scores.insert(num, i);
            }
        }
    }

    panic!("Invalid input");
}
