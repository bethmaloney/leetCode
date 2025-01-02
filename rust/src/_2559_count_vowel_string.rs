use std::ops::Index;

pub fn vowel_strings(words: Vec<String>, queries: Vec<Vec<i32>>) -> Vec<i32> {
    let vowels =  ['a', 'e', 'o', 'u', 'i'];
    let mut results = Vec::with_capacity(queries.len());

    let mut prefix_sum = Vec::with_capacity(words.len() + 1);
    prefix_sum.push(0); // add an empty value as otherwise [0,0] will always return 0
    let mut sum = 0;

    for word in &words {
        if word.starts_with(vowels) && word.ends_with(vowels) {
            sum = sum + 1;
        }

        prefix_sum.push(sum);
    }

    for query in queries {
        let start_index: usize = *query.index(0) as usize;
        let end_index: usize = 1 + *query.index(1) as usize;

        let total = prefix_sum[end_index] - prefix_sum[start_index];
        results.push(total);
    }

    return results;
}
