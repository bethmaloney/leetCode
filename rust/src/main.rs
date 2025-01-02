mod _2559_count_vowel_string;

fn main() {
    let words = vec!["aba".to_string(),"bcb".to_string(),"ece".to_string(),"aa".to_string(),"e".to_string()];
    let queries = vec![vec![0,2],vec![1,4],vec![1,1]];

    let result = _2559_count_vowel_string::vowel_strings(words, queries);
    // should be [2,3,0]
    println!("score: {:#?}", result);
}
