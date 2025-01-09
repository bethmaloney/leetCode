mod _3042_count_prefix_suffix_pairs;

fn main() {
let words = vec!["a".to_string(),"aba".to_string(),"ababa".to_string(),"aa".to_string()];

    let result = _3042_count_prefix_suffix_pairs::count_prefix_suffix_pairs(words);
    // should be 4
    println!("score: {:#?}", result);
}
