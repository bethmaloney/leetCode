pub fn max_score(s: String) -> i32 {
    let length = s.len();
    let mut max = 0i32;

    for i in 1..length {
        let left = &s[0..i];
        let right = &s[i..length];

        let left_score = left.chars().filter(|x| *x == '0').count();
        let right_score = right.chars().filter(|x| *x == '1').count();

        max = std::cmp::max(max, (left_score + right_score) as i32);
    }

    return max;
}