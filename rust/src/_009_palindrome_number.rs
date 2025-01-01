// This is slower then the string equivalent
pub fn is_palindrome(x: i32) -> bool {
    if x < 0 {
        return false;
    }

    if x < 10 {
        return true;
    }

    let x: u32 = x.try_into().unwrap();

    let magnitude = f64::from(x).log10() as u32 + 1;
    let distance = magnitude / 2;

    for i in 0..distance {
        let rhs_pow = 10u32.pow(i);
        let rhs = (x % (10u32 * rhs_pow)) / rhs_pow;
        let lhs = x / (10u32.pow(magnitude - i - 1)) % 10;

        if lhs != rhs {
            return false;
        };
    }

    return true;
}

pub fn is_palindrome_string(x: i32) -> bool {
    let string = x.to_string();
    let length = string.chars().count();
    let distance = length / 2;

    let string: Vec<char> = string.chars().collect();

    for i in 0..distance {
        if string[i] != string[length - 1 - i] {
            return false;
        }
    }

    return true;
}
