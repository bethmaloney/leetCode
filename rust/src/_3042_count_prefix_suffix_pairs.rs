pub fn count_prefix_suffix_pairs(words: Vec<String>) -> i32 {
    let mut total = 0;

    for (index, word) in words.iter().enumerate() {
        for prefix_suffix in words[index + 1..].iter() {
            if is_prefix_and_suffix(word, prefix_suffix) {
                total = total + 1;
            }
        }
    }

    return total;
}

fn is_prefix_and_suffix(word1: &str, word2: &str) -> bool {
    let suffix_prefix_length = word1.len();

    if suffix_prefix_length > word2.len() {
        return false;
    }

    let prefix = &word2[0..suffix_prefix_length];
    if prefix != word1 {
        return false;
    }

    let suffix = &word2[word2.len() - suffix_prefix_length..];

    if suffix != word1 {
        return false;
    }

    true
}
